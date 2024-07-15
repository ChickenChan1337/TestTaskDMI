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
        [HttpPost("AdditionAsync")]
        public async Task<CalculatorResponseContract> AdditionAsync(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _encryptedCalculatorService.AdditionAsync(model);
            return new CalculatorResponseContract(serviceResult);
        }

        /// <summary>
        /// Substract first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("SubstractionAsync")]
        public async Task<CalculatorResponseContract> SubstractionAsync(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _encryptedCalculatorService.SubstractionAsync(model);
            return new CalculatorResponseContract(serviceResult);
        }

        /// <summary>
        /// Multiply first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("MultiplyAsync")]
        public async Task<CalculatorResponseContract> MultiplyAsync(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _encryptedCalculatorService.MultiplyAsync(model);
            return new CalculatorResponseContract(serviceResult);
        }

        /// <summary>
        /// Divide first value with second value
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpPost("DivideAsync")]
        public async Task<CalculatorResponseContract> DivideAsync(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _encryptedCalculatorService.DivideAsync(model);
            return new CalculatorResponseContract(serviceResult);
        }
    }
}