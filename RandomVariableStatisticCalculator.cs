using System.Diagnostics.Contracts;

namespace RandomVariable
{
    public class RandomVariableStatisticCalculator : IRandomVariableStatisticCalculator
    {
        public RandomVariableStatistic CalculateStatistic(string expression, params StatisticKind[] statisticForCalculate)
        {
            var random = new RandomVariableStatistic
            {
                ExpectedValue = ParserMathExpression.Parse(expression)
            };
            return random;
        }
    }
}