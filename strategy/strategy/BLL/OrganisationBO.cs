using strategy.DAL;
using strategy.StoredModels;
using System.Collections.Generic;

namespace strategy.BLL
{
    public class OrganisationBO
    {
        private readonly CrmContext context;
        public OrganisationBO(CrmContext context)
        {
            this.context = context;
        }

        public List<object> GetExportDataOrg(DataOrg org)
        {
            string ids = org.Ids;
            long projectId = org.ProjectId;

            return context.NewGetOrgExportData(ids, projectId, true);
        }
    }
}
