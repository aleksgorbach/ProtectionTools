namespace ProtectionTools.Web.Dependencies {
    using AutoMapper;
    using Consts;
    using Core.Buses;
    using Core.Elements.Connections.Factory;
    using Core.Lines.Factories;
    using Ninject;

    public class ToolsDependencies {
        public static void Register(IKernel kernel) {
            kernel.Bind<IConnectionFactory>().To<ConnectionFactory>();
            kernel.Bind<ILineFactory>().To<LineFactory>();

            kernel.Bind<IMapper>().ToConstant(MappingConfig.Mapper);
            kernel.Bind<SimpleBus>().ToSelf().InSingletonScope();
            kernel.Bind<int>().ToConstant(ToolsConsts.MaxOutputsCount).WhenInjectedInto<SimpleBus>();
        }
    }
}