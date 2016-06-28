namespace ProtectionTools.WebAPI.Controllers {
    using Microsoft.AspNet.Mvc;
    using Models.Buses;
    using Models.FusingTools.Fuses;
    using Services.Buses;

    [Route("api/[controller]")]
    public class BusController : Controller {
        private readonly IBusService _busService;

        public BusController(IBusService busService) {
            _busService = busService;
        }

        [HttpPost]
        public double Amperage([FromBody] Bus bus) {
            var amperage = _busService.GetAmperage(bus);
            return amperage;
        }

        [HttpPost]
        public Fuse Fuse([FromBody] Bus bus) {
            var fuse = _busService.GetMatchingFuse(bus);
            return fuse;
        }
    }
}