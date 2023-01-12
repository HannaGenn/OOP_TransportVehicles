using OOP_TransportVehicles.TransportData;

namespace OOP_TransportVehicles.TransportClasses
{
    public class Automobile: TransportBase
    {
        public string hasAutomaticGearBox;

        public Automobile()
        {
            hasAutomaticGearBox = "yes";
            averageSpeed = 120;
            wheels = 4;
            type = "Automobile";
            name = ConsoleHelper.GetUserDataString("Enter automobile name: ");
        }

        public static string AutoDetails(Automobile transport)
        {
            var autoItem = TransportBasicDetails(transport) + "\nAvailability of autogearbox: " + transport.hasAutomaticGearBox + "\n";

            return autoItem;
        }
    }
}
