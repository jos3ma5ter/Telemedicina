using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio; 
using Microsoft.AspNetCore.Authorization;


namespace HospiEnCasa.App.Frontend.Pages.FamiliarF
{
    [Authorize]
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado _repoFamiliar;
        public FamiliarDesignado familiar {get; set;}
        public Mascota mascota{get; set;}
        public Historia historia{get; set;}

        public AgregarModel (IRepositorioFamiliarDesignado repoFamiliar)
        {
            this._repoFamiliar=repoFamiliar;
        }
        public void OnGet()
        {   
            mascota=new Mascota();
            familiar = new FamiliarDesignado();
            historia = new Historia();
 
        }
        public IActionResult OnPost (FamiliarDesignado familiar, Mascota mascota, Historia historia)
        {   
            var fami=_repoFamiliar.AddFamiliar(familiar,mascota,historia);
            return RedirectToPage ("ListaFamiliares");
            
        }
    }
    
}
