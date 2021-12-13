using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.SugerenciaF
{
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioSugerenciaCuidado _repoSugerencia;
        public SugerenciaCuidado sugerencia {get; set;}
        public  AgregarModel (IRepositorioSugerenciaCuidado repoSugerencia)
        {
            this._repoSugerencia=repoSugerencia;
        }
        public void OnGet()
        {
            sugerencia= new SugerenciaCuidado();
        }
        public IActionResult OnPost (SugerenciaCuidado sugerencia)
        {
            _repoSugerencia.AddSugerenciaCuidado(sugerencia);
            return RedirectToPage ("ListaSugerencia");
        }
    }
}
