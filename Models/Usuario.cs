using System;

namespace netEntradas.Models
{
    class Usuario
    {
        public int idUsuario = 0;
        public string email;
        public string nombre; 
        public string password;
        public string localidad;
        public string cuentaBancaria;
        public List<Evento> eventosComprados = new List<Evento>();

        //Constructor
        public Usuario(string email, string nombre, string password, string localidad, string cuentaBancaria)
        {
            this.idUsuario = idUsuario;
            this.email = email;
            this.nombre = nombre;
            this.password = password;
            this.localidad = localidad;
            this.cuentaBancaria = cuentaBancaria;
        }

        public void comprarEntrada(Evento evento){

            Operacion operacion = new Operacion();
            eventosComprados.add();
        }
    }
}