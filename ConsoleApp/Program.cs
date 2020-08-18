using Core;
using System;
using System.Collections;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Sodoku sodoku = new Sodoku();

            do
            {
                sodoku.Print(sodoku.Set(9, new ArrayList()));

            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

        }
    }
}
