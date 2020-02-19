using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Huesped
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rut { get; set; }
        public string Correo { get; set; }
        public virtual Habitacion HabitacionHuesped { get; set; }

        public Huesped() { }
    }



    public class Habitacion 
    {
        public int Id { get; set; }
        public bool Ocupado { get; set; }
        public virtual Categoria CategoriaHabitacion { get; set; }
        public virtual List<Huesped> Huespedes { get; set; }

        public Habitacion() { }

    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public short Capacidad { get; set; }
        public long Precio { get; set; }
        public virtual List<Habitacion> Habitaciones { get; set; }

        public Categoria() { }
    }
}