using PasswordGenerator;

internal class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("\x1b[36;40m ------------------------------------------------------------\x1b[0m");
        Console.WriteLine("\u001b[36;40m|                \u001b[0m" + "\x1b[30;46mUNIQUE PASSWORD GENERATOR\x1b[0m"+ "\u001b[36;40m                   |\u001b[0m");
        Console.WriteLine("\x1b[36;40m ------------------------------------------------------------\x1b[0m");

        while (true)
        {
            
            Console.WriteLine("\n--- "+"\x1b[30;47mMENU\x1b[0m" + " ---\n");
            Console.WriteLine("\n\x1b[36;40m1)\x1b[0m " + "Generate Password" + "\x1b[36;40m <-\x1b[0m");
            Console.WriteLine("\n\x1b[36;40m2)\x1b[0m " + "Exit" + "\u001b[36;40m <-\u001b[0m");

            Console.Write("\n\x1b[30;47mChoose an option (1, 2):\x1b[0m" + " ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GeneratePasswordMenu();
                    break;
                case "2":
                    Console.WriteLine("\n\x1b[30;43mGoodbye!\x1b[0m");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n\x1b[37;41mIncorrect input. Please choose 1 or 2.\x1b[0m");
                    break;
            }
        }
    }

    static void GeneratePasswordMenu()
    {
        Console.Write("\n\x1b[30;47mEnter password length (minimum 8 characters):\x1b[0m" + " ");
        Console.ForegroundColor = ConsoleColor.Blue;
        if (int.TryParse(Console.ReadLine(), out int passwordLength) && passwordLength >= 8)
        {
            string generatedPassword = UPassword.Instance.GeneratePassword(passwordLength);
            Console.WriteLine("\n\x1b[32;40m--------------------------------------------------------------\x1b[0m");
            Console.WriteLine("\x1b[30;42mYour unique password:\x1b[0m" + $" {generatedPassword}");
            Console.WriteLine("\x1b[32;40m--------------------------------------------------------------\x1b[0m\n\n\n");
        }
        else
        {
            Console.WriteLine("\n\x1b[37;41mIncorrect password length. Please enter a number of at least 8.\x1b[0m");
        }
    }
}
