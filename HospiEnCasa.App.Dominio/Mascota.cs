using System.Collections.Generic;
using System;
namespace HospiEnCasa.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string EstadoSalud { get; set; }
        public int Edad { get; set; }
        public Genero Genero { get; set; }
        public string Raza { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public TipoMascota TipoMascota { get; set; }
        public List<SignoVital> SignoVital { get; set; }
        public Historia Historia { get; set; }
        public Mascota()
        {
            this.SignoVital = new List<SignoVital>();
            this.Historia = new Historia();
        }
    }
}