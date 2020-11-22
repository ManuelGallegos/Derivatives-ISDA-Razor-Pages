using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derivatives_ISDA_Razor_Pages.Models
{
    public class IsdaRate
    {
        public string Currency { get; set; }
        public string EffectiveAsOf { get; set; }
        public DateTime SnapTime { get; set; }
        public string SpotDate { get; set; }

        public string DepositDayCountConvention { get; set; }

        public string SwapFixedDayCountConvention { get; set; }
        public string SwapFloatingDayCountConvention { get; set; }
        public string SwapFixedPaymentFrequency { get; set; }
        public string SwapFloatingPaymentFrequency { get; set; }

        public List<ParRate> DepositRates { get; set; }
        public List<ParRate> SwapRates { get; set; }
    }
}
