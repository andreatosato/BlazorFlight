using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.Counter
{
    public class CounterState
    {
        public int CurrentCounter { get; }
        public CounterState(int clickCounter)
        {
            CurrentCounter = clickCounter;
        }
    }
}
