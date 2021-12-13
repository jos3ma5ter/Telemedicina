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
    public class AddSugerenciaListaModel : PageModel
    {
        private readonly IRepositorioHistoria _repoHistoria; 
        public Historia historia {get; set;}
        public SugerenciaCuidado sugerencia {get; set;}
        public AddSugerenciaListaModel (IRepositorioHistoria repoHistoria)
        {
            this._repoHistoria=repoHistoria;
        }
        public IActionResult OnGet(int id)
        {
            historia=_repoHistoria.GetHistoria(id);
            if(historia==null)
            {
                return NotFound();
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(int id, SugerenciaCuidado sugerencia)
        {
            _repoHistoria.AddSugerenciaHistoria(id, sugerencia);
            return RedirectToPage ("ListaHistorias");
        }
    }
}
