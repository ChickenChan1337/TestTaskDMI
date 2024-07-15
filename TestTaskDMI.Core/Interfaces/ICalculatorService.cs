using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Core.Interfaces
{
    public interface ICalculatorService
    {
        /// <summary>
        /// Add first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation</returns>
        Task<decimal> Addition(CalculatorModel model);

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation</returns>
        Task<decimal> Substraction(CalculatorModel model);

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation</returns>
        Task<decimal> Multiply(CalculatorModel model);

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation</returns>
        Task<decimal> Divide(CalculatorModel model);
    }
}