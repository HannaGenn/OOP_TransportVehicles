using OOP_TransportVehicles.TransportData;
using OOP_TransportVehicles.TransportClasses;
using System.Collections.Generic;
using System;

namespace OOP_TransportVehicles
{
    public class Program
    {
        static void Main()
        {
            var allTransportItems = new List<TransportBase>();
            TransportCharacteristics.GetTransportDataAccordingUserChoice(allTransportItems);

            allTransportItems.Sort(0,allTransportItems.Count,new SortTransportByName());
            var transportObjectsToDisplay = TransportCharacteristics.GetTransportData(allTransportItems);
            ConsoleHelper.PrintDataOfTransport(transportObjectsToDisplay);

            new ConsoleHelper().PrintTransportSearchedByRegularExpressions(allTransportItems);

            new ConsoleHelper().PrintTransportAccordingNameSearch(allTransportItems);

            ConsoleHelper.GetUserDataString("Press Enter to add transport data in file.");
            new FileHelper().WriteTextInFile(transportObjectsToDisplay);
        }
    }
}
