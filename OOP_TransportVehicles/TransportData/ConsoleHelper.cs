using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OOP_TransportVehicles.TransportData
{
    public class ConsoleHelper
    {
        public static void PrintDataOfTransport(List<string> transports)
        {
            foreach (string transport in transports)
            {
                Console.WriteLine(transport);
            }
        }

        public static string GetUserData(string message)
        {
            Console.WriteLine(message);
            var inputItem = Console.ReadLine();

            return inputItem;
        }

        public void PrintTransportAccordingNameSearch(List<TransportBase> transportItems)
        {
            var itemForSearch = GetUserData("Enter name/part of name of the vehicle to display if it presents in the library.");
            var transportAccordingFilter =  transportItems.FindAll(x => x.name.ToLower().Contains(itemForSearch.ToLower()));
            var transportArray = TransportCharacteristics.GetTransportData(transportAccordingFilter);
            PrintDataOfTransport(transportArray);
        }

        public void PrintTransportSearchedByRegularExpressions(List <TransportBase> transportItems)
        {
            var itemForSearch = GetUserData("Enter name/part of name of the vehicle to display if it presents in the library.");
            var regexCase = new Regex(itemForSearch, RegexOptions.IgnoreCase);
            for (int i = 0; i <= transportItems.Count - 1; i++)
            {
                Match match = regexCase.Match(transportItems[i].name);
                if (match.Success)
                {
                    var foundItem = TransportCharacteristics.GetTransportData(new List<TransportBase> { transportItems[i] });
                    PrintDataOfTransport(foundItem);
                }
            }
        }
    }
}
