using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<Dialogs> Dialogs { get; set; } = null!;
        public DbSet<Friends> Friends { get; set; } = null!;
        public DbSet<Massages> Massages { get; set; } = null!;
        public DbSet<MassageToPhotos> MassageToPhotos { get; set; } = null!;
        public DbSet<Photos> Photos { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserToDialogs> UserToDialogs { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MassageToPhotos>()
                .HasOne(d => d.Photos)
                .WithMany()
                .HasForeignKey(b => b.photo_id);

            modelBuilder.Entity<MassageToPhotos>()
                .HasOne(d => d.Massages)
                .WithMany()
                .HasForeignKey(l => l.massage_id);

            modelBuilder.Entity<Massages>()
                .HasOne(d => d.Dialogs)
                .WithMany()
                .HasForeignKey(s => s.dialog_id);

            modelBuilder.Entity<Friends>()
                .HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(a => a.user_id);
            modelBuilder.Entity<Role>()
                .HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(q => q.user_id);

            modelBuilder.Entity<Role>()
                .HasOne(d => d.Dialogs)
                .WithMany()
                .HasForeignKey(w => w.Id_dialogs);

            modelBuilder.Entity<UserToDialogs>()
                .HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(r => r.user_id);

            modelBuilder.Entity<UserToDialogs>()
                .HasOne(d => d.Dialogs)
                .WithMany()
                .HasForeignKey(t => t.dialogs_id);
        }
    }

    
}
