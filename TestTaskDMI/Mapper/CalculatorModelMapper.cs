using TestTaskDMI.Contracts;
using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Mapper
{
    public static class CalculatorModelMapper
    {
        public static CalculatorModel Map(CalculatorRequestContract contract)
        {
            return new CalculatorModel(contract.FirstValue, contract.SecondValue);
        }
    }
}