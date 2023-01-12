namespace OOP_TransportVehicles.TransportClasses
{
    public class TransportBase
    {
        public string name;
        public double averageSpeed;
        public int wheels;
        public string type;
        public int maxSpeed;

        public TransportBase()
        {
            maxSpeed = 130;
        }

        public static string TransportBasicDetails(TransportBase transport)
        {
            var basicDetails = $"\nName: " + transport.name + "\nAverage speed: " + transport.averageSpeed + "\nMax speed: " +
            transport.maxSpeed+ "\nQuantity of wheels: " + transport.wheels+ "\nType of transport:" + transport.type;

            return basicDetails;
        }
    }
}
