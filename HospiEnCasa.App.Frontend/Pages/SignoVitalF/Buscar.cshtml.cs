using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.SignoVitalF
{
    public class BuscarModel : PageModel
    {
        private readonly IRepositorioSignoVital _repoSigno;

        public SignoVital signo {get; set;}

        public BuscarModel (IRepositorioSignoVital repoSigno )
        {
            this._repoSigno=repoSigno;
        }
        public void OnGet(int id)
        {
            signo =_repoSigno.GetSignoVital(id);
        }
    
    }
}
