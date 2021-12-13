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
    public class AgregarModel : PageModel
    {
        private readonly IRepositorioSignoVital _repoSigno;
        
        public SignoVital signo {get; set;}

        public AgregarModel (IRepositorioSignoVital repoSigno)
        {
            this._repoSigno=repoSigno;
        }
        public void OnGet()
        {
            signo= new SignoVital();
        }
        public IActionResult OnPost (int idMas, SignoVital signo)
        {
            _repoSigno.AddSignoVital(signo);
            return RedirectToPage ("ListaSignosVitales");
        }
    }
}
