using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_TransportVehicles.TransportData
{
    public class FileHelper
    {
        public void WriteTextInFile(List <string> transportObjects)
        {
            var fileName = "transports.txt";
            var filePath = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\"), fileName);
            using (StreamWriter stream = new StreamWriter(filePath, false))
                foreach (var transport in transportObjects)
                {
                    stream.Write(transport);
                }
        }
    }
}
