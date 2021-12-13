using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;
using Microsoft.AspNetCore.Authorization;


namespace HospiEnCasa.App.Frontend.Pages.VeterinarioF
{
    [Authorize]
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVete;
        public IEnumerable<Veterinario> veterinario {get; set;}
        public   ListaVeterinariosModel  (IRepositorioVeterinario repoVete)
        {
            this._repoVete=repoVete;
        }
        public void OnGet()
        {
           veterinario = _repoVete.GetAllVeterinario();
        }
    }
}
