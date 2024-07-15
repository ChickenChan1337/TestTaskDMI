namespace TestTaskDMI.Contracts
{
    /// <summary>
    /// Request for calculation of two values
    /// FirstValue will be calculated with SecondValue
    /// </summary>
    public class CalculatorRequestContract
    {
        public decimal FirstValue { get; set; }
        public decimal SecondValue { get; set; }
    }
}