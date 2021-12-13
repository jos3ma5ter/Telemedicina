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
    public class ListaFamiliaresModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado  _repoFamiliar ;
       
        public IEnumerable<FamiliarDesignado> familiares{get;set;}

        public ListaFamiliaresModel (IRepositorioFamiliarDesignado repoFamiliar)
        {
           this._repoFamiliar=repoFamiliar;
        }
        public void OnGet()
        {
            familiares = _repoFamiliar.GetAllF();
        }
    }
}
