using EjemploAjaxActionLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploAjaxActionLink.Controllers
{
    public class HomeController : Controller
    {
        private List<DtoUsuario> _usuarios;
        public HomeController()
        {
            _usuarios = new List<DtoUsuario>();

            _usuarios.Add(DtoUsuario.Crear(Guid.Parse("882563b1-6c76-4e2e-b030-5f4d9e9cbf20"), "Alfredo", DateTime.Now));

            _usuarios.Add(DtoUsuario.Crear(Guid.Parse("c1704b60-1c6a-4276-a65d-2cb97fa9eaf1"), "Enrique", DateTime.Now));

            _usuarios.Add(DtoUsuario.Crear(Guid.Parse("882563b1-6c76-4e2e-b030-5f4d9e9cbf23"), "Miguel", DateTime.Now));

            _usuarios.Add(DtoUsuario.Crear(Guid.Parse("882563b1-6c76-4e2e-b030-5f4d9e9cbf24"), "Alejandro", DateTime.Now));

            _usuarios.Add(DtoUsuario.Crear(Guid.Parse("882563b1-6c76-4e2e-b030-5f4d9e9cbf26"), "Alondra", DateTime.Now));
        }
        public ActionResult Index()
        {
            return View(_usuarios);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public PartialViewResult ConsultarDetalleUsuario(Guid idUsuario)
        {
            return PartialView("_consultarDetalleUsuario", (_usuarios.Where(u => u.IdUsuario == idUsuario).FirstOrDefault()));
        }
        [HttpGet]
        public PartialViewResult EditarUsuario(Guid idUsuario)
        {
            var usuario = (_usuarios.Where(u => u.IdUsuario == idUsuario).FirstOrDefault());
            return PartialView("_editarUsuario",new UsuarioViewModel() { IdUsuario = usuario.IdUsuario,Usuario =usuario.Usuario,FechaAlta = usuario.FechaAlta } );
        }
        [HttpPost]
        public string GuardarUsuarioEditado(UsuarioViewModel dtoUsuario)
        {
            if (ModelState.IsValid)
                return "El usuario se edito correctamente.";
            return "Modelo incorrecto";
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}