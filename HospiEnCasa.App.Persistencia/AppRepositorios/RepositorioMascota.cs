using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
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
        public RepositorioMascota (AppContext appContext)
        {
            _appContext=appContext;
        }
        */
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }

        void IRepositorioMascota.DeleteMascota(int IdMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == IdMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        Mascota IRepositorioMascota.GetMascota(int IdMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == IdMascota);
            return mascotaEncontrado;
        }

        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.EstadoSalud = mascota.EstadoSalud;
                mascotaEncontrado.Edad = mascota.Edad;
                mascotaEncontrado.Genero = mascota.Genero;
                mascotaEncontrado.Raza = mascota.Raza;
                mascotaEncontrado.Direccion = mascota.Direccion;
                mascotaEncontrado.Ciudad = mascota.Ciudad;
                mascotaEncontrado.Latitud = mascota.Latitud;
                mascotaEncontrado.Longitud = mascota.Longitud;
                mascotaEncontrado.TipoMascota = mascota.TipoMascota;
                mascotaEncontrado.SignoVital = mascota.SignoVital;
                mascotaEncontrado.Historia = mascota.Historia;
                _appContext.SaveChanges();

            }

            return mascotaEncontrado;
        }
        void IRepositorioMascota.AddSignoVitalLista(int idM, SignoVital signoV)
        {
            var mascota = _appContext.Mascotas.Find(idM);
            if (mascota != null)
            { 
                if (mascota.SignoVital != null)
                {
                    mascota.SignoVital.Add(signoV);
                }
                else
                {
                    mascota.SignoVital = new List<SignoVital>();
                    mascota.SignoVital.Add(signoV);
                }
                _appContext.SaveChanges();
            }      
        }
        void IRepositorioMascota.AddHistoriaDeMascota(int idM, Historia historia)
        {
            var mascota = _appContext.Mascotas.Find(idM);
            if (mascota != null)
            { 
                if (mascota.Historia != null)
                {
                    mascota.Historia = historia;
                }
                else
                {
                    mascota.Historia=new Historia();
                    mascota.Historia = historia;
                }
                _appContext.SaveChanges();
            }

        }
    }
}