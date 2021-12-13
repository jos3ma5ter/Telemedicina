using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int IdMascota);
        Mascota GetMascota (int IdMascota);
        void AddSignoVitalLista(int idM, SignoVital signoV);
        void AddHistoriaDeMascota(int idM, Historia historia);
    }
}