using Microsoft.EntityFrameworkCore;
using QuickBase.Domain.Models;

namespace QuickBase.SqliteData
{
    /// <summary>The SQlite context.</summary>
    public class SqliteContext : DbContext
    {
        /// <summary>Initializes a new instance of the <see cref="SqliteContext" /> class.</summary>
        /// <param name="options">The options.</param>
        public SqliteContext(DbContextOptions<SqliteContext> options) : base(options)
        {
        }

        /// <summary>Gets or sets the country.</summary>
        /// <value>The country.</value>
        public DbSet<Country> Country { get; set; }

        /// <summary>Gets or sets the state.</summary>
        /// <value>The state.</value>
        public DbSet<State> State { get; set; }

        /// <summary>Gets or sets the city.</summary>
        /// <value>The city.</value>
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasKey(c => c.CityId);

            modelBuilder.Entity<State>().HasKey(s => s.StateId);
            modelBuilder.Entity<State>().HasMany(s => s.Cities).WithOne(c => c.State).HasForeignKey(s => s.StateId);

            modelBuilder.Entity<Country>().HasKey(co => co.CountryId);
            modelBuilder.Entity<Country>().HasMany(co => co.States).WithOne(s => s.Country).HasForeignKey(s => s.CountryId);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
