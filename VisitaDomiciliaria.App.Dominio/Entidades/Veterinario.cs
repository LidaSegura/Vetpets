namespace VisitaDomiciliaria.App.Dominio
{
    public class Veterinario : Persona
    {
        public string TarjetaProfesional {get;set;}
        public string Especialidad {get;set;}
        public Visita Visita {get;set;}
    }
}