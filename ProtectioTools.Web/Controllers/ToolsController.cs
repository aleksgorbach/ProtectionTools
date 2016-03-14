namespace ProtectionTools.Web.Controllers {
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper;
    using Core.Buses;
    using Core.Elements.Connections.Factory;
    using Core.Elements.ElectroReceivers;
    using Models.Tools;

    public class ToolsController : Controller {
        private readonly IConnectionFactory _connectionFactory;
        private readonly IMapper _mapper;
        private readonly SimpleBus _bus;

        public ToolsController(IConnectionFactory connectionFactory, IMapper mapper, SimpleBus bus) {
            _connectionFactory = connectionFactory;
            _mapper = mapper;
            _bus = bus;
        }

        public ActionResult Bus() {
            var model = _mapper.Map<BusViewModel>(_bus);
            return View(model);
        }

        [HttpPost]
        public ActionResult Bus(BusViewModel model) {
            if (!ModelState.IsValid) {
                ViewBag["error"] = "error";
                model.HasResult = false;
                return View(model);
            }
            _bus.NominalVoltage = model.NominalVoltage;
            _bus.PowerCoef = model.PowerCoef;
            model.HasResult = true;
            model.Amperage = _bus.Amperage;
            return View(model);
        }

        public ActionResult AddConnection(string type, double activePower, int count, double usingCoefficient,
            double cos) {
            var connectionType = (ConnectionType) Enum.Parse(typeof (ConnectionType), type);
            _bus.ConnectOutput(new ElectroReceiver(_connectionFactory, connectionType, activePower, count,
                usingCoefficient, cos));
            return ConnectionList();
        }

        public ActionResult RemoveConnection(Guid elementId) {
            var elemToRemove =
                _bus.OutConnections.FirstOrDefault(x => ((IElectroReceiver) x.Element).Id == elementId);
            _bus.OutConnections.Remove(elemToRemove);
            return ConnectionList();
        }

        private ActionResult ConnectionList() {
            var model = _mapper.Map<BusViewModel>(_bus);
            return PartialView("_ConnectionList", model.Elements);
        }
    }
}