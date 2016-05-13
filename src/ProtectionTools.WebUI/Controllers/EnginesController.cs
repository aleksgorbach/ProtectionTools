namespace ProtectionTools.WebAPI.Controllers {
    using System.Collections.Generic;
    using Microsoft.AspNet.Mvc;
    using Models.Engines;
    using Newtonsoft.Json;
    using Services.Engines;

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
        public Engine Post([FromBody] dynamic value) {
            var json = value.ToString();
            var model = JsonConvert.DeserializeObject<Engine>(json);
            return _engineService.Add(model);
        }

        [HttpDelete("{id}")]
        public Engine Delete(int id) {
            return _engineService.Delete(id);
        }
    }
}