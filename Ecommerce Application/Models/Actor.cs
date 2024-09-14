using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Application.Models
{
    public class Actor
    {
        [Key]
        //prop
        public int ActorId { get; set; }
        public string ProfilePictureUrl{ get; set; }
        public string FullName{ get; set; }
        public string Bio{ get; set; }
        //Relationships
        // Navigation property for the many-to-many relationship
        //Similarly, in the Actor class, Actor_Movies is a navigation property that
        //links an Actor to all the Movies they act in.
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
