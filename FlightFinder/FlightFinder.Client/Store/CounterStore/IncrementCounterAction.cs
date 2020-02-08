using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.Counter
{
    public class IncrementCounterAction
    {
        // Call API, Storage, CloudServices
        public void SetPreviousState(int previousStateValue)
        {
            int latestState = previousStateValue;
        }
    }
}
