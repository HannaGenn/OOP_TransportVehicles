using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;

namespace OOP_TransportVehicles.TransportData
{
    public class Print
    {
        public static void TransportData(List<TransportBase> transports)
        {
            foreach (TransportBase transport in transports)
            {
                if (transport.GetType().ToString().Contains("Automobile"))
                {
                    Console.WriteLine(TransportCharacteristics.AutoDetails((Automobile)transport));
                }
                else if (transport.GetType().ToString().Contains("Motocycle"))
                {
                    Console.WriteLine(TransportCharacteristics.MotoDetails((Motocycle)transport));
                }
                else
                {
                    Console.WriteLine(TransportCharacteristics.BikeDetails((Bicycle)transport));
                }
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
