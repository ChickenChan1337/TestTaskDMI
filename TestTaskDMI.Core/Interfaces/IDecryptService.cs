namespace TestTaskDMI.Core.Interfaces
{
    public interface IDecryptService
    {
        /// <summary>
        /// Decrypt value with Caesar
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Decrypted value</returns>
        Task<string> DecryptAsync(string value);
    }
}