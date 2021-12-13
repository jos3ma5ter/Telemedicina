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
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioHistoria _repoHistoria;
        public Historia historia {get; set;}
        public  AgregarModel (IRepositorioHistoria repoHistoria)
        {
            this._repoHistoria=repoHistoria;
        }
        public void OnGet()
        {
            historia = new Historia();
        }
        public IActionResult OnPost (Historia historia)
        {
            _repoHistoria.AddHistoria(historia);
        
            return RedirectToPage ("ListaHistorias");
        }
    }
}
