using OOP_TransportVehicles.TransportClasses;
using System.Collections.Generic;

namespace OOP_TransportVehicles.TransportData
{
    public class GetTransportData
    {
        public static List<TransportBase> GetTransportItemsAccordingUserChoice(List<TransportBase> transports)
        {
            var numberOfCars = ConsoleHelper.GetUserDataInt("Enter quantity of automobiles to display: ");
            var numberOfMotocycles = ConsoleHelper.GetUserDataInt("Enter quantity of motocycles to display: ");
            var numberOfBicycles = ConsoleHelper.GetUserDataInt("Enter quantity of bicycles to display: ");
            for (int i = 0; i < numberOfCars; i++)
            {
                transports.Add(new Automobile());
            }
            for (int i = 0; i < numberOfMotocycles; i++)
            {
                transports.Add(new Motocycle());
            }
            for (int i = 0; i < numberOfBicycles; i++)
            {
                transports.Add(new Bicycle());
            }

                return transports;
        }

        public static List<string> GetTransportItemsData(List<TransportBase> transports)
        {
            var transportsToDisplay = new List<string>();
            foreach (TransportBase transport in transports)
            {
                if (transport.type.Equals("Automobile"))
                {
                    var transportItem = Automobile.AutoDetails((Automobile)transport);
                    transportsToDisplay.Add(transportItem);
                }
                else if (transport.type.Equals("Motobike"))
                {
                    var transportItem = Motocycle.MotoDetails((Motocycle)transport);
                    transportsToDisplay.Add(transportItem);
                }
                else if (transport.type.Equals("Bicycle"))
                {
                    var transportItem = Bicycle.BikeDetails((Bicycle)transport);
                    transportsToDisplay.Add(transportItem);
                }
            }

            return transportsToDisplay;
        }
    }
}