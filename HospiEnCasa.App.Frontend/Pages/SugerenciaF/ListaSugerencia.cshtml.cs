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
    public class ListaSugerenciaModel : PageModel
    {
        private readonly IRepositorioSugerenciaCuidado _repoSugerencia;
        public IEnumerable<SugerenciaCuidado> sugerencia {get; set;}
        public  ListaSugerenciaModel  (IRepositorioSugerenciaCuidado repoSugerencia)
        {
            this._repoSugerencia=repoSugerencia;
        }
        public void OnGet()
        {
            sugerencia = _repoSugerencia.GetAllSugerenciaCuidado();
        }
    }
}
