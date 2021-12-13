using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSignoVital
    {
        IEnumerable<SignoVital> GetAllSignoVital();
        SignoVital AddSignoVital(SignoVital signoVital);
        SignoVital UpdateSignoVital(SignoVital signoVital);
        void DeleteSignoVital(int signoVital);
        SignoVital GetSignoVital(int signoVital);

    }
}
