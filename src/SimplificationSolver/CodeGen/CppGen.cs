using Microsoft.Automata;
using Microsoft.Z3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver.CodeGen
{
    public class CppGen
    {
        STb<FuncDecl, Expr, Sort> stb;
        Expr stateVar;

        string types = "";
        string shapes = "";
        string composeCode = "";

        HashSet<Sort> generatedDatatypes = new HashSet<Sort>();

        string Mangle(string name)
        {
            name = name.Replace('-', '_').Replace('#', '_');
            if (name.Length >= 1 && name[0] == '_')
            {
                return "MANGLED" + name;
            }
            else if ('0' <= name[0] && name[0] <= '9')
                return "v" + name;
            else
                return name;
        }

        string Name(FuncDecl decl)
        {
            switch (decl.DeclKind)
            {
                case Z3_decl_kind.Z3_OP_EQ: return "eq";
                case Z3_decl_kind.Z3_OP_ITE: return "ite";
                case Z3_decl_kind.Z3_OP_NOT: return "!";
                default:
                    return Mangle(decl.Name.ToString());
            }
        }

        string SortToType(Sort sort)
        {
            if (sort.SortKind == Z3_sort_kind.Z3_BV_SORT)
            {
                return "Bv<" + ((BitVecSort)sort).Size + ">";
            }
            else if (sort.SortKind == Z3_sort_kind.Z3_BOOL_SORT)
            {
                return "bool";
            }
            else if (sort.SortKind == Z3_sort_kind.Z3_DATATYPE_SORT)
            {
                var dtSort = (DatatypeSort)sort;
                string def = "";
                if (!generatedDatatypes.Contains(sort))
                {
                    generatedDatatypes.Add(sort);

                    bool alwaysTag = true;

                    def += "struct _dt_" + Mangle(sort.ToString()) + " {\n";

                    var numConstructors = dtSort.NumConstructors;
                    if (numConstructors != 1 || alwaysTag)
                    {
                        string tagType = "uint8_t";
                        if (numConstructors > UInt16.MaxValue)
                        {
                            tagType = "unsigned";
                        }
                        else if (numConstructors > Byte.MaxValue)
                        {
                            tagType = "uint16_t";
                        }
                        def += "\t" + tagType + " tag;\n";
                    }

                    def += "\tunion {\n";
                    for (uint c = 0; c < numConstructors; ++c)
                    {
                        FuncDecl constructor = dtSort.Constructors[c];
                        def += "\t\tstruct {\n";
                        for (uint a = 0; a < constructor.Arity; ++a)
                        {
                            FuncDecl accessor = dtSort.Accessors[c][a];
                            def += "\t\t\t" + SortToType(accessor.Range) + " " + Name(accessor) + ";\n";
                        }
                        def += "\t\t} " + Name(constructor) + ";\n";
                    }
                    def += "\t};\n";

                    def += "\t_dt_" + Mangle(sort.ToString()) + "() {}\n";

                    if (numConstructors != 1 || alwaysTag)
                        for (uint i = 0; i < numConstructors; ++i)
                        {
                            FuncDecl recognizer = dtSort.Recognizers[i];
                            def += "\tfriend bool " + Name(recognizer) + "(const _dt_" + Mangle(sort.ToString()) + "& dt) { return dt.tag == " + i + "; }\n";
                        }
                    else
                        def += "\tbool " + Name(dtSort.Recognizers[0]) + "(const _dt_" + Mangle(sort.ToString()) + "& dt) { return true; }\n";

                    def += "};\n";

                    for (uint c = 0; c < numConstructors; ++c)
                    {
                        FuncDecl constructor = dtSort.Constructors[c];
                        def += "_dt_" + Mangle(sort.ToString()) + " " + Name(constructor) + "(";
                        for (uint a = 0; a < constructor.Arity; ++a)
                        {
                            FuncDecl accessor = dtSort.Accessors[c][a];
                            if (a != 0) def += ", ";
                            def += SortToType(accessor.Range) + " " + Name(accessor);
                        }
                        def += ") {\n";
                        def += "\t_dt_" + Mangle(sort.ToString()) + " dt;\n";
                        if (numConstructors != 1 || alwaysTag)
                            def += "\tdt.tag = " + c + ";\n";
                        for (uint a = 0; a < constructor.Arity; ++a)
                        {
                            FuncDecl accessor = dtSort.Accessors[c][a];
                            def += "\tdt." + Name(constructor) + "." + Name(accessor) + " = " + Name(accessor) + ";\n";
                        }
                        def += "\treturn dt;\n";
                        def += "}\n";
                    }

                    for (uint c = 0; c < numConstructors; ++c)
                    {
                        FuncDecl constructor = dtSort.Constructors[c];
                        for (uint a = 0; a < constructor.Arity; ++a)
                        {
                            FuncDecl accessor = dtSort.Accessors[c][a];
                            def += SortToType(accessor.Range) + " " + Name(accessor) + "(_dt_" + Mangle(sort.ToString()) + " dt) { return dt." + Name(constructor) + "." + Name(accessor) + "; }\n";
                        }
                    }

                    types += def;
                }
                return "_dt_" + Mangle(sort.ToString());
            }
            throw new AutomataException("Unsupported sort: " + sort);
        }

        string ExprToExpression(Expr term)
        {
            string o = "";

            // Ensure that all types are generated
            SortToType(term.Sort);

            if (term.IsNumeral)
            {
                o += SortToType(term.Sort) + "(" + term.ToString() + ")";
            }
            else if (term.IsConst)
            {
                o += Name(term.FuncDecl);
            }
            else if (term.IsApp)
            {
                o += Name(term.FuncDecl) + "(";
                for (uint i = 0; i < term.NumArgs; ++i)
                {
                    if (i != 0) o += ", ";
                    o += ExprToExpression(term.Args[i]);
                }
                o += ")";
            }
            else
                throw new AutomataException("Unsupported expr: " + term);

            return o;
        }

        void DefineShapes()
        {
            foreach (var state in stb.States)
            {
                var regVarName = Name(stb.RegVar.FuncDecl);
                shapes += "struct S" + state + " : Shape<_State> {\n";
                shapes += "\t" + SortToType(stb.RegisterSort) + " " + regVarName + ";\n";

                // Constructor
                shapes += "\tS" + state + "(" + SortToType(stb.RegisterSort) + " " + regVarName + ") : " +
                    regVarName + "(" + regVarName + ") { }\n";

                var rule = stb.GetFinalRuleFrom(state);
                if (rule == null)
                    throw new AutomataException("Each state must have a final rule");
                var baseRule = rule as BaseRule<Expr>;
                if (baseRule == null || baseRule.Yields.Length != 1)
                    throw new AutomataException("Final rule must be a base rule with exactly one yield");

                shapes += "\t_State Eval(_State " + Name(stateVar.FuncDecl) + ") const override {\n";
                shapes += "\t\treturn " + ExprToExpression(baseRule.Yields[0]) + ";\n";
                shapes += "\t}\n";

                shapes += "};\n";
            }
        }

        string GenerateRule(STbRule<Expr> rule, string indent)
        {
            string o = "";
            
            var iteRule = rule as IteRule<Expr>;
            if (iteRule != null)
            {
                o += indent + "if (" + ExprToExpression(iteRule.Condition) + ") {\n";
                o += GenerateRule(iteRule.TrueCase, indent + "\t");
                o += indent + "} else {\n";
                o += GenerateRule(iteRule.FalseCase, indent + "\t");
                o += indent + "}\n";
                return o;
            }

            var baseRule = rule as BaseRule<Expr>;
            if (baseRule != null)
            {
                if (baseRule.Yields.Length != 0)
                    throw new AutomataException("Non-final rule with yields not supported");
                o += indent + Name(stb.RegVar.FuncDecl) + " = " + ExprToExpression(baseRule.Register) + ";\n";
                o += indent + "++in; goto L" + baseRule.State + ";\n";
                return o;
            }

            throw new AutomataException("Unsupported rule: " + rule);
        }

        void GenerateComposeCode()
        {
            foreach (var state in new int[] { 0 }.Concat(stb.States.Except(new int[] { 0 })))
            {
                composeCode += "L" + state + ":\n";
                composeCode += "\tif (in == end) return make_unique<S" + state + ">(" + Name(stb.RegVar.FuncDecl) + ");\n";

                composeCode += GenerateRule(stb.GetRuleFrom(state), "\t");
            }
        }

        string Generate()
        {
            if (stb.InputSort.SortKind != Z3_sort_kind.Z3_BV_SORT)
                throw new AutomataException("Input sort must be a bit vector");

            string s = "";

            s += CppFramework.Header;

            DefineShapes();
            GenerateComposeCode();

            s += "\n";
            s += types;
            s += "using _State = " + SortToType(stateVar.Sort) + ";\n";
            s += "\n";
            s += shapes;
            s += "\n";
            s += "#define " + Name(stb.InputVar.FuncDecl) + " *in\n";
            s += "template<class TIter>\n";
            s += "unique_ptr<Shape<_State>> _ComposeShapeForInput(TIter begin, TIter end) {\n";
            s += "\tTIter in = begin;\n"; // Make local copy to ensure it stays in a register (on VC++ 14 it doesn't otherwise)
            s += "\tauto " + Name(stb.RegVar.FuncDecl) + " = " + ExprToExpression(stb.InitialRegister) + ";\n";
            s += composeCode;
            s += "}\n";
            s += "#undef " + Name(stb.InputVar.FuncDecl) + "\n";

            s += "\n";
            s += "const _State _INITIAL_STATE;\n";
            s += CppFramework.Footer;

            return s;
        }

        private CppGen(STb<FuncDecl, Expr, Sort> stb, Expr stateVar)
        {
            this.stb = stb;
            this.stateVar = stateVar;
        }

        public static string GenerateMultiCore(STb<FuncDecl, Expr, Sort> stb, Expr stateVar)
        {
            return new CppGen(stb, stateVar).Generate();
        }
    }
}