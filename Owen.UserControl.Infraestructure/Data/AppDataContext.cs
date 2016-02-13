using Owen.UserControl.Domain.Models;
using Owen.UserControl.Infraestructure.Data.Map;
using System.Data.Entity;

namespace Owen.UserControl.Infraestructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("AppConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
