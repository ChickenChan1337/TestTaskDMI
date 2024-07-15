namespace TestTaskDMI.Contracts
{
    public class CalculatorResponseContract
    {
        public string ResultValue { get; set; } = string.Empty;

        public CalculatorResponseContract(string result)
        {
            ResultValue = result;
        }
    }
}