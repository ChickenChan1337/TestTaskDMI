using Microsoft.AspNetCore.Mvc;
using TestTaskDMI.Contracts;
using TestTaskDMI.Mapper;
using TestTaskDMI.Service.Services;

namespace TestTaskDMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly CalculatorService _calculatorService;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
            _calculatorService = new CalculatorService();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpPost("Addition")]
        public async Task<CalculatorResponseContract> Addition(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Addition(model);
            return new CalculatorResponseContract(serviceResult);
        }

        [HttpPost("Substraction")]
        public async Task<CalculatorResponseContract> Substraction(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Substraction(model);
            return new CalculatorResponseContract(serviceResult);
        }

        [HttpPost("Multiply")]
        public async Task<CalculatorResponseContract> Multiply(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Multiply(model);
            return new CalculatorResponseContract(serviceResult);
        }

        [HttpPost("Divide")]
        public async Task<CalculatorResponseContract> Divide(CalculatorRequestContract contract)
        {
            var model = CalculatorModelMapper.Map(contract);
            var serviceResult = await _calculatorService.Divide(model);
            return new CalculatorResponseContract(serviceResult);
        }
    }
}