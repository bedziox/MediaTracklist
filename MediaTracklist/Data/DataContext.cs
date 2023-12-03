using MediaTracklist.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaTracklist.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Medium> Media { get; set; }
    public DbSet<Tracklist> Tracklists { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the User and Tracklist relationship (one-to-many)
        modelBuilder.Entity<User>()
            .HasMany(user => user.Tracklists)
            .WithOne(tracklist => tracklist.User)
            .HasForeignKey(tracklist => tracklist.UserId);

        // Configure the Tracklist and Medium relationship (one-to-many)
        modelBuilder.Entity<Tracklist>()
            .HasMany(tracklist => tracklist.Media)
            .WithOne(medium => medium.Tracklist)
            .HasForeignKey(medium => medium.TracklistId);
        
        modelBuilder.Entity<User>().HasKey(user => user.Id);
        modelBuilder.Entity<Tracklist>().HasKey(tracklist => tracklist.Id);
        modelBuilder.Entity<Medium>().HasKey(medium => medium.Id);
        
    }
}