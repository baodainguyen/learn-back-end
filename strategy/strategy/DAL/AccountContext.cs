using Microsoft.EntityFrameworkCore;
using strategy.Common;
using strategy.DbModels;
using strategy.Models;

namespace strategy.DAL
{
    public partial class AccountContext : BaseContext
    {        
        public AccountContext(DbContextOptions<AccountContext> options) : base(options) { }
        
        public virtual DbSet<AccountId> AccountIds { get; set; }
        public virtual DbSet<AccountProject> AccountProjects { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCrmRole> AccountCrmRoles { get; set; }
        
        public virtual DbSet<AccountRole> AccountRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.ActiveInviteValue).HasMaxLength(100);

                entity.Property(e => e.ActiveValue)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Firm).HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.LastLoginedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Theme).HasMaxLength(50);

                entity.Property(e => e.TmpEmail).HasMaxLength(75);
            });

            modelBuilder.Entity<AccountCrmRole>(entity =>
            {
                entity.ToTable("AccountCrmRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccountRole>(entity =>
            {
                entity.ToTable("AccountRole");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_AccountRole_Account");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountRole_Role");
            });

            modelBuilder.Entity<CrmAnswerOption>(entity =>
            {
                entity.HasKey(e => e.CrmAnswerId)
                    .HasName("PK_CrmAnswerOption_1");

                entity.ToTable("CrmAnswerOption");

                entity.Property(e => e.CrmAnswerId).ValueGeneratedNever();

                entity.Property(e => e.GreaterThan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LessThan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.CrmAnswer)
                    .WithOne(p => p.CrmAnswerOption)
                    .HasForeignKey<CrmAnswerOption>(d => d.CrmAnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmAnswerOption_CrmAnswer");
            });

            modelBuilder.Entity<CrmFilter>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.IsNavigation).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShare).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mcolor)
                    .HasMaxLength(50)
                    .HasColumnName("MColor");

                entity.Property(e => e.Mcount).HasColumnName("MCount");

                entity.Property(e => e.Mindex).HasColumnName("MIndex");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TypeId).HasComment("2 org, 3 person, 4 activity");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CrmFilters)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmFilters_Account");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CrmFilters)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_CrmFilters_Project");
            });

            modelBuilder.Entity<CrmFiltersCrowd>(entity =>
            {
                entity.ToTable("CrmFiltersCrowd");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CrowdProjectId).HasComment("1 Standard, 2 Customer");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CrmFiltersCrowds)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrmFiltersCrowd_Account");

                entity.HasOne(d => d.CrowdProject)
                    .WithMany(p => p.CrmFiltersCrowds)
                    .HasForeignKey(d => d.CrowdProjectId)
                    .HasConstraintName("FK_CrmFiltersCrowd_CrmCrowdProject");
            });

            modelBuilder.Entity<GoalPerson>(entity =>
            {
                entity.ToTable("GoalPerson");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Mdf).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.GoalPeople)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_GoalPerson_Account");

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.GoalPeople)
                    .HasForeignKey(d => d.GoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GoalPerson_MainGoal");
            });

            modelBuilder.Entity<SubMarketProductAccount>(entity =>
            {
                entity.ToTable("SubMarketProductAccount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SubMarketProductAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarketProductAccount_Account");

                entity.HasOne(d => d.SubMarketProduct)
                    .WithMany(p => p.SubMarketProductAccounts)
                    .HasForeignKey(d => d.SubMarketProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMarketProductAccount_SubMarketProduct");
            });

            base.OnModelCreating(modelBuilder);
            
        }

    }
}
