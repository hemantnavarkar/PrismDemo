using System;
using Prism.Ioc;
using Prism.Modularity;

namespace Prism7.ModuleA
{
    public class ModuleA : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            Console.WriteLine("In Initilased");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Console.WriteLine("In RegisterTypes");
        }
    }

}
