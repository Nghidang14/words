using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            //your code goes here
            foreach (string i in words)
            {
                if (i.Contains(letter))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}