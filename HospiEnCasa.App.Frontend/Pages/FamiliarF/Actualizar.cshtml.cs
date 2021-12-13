using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio; 


namespace HospiEnCasa.App.Frontend.Pages.FamiliarF
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado _repoFamiliar;

        public FamiliarDesignado familiar {get; set;}

        public  ActualizarModel (IRepositorioFamiliarDesignado repoFamiliar)
        {
            this._repoFamiliar=repoFamiliar;
        }
        public IActionResult OnGet(int id)
        {
            familiar=_repoFamiliar.GetFamiliar(id);
            if(familiar==null)
            {
                return NotFound();
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(FamiliarDesignado familiar )
        {
            _repoFamiliar.UpdateFamiliar(familiar);
            return RedirectToPage ("ListaFamiliares");
        }
    }
}
