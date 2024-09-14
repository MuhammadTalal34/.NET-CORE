using Ecommerce_Application.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce_Application.Models
{
    public class Movie
    {
        // Primary Key: This defines the unique identifier for each movie.
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public MovieCategory MovieCategory { get; set; }

        // Many-to-Many Relationship: A movie can have many actors, and an actor can appear in many movies.
        // The 'Actor_Movies' list holds the join entities representing this relationship.
        public List<Actor_Movie> Actor_Movies { get; set; }

        // Foreign Key: CinemaId is the foreign key representing the Cinema where the movie is shown.
        // It creates a one-to-many relationship where one cinema can have many movies.
        public int CinemaId { get; set; }

        // Foreign Key Attribute: This explicitly marks CinemaId as the foreign key for the Cinema table.
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Foreign Key: ProducerId represents the producer of the movie.
        // It creates a one-to-many relationship where one producer can produce many movies.
        public int ProducerId { get; set; }

        // Foreign Key Attribute: This explicitly marks ProducerId as the foreign key for the Producer table.
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
