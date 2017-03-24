using Filter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.SearchCriteria
{
    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}
