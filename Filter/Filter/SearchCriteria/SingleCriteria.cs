using Filter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.SearchCriteria
{
    public class SingleCriteria : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            return persons.Where(p => p.MaritalStatus == "Single").ToList();
        }
    }
}
