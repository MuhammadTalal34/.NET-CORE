using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Application.Models
{
    public class Producer
    {
        // Primary Key: This defines the unique identifier for each producer.
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // One-to-Many Relationship: A producer can be associated with multiple movies.
        // This list holds the movies that are produced by this producer.
        // The `Movies` property represents a one-to-many relationship where one producer can produce many movies.
        public List<Movie> Movies { get; set; }
    }
}
