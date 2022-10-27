using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cliente_api.Models
{
    public class UnitMeasureClass
    {
        [Display(Name = "UnitMeasureCode")]
        public string UnitMeasureCode { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "ModifiedDate")]
        public string ModifiedDate { get; set; }
    }
}