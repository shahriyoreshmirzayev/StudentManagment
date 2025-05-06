using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Shared.Models;

namespace StudentManagment.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<SystemCode> SystemCodes { get; set; }
        public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookIssuance> BookIssuanceHistory { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach(var realtionship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                realtionship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(builder);
            builder.Entity<Student>()
                   .HasOne(f => f.Country)
                   .WithMany()
                   .HasForeignKey(f => f.CountryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<Parent>())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    if (entry.Entity.DOB.Kind != DateTimeKind.Utc)
                    {
                        entry.Entity.DOB = DateTime.SpecifyKind(entry.Entity.DOB, DateTimeKind.Utc);
                    }
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
