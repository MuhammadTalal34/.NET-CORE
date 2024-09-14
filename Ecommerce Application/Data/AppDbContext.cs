using Ecommerce_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Application.Data
{
    // DbContext is the main class that interacts with the database in EF Core.
    // This class defines the application's data models and configures their relationships.
    public class AppDbContext : DbContext
    {
        // Constructor to pass configuration options (like the database connection string) to DbContext.
        // These options are typically passed in from the application's startup configuration.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Override the OnModelCreating method to define model relationships and configure composite keys.
        // This method is called when the EF Core model is being created.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the composite primary key for the Actor_Movie join entity.
            // The primary key consists of both ActorId and MovieId, which form the unique identifier for each entry.
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,  // The ActorId column will be part of the primary key.
                am.MovieId   // The MovieId column will also be part of the primary key.
            });

            // Set up the relationship between Actor_Movie and Movie.
            // Each Actor_Movie entry refers to a single Movie (many-to-one relationship).
            // Each Movie can be associated with many Actor_Movie entries (one-to-many relationship).
            modelBuilder.Entity<Actor_Movie>()
                .HasOne(am => am.Movie)                // Each Actor_Movie entry has one Movie.
                .WithMany(m => m.Actor_Movies)         // Each Movie can have many Actor_Movie entries.
                .HasForeignKey(am => am.MovieId);      // MovieId is the foreign key that references the Movie entity.

            // Set up the relationship between Actor_Movie and Actor.
            // Each Actor_Movie entry refers to a single Actor (many-to-one relationship).
            // Each Actor can be associated with many Actor_Movie entries (one-to-many relationship).
            modelBuilder.Entity<Actor_Movie>()
                .HasOne(am => am.Actor)                // Each Actor_Movie entry has one Actor.
                .WithMany(a => a.Actor_Movies)         // Each Actor can have many Actor_Movie entries.
                .HasForeignKey(am => am.ActorId);      // ActorId is the foreign key that references the Actor entity.

            // Always call the base class's OnModelCreating method to ensure that any default configuration provided by the base class is applied.
            base.OnModelCreating(modelBuilder);
        }

        // DbSet properties define which models are represented as tables in the database.
        // Each DbSet corresponds to a table in the database, and each property is a row in that table.

        // DbSet for Actor table, which stores all Actor entities.
        public DbSet<Actor> Actors { get; set; }

        // DbSet for the join entity Actor_Movie, which represents the many-to-many relationship between Actors and Movies.
        public DbSet<Actor_Movie> Actor_Movies { get; set; }

        // DbSet for Movie table, which stores all Movie entities.
        public DbSet<Movie> Movies { get; set; }

        // DbSet for Producer table, which stores all Producer entities.
        public DbSet<Producer> Producers { get; set; }

        // DbSet for Cinema table, which stores all Cinema entities.
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
