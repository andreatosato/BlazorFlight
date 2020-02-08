using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ChildGreenNameChangedReducer : Reducer<ParentStore, ChildRedNameChangedAction>
    {
        public override ParentStore Reduce(ParentStore state, ChildRedNameChangedAction action)
        {
            return new ParentStore(state.Parent, new ChildData()
                {
                    Name = action.NewName,
                    Selected = state.ChildGreen.Selected
                }, null);
        }
    }
}
