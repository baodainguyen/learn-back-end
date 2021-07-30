using Microsoft.Data.SqlClient;
using strategy.Common;
using strategy.DAL;
using strategy.DbModels;
using strategy.Entity.CustomDto;
using strategy.StoredModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.BLL
{
    public class ProjectGroupBO
    {
        private readonly ProjectGroupContext context;

        public ProjectGroupBO(ProjectGroupContext context)
        {
            this.context = context;
        }

        
        public ProjectGroupMemberRole GetMemberByProjectGroupId(long projectGroupId, long accountId)
        {
            var sqlParams = new[] {
                    new SqlParameter("@projectGroupId", projectGroupId)
                };
            var groupPrjs = context.ExecToList<ProjectGroupGetMember, ProjectGroupContext>("ProjectGroup_GetMemberById", sqlParams)
                    .Select(p => {
                        ProjectGroupMember projectGroupMember = new ProjectGroupMember(p);
                        projectGroupMember.RowState = DataRowState.Unchanged;
                        return projectGroupMember;
                    }).ToList();

            int role = GetCurrentRole(projectGroupId, accountId);

            return new ProjectGroupMemberRole() { 
                Members = groupPrjs,
                Role = 1
            };
        }

        public int GetCurrentRole(long projectGroupId, long accountId)
        {
            var sqlParams = new[] {
                    new SqlParameter("@AccountId", accountId),
                    new SqlParameter("@ProjectGroupId", projectGroupId)
                };
            return context.ExecScalar("AccountRole_GetCurrentRoleWithGroup", sqlParams);
        }

        public IEnumerable<ProjectGroupObj> Get(long accountId)
        {
            if (accountId < 1) return new List<ProjectGroupObj>();
            
            var projectLastActions = GetProjectLasctAction(accountId);

            var parameters = new[] {
                new SqlParameter("@accountId", accountId)
            };
            var groupPrjs = context.ExecToList<ProjectGetByMemberWithGroup, ProjectGroupContext>("Project_GetByMemberWithGroup", parameters).ToList();
            
            IEnumerable<ProjectGroupObj> res = groupPrjs.GroupBy(t => t.ProjectGroupId)
                .Select(t => GetProjectGroup(t, projectLastActions)).ToList();
            
            return res;
        }

        private Dictionary<long ,long> GetProjectLasctAction(long accountId)
        {
            var parameters = new[] {
                new SqlParameter("@AccountId", accountId)
            };
            var actions = context.ExecToList<AccountLastAct, ProjectGroupContext>("AccountLastAction_GetActions", parameters);
            var als = actions.Where(t => t.CodeLastActionId == (int)ECodeLastAction.PROJECT_MODULE).DistinctBy(t => t.ProjectId);
            Dictionary<long, long> projectLastActions = als.ToDictionary(t => t.ProjectId, d => long.Parse(d.Value));

            return projectLastActions;
        }

        private ProjectGroupObj GetProjectGroup(IGrouping<long, ProjectGetByMemberWithGroup> grouping, Dictionary<long, long> projectLastActions)
        {
            var group = grouping.First();
            var projectGroupObj = new ProjectGroupObj
            {
                Id = group.ProjectGroupId,
                Name = group.ProjectGroupName,
                Mdf = group.ProjectGroupMdf,
                MIndex = group.ProjectGroupMIndex,
                ListProject = grouping.Where(t => t.ProjectId != null && t.ProjectMdf != null && t.ProjectMIndex != null && t.StrategyId != null)
                        .GroupBy(t => t.ProjectId.Value).Select(t => GetProject(t, projectLastActions)).ToList()
            };
            return projectGroupObj;
        }
        private ProjectByMember GetProject(IGrouping<long, ProjectGetByMemberWithGroup> grouping, Dictionary<long, long> projectLastActions)
        {
            var projectInfo = grouping.First();

            projectLastActions.TryGetValue(projectInfo.ProjectId.Value, out long lastStrategyId);
            var lastProjectAction = grouping
                .Select(t => new { 
                    Project = t, 
                    HasRole = true, 
                    IsLastAction = t.StrategyId.Value == lastStrategyId 
                }).OrderByDescending(t => t.IsLastAction)
                .ThenByDescending(t => t.HasRole)
                .FirstOrDefault(t => t.HasRole);

            ProjectByMember project = new ProjectByMember
            {
                Id = projectInfo.ProjectId.Value,
                ProjectName = projectInfo.ProjectName,
                Mdf = projectInfo.ProjectMdf.Value,
                MIndex = projectInfo.ProjectMIndex.Value,
                IsRole = 1,
                Member = projectInfo.ProjectOwner,
                CreatedDate = projectInfo.ProjectCreatedDate,
                ModifiedDate = projectInfo.ProjectModifiedDate,
                StrategyId = lastProjectAction == null ? 0 : lastProjectAction.Project.StrategyId.Value,
                Url = lastProjectAction == null
                    ? string.Empty
                    : lastProjectAction.Project.Type == 1 ? Constants.UrlMarketting : Constants.UrlCrm
            };
            return project;
        }
    }
}
