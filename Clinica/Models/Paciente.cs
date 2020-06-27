using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Paciente
    {
        public int Id { get;  set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]

        public string Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Apellido { get; set; }

        
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]

        public string Correo { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Rut { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 9)]
        public string Telefono { get; set; }

        
    }
}