using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        //======================================================
        //conectar a la base de datos desde frontend
        //=====================================================
        ///*
        private readonly AppContext _appContext = new AppContext();
        //*/
        //============================================================
        //conectar a la base de datos desde consola para hacer pruebas 
        //============================================================
         /*
        private readonly AppContext _appContext;
        public RepositorioHistoria (AppContext appContext)
        {
            this._appContext = appContext;
        }
        */
        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
           var historiaAdicionado= _appContext.Historias.Add(historia);
           _appContext.SaveChanges();
           return historiaAdicionado.Entity;
        }
        void IRepositorioHistoria.DeleteHistoria(int IdHistoria)
        {
            var historiaEncontrado=_appContext.Historias.FirstOrDefault(p => p.Id == IdHistoria);
            if (historiaEncontrado==null)
            return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Historia> IRepositorioHistoria.GetAllHistorias()
        {
            return _appContext.Historias;
        }
        Historia IRepositorioHistoria.GetHistoria(int IdHistoria)
        {
            var historiaEncontrado=_appContext.Historias.FirstOrDefault(p => p.Id == IdHistoria);
            return historiaEncontrado;
        }
        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var historiaEncontrado=_appContext.Historias.FirstOrDefault(p => p.Id == historia.Id);
            if (historiaEncontrado!=null)
            {
                historiaEncontrado.Diagnostico=historia.Diagnostico;
                historiaEncontrado.SugerenciaCuidado=historia.SugerenciaCuidado;
                _appContext.SaveChanges();
                
            }
            
            return historiaEncontrado;
        }
        void IRepositorioHistoria.AddSugerenciaHistoria(int id, SugerenciaCuidado sugerencia)
        {
            var historia=_appContext.Historias.Find(id);
            if (historia != null)
            { 
                if (historia.SugerenciaCuidado != null)
                {
                    historia.SugerenciaCuidado.Add(sugerencia);
                }
                else
                {
                    historia.SugerenciaCuidado = new List<SugerenciaCuidado>();
                    historia.SugerenciaCuidado.Add(sugerencia);
                }
                _appContext.SaveChanges();
            }
        }
    }
}