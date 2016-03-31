namespace ProtectionTools.WebUI.Controllers {
    using System.Linq;
    using AutoMapper;
    using Core.Elements.ElectroReceivers;
    using Microsoft.AspNet.Mvc;
    using Services;
    using ViewModels;

    public class AppController : Controller {
        private readonly IBusService _busService;
        private readonly IMapper _mapper;

        public AppController(IBusService busService, IMapper mapper) {
            _busService = busService;
            _mapper = mapper;
        }

        public IActionResult Index() {
            return View(new BusViewModel());
        }

        [HttpPost]
        public IActionResult Index(BusViewModel model) {
            if (!ModelState.IsValid) {
                ModelState.AddModelError("", "Please enter correct data");
                return View(model);
            }
            model.Amperage = _busService.GetCurrent(model.PowerCoef, model.NominalVoltage,
                model.Elements.Select(elem => _mapper.Map<ElectroReceiver>(elem)));
            return View(model);
        }
    }
}