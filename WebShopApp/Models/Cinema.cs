using System.ComponentModel.DataAnnotations;

namespace WebshopApp.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public  string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships: 1 Cinema can have MANY movies
        public List<Movie> Movies { get; set; }
    }
}
