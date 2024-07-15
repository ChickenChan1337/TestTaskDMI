using TestTaskDMI.Service.Models;

namespace TestTaskDMI.Core.Interfaces
{
    public interface IEncryptedCalculatorService
    {
        /// <summary>
        /// Add first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> Addition(CalculatorModel model);

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> Substraction(CalculatorModel model);

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> Multiply(CalculatorModel model);

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> Divide(CalculatorModel model);
    }
}