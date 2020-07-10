using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Fecha { get; set; }

 
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Odontologo { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Motivo { get; set; }
    }
}