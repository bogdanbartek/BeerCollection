using BeerCollection.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerCollection.Models
{
    public class Beer  
    {
        [Key]  
        public int Id { get; set; }  

        [Required(ErrorMessage = "Nazwa piwa jest wymagana")]
        [StringLength(100, ErrorMessage = "Nazwa może mieć maksymalnie 100 znaków")]
        public string Name { get; set; }  

        [Required(ErrorMessage = "Browar jest wymagany")]  
        public int BreweryId { get; set; }  

        [Required(ErrorMessage = "Typ piwa jest wymagany")]
        [StringLength(50)]
        public string BeerType { get; set; }  

        [Range(0, 50, ErrorMessage = "Zawartość alkoholu musi być między 0 a 50%")]
        public decimal AlcoholContent { get; set; }  

        [Range(1, 5000, ErrorMessage = "Objętość musi być między 1 a 5000 ml")]
        public int Volume { get; set; } 

        [Range(0.01, 999.99, ErrorMessage = "Cena musi być między 0.01 a 999.99")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; } 

        [StringLength(500)]
        public string? Description { get; set; }  

        

       
        [ForeignKey("BreweryId")]  
        public Brewery Brewery { get; set; }  
                                             

        public ICollection<Review> Reviews { get; set; } = new List<Review>();  
    }
}