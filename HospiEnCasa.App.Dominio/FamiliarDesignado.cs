using System;
namespace HospiEnCasa.App.Dominio
{
    public class FamiliarDesignado : Persona
    {
        public string Email { get; set; }
        public Mascota Mascota { get; set; }
        public FamiliarDesignado()
        {
            this.Mascota = new Mascota();
        }
    }
}