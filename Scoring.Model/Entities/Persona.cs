using System;

namespace Scoring.Model.Entities
{
    internal class Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public double IngresosNetosAunales {  get; set; } //Autonomo y/o asalariado
        public double IngresosBrutosAnuales { get; set; } //Solo autonomo
        public DateTime FechaInicioEmpleo { get; set; }
        public string Nacionalidad { get; set; }    
        public string CIF {  get; set; }
    }
}
