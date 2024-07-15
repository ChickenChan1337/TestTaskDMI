using TestTaskDMI.Service.Helper;
using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Service.Services
{
    public class CalculatorService
    {
        public async Task<string> Addition(CalculatorModel model)
        {
            var calculationResult = model.FirstValue + model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }

        public async Task<string> Substraction(CalculatorModel model)
        {
            var calculationResult = model.FirstValue - model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }

        public async Task<string> Multiply(CalculatorModel model)
        {
            var calculationResult = model.FirstValue * model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }

        public async Task<string> Divide(CalculatorModel model)
        {
            var calculationResult = model.FirstValue / model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }
    }
}