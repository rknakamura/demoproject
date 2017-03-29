using Ninject.Modules;
using DemoProject.Business;
using DemoProject.Repository;
using DemoProject.Business.Interface;

namespace DemoProject
{
    public class DependecyModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IHome>().To<Home>();
            this.Bind<IRepo>().To<Repo>();
        }
    }
}