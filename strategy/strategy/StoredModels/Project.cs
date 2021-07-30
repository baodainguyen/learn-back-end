using strategy.Entity.CustomDto;
using System;
using System.Collections.Generic;
using System.Data;

namespace strategy.StoredModels
{
    public class ProjectGetByMemberWithGroup
    {
        public long ProjectGroupId { get; set; }
        public string ProjectGroupName { get; set; }
        public int ProjectGroupMdf { get; set; }
        public int ProjectGroupMIndex { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectOwner { get; set; }
        public int? ProjectMdf { get; set; }
        public int? ProjectMIndex { get; set; }
        public DateTime? ProjectCreatedDate { get; set; }
        public DateTime? ProjectModifiedDate { get; set; }
        public long? StrategyId { get; set; }
        public int? Type { get; set; }
        public long Rn { get; set; }

    }
    public class ProjectGroupGetMember
    {
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LastLoginedDate { get; set; }
        public int Role { get; set; }
        public long MemberId { get; set; }
        public bool IsActived { get; set; }
        public string ActiveValue { get; set; }
        public string Firm { get; set; }
        public string Department { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
    }
    public class ProjectGroupMember : ProjectGroupGetMember
    {
        public ProjectGroupMember(ProjectGroupGetMember projectG)
        {
            MemberName = projectG.MemberName;
            MemberEmail = projectG.MemberEmail;
            FirstName = projectG.FirstName;
            LastName = projectG.LastName;
            LastLoginedDate = projectG.LastLoginedDate;
            Role = projectG.Role;
            MemberId = projectG.MemberId;
            IsActived = projectG.IsActived;
            ActiveValue = projectG.ActiveValue;
            Firm = projectG.Firm;
            Department = projectG.Department;
            MobilePhone = projectG.MobilePhone;
            HomePhone = projectG.HomePhone;
        }
        public DataRowState RowState { get; set; }
        public bool IsDepartmentChange { get; set; }
        public List<long> ListDepartment { get; set; }
        public TransferResponsibility TransferResponsibility { get; set; }
    }

    public class TransferResponsibility
    {
        public bool IsDone { get; set; }
        public bool IsUndone { get; set; }
        public long TMemberId { get; set; } = -1;
    }

    public class ProjectGroupObj
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Mdf { get; set; }
        public int MIndex { get; set; }
        public List<ProjectByMember> ListProject { get; set; }
        public bool ShowButton { get; set; }
        public bool IsEdit { get; set; }
        public bool IsAddProject { get; set; }
        public bool IsDelete { get; set; }

    }
}
