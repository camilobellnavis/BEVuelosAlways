using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEVuelosAlways.Model
{
    public class Login
    {
        public int id { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        public string contraseña { get; set; }
        [Required]
        public string rol { get; set; }



    }
}
