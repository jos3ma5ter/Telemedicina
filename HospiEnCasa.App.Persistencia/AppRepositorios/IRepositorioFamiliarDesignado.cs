using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioFamiliarDesignado
    {
        IEnumerable<FamiliarDesignado> GetAllF();
        FamiliarDesignado AddFamiliar(FamiliarDesignado familiar, Mascota mascota, Historia historia);
        FamiliarDesignado UpdateFamiliar(FamiliarDesignado familiar);
        void DeleteFamiliar (int IdFamiliarDesignado);
        FamiliarDesignado GetFamiliar(int IdFamiliarDesignado);
        Mascota BuscarMascotaId(int IdFaml);
        FamiliarDesignado GetFamiliarPorCc(string cedula);
    }
}   