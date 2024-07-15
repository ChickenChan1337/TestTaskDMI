using TestTaskDMI.Core.Interfaces;
using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Service.Services
{
    public class CalculatorService : ICalculatorService
    {
        /// <summary>
        /// Add first value with second value
        /// exemplified as an asynchronous process
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<decimal> Addition(CalculatorModel model)
        {
            return await Task.Run(() =>
            {
                return model.FirstValue + model.SecondValue;
            });
        }

        /// <summary>
        /// Substract first value with second value
        /// exemplified as an asynchronous process
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<decimal> Substraction(CalculatorModel model)
        {
            return await Task.Run(() =>
            {
                return model.FirstValue - model.SecondValue;
            });
        }

        /// <summary>
        /// Multiply first value with second value
        /// exemplified as an asynchronous process
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<decimal> Multiply(CalculatorModel model)
        {
            return await Task.Run(() =>
            {
                return model.FirstValue * model.SecondValue;
            });
        }

        /// <summary>
        /// Divide first value with second value
        /// exemplified as an asynchronous process
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        public async Task<decimal> Divide(CalculatorModel model)
        {
            return await Task.Run(() =>
            {
                return model.FirstValue / model.SecondValue;
            });
        }
    }
}