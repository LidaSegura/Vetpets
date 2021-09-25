using System;
namespace VisitaDomiciliaria.App.Dominio
{
    public class Visita
    {
        public string IdVisita {get;set;}        
        public int Temperatura {get;set;}
        public float Peso {get;set;}
        public string FrecuenciaRespiratoria {get;set;}
        public string FrecuenciaCardiaca {get;set;}
        public string EstadoAnimo {get;set;}
        public string IdVeterinario {get;set;}
        public string IdGato {get;set;}
        public string Recomendaciones {get;set;}
        public DateTime FechaVisita {get;set;}
        
    }
}