using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Paciente

    {
        public int Id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
         public String Apellido { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }

        [Required]
         [StringLength(25, MinimumLength = 5)]
        public String Direccion { get; set; }

       

        [Required(ErrorMessage = "Debe ingresar el Rut")]
        public String Rut { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 9)]
        public String Telefono { get; set; }
    }
}