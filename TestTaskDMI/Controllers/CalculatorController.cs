using Microsoft.AspNetCore.Mvc;
using TestTaskDMI.Contracts;
using TestTaskDMI.Mapper;
using TestTaskDMI.Service.Services;

namespace TestTaskDMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController(ILogger<CalculatorController> logger) : ControllerBase
    {
        private readonly CalculatorService _calculatorService = new();

        /// <summary>
        /// Add first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("Addition")]
        public async Task<CalculatorResponseContract> Addition(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Addition(model);
            return new CalculatorResponseContract(serviceResult);
        }

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("Substraction")]
        public async Task<CalculatorResponseContract> Substraction(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Substraction(model);
            return new CalculatorResponseContract(serviceResult);
        }

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("Multiply")]
        public async Task<CalculatorResponseContract> Multiply(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Multiply(model);
            return new CalculatorResponseContract(serviceResult);
        }

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("Divide")]
        public async Task<CalculatorResponseContract> Divide(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Divide(model);
            return new CalculatorResponseContract(serviceResult);
        }
    }
}