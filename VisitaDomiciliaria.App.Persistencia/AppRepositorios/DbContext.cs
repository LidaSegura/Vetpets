using Microsoft.EntityframeworkCore;

namespace VisitaDomiciliaria.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Mascota> Mascotas {get;set;}
    }
}