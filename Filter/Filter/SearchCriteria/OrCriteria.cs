using Filter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter.SearchCriteria
{
    public class OrCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria criteria2;

        public OrCriteria(ICriteria criteria, ICriteria criteria2)
        {
            this.criteria = criteria;
            this.criteria2 = criteria2;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaItems = criteria.MeetCriteria(persons);
            var secondCriteriaItems = criteria2.MeetCriteria(persons);

            return firstCriteriaItems.Union(secondCriteriaItems).ToList();
        }
    }
}
