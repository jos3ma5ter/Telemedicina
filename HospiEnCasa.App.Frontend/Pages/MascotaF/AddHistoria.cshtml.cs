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
    public class AddHistoriaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMasco; 
        public Mascota mascota {get; set;}
        public Historia historia {get; set;}
        public AddHistoriaModel (IRepositorioMascota repoMasco)
        {
            this._repoMasco=repoMasco;
        }
        public IActionResult OnGet(int id)
        {
            mascota=_repoMasco.GetMascota(id);
            if(mascota==null)
            {
                return NotFound();
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(int id, Historia historia)
        {
            _repoMasco.AddHistoriaDeMascota(id, historia);
            return RedirectToPage ("ListaMascotas");
        }
    }
}
