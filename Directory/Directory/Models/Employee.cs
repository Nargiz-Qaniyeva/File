using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_task.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public double Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}-Id:{Id}-Salary:{Salary}");
        }
    }
}
