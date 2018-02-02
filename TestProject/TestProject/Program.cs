using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject.Tests")]

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
