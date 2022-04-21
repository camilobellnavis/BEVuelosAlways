using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEVuelosAlways.Model
{
    public class Vuelo
    {
        public int id { get; set; }
        [Required]
        public string ciudadorigen { get; set; }
        [Required]
        public string ciudaddestino { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public int horasalida { get; set; }
        [Required]
        public int horallegada { get; set; }
        [Required]
        public int numerodevuelo { get; set; }
        [Required]
        public string aerolinea { get; set; }
        [Required]
        public string estado { get; set; }
    }
}
