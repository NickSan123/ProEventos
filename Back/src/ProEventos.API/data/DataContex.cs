using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.data
{
    public class DataContex:DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
    }
}