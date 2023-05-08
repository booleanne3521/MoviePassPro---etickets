using System.ComponentModel.DataAnnotations;

namespace WebshopApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships: 1 Producer can have MANY movies
        public List<Movie> Movies { get; set; }

    }
}
