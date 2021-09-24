using Microsoft.EntityFramemworkCore;
		namespace VisitaDomiciliaria.App.Persistencia
        {
			public class AppContext:DbContext
            {
				//crear propiedades por cada entidad del Dominio
				public DbSet<Gato> Gatos {get;set;}
                public DbSet<Mascota> Mascotas {get;set;}
                public DbSet<Persona> Personas {get;set;}
                public DbSet<Propietario> Propietarios {get;set;}
                public DbSet<Veterinario> Veterinarios {get;set;}
                public DbSet<Visita> Visitas {get;set;}

                //Conexión con la base de datos
                protected override void OnConfiguring(DbContextOptionBuilder optionsBuilder)
                {
                    if (!optionsBuilder.IsConfigured)
                    {
                        optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = VisitaDomiciliariaData");
                    }		
                }
			}
		}

