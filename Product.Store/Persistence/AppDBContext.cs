using Microsoft.EntityFrameworkCore;
using ProductStore.Domain.Models;

namespace ProductStore.Persistence
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) :base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Product> Products { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>().HasKey(x => x.Id);
        //    modelBuilder.Entity<User>().Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
        //    modelBuilder.Entity<User>().Property(x => x.Cpf).IsRequired().HasMaxLength(11);
        //    modelBuilder.Entity<User>().Property(x => x.Email).IsRequired();
        //    modelBuilder.Entity<User>().Property(x => x.Name).IsRequired();
        //    modelBuilder.Entity<User>().Property(x => x.TellPhone).IsRequired();
        //    modelBuilder.Entity<User>().Property(x => x.TellPhone).IsRequired();

        //    modelBuilder.Entity<User>().HasData
        //    (
        //        new User { Id = 1, Cpf = "12312312323", Email= "gg@gg.com", Name = "teste", Password = "123", TellPhone = "88988882899"}
        //    );
        //}
    }
}
