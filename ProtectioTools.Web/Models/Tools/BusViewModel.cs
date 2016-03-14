namespace ProtectionTools.Web.Models.Tools {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BusViewModel {
        public bool HasResult { get; set; }

        [Display(Name = "Коэффициент мощности")]
        public double PowerCoef { get; set; }

        [Display(Name = "Номинальное напряжение")]
        public double NominalVoltage { get; set; }

        [Display(Name = "Ток")]
        public double Amperage { get; set; }

        [Display(Name = "Элементы")]
        public List<ElementViewModel> Elements { get; set; }

        public BusViewModel() {
            Elements = new List<ElementViewModel>();
            PowerCoef = 1;
            NominalVoltage = 220;
        }
    }
}