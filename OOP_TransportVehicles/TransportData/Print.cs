using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        public void TransportAccordingNameSearch(List<TransportBase> transportItems)
        {
            Console.WriteLine("Enter name/part of name of the vehicle to display if it presents in the library.");
            var itemForSearch = Console.ReadLine();
            var transportAccordingFilter =  transportItems.FindAll(x => x.name.Contains(itemForSearch));
            var transportArray = TransportCharacteristics.GetTransportData(transportAccordingFilter);
            TransportData(transportArray);
        }

        public void TransportSearchByRegularExpressions(List <TransportBase> transportItems)
        {
            Console.WriteLine("Enter name/part of name of the vehicle to display if it presents in the library.");
            var itemForSearch = Console.ReadLine();
            var regexCase = new Regex(itemForSearch, RegexOptions.IgnoreCase);
            for (int i = 0; i <= transportItems.Count - 1; i++)
            {
                Match match = regexCase.Match(transportItems[i].name);
                if (match.Success)
                {
                    var foundItem = TransportCharacteristics.GetTransportData(transportItems[i]);
                    TransportData(foundItem);
                }
            }
        }
    }
}
