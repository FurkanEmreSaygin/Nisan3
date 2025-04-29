using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<User> Users => Set<User>();
        public DbSet<Movies> Movies => Set<Movies>();
        public DbSet<MovieTrack> MovieTracks => Set<MovieTrack>();
    }
}