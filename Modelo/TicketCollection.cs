using Proyecto_PeCe_s_Consola.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PeCe_s_Consola.Colecciones
{
    public static class TicketCollection
    {
        private static List<Ticket> _listadoTickets = new List<Ticket>();

        public static string Create(Ticket ticket)
        {
            _listadoTickets.Add(ticket);
            return "Ticket creado exitosamente.";
        }
        //El operador null conditional (?.) permite llamar a ToString() solo si ticket no es nulo. 
        public static string Read(int Id, string producto)
        {
            Ticket ticket = _listadoTickets.First(t => t.Id == Id);
            if (ticket != null)
                return ticket?.ToString() ?? "Ticket no encontrado.";
            else
                return "Ticket no encontrado.";
        }
        public static string Update(int id, Ticket ticket)
        {
            // Buscamos el ticket con el ID proporcionado en la lista _listadoTickets utilizando LINQ.
            Ticket existingTicket = _listadoTickets.First(t => ticket.Id == id);

            if (existingTicket != null)
            {
                // Actualizamos solo las propiedades Producto, Descripción y Estado del ticket existente.
                existingTicket.Producto = ticket.Producto;
                existingTicket.Descripcion = ticket.Descripcion;
                existingTicket.Estado = ticket.Estado;

                return "Ticket actualizado exitosamente.";
            }
            else
            {
                return "Ticket no encontrado para actualizar.";
            }
        }
        public static string Delete(int Id)
        {
            // Buscamos el ticket con el ID proporcionado en la lista _listadoTickets utilizando LINQ.
            Ticket existingTicket = _listadoTickets.First(ticket => ticket.Id == Id);

            if (existingTicket != null)
            {
                _listadoTickets.Remove(existingTicket);
                return "Ticket eliminado exitosamente.";
            }
            else
            {
                return "Ticket no encontrado para eliminar.";
            }
        }
        public static List<Ticket> ReadAll()
        {
            return _listadoTickets.ToList();
        }
        public static List<Ticket> Search(string filter)
        {
            List<Ticket> filteredTickets = _listadoTickets
                .Where(ticket =>
                    (ticket.Cliente?.Nombre?.Contains(filter) ?? false) ||
                    (ticket.Cliente?.Rut?.Contains(filter) ?? false) ||
                    (ticket.Estado?.Contains(filter) ?? false))
                .ToList();

            return filteredTickets;
        }
    }
}
