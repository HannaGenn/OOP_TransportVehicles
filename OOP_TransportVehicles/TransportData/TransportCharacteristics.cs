using OOP_TransportVehicles.TransportClasses;
using System.Collections.Generic;

namespace OOP_TransportVehicles.TransportData
{
    public class TransportCharacteristics
    {
        public static Automobile GetNameForAuto(Automobile autoItem)
        {
            autoItem.name = ConsoleHelper.GetUserDataString("Enter automobile name: ");

            return autoItem;
        }

        public static Motocycle GetNameForMoto(Motocycle motoItem)
        {
            motoItem.name = ConsoleHelper.GetUserDataString("Enter motocycle name: ");

            return motoItem;
        }

        public static Bicycle GetNameForBike(Bicycle bikeItem)
        {
            bikeItem.name = ConsoleHelper.GetUserDataString("Enter bicycle name: ");

            return bikeItem;
        }

        public static string TransportBasicDetails(TransportBase transport)
        {
            var basicDetails = $"\nName: " + transport.name + "\nAverage speed: " + transport.averageSpeed + "\nMax speed: " +
            transport.maxSpeed+ "\nQuantity of wheels: " + transport.wheels+ "\nType of transport:" + transport.type;

            return basicDetails;
        }

        public static string AutoDetails(Automobile transport)
        {
            var basicDetails = TransportBasicDetails(transport);
            var autoDetails = basicDetails + "\nAvailability of autogearbox: " + transport.hasAutomaticGearBox + "\n";

            return autoDetails;
        }

        public static string MotoDetails(Motocycle transport)
        {
            var basicDetails = TransportBasicDetails(transport);
            var motoDetails = basicDetails + "\nAvailability of boot: " + transport.hasMotorbikeBoot + "\n";

            return motoDetails;
        }

        public static string BikeDetails(Bicycle transport)
        {
            var basicDetails = TransportBasicDetails(transport);
            var bikeDetails = basicDetails + "\nAvailability of bell: " + transport.hasBell + "\n";

            return bikeDetails;
        }

        public static List<TransportBase> GetTransportDataAccordingUserChoice(List<TransportBase> transports)
        {
            var numberOfCars = ConsoleHelper.GetUserDataInt("Enter quantity of automobiles to display: ");
            var numberOfMotocycles = ConsoleHelper.GetUserDataInt("Enter quantity of motocycles to display: ");
            var numberOfBicycles = ConsoleHelper.GetUserDataInt("Enter quantity of bicycles to display: ");
            for (int i = 0; i < numberOfCars; i++)
            {
                transports.Add(GetNameForAuto(new Automobile()));
            }
            for (int i = 0; i < numberOfMotocycles; i++)
            {
                transports.Add(GetNameForMoto(new Motocycle()));
            }
            for (int i = 0; i < numberOfBicycles; i++)
            {
                transports.Add(GetNameForBike(new Bicycle()));
            }

                return transports;
        }

        public static List<string> GetTransportData(List<TransportBase> transports)
        {
            var transportsToStringArray = new List<string>();
            foreach (TransportBase transport in transports)
            {
                if (transport.GetType().ToString().Contains("Automobile"))
                {
                    var transportItem = AutoDetails((Automobile)transport);
                    transportsToStringArray.Add(transportItem);
                }
                else if (transport.GetType().ToString().Contains("Motocycle"))
                {
                    var transportItem = MotoDetails((Motocycle)transport);
                    transportsToStringArray.Add(transportItem);
                }
                else
                {
                    var transportItem = BikeDetails((Bicycle)transport);
                    transportsToStringArray.Add(transportItem);
                }
            }

            return transportsToStringArray;
        }
    }
}