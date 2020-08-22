using System;
using System.ComponentModel.DataAnnotations;

namespace GameLib.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }
    }
}