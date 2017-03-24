using Filter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.SearchCriteria
{
    public class FemaleCriteria : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(p => p.Gender == "Female").ToList();
        }
    }
}
