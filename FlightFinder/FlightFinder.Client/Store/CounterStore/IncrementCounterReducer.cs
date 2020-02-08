using Blazor.Fluxor;

namespace FlightFinder.Client.Store.Counter
{
    public class IncrementCounterReducer : Reducer<CounterState, IncrementCounterAction>
    {
        public override CounterState Reduce(CounterState state, IncrementCounterAction action)
        {
            // If you must execute logic, call action!
            action.SetPreviousState(state.CurrentCounter);


            int previeusState = state.CurrentCounter;
            int nextState = previeusState + 1;
            return new CounterState(nextState);
        }
    }
}
