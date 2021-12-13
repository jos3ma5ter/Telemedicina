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
    public class BuscarModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado _repoFamiliar;

        public FamiliarDesignado familiar {get; set;}
        public Mascota mas {get; set;}
        public BuscarModel (IRepositorioFamiliarDesignado repoFamiliar )
        {
            this._repoFamiliar=repoFamiliar;
        }
        public IActionResult OnGet(int id)
        {
            familiar=_repoFamiliar.GetFamiliar(id);
            if (familiar== null)
            {
                mas = new Mascota();
                return Page();
            }
            else
            {
                mas=familiar.Mascota;
                return Page();
            }   
        }  
    }
}
 
 