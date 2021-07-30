using Microsoft.EntityFrameworkCore;
using strategy.DbModels;
using strategy.StoredModels;


namespace strategy.DAL
{
    public class ProjectGroupContext : BaseContext
    {
        public ProjectGroupContext(DbContextOptions<ProjectGroupContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ProjectGroupGetMember>(entity =>
            {
                entity.Property(e => e.MemberName);
                entity.Property(e => e.MemberEmail);
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName);
                entity.Property(e => e.LastLoginedDate);
                entity.Property(e => e.Role);
                entity.Property(e => e.MemberId);
                entity.Property(e => e.IsActived);
                entity.Property(e => e.ActiveValue);
                entity.Property(e => e.Firm);
                entity.Property(e => e.Department);
                entity.Property(e => e.MobilePhone);
                entity.Property(e => e.HomePhone);

                entity.HasNoKey();
            });

            modelBuilder.Entity<ProjectGetByMemberWithGroup>(entity =>
            {
                entity.Property(e => e.ProjectGroupId);
                entity.Property(e => e.ProjectGroupName);
                entity.Property(e => e.ProjectGroupMdf);
                entity.Property(e => e.ProjectGroupMIndex);
                entity.Property(e => e.ProjectId);
                entity.Property(e => e.ProjectName);
                entity.Property(e => e.ProjectOwner);
                entity.Property(e => e.ProjectMdf);
                entity.Property(e => e.ProjectMIndex);
                entity.Property(e => e.ProjectCreatedDate);
                entity.Property(e => e.ProjectModifiedDate);
                entity.Property(e => e.StrategyId);
                entity.Property(e => e.Type);
                entity.Property(e => e.Rn);

                entity.HasNoKey();
            });

            modelBuilder.Entity<AccountLastAct>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.AccountId);
                entity.Property(e => e.ProjectId);
                entity.Property(e => e.CodeLastActionId);
                entity.Property(e => e.Value);

                entity.HasNoKey();
            });

            base.OnModelCreating(modelBuilder);

        }

    }
}
