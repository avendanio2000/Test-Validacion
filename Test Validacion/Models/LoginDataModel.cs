using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_Validacion.Models
{
    public class LoginDataModel
    {
        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}", ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud maxima 100")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Recordarme")]
        public bool RemeberMe { get; set; }
    }
}