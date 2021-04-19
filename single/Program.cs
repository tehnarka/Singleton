using System;
using static System.Console;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {

            Odinak first = Odinak.Instance();


            if (first != null)
            {
                first.D = 25;
                first.Print("first");
            }
            else
                WriteLine("first == null");
        }
    }
}