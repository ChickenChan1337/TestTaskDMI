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
        Task<string> AdditionAsync(CalculatorModel model);

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> SubstractionAsync(CalculatorModel model);

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> MultiplyAsync(CalculatorModel model);

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        Task<string> DivideAsync(CalculatorModel model);
    }
}