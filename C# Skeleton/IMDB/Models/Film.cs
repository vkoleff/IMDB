using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IMDB.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Name { get; set; }

        [AllowHtml]
        [Required]
        public string Genre { get; set; }

        [AllowHtml]
        [Required]
        public string Director { get; set; }

        [Required]
        public int Year { get; set; }
    }
}