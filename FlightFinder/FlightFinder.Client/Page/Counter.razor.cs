using Blazor.Fluxor;
using FlightFinder.Client.Store.Counter;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Page
{
    public partial class Counter
    {
        [Inject]
        public IState<CounterState> State { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        void IncrementCount()
        {
            Console.WriteLine($"Current count: {State.Value.CurrentCounter}");
            Dispatcher.Dispatch(new IncrementCounterAction());
        }
    }
}
