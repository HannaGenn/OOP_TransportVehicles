using OOP_TransportVehicles.TransportClasses;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_TransportVehicles.TransportData
{
    public class FileHelper
    {
        public void WriteTextInFile(List <string> transportObjects)
        {
            var input = ConsoleHelper.GetUserData("Write path to save file");
            var filePosition = $@"{input}";
            using (FileStream file = new FileStream(filePosition, FileMode.Append))
            using (StreamWriter stream = new StreamWriter(file))
                foreach (var transport in transportObjects)
                {
                    stream.Write(transport);
                }
        }
    }
}
