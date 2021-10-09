using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Fonfapres.App.Domain;
using Fonfapres.App.Data;

namespace Fonfapres.App.View.Pages
{
    public class AsociadoModel : PageModel
    {
        //LLamo instancia de Repositorio Asociado
        private static IPartnerRepo _repoPartner= new PartnerRepo(new Data.AppContext());

        public IEnumerable<Partner> partners { get; private set;}
                
        public void OnGet()
        {
            partners = _repoPartner.GetAllPartners();
        }
    }
}
