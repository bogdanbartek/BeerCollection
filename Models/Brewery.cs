using BeerCollection.Models;
using System.ComponentModel.DataAnnotations;

namespace BeerCollection.Models
{
    public class Brewery  
    {
        [Key]  
        public int Id { get; set; } 

        [Required(ErrorMessage = "Nazwa browaru jest wymagana")]
        [StringLength(100, ErrorMessage = "Nazwa browaru może mieć maksymalnie 100 znaków")]
        public string Name { get; set; } 

        [Required(ErrorMessage = "Kraj jest wymagany")]
        [StringLength(50, ErrorMessage = "Nazwa kraju może mieć maksymalnie 50 znaków")]
        public string Country { get; set; } 

        [StringLength(100, ErrorMessage = "Nazwa miasta może mieć maksymalnie 100 znaków")]
        public string? City { get; set; }  

      

       

        
        public ICollection<Beer> Beers { get; set; } = new List<Beer>();  
    }
}