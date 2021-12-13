using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
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
        public RepositorioSugerenciaCuidado (AppContext appContext)
        {
            _appContext = appContext;
        }
        */
        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
           var sugerenciaCuidadoAdicionado= _appContext.SugerenciasCuidado.Add(sugerenciaCuidado);
           _appContext.SaveChanges();
           return sugerenciaCuidadoAdicionado.Entity;
        }

        void IRepositorioSugerenciaCuidado.DeleteSugerenciaCuidado(int IdSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado=_appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == IdSugerenciaCuidado);
            if (sugerenciaCuidadoEncontrado==null)
            return;
            _appContext.SugerenciasCuidado.Remove(sugerenciaCuidadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.GetAllSugerenciaCuidado()
        {
            return _appContext.SugerenciasCuidado;
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.GetSugerenciaCuidado(int IdSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado=_appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == IdSugerenciaCuidado);
            return sugerenciaCuidadoEncontrado;
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado=_appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == sugerenciaCuidado.Id);
            if (sugerenciaCuidadoEncontrado!=null)
            {
                sugerenciaCuidadoEncontrado.Descripcion=sugerenciaCuidado.Descripcion;
                sugerenciaCuidadoEncontrado.FechaHora=sugerenciaCuidado.FechaHora;
                _appContext.SaveChanges();
                
            }
            
            return sugerenciaCuidadoEncontrado;
        }
    }
}