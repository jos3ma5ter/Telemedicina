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
    public class BuscarModel : PageModel
    {
        private readonly IRepositorioHistoria _repoHistoria;
        public Historia historia {get; set;}
        public  BuscarModel (IRepositorioHistoria repoHistoria)
        {
            this._repoHistoria=repoHistoria;
        }
        public IActionResult OnGet(int id)
        {
                historia =_repoHistoria.GetHistoria(id);
                return Page ();
        } 
    }
}
