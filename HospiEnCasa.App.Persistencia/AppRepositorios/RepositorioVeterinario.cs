using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
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
        public RepositorioVeterinario (AppContext appContext)
        {
            _appContext=appContext;
        }
        */
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var AgregarVeterinario = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return AgregarVeterinario.Entity;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int IdVeterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == IdVeterinario);
            if(VeterinarioEncontrado==null)
                return;
                _appContext.Veterinarios.Remove(VeterinarioEncontrado);
                _appContext.SaveChanges();
        }

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
        {
            return _appContext.Veterinarios;
        }

        Veterinario IRepositorioVeterinario.GetVeterinario(int IdVeterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p=>p.Id==IdVeterinario);
            return VeterinarioEncontrado;
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinario.Id);
            if (VeterinarioEncontrado!=null)
            {
                VeterinarioEncontrado.Nombres=veterinario.Nombres;
                VeterinarioEncontrado.Apellidos=veterinario.Apellidos;
                VeterinarioEncontrado.DocumentoIdentidad= veterinario.Apellidos;
                VeterinarioEncontrado.TarjetaProfesional=veterinario.TarjetaProfesional;
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        }
    }
}