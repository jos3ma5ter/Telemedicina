using System.Collections.Generic;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Persistencia
{
    public interface  IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistorias();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        void DeleteHistoria(int IdHistoria);
        Historia GetHistoria (int IdHistoria);
        void AddSugerenciaHistoria(int id, SugerenciaCuidado sugerencia);
        
    }
}