﻿using System;

namespace _04.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = (Console.ReadLine());
            if (userResponse == ($"s3cr3t!P@ssw0rd"))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine($"Wrong password!");
            }
        }
    }
}
