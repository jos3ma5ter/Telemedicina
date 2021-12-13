using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages.FamiliarF
{
    public class AdminModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado _repoFamiliar;

        public FamiliarDesignado familiar {get;set;}

        public Mascota masco {get;set;}

        public AdminModel (IRepositorioFamiliarDesignado repoFamiliar)
        {
            this._repoFamiliar=repoFamiliar;
        }
        public void OnGet(int id)
        {
            familiar=_repoFamiliar.GetFamiliar(id);
            masco=familiar.Mascota;
           
        }
    }
}

