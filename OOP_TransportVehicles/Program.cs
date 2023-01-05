using OOP_TransportVehicles.TransportData;
using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;

namespace OOP_TransportVehicles
{
    public class Program
    {
        static void Main()
        {
            var auto = new Automobile();
            var moto = new Motocycle();
            var bike = new Bicycle();
            var allTransportItems = new List<TransportBase>();

            for(int i = 1; i <= 1; i++)
            {
                TransportCharacteristics.GetNameForAuto(auto);
                allTransportItems.Add(auto);
                TransportCharacteristics.GetNameForBike(bike);
                allTransportItems.Add(bike);
                TransportCharacteristics.GetNameForMoto(moto);
                allTransportItems.Add(moto);
            }

            allTransportItems.Sort(new SortTransportByName());
            Print.TransportData(allTransportItems);

            var printItem = new Print();
            var searchResults = printItem.TransportByEnteredCharacters(allTransportItems);
            Print.TransportData(searchResults);

            Console.WriteLine("Press Enter to add transport data in file.");
            Console.ReadLine();
            var getFile = new FileHelper();
            getFile.WriteTextInFile(allTransportItems);
        }
    }
}
