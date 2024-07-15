using Microsoft.AspNetCore.Mvc;
using TestTaskDMI.Contracts;
using TestTaskDMI.Core.Interfaces;

namespace TestTaskDMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecryptController : ControllerBase
    {
        private readonly IDecryptService _decryptService;

        public DecryptController(IDecryptService decryptService)
        {
            _decryptService = decryptService;
        }

        /// <summary>
        /// Decrypt value with Caesar
        /// </summary>
        /// <param name="contract"></param>
        /// <returns>Result of calculation encrypted by Caesar</returns>
        [HttpGet("DecryptAsync")]
        public async Task<CalculatorResponseContract> DecryptAsync(string value)
        {
            var serviceResult = await _decryptService.DecryptAsync(value);
            return new CalculatorResponseContract(serviceResult);
        }
    }
}