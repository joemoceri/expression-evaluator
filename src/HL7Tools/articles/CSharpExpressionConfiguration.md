### CSharpExpressionConfiguration

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Links](#links)

#### Description

Use this class to evaluate math (1+2), string ("a"+"b"), or boolean (1>2) expressions.

Inside of the [Evaluator](../api/HL7Tools.Evaluator.html), [higher precedence operators](../api/HL7Tools.OperatorPrecedence.html#HL7Tools_OperatorPrecedence_Higher) are solved first, followed by [lower precedence operators](../api/HL7Tools.OperatorPrecedence.html#HL7Tools_OperatorPrecedence_Lower). Only the operators shown are supported.


#### Properties

- [Operators](../api/HL7Tools.CSharpExpressionConfiguration.html#HL7Tools_CSharpExpressionConfiguration_Operators): Returns a list of [ExpressionConfigurationOperator](../api/HL7Tools.ExpressionConfigurationOperator.html).

- [Options](../api/HL7Tools.CSharpExpressionConfiguration.html#HL7Tools_CSharpExpressionConfiguration_Options): Returns [ExpressionConfigurationOptions](../api/HL7Tools.ExpressionConfigurationOptions.html).

The default options are the following:
```csharp
options = new ExpressionConfigurationOptions
{
    IgnoreWhitespaceOutsideQuotes = false,
    IgnoreParentheses = false,
    IgnoreQuotesValidation = false
};
```
- [IgnoreWhitespaceOutsideQuotes](../api/HL7Tools.ExpressionConfigurationOptions.html#HL7Tools_ExpressionConfigurationOptions_IgnoreWhitespaceOutsideQuotes): By default the CSharpExpressionConfiguration removes whitespace outside of quotes inside of the expression, so this is set to **false**.

- [IgnoreParentheses](../api/HL7Tools.ExpressionConfigurationOptions.html#HL7Tools_ExpressionConfigurationOptions_IgnoreParentheses): By default the CSharpExpressionConfiguration breaks expressions down from the outer most parentheses set to the inner most, so this is set to **false**.

- [IgnoreQuotesValidation](../api/HL7Tools.ExpressionConfigurationOptions.html#HL7Tools_ExpressionConfigurationOptions_IgnoreQuotesValidation): By default the CSharpExpressionConfiguration validates if there are a balanced (1:1 ratio) set of quotes inside of the expression, so this is set to **false**.

The default operators are the following:
```csharp
operators = new List<ExpressionConfigurationOperator>
{
    CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "+"),
    CreateExpressionConfigurationOperator(Operator.Subtraction, OperatorPrecedence.Lower, OperatorType.MathString, "-"),
    CreateExpressionConfigurationOperator(Operator.Multiplication, OperatorPrecedence.Higher, OperatorType.MathString, "*"),
    CreateExpressionConfigurationOperator(Operator.Division, OperatorPrecedence.Higher, OperatorType.MathString, "/"),
    CreateExpressionConfigurationOperator(Operator.Modulus, OperatorPrecedence.Higher, OperatorType.MathString, "%"),
    CreateExpressionConfigurationOperator(Operator.And, OperatorPrecedence.Lower, OperatorType.Boolean, "&&"),
    CreateExpressionConfigurationOperator(Operator.Or, OperatorPrecedence.Lower, OperatorType.Boolean, "||"),
    CreateExpressionConfigurationOperator(Operator.LessThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "<="),
    CreateExpressionConfigurationOperator(Operator.GreaterThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, ">="),
    CreateExpressionConfigurationOperator(Operator.EqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "=="),
    CreateExpressionConfigurationOperator(Operator.NotEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "!="),
    CreateExpressionConfigurationOperator(Operator.LessThan, OperatorPrecedence.Higher, OperatorType.Boolean, "<"),
    CreateExpressionConfigurationOperator(Operator.GreaterThan, OperatorPrecedence.Higher, OperatorType.Boolean, ">"),
};
```

#### Links

[Link to the file](../api/HL7Tools.CSharpExpressionConfiguration.html)