using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Derivatives_ISDA_Razor_Pages.Models;

namespace Derivatives_ISDA_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Isda IsdaModel { get; set; } = new Isda();

        public void OnGet()
        {
            IsdaModel.Currency = "USD";
            IsdaModel.Date = "20200511";
            IsdaModel.IsdaRate = IsdaClass.GetIsdaRates(IsdaModel.Currency, IsdaModel.Date);
        }

        public void OnPost()
        {
            IsdaModel.IsdaRate = IsdaClass.GetIsdaRates(IsdaModel.Currency, IsdaModel.Date);
        }
    }

    public class Isda
    {
        public string Currency { get; set; }
        public string Date { get; set; }
        public IsdaRate IsdaRate { get; set; }
    }
}
