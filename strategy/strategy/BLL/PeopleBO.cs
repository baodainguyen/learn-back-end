using strategy.DAL;
using strategy.StoredModels;
using System.Collections.Generic;

namespace strategy.BLL
{
    public class PeopleBO
    {
        private readonly CrmContext context;
        public PeopleBO(CrmContext context)
        {
            this.context = context;
        }

        public List<object> GetExportDataByPer(DataPeople people)
        {
            string pers = people.PersonIds;
            long projectId = people.ProjectId;

            return context.GetExportDataByPer(pers, projectId);
        }
        
    }
}
