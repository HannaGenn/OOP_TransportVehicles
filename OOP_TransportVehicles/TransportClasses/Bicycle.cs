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
        }
    }
}
