﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a program that will read user name and will check if it is a valid one (has more than 0 symbols and less than 50 symbols). 
If the input is invalid it should write an error message and prompt for user name again until user enters a valid name.
*/
namespace HW5_3
{
    class HW5_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            int nameLenght = userName.Length;           //Defining name's lenght
            while (nameLenght > 50 || nameLenght < 1)   //Name's lenght validation
            {
                Console.WriteLine("User name must have more then 0 and less then 51 characters.");
                Console.WriteLine("Please enter your name:");
                userName = Console.ReadLine();
                nameLenght = userName.Length;
            }
            Console.WriteLine("Welcome {0}", userName);
            Console.ReadKey();
        }
    }
}
