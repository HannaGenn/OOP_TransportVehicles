using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;

namespace OOP_TransportVehicles.TransportData
{
    public class TransportCharacteristics
    {
        public static string messageForDistinguishedDetail;

        public static Automobile GetNameForAuto(Automobile autoItem)
        {
            Console.WriteLine("Enter automobile name: ");
            autoItem.name = Console.ReadLine();

            return autoItem;
        }

        public static Motocycle GetNameForMoto(Motocycle motoItem)
        {
            Console.WriteLine("Enter motocycle name: ");
            motoItem.name = Console.ReadLine();

            return motoItem;
        }

        public static Bicycle GetNameForBike(Bicycle bikeItem)
        {
            Console.WriteLine("Enter bicycle name: ");
            bikeItem.name = Console.ReadLine();

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
            messageForDistinguishedDetail = "\nAvailability of autogearbox: ";
            var autoDetails = basicDetails + messageForDistinguishedDetail + transport.hasAutomaticGearBox + "\n";

            return autoDetails;
        }

        public static string MotoDetails(Motocycle transport)
        {
            var basicDetails = TransportBasicDetails(transport);
            messageForDistinguishedDetail = "\nAvailability of boot: ";
            var motoDetails = basicDetails + messageForDistinguishedDetail + transport.hasMotorbikeBoot + "\n";

            return motoDetails;
        }

        public static string BikeDetails(Bicycle transport)
        {
            var basicDetails = TransportBasicDetails(transport);
            messageForDistinguishedDetail = "\nAvailability of bell: ";
            var bikeDetails = basicDetails + messageForDistinguishedDetail + transport.hasBell + "\n";

            return bikeDetails;
        }

        public static List<string> TransportData(List<TransportBase> transports)
        {
            string transportItem;
            var transportsToStringArray = new List<string>();
            foreach (TransportBase transport in transports)
            {
                if (transport.GetType().ToString().Contains("Automobile"))
                {
                    transportItem = AutoDetails((Automobile)transport);
                    transportsToStringArray.Add(transportItem);
                }
                else if (transport.GetType().ToString().Contains("Motocycle"))
                {
                    transportItem = MotoDetails((Motocycle)transport);
                    transportsToStringArray.Add(transportItem);
                }
                else
                {
                    transportItem = BikeDetails((Bicycle)transport);
                    transportsToStringArray.Add(transportItem);
                }
            }

            return transportsToStringArray;
        }
    }
}