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
    public class AddSignoVModel : PageModel
    {
        private readonly IRepositorioMascota _repoMasco; 
        public Mascota mascota {get; set;}
        public SignoVital signo {get; set;}
        public AddSignoVModel (IRepositorioMascota repoMasco)
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
        public IActionResult OnPost(int id, SignoVital signo)
        {
            _repoMasco.AddSignoVitalLista(id, signo);
            return RedirectToPage ("ListaMascotas");
        }
    }
}
