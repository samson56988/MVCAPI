using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class mvcEmployee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}