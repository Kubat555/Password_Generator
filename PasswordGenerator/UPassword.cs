using System;


namespace PasswordGenerator
{
    internal class UPassword
    {
        private static UPassword instance;
        private static readonly object lockObject = new object();
        private readonly Random random;

        private UPassword()
        {
            random = new Random();
        }

        public static UPassword Instance
        {
            get
            {
                lock (lockObject)
                {
                    return instance ?? (instance = new UPassword());
                }
            }
        }

        public string GeneratePassword(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$";
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = characters[random.Next(characters.Length)];
            }

            return new string(password);
        }
    }
}
