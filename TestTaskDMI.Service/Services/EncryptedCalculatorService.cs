using TestTaskDMI.Core.Interfaces;
using TestTaskDMI.Service.Helper;
using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Service.Services
{
    public class EncryptedCalculatorService : IEncryptedCalculatorService
    {
        /// <summary>
        /// Add first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> AdditionAsync(CalculatorModel model)
        {
            var calculationResult = model.FirstValue + model.SecondValue;

            return await Caesar.EncryptAsync(calculationResult.ToString());
        }

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> SubstractionAsync(CalculatorModel model)
        {
            var calculationResult = model.FirstValue - model.SecondValue;

            return await Caesar.EncryptAsync(calculationResult.ToString());
        }

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> MultiplyAsync(CalculatorModel model)
        {
            var calculationResult = model.FirstValue * model.SecondValue;

            return await Caesar.EncryptAsync(calculationResult.ToString());
        }

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<string> DivideAsync(CalculatorModel model)
        {
            var calculationResult = model.FirstValue / model.SecondValue;

            return await Caesar.EncryptAsync(calculationResult.ToString());
        }
    }
}