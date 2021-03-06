﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Automata.MSO.Mona;
using System.IO;

namespace MSO.Tests
{
    [TestClass]
    public class MonaTests
    {
        //[TestMethod]
        //public void MonaTest_parse_ltl() 
        //{
        //    DirectoryInfo di = new DirectoryInfo(@"C:\tmp\automatark-master\automatark-master\m2l-str\LTL-finite");
        //    foreach (var subdir in di.EnumerateDirectories())    
        //    {
        //        foreach (var fi in subdir.EnumerateFiles())
        //        {
        //            Program pgm = MonaParser.ParseFromFile(fi.FullName);
        //            var pgmstr = pgm.Description;
        //            Assert.IsTrue(pgm.header == Header.M2LSTR);
        //            Assert.IsTrue(pgm.declarations.Count > 0);
        //        }
        //    }
        //}

        [TestMethod]
        public void MonaTest1()
        {
            string input = @"
/*
header declares M2L-STR semantics 
(finite input strings)
*/
m2l-str;

var1 p, q, r;            # fo vars p, q and r
var2 $;                  # s0 var $
p = q + 1;               # p is the successor of q
p < r;                   # r is after p
p notin $ & q in $;     
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.IsTrue(pgm.declarations.Count > 0);
            Assert.AreEqual<Tokens>(Tokens.M2LSTR, pgm.token.Kind);
        }

        [TestMethod]
        public void MonaTest2()
        {
            string input = @"
# Qe describes the valid indices of a queue
pred isWfQueue(var2 Qe) =
   all1 p: (p in Qe & p > 0  => p - 1 in Qe);

# isx holds if p contains an x
pred is0(var1 p, var2 Qe, Q1, Q2) = p in Qe & p notin Q1 & p notin Q2;
pred is1(var1 p, var2 Qe, Q1, Q2) = p in Qe & p notin Q1 & p in Q2;
pred is2(var1 p, var2 Qe, Q1, Q2) = p in Qe & p in Q1 & p notin Q2;
pred is3(var1 p, var2 Qe, Q1, Q2) = p in Qe & p in Q1 & p in Q2;
  
# lt compares the elements at positions p and q of a queue 
pred lt(var1 p, q, var2 Qe, Q1, Q2) =
    (is0(p, Qe, Q1, Q2) & ~is0(q, Qe, Q1, Q2)) 
  | (   is1(p, Qe, Q1, Q2)
     & (is2(q, Qe, Q1, Q2) | is3(q, Qe, Q1, Q2)))
  | (   is2(p, Qe, Q1, Q2)
     & (is3(q, Qe, Q1, Q2))); 

# isLast holds if p is the last element in the queue
pred isLast(var1 p, var2 Qe) =
  p in Qe & (all1 q': q' in Qe => q' <= p);  
  
# an ordered queue of length l 
pred Queue(var2 Qe, Q1, Q2, var1 l) =
   isLast(l - 1, Qe)
  &
   (all1 p, q: p<q & p in Qe & q in Qe => lt(p, q, Qe, Q1, Q2));

# eqQueue2 compares elements in two queues
pred eqQueue2(var1 p, q, var2 Q1, Q2, Q1', Q2') =
    (p in Q1 <=> q in Q1')
  & (p in Q2 <=> q in Q2');
 
# LooseOne holds about a queue Q and a queue Q' if
# queue Q' is the same as Q except that one
# element (denoted by p below) is removed
pred LooseOne(var2 Qe, Q1, Q2, Qe', Q1', Q2') =
  ex1 p: p in Qe
  &  (all1 q: (~isLast(q, Qe) => (q in Qe  <=> q in Qe'))
         & (isLast(q, Qe) => (q notin Qe')))
  &  (all1 q: q<p & q in Qe  => eqQueue2(q, q, Q1, Q2, Q1', Q2'))
  &  (all1 q: q > p & q in Qe  => eqQueue2(q, q - 1, Q1, Q2, Q1', Q2'));

var2 Qe, Q1, Q2;     # the queue Q
var2 Qe', Q1', Q2';  # the queue Q'

assert isWfQueue(Qe);

# the primed variables denote a queue of length 3 containing
# three of the elements 0, 1, 2, 3 in that order and the element 3
Queue(Qe, Q1, Q2, 4);   # the queue Q is a queue of length 3
                        # containing the elements 0, 1, 2, 3 
LooseOne(Qe, Q1, Q2, Qe', Q1', Q2'); # Q' is Q except for one element
ex1 p: is3(p, Qe', Q1', Q2'); # Q' does contain the element 3      
";
            MonaProgram pgm = MonaParser.Parse(input);
            string s = pgm.ToString();
            Assert.IsTrue(pgm.declarations.Count > 0);
        }


        [TestMethod]
        public void MonaTestIn()
        {
            string input = @"
0x3 in {1,2,3};
4 notin {1,...,3,6};
"; 
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.IsTrue(pgm.declarations.Count == 2);
        }

        [TestMethod]
        public void MonaTestPred()
        {
            string input = @"
var1 p, q;
var2 Qe, Q1, Q2;
pred is0(var1 p, var2 Qe, Q1, Q2) = p in Qe & p notin Q1 & p notin Q2;
is0(p, Qe, Q1, Q2) & ~is0(q, Qe, Q1, Q2);  
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.IsTrue(pgm.declarations.Count == 4);
        }
        [TestMethod]
        public void MonaTestPred_error1()
        {
            string input = @"
var1 p, q;
var2 Qe, Q1, Q2;
pred is0(var1 p, var2 Qe, Q1, Q2) = p in Qe & p notin Q1 & p notin Q2;
is0(p, Qe, Q1, Q2) & ~is0(Q2, Qe, Q1, Q2);  
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(e.Kind, MonaParseExceptionKind.TypeMismatch);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.TypeMismatch.ToString());
        }

        [TestMethod]
        public void MonaTestPred_error2()
        {
            string input = @"
var1 p;
var2 Qe, Q1, Q2;
pred is0(var1 p, var2 Qe, Q1, Q2) = p in Qe & p notin Q1 & p notin Q2;
is0(p, Qe, Q1, Q2) & ~is0(q, Qe, Q1, Q2);  
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(e.Kind, MonaParseExceptionKind.UndeclaredIdentifier);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.UndeclaredIdentifier.ToString());
        }

        [TestMethod]
        public void MonaTestAllpos()
        {
            string input = @"
var2 q;
allpos q; 
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.IsTrue(pgm.declarations.Count == 2);
        }

        [TestMethod]
        public void MonaTestAllpos_error1()
        {
            string input = @"
allpos q; 
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(e.Kind, MonaParseExceptionKind.UndeclaredIdentifier);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.UndeclaredIdentifier.ToString());
        }

        [TestMethod]
        public void MonaTestAllpos_error2()
        {
            string input = @"
var1 q;
allpos q; 
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(e.Kind, MonaParseExceptionKind.TypeMismatch);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.TypeMismatch.ToString());
        }

        [TestMethod]
        public void MonaTestVar0decl()
        {
            string input = @"
var0 a, b ; # Boolean vars a and b
";
            MonaProgram pgm = MonaParser.Parse(input);   
            Assert.AreEqual<int>(1, pgm.declarations.Count);
            Assert.AreEqual<string>("var0 a,b;", pgm.ToString().Trim());
        }

        [TestMethod]
        public void MonaTestVar0decl_error()
        {
            string input = @"
var1 a; # variable a 
var0 a; # variable a again
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(MonaParseExceptionKind.DuplicateDeclaration, e.Kind);
                return;
            }
            Assert.Fail("expected " + MonaParseExceptionKind.DuplicateDeclaration.ToString());
        }

        [TestMethod]
        public void MonaTestUnivDecl()
        {
            string input = @"
m2l-tree;
universe U1, U2:110101, U3:foo; # sample universes
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(1, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaUnivDecls);
            var univdecl = pgm.declarations[0] as MonaUnivDecls;
            Assert.IsTrue(univdecl.args.Count == 3);
            Assert.IsTrue(univdecl.args[1] is MonaUnivArgWithSucc);
            Assert.IsTrue(univdecl.args[2] is MonaUnivArgWithType);
        }

        [TestMethod]
        public void MonaTestUnivDecl_error()
        {
            string input = @"
m2l-tree;
universe U1, U2:110201, U3:foo; # sample universes
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(MonaParseExceptionKind.InvalidUniverseDeclaration, e.Kind);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.InvalidUniverseDeclaration.ToString());
        }

        [TestMethod]
        public void MonaTestConstDecl()
        {
            string input = @"
const a = 23 + 2;
const b = a + (2 - a);
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(2, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaConstDecl);
            Assert.IsTrue(pgm.declarations[1] is MonaConstDecl);
            var a = pgm.declarations[0] as MonaConstDecl;
            Assert.IsTrue(a.name.text == "a");
            var b = pgm.declarations[1] as MonaConstDecl;
            Assert.IsTrue(b.name.text == "b");
        }

        [TestMethod]
        public void MonaTestConstDecl_error()
        {
            string input = @"
const a = 23 + 2;
const b = a + (2 - c);
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.IsTrue(e.Kind == MonaParseExceptionKind.UndeclaredConstant);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.UndeclaredConstant.ToString());
        }

        [TestMethod]
        public void MonaTestDefaultWhereDecl()
        {
            string input = @"
defaultwhere1(p) = p < 10;
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(1, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaDefaultWhereDecl);
            Assert.IsFalse((pgm.declarations[0] as MonaDefaultWhereDecl).isSecondOrder);
            Assert.IsTrue((pgm.declarations[0] as MonaDefaultWhereDecl).kind == MonaDeclKind.defaultwhere1);
        }


        [TestMethod]
        public void MonaTestPredDecl1()
        {
            string input = @"
pred foo() = 4 < 6;
pred bar(var2 P, var1 p) = p in P & foo();
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(2, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaPredDecl);
            Assert.IsTrue(pgm.declarations[1] is MonaPredDecl);
            var foo = pgm.declarations[0] as MonaPredDecl;
            var bar = pgm.declarations[1] as MonaPredDecl; 
            Assert.IsFalse(foo.isMacro);
            Assert.IsFalse(bar.isMacro);
            Assert.AreEqual<string>("foo", foo.name.text);
            Assert.AreEqual<string>("bar", bar.name.text);
            Assert.IsTrue(foo.parameters.Count == 0);
            Assert.AreEqual<int>(2, bar.parameters.Count);
            Assert.IsTrue(bar.parameters[0].kind == MonaParamKind.var2);
            Assert.IsTrue(bar.parameters[1].kind == MonaParamKind.var1);
        }

        [TestMethod]
        public void MonaTestMacroDecl1()
        {
            string input = @"
macro bar(var2 P,Q) = 1 in P;
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(1, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaPredDecl);
            var bar = pgm.declarations[0] as MonaPredDecl;
            Assert.IsTrue(bar.isMacro);
            Assert.AreEqual<string>("bar", bar.name.text);
            Assert.IsTrue(bar.parameters.Count == 2);
            Assert.IsTrue(bar.parameters[0].kind == MonaParamKind.var2);
            Assert.IsTrue(bar.parameters[1].kind == MonaParamKind.var2);
        }

        [TestMethod]
        public void MonaTestMacroDecl2()
        {
            string input = @"
macro bar(var2 P, R, Q, var1 q, var0 e) = q in P;
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(1, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaPredDecl);
            var bar = pgm.declarations[0] as MonaPredDecl;
            Assert.IsTrue(bar.isMacro);
            Assert.AreEqual<string>("bar", bar.name.text);
            Assert.AreEqual<int>(5, bar.parameters.Count);
            Assert.IsTrue(bar.parameters[0].kind == MonaParamKind.var2);
            Assert.IsTrue(bar.parameters[1].kind == MonaParamKind.var2);
            Assert.IsTrue(bar.parameters[2].kind == MonaParamKind.var2);
            Assert.IsTrue(bar.parameters[3].kind == MonaParamKind.var1);
            Assert.IsTrue(bar.parameters[4].kind == MonaParamKind.var0);
        }

        [TestMethod]
        public void MonaTestMacroDecl2_error()
        {
            string input = @"
macro bar(var2 P, R, Q, var1 Q, var0 e) = q in P;
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(MonaParseExceptionKind.DuplicateDeclaration, e.Kind);
                return;
            }
            Assert.Fail("expected " + MonaParseExceptionKind.DuplicateDeclaration.ToString());
        }

        [TestMethod]
        public void MonaTestDecl()
        {
            string input = @"
const a = 23 + 2;
pred P = 1 = 1;
const b = a + 2*a;
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(3, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaConstDecl);
            Assert.IsTrue(pgm.declarations[2] is MonaConstDecl);
            Assert.IsTrue(pgm.declarations[1] is MonaPredDecl);
            var a = pgm.declarations[0] as MonaConstDecl;
            Assert.IsTrue(a.name.text == "a");
            var b = pgm.declarations[2] as MonaConstDecl;
            Assert.IsTrue(b.name.text == "b");
            var P = pgm.declarations[1] as MonaPredDecl;
            Assert.IsTrue(P.name.text == "P");
        }

        [TestMethod]
        public void MonaTestDecl_error()
        {
            string input = @"
const a = 23 + 2;
pred P = 1 = 1;
const b = a + (2 - P);
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.AreEqual(MonaParseExceptionKind.IdentifierIsNotDeclaredConstant, e.Kind);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.IdentifierIsNotDeclaredConstant.ToString());

        }

        [TestMethod]
        public void MonaTestQ1()
        {
            string input = @"
const zero = 0;
pred lt(var1 x,y) = x < y + zero;
macro psi(var2 Y, var1 x,y) = (ex1 z: lt(x,z) & lt(z,y)) & (all2 X: X sub Y => X = Y); 
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(3, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaConstDecl);
            Assert.IsTrue(pgm.declarations[1] is MonaPredDecl);
            Assert.IsTrue(pgm.declarations[2] is MonaPredDecl);
            var zero = pgm.declarations[0] as MonaConstDecl;
            Assert.IsTrue(zero.name.text == "zero");
            var lt = pgm.declarations[1] as MonaPredDecl;
            Assert.IsFalse(lt.isMacro);
            Assert.IsTrue(lt.name.text == "lt");
            var pred = pgm.declarations[2] as MonaPredDecl;
            Assert.IsTrue(pred.isMacro);
            Assert.IsTrue(pred.name.text == "psi");
            Assert.IsTrue(pred.formula.type == MonaExprType.BOOL);
            Assert.IsTrue(pred.formula is MonaBinaryBooleanFormula);
            MonaBinaryBooleanFormula phi = pred.formula as MonaBinaryBooleanFormula;
            Assert.IsTrue(phi.op == MonaBinaryBooleanOp.AND);
            Assert.IsTrue(phi.arg1.type == MonaExprType.BOOL);
            Assert.IsTrue(phi.arg2.type == MonaExprType.BOOL);
            Assert.IsTrue(phi.arg1 is MonaQFormula);
            Assert.IsTrue(phi.arg2 is MonaQFormula);
            var psi1 = phi.arg1 as MonaQFormula;
            var psi2 = phi.arg2 as MonaQFormula;
            Assert.IsTrue(psi1.symbol.Kind == Tokens.EX1);
            Assert.IsTrue(psi2.symbol.Kind == Tokens.ALL2);
            Assert.IsTrue(psi2.formula.type == MonaExprType.BOOL);
            Assert.IsTrue(psi2.formula is MonaBinaryBooleanFormula);
            var psi3 = psi2.formula as MonaBinaryBooleanFormula;
            Assert.IsTrue(psi3.op == MonaBinaryBooleanOp.IMPLIES);
            Assert.IsTrue(psi3.arg1 is MonaBinaryAtom);
            var lhs = psi3.arg1 as MonaBinaryAtom;
            Assert.IsTrue(lhs.symbol.Kind == Tokens.SUBSET);
            var rhs = psi3.arg2 as MonaBinaryAtom;
            Assert.IsTrue(rhs.symbol.Kind == Tokens.EQ);
        }

        [TestMethod]
        public void MonaTestLet1()
        {
            string input = @"
const c = 42;
let1 x=3,y=c in x < y;
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(2, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaConstDecl);
            Assert.IsTrue(pgm.declarations[1] is MonaFormulaDecl);
            var let = (pgm.declarations[1] as MonaFormulaDecl).formula as MonaLet;
            Assert.IsTrue(let != null && let.Kind == MonaLetKind.let1);
            Assert.IsTrue(let.let_vars.Count == 2);
            foreach (var kv in let.let_vars)
            {
                Assert.IsTrue(kv.Value.kind == MonaParamKind.var1);
            }
        }

        [TestMethod]
        public void MonaTestLet0()
        {
            string input = @"
const t = 42;
let0 x=(t=t),y=(true) in (x <=> y);
";
            MonaProgram pgm = MonaParser.Parse(input);
            Assert.AreEqual<int>(2, pgm.declarations.Count);
            Assert.IsTrue(pgm.declarations[0] is MonaConstDecl);
            Assert.IsTrue(pgm.declarations[1] is MonaFormulaDecl);
            var let = (pgm.declarations[1] as MonaFormulaDecl).formula as MonaLet;
            Assert.IsTrue(let != null && let.Kind == MonaLetKind.let0);
            Assert.IsTrue(let.let_vars.Count == 2);
            foreach (var kv in let.let_vars)
            {
                Assert.IsTrue(kv.Value.kind == MonaParamKind.var0);
            }
        }

        [TestMethod]
        public void MonaTestLet1_error()
        {
            string input = @"
var2 c;
let1 x=3,y=c in x < y;
";
            try
            {
                MonaProgram pgm = MonaParser.Parse(input);
            }
            catch (MonaParseException e)
            {
                Assert.IsTrue(e.Kind == MonaParseExceptionKind.TypeMismatch);
                return;
            }
            Assert.Fail("expecting " + MonaParseExceptionKind.TypeMismatch.ToString());
        
        }
    }
}
