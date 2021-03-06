//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.4-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calculator.g4 by ANTLR 4.5.4-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Dangl.Calculator.Generated {

#pragma warning disable 0419
#pragma warning disable 3021
#pragma warning disable 1574
#pragma warning disable 1591
#pragma warning disable 1658
#pragma warning disable 1584
#pragma warning disable 0108

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CalculatorParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface ICalculatorVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>Tan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTan([NotNull] CalculatorParser.TanContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Cosh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCosh([NotNull] CalculatorParser.CoshContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SqRoot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSqRoot([NotNull] CalculatorParser.SqRootContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NegExponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegExponent([NotNull] CalculatorParser.NegExponentContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Exponent</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExponent([NotNull] CalculatorParser.ExponentContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Arctan2</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArctan2([NotNull] CalculatorParser.Arctan2Context context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulDiv([NotNull] CalculatorParser.MulDivContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Arcsin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArcsin([NotNull] CalculatorParser.ArcsinContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryPlus</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryPlus([NotNull] CalculatorParser.UnaryPlusContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Arccot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArccot([NotNull] CalculatorParser.ArccotContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Arccos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArccos([NotNull] CalculatorParser.ArccosContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Euler</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEuler([NotNull] CalculatorParser.EulerContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Arctan</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArctan([NotNull] CalculatorParser.ArctanContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Parenthesis</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesis([NotNull] CalculatorParser.ParenthesisContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Abs</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbs([NotNull] CalculatorParser.AbsContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] CalculatorParser.NumberContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Sinh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSinh([NotNull] CalculatorParser.SinhContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Round</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRound([NotNull] CalculatorParser.RoundContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Trunc</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrunc([NotNull] CalculatorParser.TruncContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Pi</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPi([NotNull] CalculatorParser.PiContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Tanh</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTanh([NotNull] CalculatorParser.TanhContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Floor</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloor([NotNull] CalculatorParser.FloorContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Ln</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLn([NotNull] CalculatorParser.LnContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Mod</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMod([NotNull] CalculatorParser.ModContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Log</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLog([NotNull] CalculatorParser.LogContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddSub([NotNull] CalculatorParser.AddSubContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Cos</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCos([NotNull] CalculatorParser.CosContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Deg</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeg([NotNull] CalculatorParser.DegContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Sqrt</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSqrt([NotNull] CalculatorParser.SqrtContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Cot</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCot([NotNull] CalculatorParser.CotContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Whole</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhole([NotNull] CalculatorParser.WholeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Unary</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnary([NotNull] CalculatorParser.UnaryContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Rad</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRad([NotNull] CalculatorParser.RadContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Sqr</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSqr([NotNull] CalculatorParser.SqrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Sin</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSin([NotNull] CalculatorParser.SinContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Eex</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEex([NotNull] CalculatorParser.EexContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Pow</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPow([NotNull] CalculatorParser.PowContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Ceil</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCeil([NotNull] CalculatorParser.CeilContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Exp</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExp([NotNull] CalculatorParser.ExpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Roundk</c>
	/// labeled alternative in <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRoundk([NotNull] CalculatorParser.RoundkContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.calculator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCalculator([NotNull] CalculatorParser.CalculatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] CalculatorParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="CalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] CalculatorParser.CompileUnitContext context);
}
} // namespace Dangl.Calculator.Generated
