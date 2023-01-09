using OOP_TransportVehicles.TransportClasses;
using System.Collections;
using System.Collections.Generic;

namespace OOP_TransportVehicles.TransportData
{
    public class SortTransportByName : IComparer <TransportBase>
    {
        public int Compare(TransportBase o1,TransportBase o2)
        {
            return o1.name.CompareTo(o2.name);
        }
    }
}
