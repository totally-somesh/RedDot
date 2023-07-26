using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    [Index(nameof(MovieName), IsUnique = true)]
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Please Enter A Valid MovieName !")]
        public string MovieName { get; set; }

        [Required(ErrorMessage = " Please Enter A Valid Director !")]
        public string Director { get; set; }

        [Required(ErrorMessage = " Please Enter A Valid Ticket !")]
        public double Ticket{ get; set; }

        [Required(ErrorMessage = " Please Enter A Valid Release Date !")]
        public DateOnly ReleaseDate { get; set; }



    }
}
