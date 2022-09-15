using System;
using System.Windows;
using System.Windows.Controls;
using Prism.Regions;

namespace Prism7.Core.Regions
{
    public class MyStackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {

        public MyStackPanelRegionAdapter(RegionBehaviorFactory regionBehaviourFactory) : base(regionBehaviourFactory)
        { 

        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    if (e.NewItems == null)
                    {
                        return;
                    }

                    foreach (FrameworkElement item in e.NewItems)
                    {
                        regionTarget.Children.Add(item);
                    }
                }

                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {
                    if (e.OldItems == null)
                    {
                        return;
                    }

                    foreach (FrameworkElement item in e.OldItems)
                    {
                        regionTarget.Children.Remove(item);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new Region();
        }
    }
}
