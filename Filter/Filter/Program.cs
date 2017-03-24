using Filter.Model;
using Filter.SearchCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Person { Name = "Robert", Gender = "Male", MaritalStatus = "Single" });
            persons.Add(new Person { Name = "John", Gender = "Male", MaritalStatus = "Married" });
            persons.Add(new Person { Name = "Laura", Gender = "Female", MaritalStatus = "Married" });
            persons.Add(new Person { Name = "Diana", Gender = "Female", MaritalStatus = "Single" });
            persons.Add(new Person { Name = "Mike", Gender = "Male", MaritalStatus = "Single" });
            persons.Add(new Person { Name = "Bobby", Gender = "Male", MaritalStatus = "Single" });

            ICriteria male = new MaleCriteria();
            ICriteria female = new FemaleCriteria();
            ICriteria single = new SingleCriteria();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            printPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            printPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            printPersons(singleOrFemale.MeetCriteria(persons));
        }

        private static void printPersons(List<Person> persons)
        {

            foreach (var person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.Name + ", Gender : " + person.Gender + ", Marital Status : " + person.MaritalStatus + " ]");
            }
        }
    }
}
