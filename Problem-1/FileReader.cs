using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Problem_1
{
    public class FileReader
    {
        public static List<Inventory> inventories = new List<Inventory>();

        public List<Inventory> GetInventry()
        {
            string text = File.ReadAllText(@"C:\Users\gupta\OneDrive\Desktop\DataOFPulses.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);
            return inventories;
        }

    }
}