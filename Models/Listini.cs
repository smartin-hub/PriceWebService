using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PriceWebService.Models {

    public class Listini {

        [Key]
        [MinLength(1, ErrorMessage="Inserisci l'Id del listino")]
        public string Id {get; set;}

        [MinLength(5, ErrorMessage = "La descrizione non può avere meno di 5 caratteri")]
        [MaxLength(30, ErrorMessage = "La descrizione può avere al massimo 30 caratteri.")]
        public string Descrizione {get; set;}

        public string Obsoleto {get; set;}

        public virtual ICollection<DettListini> DettListini { get; set; }
    }
}