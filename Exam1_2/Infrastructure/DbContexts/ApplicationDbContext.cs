using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Exam1_2.Infrastructure.DbContexts;
using Exam1_2.Infrastructure.BusinessObjects;
using Exam1_2.Infrastructure.Entities;
using Microsoft.AspNet.SignalR.Messaging;
using Book = Exam1_2.Infrastructure.BusinessObjects.Book;
using Reader = Exam1_2.Infrastructure.BusinessObjects.Reader;

namespace Exam1_2.Infrastructure.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public ApplicationDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                object value = optionsBuilder.UseSqlServer(_connectionString,
                    b => b.MigrationsAssembly(_migrationAssemblyName)
                );
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");

            modelBuilder.Entity<ReaderRegistration>().HasKey(c => new { c.Book, c.MemberID });


            modelBuilder.Entity<ReaderRegistration>()
                .HasOne(a => a.Book)
                .WithMany(n => n.ReaderBooks)
                .HasForeignKey(x => x.MemberID);

            modelBuilder.Entity<ReaderRegistration>()
                .HasOne(a => a.Student)
                .WithMany(n => n.ReaderBooks)
                .HasForeignKey(x => x.StudentId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }
        
    }
}
}