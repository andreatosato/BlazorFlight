using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightFinder.Client.Store.ParentChildSample
{
    public class ParentStore
    {
        public ParentStore()
        {
            Parent = new ParentData();
            ChildGreen = new ChildData();
            ChildRed = new ChildData();
        }

        public ParentStore(ParentData parentData, ChildData green, ChildData red)
        {
            Parent = parentData;
            if (green != null)
            {
                ChildGreen = green;
                Parent.GreenValue = green.Selected;
            }
            if (red != null)
            {
                ChildRed = red;
                Parent.RedValue = red.Selected;
            }
        }

        public ParentData Parent { get; set; }
        public ChildData ChildGreen { get; set; }
        public ChildData ChildRed { get; set; }
    }

    public class ChildData
    {
        public string Name { get; set; }
        public bool Selected { get; set; }
    }

    public class ParentData
    {
        public int ButtonClicked { get; set; }
        public bool RedValue { get; set; }
        public bool GreenValue { get; set; }
    }
}
