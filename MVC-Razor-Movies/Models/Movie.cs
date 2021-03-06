using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Razor_Movies.Models
{
    public enum Genres
    {
        Comedy, Drama, Horror, Romance, Fantasy, Cyberpunk, Anime 
    }

    /// <summary>
    /// The main properties for a movie in a database
    /// 
    /// Created by Tyronne Bradburn
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Genres Genre { get; set; }

        public decimal Price { get; set; }
    }
}
