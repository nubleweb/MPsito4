using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PeCe_s_Consola.Clases
{      /*Propiedad :createdAt=hora de creación del ticket utilizando la inicialización
        *de propiedad automática con el valor DateTime.Now.
        */
    public class Ticket
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set;}
        public string Estado { get; set; }
        private DateTime _createdAt {get; set;} = DateTime.Now;

        private static int _nextID = 1;

        public Ticket()
        {
            Id = _nextID++;
            Estado = "Recepcionado";
        }


        /*Metodo que imprime toda la informacion del Ticket
        //nvironment.NewLine  propiedad devuelve la combinación de caracteres específica del so actual
        //para un salto de línea. De esta manera, el código es más portable
        entre diferentes plataformas */
        public void Informacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Cliente:");
            Console.WriteLine($"Nombre: {Cliente?.Nombre}");
            Console.WriteLine($"Rut: {Cliente?.Rut}");
            Console.WriteLine($"Teléfono: {Cliente?.Telefono}");
            Console.WriteLine($"Correo electrónico: {Cliente?.Email}");
            Console.WriteLine($"Dirección: {Cliente?.Direccion}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Producto: {Producto}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Creado en: {_createdAt}");
        }


    }
}
