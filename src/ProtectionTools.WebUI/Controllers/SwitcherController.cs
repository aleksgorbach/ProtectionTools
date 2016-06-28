namespace ProtectionTools.WebAPI.Controllers {
    using Microsoft.AspNet.Mvc;
    using Models.Buses;
    using Models.FusingTools.Switchers;
    using Services.Buses;

    [Route("api/[controller]")]
    public class SwitcherController : Controller {
        private readonly IBusService _busService;

        public SwitcherController(IBusService busService) {
            _busService = busService;
        }

        [HttpPost]
        public AutomaticSwitcher Switcher([FromBody] Bus bus) {
            var switcher = _busService.GetMatchingSwitcher(bus);
            return switcher;
        }
    }
}