using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio; 

namespace HospiEnCasa.App.Frontend.Pages.MascotaF
{
    public class ListaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascotas ;
       
        public IEnumerable<Mascota> mascota{get;set;}

        public ListaMascotasModel (IRepositorioMascota repositorioMascota)
        {
           _repoMascotas=repositorioMascota;
        }
        public void OnGet()
        {
            mascota = _repoMascotas.GetAllMascotas();
        }
    }
}
