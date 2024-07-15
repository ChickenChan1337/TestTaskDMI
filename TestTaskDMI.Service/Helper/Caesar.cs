namespace TestTaskDMI.Service.Helper
{
    public static class Caesar
    {
        /// <summary>
        /// use this to change the shift in caesar encryption
        /// </summary>
        private const int shift = 42;

        /// <summary>
        /// Caesar encryption
        /// exemplified as an asynchronous process
        /// </summary>
        /// <param name="input">input should be your result of the calculation as a string</param>
        /// <returns>encrypted result</returns>
        public static async Task<string> EncryptAsync(string input)
        {
            ValidateShift(shift);

            return await Task.Run(() =>
            {
                char[] buffer = input.ToCharArray();

                for (int i = 0; i < buffer.Length; i++)
                {
                    char value = buffer[i];
                    char valueShifted;
                    if (value != ',')
                    {
                        valueShifted = (char)(value + shift);
                        buffer[i] = valueShifted;
                    }
                }
                return new string(buffer);
            });
        }

        /// <summary>
        /// Caesar encryption
        /// exemplified as an asynchronous process
        /// </summary>
        /// <param name="input">input should be your result of the calculation as a string</param>
        /// <returns>encrypted result</returns>
        public static async Task<string> DecryptAsync(string input)
        {
            ValidateShift(shift);

            return await Task.Run(() =>
            {
                char[] buffer = input.ToCharArray();

                for (int i = 0; i < buffer.Length; i++)
                {
                    char value = buffer[i];
                    char valueShifted;
                    if (value != ',')
                    {
                        valueShifted = (char)(value - shift);
                        buffer[i] = valueShifted;
                    }
                }
                return new string(buffer);
            });
        }

        /// <summary>
        /// shift should be a number from 1 to 69
        /// </summary>
        /// <param name="shift"></param>
        /// <exception cref="Exception"></exception>
        private static void ValidateShift(int shift)
        {
            if (shift > 69 || shift < 1)
            {
                throw new Exception("Et tu, Brute?");
            }
        }
    }
}