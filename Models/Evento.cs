using System;

namespace netEntradas.Models
{
    class Evento
    {
        public int idEvento = 0;
        public string nombre;
        public string cantante;
        public string descripcion;
        public string localidad;
        public decimal precioEntrada;
        public int stock;

        //Constructor
        public Evento(string idEvento, string nombre, string cantante, string descripcion, string localidad, string precioEntrada, string stock)
        {
            this.idEvento = idEvento;
            this.nombre = nombre;
            this.cantante = cantante;
            this.descripcion = descripcion;
            this.localidad = localidad;
            this.precioEntrada = precioEntrada;
            this.stock = stock;
        }
    }
}