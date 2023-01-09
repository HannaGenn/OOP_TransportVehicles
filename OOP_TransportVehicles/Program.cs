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
            var allTransportItems = new List<TransportBase>();
            TransportCharacteristics.GetTransportDataAccordingUserChoice(allTransportItems);

            allTransportItems.Sort(0,allTransportItems.Count,new SortTransportByName());
            var transportObjectsToDisplay = TransportCharacteristics.GetTransportData(allTransportItems);
            ConsoleHelper.PrintDataOfTransport(transportObjectsToDisplay);

            ConsoleHelper.GetUserData("Press Enter to search item using Regular expressions.");
            new ConsoleHelper().PrintTransportSearchedByRegularExpressions(allTransportItems);

            ConsoleHelper.GetUserData("Press Enter to search item using FindAll");
            new ConsoleHelper().PrintTransportAccordingNameSearch(allTransportItems);

            ConsoleHelper.GetUserData("Press Enter to add transport data in file.");
            new FileHelper().WriteTextInFile(transportObjectsToDisplay);

        }
    }
}
