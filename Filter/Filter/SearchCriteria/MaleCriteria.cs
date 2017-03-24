using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filter.Model;

namespace Filter.SearchCriteria
{
    public class MaleCriteria : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(p => p.Gender == "Male").ToList();
        }
    }
}
