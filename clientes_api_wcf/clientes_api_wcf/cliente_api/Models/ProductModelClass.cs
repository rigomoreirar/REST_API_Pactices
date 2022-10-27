using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cliente_api.Models
{
    public class ProductModelClass
    {
        [Display(Name = "ProductModelID")]
        public string ProductModelID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "CatalogDescription")]
        public string CatalogDescription { get; set; }

        [Display(Name = "Instructions")]
        public string Instructions { get; set; }

        [Display(Name = "rowguid")]
        public string rowguid { get; set; }

        [Display(Name = "ModifiedDate")]
        public string ModifiedDate { get; set; }
    }
}