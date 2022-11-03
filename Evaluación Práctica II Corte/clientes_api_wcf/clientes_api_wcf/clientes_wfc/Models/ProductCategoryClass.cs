using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clientes_wfc.Models
{
    public class ProductCategoryClass
    {
        [Display(Name = "ID")]
        public int ProductCategoryID { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }
    }
}