using BeerCollection.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerCollection.Models
{
    public class Review 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BeerId { get; set; }

        [Required(ErrorMessage = "Imię recenzenta jest wymagane")]
        [StringLength(100)]
        public string ReviewerName { get; set; }

        [Range(1, 5, ErrorMessage = "Ocena musi być od 1 do 5")]
        public int Rating { get; set; }

        [StringLength(1000)]
        public string? Comment { get; set; }

        public DateTime ReviewDate { get; set; } = DateTime.Now;

        [ForeignKey("BeerId")]
        public Beer Beer { get; set; }
    }
}