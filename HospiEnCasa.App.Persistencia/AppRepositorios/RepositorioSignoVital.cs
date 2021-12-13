using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSignoVital:IRepositorioSignoVital
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
        public RepositorioSignoVital (AppContext appContext)
        {
            this._appContext = appContext;
        }
        */
        SignoVital IRepositorioSignoVital.AddSignoVital(SignoVital signoVital)
        {
           var SignoVitalAdicionado= _appContext.SignosVitales.Add(signoVital);
           _appContext.SaveChanges();
           return SignoVitalAdicionado.Entity;
        }
        void IRepositorioSignoVital.DeleteSignoVital(int IdSignoVital)
        {
            var signoVitalEncontrado=_appContext.SignosVitales.FirstOrDefault(p => p.Id == IdSignoVital);
            if (signoVitalEncontrado==null)
            return;
            _appContext.SignosVitales.Remove(signoVitalEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<SignoVital> IRepositorioSignoVital.GetAllSignoVital()
        {
            return _appContext.SignosVitales;
        }
        SignoVital IRepositorioSignoVital.GetSignoVital(int IdSignoVital)
        {
            var signoVitalEncontrado=_appContext.SignosVitales.FirstOrDefault(p => p.Id == IdSignoVital);
            return signoVitalEncontrado;
        }
        SignoVital IRepositorioSignoVital.UpdateSignoVital(SignoVital signoVital)
        {
            var signoVitalEncontrado=_appContext.SignosVitales.FirstOrDefault(p => p.Id == signoVital.Id);
            if (signoVitalEncontrado!=null)
            {
                signoVitalEncontrado.FrecuenciaCardiaca=signoVital.FrecuenciaCardiaca;
                signoVitalEncontrado.FrecuenciaRespiratoria=signoVital.FrecuenciaRespiratoria;
                signoVitalEncontrado.Temperatura=signoVital.Temperatura;
                    
            }
            
            return signoVitalEncontrado;
        }

    }
}