using OOP_TransportVehicles.TransportData;

namespace OOP_TransportVehicles.TransportClasses
{
    public class Bicycle: TransportBase
    {
        public string hasBell;

        public Bicycle()
        {
            hasBell = "no";
            averageSpeed = 40;
            wheels = 2;
            type = "Bicycle";
            name = ConsoleHelper.GetUserDataString("Enter bicycle name: ");
        }

        public static string BikeDetails(Bicycle transport)
        {
            var bikeItem = TransportBasicDetails(transport) + "\nAvailability of bell: " + transport.hasBell + "\n";

            return bikeItem;
        }
    }
}
