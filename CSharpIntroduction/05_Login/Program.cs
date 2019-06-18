using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                password += username[i];
            }

            string currentPassword = Console.ReadLine();
            int invalidPasswordAttemps = 0;

            while (currentPassword != password)
            {

                invalidPasswordAttemps += 1;
                if (invalidPasswordAttemps == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                currentPassword = Console.ReadLine();
            }

            if (invalidPasswordAttemps < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
