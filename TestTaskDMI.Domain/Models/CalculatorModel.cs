namespace TestTaskDMI.Service.Models
{
    /// <summary>
    /// Model for calculation of two values
    /// FirstValue will be calculated with SecondValue
    /// </summary>
    public class CalculatorModel
    {
        public decimal FirstValue { get; set; }
        public decimal SecondValue { get; set; }

        public CalculatorModel(decimal firstValue, decimal secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }
    }
}