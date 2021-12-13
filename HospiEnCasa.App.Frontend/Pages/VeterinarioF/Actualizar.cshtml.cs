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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVete;
        public Veterinario veterinario {get; set;}
        public  ActualizarModel (IRepositorioVeterinario repoVete)
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
        public IActionResult OnPost(Veterinario veterinario)
        {
            _repoVete.UpdateVeterinario(veterinario);
            return RedirectToPage ("ListaVeterinarios");
        }
    
    }
}
