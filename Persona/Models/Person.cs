using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Persona.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Fecha es obligatorio")] 
        public string Fecha { get; set; }
        [Required(ErrorMessage = "El campo DNI solo tiene 8 digitos")]
        public string DNI { get; set; }
        [Required(ErrorMessage = "El campo Genero es obligatorio")] 
        public string Genero { get; set; }
        [Required(ErrorMessage = "El campo Ciudad es obligatorio")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El campo Direccion es obligatorio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo Correo debe contener @ es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo Usuario es obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo Contraseña debe tener numerso y letras es obligatorio")]
        public string Contraseña { get; set; }

    }
}
