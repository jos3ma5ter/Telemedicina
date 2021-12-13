using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable <Veterinario> GetAllVeterinario();
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario (Veterinario veterinario);
        void DeleteVeterinario (int IdVeterinario);
        Veterinario GetVeterinario (int IdVeterinario);
    }
}
