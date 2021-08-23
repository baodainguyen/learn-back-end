using strategy.DAL;
using Microsoft.Data.SqlClient;
using strategy.Common;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
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

        public List<object> GetExportDataByPer(DataPeople people, Type classType)
        {
            string pers = people.PersonIds;
            long projectId = people.ProjectId;

            return context.ExecuteToMultiObject(pers, projectId);
        }
        private MethodInfo _methodInfo;
        private MethodInfo GetDataMethod(Type classType)
        {
            if (_methodInfo == null)
                _methodInfo = classType.GetMethod("GetData", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            return _methodInfo;
        }
    }
}
