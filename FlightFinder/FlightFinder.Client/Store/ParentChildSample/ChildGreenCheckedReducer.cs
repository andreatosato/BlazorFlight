using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ChildGreenCheckedReducer : Reducer<ParentStore, ChildGreenCheckedAction>
    {
        public override ParentStore Reduce(ParentStore state, ChildGreenCheckedAction action)
        {
            Console.WriteLine(state.Parent);
            return new ParentStore(state.Parent, new ChildData()
            {
                Selected = !state.ChildGreen.Selected,
                Name = state.ChildGreen.Name
            }, null);
        }
    }
}
