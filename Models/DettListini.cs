using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceWebService.Models {

    public class DettListini {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required]
        [MinLength(5, ErrorMessage = "La numero minimo di caratteri è 5")]
        [MaxLength(20, ErrorMessage = "La numero massimo di caratteri è 30")]
        public string CodArt {get; set;}

        [Required]
        public string IdList {get; set;}

        [Required]
        [Range(0.01, 1000, ErrorMessage = "Il prezzo deve avere un valore minimo di 1 centesimo e massimo di 1000")]
        
        public decimal Prezzo {get;set;}

        public virtual Listini listino {get; set;}
      
    }

}