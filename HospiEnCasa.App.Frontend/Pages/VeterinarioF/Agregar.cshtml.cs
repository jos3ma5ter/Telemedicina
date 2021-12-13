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
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVete;
        public Veterinario veterinario {get; set;}
        public  AgregarModel (IRepositorioVeterinario repoVete)
        {
            this._repoVete=repoVete;
        }
        public void OnGet()
        {
            veterinario= new Veterinario();
        }
        public IActionResult OnPost (Veterinario veterinario)
        {
            _repoVete.AddVeterinario(veterinario);
            return RedirectToPage ("ListaVeterinarios");
        }
    }
}
