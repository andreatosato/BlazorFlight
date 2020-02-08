using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.Counter
{
    public class FeatureCounterState : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState()
        {
            return new CounterState(0);
        }
        public override void ReceiveDispatchNotificationFromStore(object action)
        {
            base.ReceiveDispatchNotificationFromStore(action);
        }
    }
}
