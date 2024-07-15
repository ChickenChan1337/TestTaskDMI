using TestTaskDMI.Service.Helper;
using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Service.Services
{
    public class CalculatorService
    {

        /// <summary>
        /// Add first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> Addition(CalculatorModel model)
        {
            var calculationResult = model.FirstValue + model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> Substraction(CalculatorModel model)
        {
            var calculationResult = model.FirstValue - model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> Multiply(CalculatorModel model)
        {
            var calculationResult = model.FirstValue * model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> Divide(CalculatorModel model)
        {
            var calculationResult = model.FirstValue / model.SecondValue;

            return await Caesar.AsyncEncrypt(calculationResult.ToString());
        }
    }
}