using System;

namespace Scoring.Model.Entities
{
    internal class Solicitud
    {
        public DateTime FechaSolicitud { get; set; }
        public int NumVehiculos { get; set; }
        public double Inversion { get; set; }
        public double Cuota { get; set; }
        public int PlazoMeses { get; set; }
        public DateTime FechaInicio { get; set; }
        public Persona cliente { get; set; }
    }
}