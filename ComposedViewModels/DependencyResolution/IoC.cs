using ComposedViewModels.Models;
using ComposedViewModels.ViewModels.Fields;
using StructureMap;
using StructureMap.Pipeline;

namespace ComposedViewModels {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.AddAllTypesOf<IPageField>();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<Person>().LifecycleIs(new HttpSessionLifecycle()).Use(ctx=>new Person());            
                        });
            return ObjectFactory.Container;
        }
    }
}