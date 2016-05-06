using ProtectionTools.Data.Repository;
using ProtectionTools.Models.Engines;
using System.Collections.Generic;

namespace ProtectionTools.WebAPI.Services.Engines {
    public class EngineService : IEngineService {
        private readonly IRepository<Engine> _engineRepository;

        public EngineService(IRepository<Engine> engineRepository) {
            _engineRepository = engineRepository;
        }

        public IEnumerable<Engine> GetAll() {
            return _engineRepository.GetAll();
        }

        public void Add(Engine model) {
            _engineRepository.Add(model);
        }
    }
}