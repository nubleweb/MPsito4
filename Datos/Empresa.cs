using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PeCe_s_Consola.Clases
{//Clase Empresa que hereda de Cliente y propiedad
    public class Empresa : Cliente
    {
        public string RazonSocial { get; set; }
//Sobreescribe el metodo Información()de Cliente
        public override string Informacion()
        {
            string informacionCliente = base.Informacion(); // Llamada al método base de la clase Cliente
            return $"{informacionCliente}\nRazón Social: {RazonSocial}";
        }
    }
}
