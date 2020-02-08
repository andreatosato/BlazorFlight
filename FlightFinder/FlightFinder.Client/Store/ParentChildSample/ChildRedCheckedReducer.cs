using Blazor.Fluxor;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ChildRedCheckedReducer : Reducer<ParentStore, ChildRedCheckedAction>
    {
        public override ParentStore Reduce(ParentStore state, ChildRedCheckedAction action)
        {
            return new ParentStore(state.Parent, null,
                new ChildData()
            {
                Selected = !state.ChildRed.Selected,
                Name = state.ChildRed.Name
            });
        }
    }
}
