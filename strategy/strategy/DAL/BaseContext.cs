using Microsoft.EntityFrameworkCore;
using strategy.Common;
using strategy.DbModels;

namespace strategy.DAL
{
    public partial class BaseContext: DbContext
    {
        //public virtual DbSet<AccountLastAction> AccountLastActions { get; set; }

        public BaseContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AccountLastAction>(entity =>
            {
                entity.ToTable("AccountLastAction");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
