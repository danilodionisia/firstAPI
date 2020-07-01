using Microsoft.EntityFrameworkCore;
using PorAgil.API.Model;

namespace PorAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Evento> Eventos {get;set;}
    }
}