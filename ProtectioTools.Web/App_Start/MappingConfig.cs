namespace ProtectionTools.Web {
    using System.Linq;
    using AutoMapper;
    using Core.Buses;
    using Core.Elements.ElectroReceivers;
    using Core.Lines;
    using Models.Tools;

    public static class MappingConfig {
        public static IMapper Mapper { get; private set; }

        static MappingConfig() {
            Mapper =
                new MapperConfiguration(configuration => {
                    configuration.CreateMap<BusViewModel, SimpleBus>();
                    configuration.CreateMap<SimpleBus, BusViewModel>()
                        .ForMember(model => model.Elements,
                            cfg => cfg.MapFrom(src => src.OutConnections.Select(x => x.Element).Cast<ElectroReceiver>()));
                    configuration.CreateMap<ElectroReceiver, ElementViewModel>();
                })
                    .CreateMapper();
        }
    }
}