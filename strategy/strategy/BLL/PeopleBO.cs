using strategy.DAL;
using strategy.StoredModels;
using System.Collections.Generic;
using System.Reflection;

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

            return context.ExecuteToMultiObject(pers, projectId);
        }
        
    }
}
