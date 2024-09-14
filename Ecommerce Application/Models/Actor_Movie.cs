using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ecommerce_Application.Models
{
    // The Actor_Movie class represents the join table that links Actor and Movie.
    // This is a many-to-many relationship join table that connects actors with movies they are involved in.
    public class Actor_Movie
    {
        // Foreign key to the Movie entity.
        // This integer property represents the unique identifier of the movie in the Movie table.
        public int MovieId { get; set; }

        // Navigation property for the Movie entity.
        // This property allows access to the associated Movie entity for this join record.
        public Movie Movie { get; set; }

        // Foreign key to the Actor entity.
        // This integer property represents the unique identifier of the actor in the Actor table.
        public int ActorId { get; set; }

        // Navigation property for the Actor entity.
        // This property allows access to the associated Actor entity for this join record.
        public Actor Actor { get; set; }
    }
}

// Summary:
// - The `Actor_Movie` class acts as a junction table for a many-to-many relationship between `Actor` and `Movie` entities.
// - `MovieId` and `ActorId` are foreign keys that link this join table to the `Movie` and `Actor` entities, respectively.
// - The `Movie` and `Actor` properties are navigation properties that facilitate access to the related entities.
// - This setup allows the application to manage and query the many-to-many relationship between actors and movies efficiently.
