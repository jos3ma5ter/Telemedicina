using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
namespace HospiEnCasa.App.Frontend.Pages.MascotaF
{
    public class BuscarModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascotas;

        public Mascota mascota{get; set;}

        public BuscarModel (IRepositorioMascota repoMascota )
        {
            this._repoMascotas=repoMascota;
        }
        public IActionResult OnGet(int id)
        {
                mascota =_repoMascotas.GetMascota(id);
                return Page ();
        }    
    }
}


