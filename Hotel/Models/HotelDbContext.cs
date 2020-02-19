using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Models.Huesped> Huespedes { get; set; }

        public DbSet<Models.Habitacion> Habitaciones { get; set; }

        public DbSet<Models.Categoria> Categorias { get; set; }
    }
}