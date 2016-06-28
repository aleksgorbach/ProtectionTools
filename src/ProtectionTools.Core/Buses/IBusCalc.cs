namespace ProtectionTools.Core.Buses {
    using Models.Buses;
    using Models.FusingTools.Fuses;
    using Models.FusingTools.Switchers;

    public interface IBusCalc {
        double GetAmperage(Bus bus);
        Fuse GetMatchingFuse(Bus bus);
        AutomaticSwitcher GetMatchingSwitcher(Bus bus);
    }
}