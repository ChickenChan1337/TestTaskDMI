namespace TestTaskDMI.Service.Helper
{
    public static class Caesar
    {
        private const int shift = 4;

        public static async Task<string> AsyncEncrypt(string input)
        {
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
    }
}