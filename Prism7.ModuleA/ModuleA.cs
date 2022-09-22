using System;
using System.Windows.Controls;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism7.ModuleA.Views;

namespace Prism7.ModuleA
{
    public class ModuleA : IModule
    {
        private readonly IRegionManager _regionManager;
        public ModuleA(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // this._regionManager.RegisterViewWithRegion("ContentRegion",typeof(ViewA));

            IRegion region = _regionManager.Regions["ContentRegion"];
            var view = containerProvider.Resolve<ViewA>();
            region.Add(view);


             
            var view2 = containerProvider.Resolve<ViewA>();
            view2.Content = new TextBlock()
            {
                Text = "Hemant View2",
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                FontSize = 45
            };
            region.Add(view2);
            region.Activate(view2);
            Console.WriteLine("In Initilased");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Console.WriteLine("In RegisterTypes");
        }
    }

}
