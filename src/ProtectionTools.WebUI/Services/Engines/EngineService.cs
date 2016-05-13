namespace ProtectionTools.WebAPI.Services.Engines {
    using System.Collections.Generic;
    using Data.Repository;
    using Models.Engines;

    public class EngineService : IEngineService {
        private readonly IRepository<Engine> _engineRepository;

        public EngineService(IRepository<Engine> engineRepository) {
            _engineRepository = engineRepository;
        }

        public IEnumerable<Engine> GetAll() {
            return _engineRepository.GetAll();
        }

        public Engine Add(Engine model) {
            return _engineRepository.Add(model);
        }

        public Engine Delete(int id) {
            return _engineRepository.Remove(id);
        }
    }
}