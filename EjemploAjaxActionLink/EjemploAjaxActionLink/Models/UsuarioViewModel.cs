using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjemploAjaxActionLink.Models
{
    public class UsuarioViewModel
    {
        public Guid IdUsuario { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public DateTime FechaAlta { get; set; }
    }
}