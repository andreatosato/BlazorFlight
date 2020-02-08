﻿using Blazor.Fluxor;

namespace FlightFinder.Client.Store
{
	public class AppFeature : Feature<AppState>
	{
		public override string GetName() => "App";
		protected override AppState GetInitialState() => new AppState();
	}
}
