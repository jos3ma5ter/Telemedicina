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
    public class ListaSignosVitalesModel : PageModel
    {
        private readonly IRepositorioSignoVital _repoSigno;

        public IEnumerable<SignoVital> signo { get; set; }

        public ListaSignosVitalesModel(IRepositorioSignoVital repoSigno)
        {
            this._repoSigno = repoSigno;
        }
        public void OnGet()
        {
            signo = _repoSigno.GetAllSignoVital();
        }

    }
}
