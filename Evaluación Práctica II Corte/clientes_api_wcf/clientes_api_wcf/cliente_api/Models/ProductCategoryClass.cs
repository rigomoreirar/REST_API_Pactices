using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cliente_api.Models
{
    public class ProductCategoryClass
    {
        [Display(Name = "ProductCategoryID")]
        public string ProductCategoryID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "rowguid")]
        public string rowguid { get; set; }

        [Display(Name = "ModifiedDate")]
        public string ModifiedDate { get; set; }
    }
}