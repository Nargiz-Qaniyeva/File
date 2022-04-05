using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_task.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        private List<Employee> _employees;
        public void AddEmployee()
        {
            Employee employee = new Employee();
        }
        public Employee GetEmployeeById(int id)
        {
            return _employees.Find(x => x.Id == id);    
        }
        public Employee RemoveEmployee(int id)
        {
            return _employees.Find(x => x.Id == id);
        }
    }
}
