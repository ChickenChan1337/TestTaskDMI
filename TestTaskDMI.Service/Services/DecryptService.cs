using TestTaskDMI.Core.Interfaces;
using TestTaskDMI.Service.Helper;

namespace TestTaskDMI.Service.Services
{
    public class DecryptService : IDecryptService
    {
        /// <summary>
        /// Decrypt value with Caesar
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Decrypted value</returns>
        public async Task<string> DecryptAsync(string value)
            => await Caesar.DecryptAsync(value);
    }
}