using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{

    public class Historia
    {
        public int Id { get; set; }
        public int Diagnostico { get; set; }
        public List<SugerenciaCuidado> SugerenciaCuidado { get; set; }

        public Historia()
        {
            this.SugerenciaCuidado = new List<SugerenciaCuidado>();
        }
    }
}