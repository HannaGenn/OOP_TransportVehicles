using OOP_TransportVehicles.TransportData;

namespace OOP_TransportVehicles.TransportClasses
{
    public class Motocycle: TransportBase
    {
        public string hasMotorbikeBoot;

        public Motocycle()
        {
            hasMotorbikeBoot = "yes";
            averageSpeed = 90;
            wheels = 2;
            type = "Motobike";
            name = ConsoleHelper.GetUserDataString("Enter motocycle name: ");
        }

        public static string MotoDetails(Motocycle transport)
        {
            var motoItem = TransportBasicDetails(transport) + "\nAvailability of boot: " + transport.hasMotorbikeBoot + "\n";

            return motoItem;
        }
    }
}
