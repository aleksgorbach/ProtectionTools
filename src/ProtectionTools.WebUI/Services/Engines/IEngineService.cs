namespace ProtectionTools.WebAPI.Services.Engines {
    using System.Collections.Generic;
    using Models.Engines;

    public interface IEngineService {
        IEnumerable<Engine> GetAll();
        Engine Add(Engine model);
        Engine Delete(int id);
    }
}