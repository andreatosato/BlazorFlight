using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ChildGreenNameChangedReducer : Reducer<ParentStore, ChildGreenNameChangedAction>
    {
        public override ParentStore Reduce(ParentStore state, ChildGreenNameChangedAction action)
        {
            Console.WriteLine(state.Parent);
            return new ParentStore(state.Parent, new ChildData()
                {
                    Name = action.NewName,
                    Selected = state.ChildGreen.Selected
                }, null);
        }
    }
}
