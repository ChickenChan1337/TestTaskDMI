namespace TestTaskDMI.Service.Models
{
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