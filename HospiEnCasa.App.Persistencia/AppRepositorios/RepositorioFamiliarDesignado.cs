using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliarDesignado : IRepositorioFamiliarDesignado
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
        public RepositorioFamiliarDesignado (AppContext appContext)
        {
            this._appContext=appContext;
        }
        */ 
        FamiliarDesignado IRepositorioFamiliarDesignado.AddFamiliar(FamiliarDesignado familiar, Mascota mascota, Historia historia)
        {   
            List<SignoVital> listasignoV = new List<SignoVital>();
            List<SugerenciaCuidado> listasugerencia = new List<SugerenciaCuidado>();
            var signovital= new SignoVital();
            var sugerenciacuidado = new SugerenciaCuidado();

            listasignoV.Add(signovital);
            listasugerencia.Add(sugerenciacuidado);


            
            familiar.Mascota=mascota;
            familiar.Mascota.SignoVital=listasignoV;
            familiar.Mascota.Historia=historia;
            familiar.Mascota.Historia.SugerenciaCuidado=listasugerencia;

            var guardarFamiliar = familiar;

            var familiarGuardado= _appContext.FamiliaresAsignados.Add(guardarFamiliar);
            _appContext.SaveChanges();
            return familiarGuardado.Entity;
        }

        void IRepositorioFamiliarDesignado.DeleteFamiliar(int IdFamiliarDesignado)
        { 
            var familiarEncontrado=_appContext.FamiliaresAsignados.FirstOrDefault(p => p.Id == IdFamiliarDesignado);
            if (familiarEncontrado==null)
            return;
            _appContext.FamiliaresAsignados.Remove(familiarEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliarDesignado.GetAllF()
        {
            return _appContext.FamiliaresAsignados;
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.GetFamiliar(int IdFamiliarDesignado)
        {
            var familiarEncontrado =_appContext.FamiliaresAsignados.FirstOrDefault(p=> p.Id == IdFamiliarDesignado);
            return familiarEncontrado;
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.UpdateFamiliar(FamiliarDesignado familiar)
        {
            var familiarEncontrado =_appContext.FamiliaresAsignados.FirstOrDefault(p=> p.Id == familiar.Id);
            if (familiarEncontrado!=null)
            {
                familiarEncontrado.Nombres=familiar.Nombres;
                familiarEncontrado.Apellidos=familiar.Apellidos;
                familiarEncontrado.DocumentoIdentidad=familiar.DocumentoIdentidad;
                _appContext.SaveChanges();
            }
            return familiarEncontrado;
        }

        Mascota IRepositorioFamiliarDesignado.BuscarMascotaId(int IdFaml)
        {
            var Buscarfamiliar=_appContext.FamiliaresAsignados.Find(IdFaml);
            {
                var Encontrado = new Mascota();
                if (Buscarfamiliar != null)
                {
                    Encontrado= Buscarfamiliar.Mascota;
                }
                return Encontrado;
            }   
            
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.GetFamiliarPorCc(string cedula)
        {
            var familiarEncontrado =_appContext.FamiliaresAsignados.Find(cedula);
            return familiarEncontrado;
        }
    }
}