using Blazor.Fluxor;
using FlightFinder.Shared;
using System.Collections.Generic;

namespace FlightFinder.Client.Store
{
	public class SearchReducer : Reducer<AppState, SearchAction>
	{
		public override AppState Reduce(AppState state, SearchAction action)
		{
			return new AppState(
				searchInProgress: true,
				searchResults: new List<Itinerary>(),
				shortlist: state.Shortlist,
				airports: state.Airports);
		}
	}
}
