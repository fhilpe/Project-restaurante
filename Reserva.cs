using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebadiseño
{
    internal class Reserva
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public int cantidad_personas { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public int id_mesa { get; set; }

        public Reserva() { }

        public Reserva(int id, string nombre, string celular, string correo, int cantidad_personas, DateTime fecha, TimeSpan hora)
        {
            this.id = id;
            this.nombre = nombre;
            this.celular = celular;
            this.correo = correo;
            this.cantidad_personas = cantidad_personas;
            this.fecha = fecha;
            this.hora = hora;
            this.id_mesa = id_mesa;
        }



    }
}
