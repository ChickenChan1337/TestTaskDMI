namespace TestTaskDMI.Contracts
{
    /// <summary>
    /// encrypted result of a calculation
    /// ResultValue can be empty string
    /// </summary>
    public class CalculatorResponseContract
    {
        public string ResultValue { get; set; } = string.Empty;

        public CalculatorResponseContract(string result)
        {
            ResultValue = result;
        }

        public CalculatorResponseContract(decimal result)
        {
            ResultValue = result.ToString();
        }
    }
}