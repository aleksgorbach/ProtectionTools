namespace ProtectionTools.WebUI.ViewModels {
    using System.ComponentModel.DataAnnotations;

    public class ElementViewModel {
        [Display(Name = "Активная мощность")]
        public double ActivePower { get; set; }

        [Display(Name = "Количество")]
        public int Count { get; set; }

        [Display(Name = "Коэффициент использования")]
        public double UsingCoefficient { get; set; }

        [Display(Name = "cos(f)")]
        public double Cos { get; set; }
    }
}