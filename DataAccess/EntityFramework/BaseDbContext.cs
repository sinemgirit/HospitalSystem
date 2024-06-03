using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    // Veritabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Tobeto4A2; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            //modelBuilder.Entity<Appointment>().HasOne(i => i.DoctorId);
           // modelBuilder.Entity<Product>().Property(i => i.Name).HasColumnName("Name").HasMaxLength(50);
            modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<UserOperationClaim>()

            //Seed Data


            //Category category = new Category(1, "Giyim");
            //Category category1 = new(2, "Elektronik");

            //Product product = new Product(1, "Kazak", 500, 50, 1);

            //modelBuilder.Entity<Category>().HasData(category, category1);
            //modelBuilder.Entity<Product>().HasData(product);

            base.OnModelCreating(modelBuilder);
        }
    }
}
// En doğru seçim => Tutarlı seçim