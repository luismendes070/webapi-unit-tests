using System;
using Timothy = Tim.Is.Cool.GenericData;

namespace NamespaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timothy.DataAccess dataAccess = new();
            Data.PersonModel model = new Data.PersonModel();

            BetterConsole b = new BetterConsole();
            b.BetterWriteLine();

            Models.PersonModel personModel= new Models.PersonModel();

            Console.WriteLine("Hello World!");
        }
    }
}
