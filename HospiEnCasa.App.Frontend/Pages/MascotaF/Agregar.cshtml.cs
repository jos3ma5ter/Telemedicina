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
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascotas;
        public Mascota mascota {get; set;}
        public AgregarModel (IRepositorioMascota repoMascota )
        {
            this._repoMascotas=repoMascota;
        }
        public void OnGet()
        {

            mascota = new Mascota();
        }
        public IActionResult OnPost (Mascota mascota)
        {
            _repoMascotas.AddMascota(mascota);
        
            return RedirectToPage ("ListaMascotas");
        }
    }
}

