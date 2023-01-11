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
        }
    }
}
