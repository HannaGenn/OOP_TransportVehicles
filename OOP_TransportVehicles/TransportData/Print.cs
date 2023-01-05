using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;

namespace OOP_TransportVehicles.TransportData
{
    public class Print
    {
        public static void TransportData(List<string> transports)
        {
            foreach (string transport in transports)
            {
                Console.WriteLine(transport);
            }
        }

        public List<TransportBase> TransportByEnteredCharacters(List<TransportBase> transportItems)
        {
            Console.WriteLine("Enter name/part of name of the vehicle to display if it presents in the library.");
            var itemForSearch = Console.ReadLine();
            return transportItems.FindAll(x => x.name.Contains(itemForSearch));
        }
    }
}
