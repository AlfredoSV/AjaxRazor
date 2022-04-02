using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploAjaxActionLink.Models
{
    public class DtoUsuario
    {
        private Guid idUsuario;
        private string usuario;
        private DateTime fechaAlta;

        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }

        public DtoUsuario(Guid idUsuario, string usuario, DateTime fechaAlta)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.fechaAlta = fechaAlta;
        }

        public static DtoUsuario Crear(Guid idUsuario, string usuario, DateTime fechaAlta) =>
            new DtoUsuario( idUsuario,  usuario,  fechaAlta);
    }
}