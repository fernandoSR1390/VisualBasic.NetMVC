using Microsoft.Extensions.Hosting.Internal;

namespace VisualBasic.NetMVC.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string comentarios)
        {
            StreamWriter archivo = new StreamWriter(Path.GetFullPath("/ExampleC#/datos.txt"), append: true);
            archivo.WriteLine("Nombre:" + nombre + "<br>Comentarios:" + comentarios + "<hr>");
            archivo.Close();
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(Path.GetFullPath("/ExampleC#/datos.txt"));
            string todo = archivo.ReadToEnd();
            archivo.Close();
            return todo;
        }
    }
}
