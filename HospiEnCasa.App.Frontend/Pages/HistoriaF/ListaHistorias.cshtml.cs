using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.HistoriaF
{
    public class ListaHistoriasModel : PageModel
    {
        private readonly IRepositorioHistoria _repoHistoria;
        public IEnumerable<Historia> historia {get; set;}
        public  ListaHistoriasModel (IRepositorioHistoria repoHistoria)
        {
            this._repoHistoria=repoHistoria;
        }
        public void OnGet()
        {
            historia = _repoHistoria.GetAllHistorias();
        }
    }
}
