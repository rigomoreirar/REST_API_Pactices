using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clientes_wfc.Models
{
    public class CreditCardClass
    {
        [Display(Name = "ID")]
        public int CreditCardID { get; set; }

        [Display(Name = "Tipo de Tarjeta")]
        public string CardType { get; set; }

        [Display(Name = "Número de Tarjeta")]
        public string CardNumber { get; set; }

        [Display(Name = "Mes de Vencimiento")]
        public int ExpMonth { get; set; }

        [Display(Name = "Año de Vencimiento")]
        public int ExpYear { get; set; }
    }
}