using System;
using System.Collections.Generic;
using System.IO;
namespace Directory_task
{
    internal class Program
    {
        public static IEnumerable<object> AddEmployee { get; private set; }

        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\nargi\Desktop\File\Directory\Directory\NewFiles");
            if (!File.Exists(@"C:\Users\nargi\Desktop\File\Directory\Directory\NewFiles\Database.json"))
            {
                File.Create(@"C:\Users\nargi\Desktop\File\Directory\Directory\NewFiles\Database.json");

                bool check = true;
                do
                {
                    Console.WriteLine("***** Menu *****");
                    Console.WriteLine("1. Add employee");
                    Console.WriteLine("2. Get employee by id");
                    Console.WriteLine("3. Remove employee");
                    Console.WriteLine("0.Quit");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            foreach (var item in AddEmployee)
                            {

                            }
                            break;
                    }
                }
                while (check);
            }
        }

    }
}

