using Microsoft.EntityFrameworkCore;
using strategy.Common;


namespace strategy.DAL
{
    public partial class BaseContext<T>: DbContext where T: class
    {
        public virtual DbSet<T> DbSets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Global.ConnectStr);
            }
        }

        public BaseContext(DbContextOptions options) : base(options)
        {
        }
        public BaseContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
