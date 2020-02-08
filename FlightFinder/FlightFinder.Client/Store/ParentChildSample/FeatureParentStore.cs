using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class FeatureParentStore : Feature<ParentStore>
    {
        public override string GetName() => nameof(ParentStore);

        protected override ParentStore GetInitialState()
        {
            var parentStore = new ParentStore();
            parentStore.Parent.ButtonClicked = 100;
            return parentStore;
        }
    }
}
