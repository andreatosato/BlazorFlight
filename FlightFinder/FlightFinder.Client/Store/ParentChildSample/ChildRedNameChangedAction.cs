using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ChildRedNameChangedAction
    {
        public string NewName { get; set; }

        public ChildRedNameChangedAction(string newName)
        {
            NewName = newName;
        }
    }
}
