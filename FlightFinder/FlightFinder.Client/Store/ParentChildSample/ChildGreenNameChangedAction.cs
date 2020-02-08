using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ChildGreenNameChangedAction
    {
        public string NewName { get; set; }

        public ChildGreenNameChangedAction(string newName)
        {
            NewName = newName;
        }
    }
}
