using Microsoft.AspNetCore.Mvc;
using VisualBasic.NetMVC.Models;

namespace VisualBasic.NetMVC.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FormularioVisita()
        {
            return View();
        }

        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string comentarios = Request.Form["comentarios"].ToString();
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }

        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View();
        }
    }
}
