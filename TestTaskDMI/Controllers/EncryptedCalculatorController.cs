using Microsoft.AspNetCore.Mvc;
using TestTaskDMI.Contracts;
using TestTaskDMI.Core.Interfaces;
using TestTaskDMI.Mapper;

namespace TestTaskDMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncryptedCalculatorController : ControllerBase
    {
        private readonly IEncryptedCalculatorService _encryptedCalculatorService;

        public EncryptedCalculatorController(IEncryptedCalculatorService encryptedCalculatorService)
        {
            _encryptedCalculatorService = encryptedCalculatorService;
        }

        /// <summary>
        /// Add first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("Addition")]
        public async Task<CalculatorResponseContract> Addition(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _encryptedCalculatorService.Addition(model);
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
            var serviceResult = await _encryptedCalculatorService.Substraction(model);
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
            var serviceResult = await _encryptedCalculatorService.Multiply(model);
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
            var serviceResult = await _encryptedCalculatorService.Divide(model);
            return new CalculatorResponseContract(serviceResult);
        }
    }
}