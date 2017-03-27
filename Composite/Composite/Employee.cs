using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salary;

        // constructor
        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            salary = sal;
            Subordinates = new List<Employee>();
        }

        public List<Employee> Subordinates { get; set; }

        public void Add(Employee e)
        {
            Subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            Subordinates.Remove(e);
        }

        public override string ToString()
        {
            return ("Employee :[ Name : " + name + ", dept : " + dept + ", salary :" + salary + " ]");
        }
    }
}
