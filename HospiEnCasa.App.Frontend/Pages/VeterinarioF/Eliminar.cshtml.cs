using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Frontend.Pages.VeterinarioF
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVete;
        public Veterinario veterinario {get; set;}
        public EliminarModel  (IRepositorioVeterinario repoVete)
        {
            this._repoVete=repoVete;
        }
        public IActionResult OnGet(int id)
        {
            veterinario=_repoVete.GetVeterinario(id);
            if(veterinario==null)
            {
                return NotFound();
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(int id)
        {
            _repoVete.DeleteVeterinario(id);
            return RedirectToPage ("ListaVeterinarios");
        }
    }
}
