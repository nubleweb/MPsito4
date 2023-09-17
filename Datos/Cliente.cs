using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PeCe_s_Consola.Clases
{//propiedades de la clase Cliente
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

//Metodo que permite sobreescritura en clases derivadas (polimorfismo), cadena interpolada
        public virtual string Informacion()
        {
            return $"ID: {Id}\nNombre: {Nombre}\nRut: {Rut}\nTelefono: {Telefono}\nEmail: {Email}\nDireccion: {Direccion}";
        }


    }



}
