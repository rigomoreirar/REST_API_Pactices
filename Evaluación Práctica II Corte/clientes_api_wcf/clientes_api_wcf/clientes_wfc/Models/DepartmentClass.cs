using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace clientes_wfc.Models
{
    public class DepartmentClass
    {
        [Display(Name = "ID")]
        public int DepartmentID { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Grupo")]
        public string GroupName { get; set; }
    }
}