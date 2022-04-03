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
        public string Usuario { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}