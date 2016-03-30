namespace ProtectionTools.WebUI.ViewModels {
    using System;
    using System.ComponentModel.DataAnnotations;
    using Core.Elements.ElectroReceivers;

    public class ElementViewModel {
        public Guid Id { get; set; }

        [Display(Name = "Тип соединения")]
        public ConnectionType ConnectionType { get; set; }

        [Display(Name = "Активная мощность")]
        public double ActivePower { get; set; }

        [Display(Name = "Количество")]
        public int Count { get; set; }

        [Display(Name = "Коэффициент использования")]
        public double UsingCoefficient { get; set; }

        [Display(Name = "cos(f)")]
        [Range(0.0, 1.0, ErrorMessage = "Значение должно находиться в интервале [0, 1]")]
        public double Cos { get; set; }

        [Display(Name = "Общая мощность")]
        public double TotalNominalPower { get; set; }

        [Display(Name = "Реактивная нагрузка")]
        public double ReactiveLoad { get; set; }
    }
}