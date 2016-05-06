using ProtectionTools.Models.Engines;
using System.Collections.Generic;

namespace ProtectionTools.WebAPI.Services.Engines {
    public interface IEngineService {
        IEnumerable<Engine> GetAll();
        void Add(Engine model);
    }
}