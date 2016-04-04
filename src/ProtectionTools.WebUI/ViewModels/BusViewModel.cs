﻿namespace ProtectionTools.WebUI.ViewModels {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BusViewModel {
        [Display(Name = "Коэффициент мощности")]
        public double PowerCoef { get; set; }

        [Display(Name = "Номинальное напряжение")]
        public double NominalVoltage { get; set; }

        [Display(Name = "Ток")]
        public double Amperage { get; set; }

        [Display(Name = "Элементы")]
        public List<ElementViewModel> Elements { get; set; }
    }
}