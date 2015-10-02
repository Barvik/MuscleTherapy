using StructureMap;
using StructureMap.Graph;

namespace MucleTherapyMVC.Common.Infrastructure
{
    public static class StructureMapBootstrapper
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Configure(x => x.Scan(scan =>
            {
                scan.LookForRegistries();
                scan.TheCallingAssembly();
                scan.AssembliesFromApplicationBaseDirectory(y => y.FullName.StartsWith("MuscleTherapy"));
                scan.WithDefaultConventions();
            }
                ));
            return ObjectFactory.Container;
        }
    }
}
