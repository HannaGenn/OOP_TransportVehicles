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
        }
    }
}
