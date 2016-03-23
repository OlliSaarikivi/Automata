using Microsoft.CodeAnalysis;
using Microsoft.Automata.CSharpFrontend.CodeGeneration;
using Microsoft.Automata.CSharpFrontend.SymbolicExploration;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.CSharpFrontend
{
    class TypeSymbolToSortMapper : SymbolVisitor<SortMapping>
    {
        public Context Ctx { get { return _info.Ctx; } }
        public BoolSortMapping BoolSortMapping { get; private set; }
        public BigIntSortMapping BigIntSortMapping { get; private set; }

        CompilationInfo _info;
        HashSet<ITypeSymbol> _handleAsValueType;
        Dictionary<string, StructSortMapping> _structInfo = new Dictionary<string, StructSortMapping>();

        public TypeSymbolToSortMapper(CompilationInfo info, IEnumerable<ITypeSymbol> handleAsValueType)
        {
            _info = info;
            BoolSortMapping = new BoolSortMapping(_info);
            BigIntSortMapping = new BigIntSortMapping(_info);
            _handleAsValueType = new HashSet<ITypeSymbol>(handleAsValueType);
        }

        Dictionary<ISymbol, SortMapping> _mappingForISymbol = new Dictionary<ISymbol, SortMapping>();
        /// <summary>
        /// Multiple calls with the same parameters return the same SortMapping object.
        /// </summary>
        public SortMapping GetSortMapping(ISymbol symbol)
        {
            return _mappingForISymbol.GetOrCreate(symbol, () => Visit(symbol));
        }

        #region Struct information
        // These could be move elsewhere

        public void RegisterStructSortMapping(StructSortMapping mapping)
        {
            _structInfo.Add(mapping.Sort.Name.ToString(), mapping);
        }

        public StructSortMapping RecoverStructSortMapping(string sortName)
        {
            StructSortMapping mapping;
            if (!_structInfo.TryGetValue(sortName, out mapping))
            {
                throw new CodeGenerationException("Could not recover sort mapping for sort " + sortName);
            }
            return mapping;
        }

        public IEnumerable<StructSortMapping> GetStructSortMappings()
        {
            return _structInfo.Values;
        }
        #endregion

        /// <summary>
        /// Creates a Z3 Symbol named with an ISymbol's metadata name. Two invocations of this for the same
        /// ISymbol will not return the same Z3 Symbol.
        /// </summary>
        public Symbol CreateZ3Symbol(ISymbol symbol)
        {
            return Ctx.MkSymbol((symbol.ContainingNamespace != null ? symbol.ContainingNamespace.MetadataName + "." : "")
                + (symbol.ContainingType != null ? symbol.ContainingType.MetadataName + "." : "")
                + symbol.MetadataName);
        }

        public IntSortMapping GetBitVecSortMapping(ITypeSymbol specialIntType)
        {
            // Ugly hack: substitute Int for bitvector sorts (only signed types though)
            //switch (specialIntType.SpecialType)
            //{
            //    case SpecialType.System_SByte:
            //    case SpecialType.System_Int16:
            //    case SpecialType.System_Int32:
            //    case SpecialType.System_Int64:
            //        return BigIntSortMapping;
            //}

            switch (specialIntType.SpecialType)
            {
                case SpecialType.System_SByte:
                    return GetBitVecSortMapping(true, 8);
                case SpecialType.System_Int16:
                    return GetBitVecSortMapping(true, 16);
                case SpecialType.System_Int32:
                    return GetBitVecSortMapping(true, 32);
                case SpecialType.System_Int64:
                    return GetBitVecSortMapping(true, 64);
                case SpecialType.System_Byte:
                    return GetBitVecSortMapping(false, 8);
                case SpecialType.System_Char:
                case SpecialType.System_UInt16:
                    return GetBitVecSortMapping(false, 16);
                case SpecialType.System_UInt32:
                    return GetBitVecSortMapping(false, 32);
                case SpecialType.System_UInt64:
                    return GetBitVecSortMapping(false, 64);
            }
            throw new ArgumentException("Provided type was not an integral builtin: " + specialIntType);
        }

        Dictionary<Tuple<bool, uint>, IntSortMapping> _bitVecSortMappings = new Dictionary<Tuple<bool, uint>, IntSortMapping>();
        /// <summary>
        /// Multiple calls with the same parameters return the same SortMapping object.
        /// </summary>
        IntSortMapping GetBitVecSortMapping(bool isSigned, uint size)
        {
            return _bitVecSortMappings.GetOrCreate(Tuple.Create(isSigned, size), () => new IntSortMapping(_info, isSigned, size));
        }

        public bool IsIntBuiltin(ITypeSymbol symbol)
        {
            var type = symbol.SpecialType;
            return (type == SpecialType.System_SByte) ||
                (type == SpecialType.System_Int16) ||
                (type == SpecialType.System_Int32) ||
                (type == SpecialType.System_Int64) ||
                (type == SpecialType.System_Byte) ||
                (type == SpecialType.System_Char) ||
                (type == SpecialType.System_UInt16) ||
                (type == SpecialType.System_UInt32) ||
                (type == SpecialType.System_UInt64);
        }

        #region SymbolVisitor<Sort>

        public override SortMapping Visit(ISymbol symbol)
        {
            if (symbol == null)
            {
                throw new ArgumentNullException("Tried to visit a null symbol");
            }
            return symbol.Accept(this);
        }

        public override SortMapping DefaultVisit(ISymbol symbol)
        {
            throw new SyntaxErrorException("Unsupported symbol: " + symbol.ToDisplayString());
        }

        public override SortMapping VisitNamedType(INamedTypeSymbol symbol)
        {
            if (IsIntBuiltin(symbol))
            {
                return GetBitVecSortMapping(symbol);
            }
            switch (symbol.SpecialType)
            {
                case SpecialType.System_Boolean:
                    return BoolSortMapping;
                case SpecialType.System_Nullable_T:
                    // TODO: Create a sort mapping for nullable types
                    throw new SyntaxErrorException("Unsupported symbol: " + symbol);
                case SpecialType.None:
                    break;
                default:
                    throw new SyntaxErrorException("Unsupported symbol: " + symbol);
            }

            // If the type is not recognized as a more specialized type it is handled as a struct/class
            if (symbol.IsValueType || _handleAsValueType.Contains(symbol))
            {
                return new StructSortMapping(_info, symbol); ;
            }
            else
            {
                Debug.Assert(symbol.IsReferenceType, "A INamedTypeSymbol was neither a reference or a value type?!");
                throw new SyntaxErrorException("Unsupported reference type symbol: " + symbol);
                // TODO: Create a sort mapping for reference types
            }
        }

        #endregion
    }
}
