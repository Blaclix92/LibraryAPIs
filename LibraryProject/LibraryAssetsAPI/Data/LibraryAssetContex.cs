using LibraryAssetsAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssetsAPI.Data
{
    public class LibraryAssetContex:DbContext
    {
        public LibraryAssetContex(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(ConfigureBook);
            builder.Entity<Status>(ConfigureStatus);
            builder.Entity<Video>(ConfigureVideo);
        }

        private void ConfigureVideo(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable("Video");
            builder.Property(c => c.Id).ForSqlServerUseSequenceHiLo("video_hilo").IsRequired(true);
            builder.Property(c => c.Title).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.Year).IsRequired(true);
            builder.Property(c => c.NumberOfCopies).IsRequired(true);
            builder.Property(c => c.Cost).IsRequired(true);
            builder.Property(c => c.ImageUrl).IsRequired(true);
            //builder.Property(c => c.StatusId).IsRequired(true);
            builder.Property(c => c.Director).IsRequired(true);
            builder.HasOne(c => c.Status).WithMany().HasForeignKey(c => c.StatusId);
            //throw new NotImplementedException();
        }

        private void ConfigureStatus(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            builder.Property(c => c.Id).ForSqlServerUseSequenceHiLo("status_hilo").IsRequired(true);
            builder.Property(c => c.Name).IsRequired(true).HasMaxLength(100);
            builder.Property(c => c.Description).IsRequired(true).HasMaxLength(100);
           // throw new NotImplementedException();
        }

        private void ConfigureBook(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.Property(c => c.Id).ForSqlServerUseSequenceHiLo("book_hilo").IsRequired(true);
            builder.Property(c => c.Title).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.Year).IsRequired(true);
            builder.Property(c => c.NumberOfCopies).IsRequired(true);
            builder.Property(c => c.Cost).IsRequired(true);
            builder.Property(c => c.ImageUrl).IsRequired(false);
            //builder.Property(c => c.StatusId).IsRequired(true);
            builder.Property(c => c.ISBN).IsRequired(true);
            builder.Property(c => c.Author).IsRequired(true);
            builder.Property(c => c.DeweyIndex).IsRequired(true);
            builder.HasOne(c => c.Status).WithMany().HasForeignKey(c=> c.StatusId);
            //throw new NotImplementedException();
        }
        public DbSet<Video> Video { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
