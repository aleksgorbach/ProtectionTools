namespace ProtectionTools.WebAPI.Controllers {
    using Microsoft.AspNet.Mvc;
    using Models.Engines;
    using Newtonsoft.Json;
    using Services.Engines;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    public class EnginesController : Controller {
        private readonly IEngineService _engineService;

        public EnginesController(IEngineService engineService) {
            _engineService = engineService;
        }

        [HttpGet]
        public IEnumerable<Engine> Get() {
            return _engineService.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] dynamic value) {
            var json = value.ToString();
            var model = JsonConvert.DeserializeObject<Engine>(json);
            _engineService.Add(model);
        }
    }
}