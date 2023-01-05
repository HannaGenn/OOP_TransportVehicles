using System;

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
    }
}
