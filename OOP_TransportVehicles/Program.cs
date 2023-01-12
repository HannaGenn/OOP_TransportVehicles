using OOP_TransportVehicles.TransportData;
using OOP_TransportVehicles.TransportClasses;
using System.Collections.Generic;

namespace OOP_TransportVehicles
{
    public class Program
    {
        static void Main()
        {
            var allTransportItems = new List<TransportBase>();
            GetTransportData.GetTransportItemsAccordingUserChoice(allTransportItems);

            allTransportItems.Sort(0,allTransportItems.Count,new SortTransportByName());
            var itemsToPrint = GetTransportData.GetTransportItemsData(allTransportItems);
            ConsoleHelper.PrintDataOfTransport(itemsToPrint);

            new ConsoleHelper().PrintTransportSearchedByRegularExpressions(allTransportItems);

            new ConsoleHelper().PrintTransportAccordingNameSearch(allTransportItems);

            ConsoleHelper.GetUserDataString("Press Enter to add transport data in file.");
            new FileHelper().WriteTextInFile(itemsToPrint);
        }
    }
}
