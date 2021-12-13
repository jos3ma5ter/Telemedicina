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
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascotas;
        public Mascota mascota {get; set;}
        public EliminarModel (IRepositorioMascota repoMascota)
        {
            this._repoMascotas=repoMascota;
        }
        public IActionResult OnGet(int id)
        {
            mascota=_repoMascotas.GetMascota(id);
            if(mascota==null)
            {
                return NotFound();
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(int id)
        {
            _repoMascotas.DeleteMascota(id);
            return RedirectToPage ("ListaMascotas");
        }
    }
}
