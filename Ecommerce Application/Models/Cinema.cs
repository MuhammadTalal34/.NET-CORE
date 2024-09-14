using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Application.Models
{
    public class Cinema
    {
        // Primary Key: This defines the unique identifier for each cinema.
        [Key]
        public int CinemaId { get; set; }
        public string CinemaLogo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // One-to-Many Relationship: A cinema can show multiple movies.
        // This list holds the movies that are shown in this cinema.
        // The `Movies` property represents the one-to-many relationship where one cinema can have many movies.
        public List<Movie> Movies { get; set; }
    }
}
