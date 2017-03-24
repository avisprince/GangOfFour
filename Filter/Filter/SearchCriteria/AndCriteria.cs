using Filter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.SearchCriteria
{
    public class AndCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria criteria2;

        public AndCriteria(ICriteria criteria, ICriteria criteria2)
        {
            this.criteria = criteria;
            this.criteria2 = criteria2;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaPersons = criteria.MeetCriteria(persons);
            return criteria2.MeetCriteria(firstCriteriaPersons);
        }
    }
}
