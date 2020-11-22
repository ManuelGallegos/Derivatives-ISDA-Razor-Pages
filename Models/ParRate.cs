using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derivatives_ISDA_Razor_Pages.Models
{
    public class ParRate
    {
        public string Tenor { get; set; }
        public string Rate { get; set; }
        public string Maturity { get; set; }
    }
}
