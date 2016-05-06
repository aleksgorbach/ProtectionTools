namespace ProtectionTools.WebAPI.Controllers {
    using Microsoft.AspNet.Mvc;
    using Models.Buses;
    using Newtonsoft.Json;
    using Services.Buses;

    [Route("api/[controller]")]
    public class BusController : Controller {
        private readonly IBusService _busService;

        public BusController(IBusService busService) {
            _busService = busService;
        }

        [HttpPost]
        public double Amperage([FromBody] dynamic json) {
            string str = json.ToString();
            var bus = JsonConvert.DeserializeObject<Bus>(str);
            var amperage = _busService.GetAmperage(bus);
            return amperage;
        }
    }
}