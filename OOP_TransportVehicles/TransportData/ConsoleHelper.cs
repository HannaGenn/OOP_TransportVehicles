using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OOP_TransportVehicles.TransportData
{
    public class ConsoleHelper
    {
        public static void PrintDataOfTransport(List<string> transports)
        {
            foreach (var transport in transports)
            {
                Console.WriteLine(transport);
            }
        }

        public static string GetUserDataString(string message)
        {
            Console.WriteLine(message);
            var inputItem = Console.ReadLine();

            if (inputItem.All(char.IsLetter))

                return inputItem;
            Console.WriteLine("Please enter text characters!\n");

            return GetUserDataString(message);
        }

        public static int GetUserDataInt(string message)
        {
            Console.WriteLine(message);
            var inputItem = Console.ReadLine();

            bool isNumeric = int.TryParse(inputItem.ToString(), out int number);
            if (isNumeric)

                return number;
            Console.WriteLine("Please enter number!\n");

            return GetUserDataInt(message);
        }

        public void PrintTransportAccordingNameSearch(List<TransportBase> transportItems)
        {
            var itemForSearch = GetUserDataString("Search item using FindAll.\nEnter name/part of name of the vehicle to display if it presents in the library.");
            var transportAccordingFilter =  transportItems.FindAll(x => x.name.ToLower().Contains(itemForSearch.ToLower()));
            var itemsToPrint = GetTransportData.GetTransportItemsData(transportAccordingFilter);
            PrintDataOfTransport(itemsToPrint);
        }

        public void PrintTransportSearchedByRegularExpressions(List <TransportBase> transportItems)
        {
            var itemForSearch = GetUserDataString("Search item using Regular expressions.\nEnter name/part of name of the vehicle to display if it presents in the library.");
            var regexCase = new Regex(itemForSearch, RegexOptions.IgnoreCase);
            for (int i = 0; i <= transportItems.Count - 1; i++)
            {
                Match match = regexCase.Match(transportItems[i].name);
                if (match.Success)
                {
                    var itemToPrint = GetTransportData.GetTransportItemsData(new List<TransportBase> { transportItems[i] });
                    PrintDataOfTransport(itemToPrint);
                }
            }
        }
    }
}
