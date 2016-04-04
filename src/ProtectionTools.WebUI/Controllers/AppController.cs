namespace ProtectionTools.WebUI.Controllers {
    using System.Collections.Generic;
    using System.Linq;
    using Core.Elements.Connections.Factory;
    using Core.Elements.ElectroReceivers;
    using Microsoft.AspNet.Mvc;
    using Services;
    using ViewModels;

    public class AppController : Controller {
        private readonly IBusService _busService;
        private readonly IConnectionFactory _connectionFactory;

        public AppController(IBusService busService, IConnectionFactory connectionFactory) {
            _busService = busService;
            _connectionFactory = connectionFactory;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Calc([FromBody] BusViewModel model) {
            if (!ModelState.IsValid) {
                ModelState.AddModelError("", "Please enter correct data");
                return View(model);
            }
            model.Amperage = _busService.GetCurrent(model.PowerCoef, model.NominalVoltage,
                model.Elements.Select(
                    elem =>
                        new ElectroReceiver(
                            _connectionFactory,
                            elem.ActivePower,
                            elem.Count,
                            elem.UsingCoefficient,
                            elem.Cos)));
            return Json(model);
        }

        public IActionResult Add([FromBody] List<ElementViewModel> model) {
            model.Add(new ElementViewModel());
            return Json(model);
        }
    }
}