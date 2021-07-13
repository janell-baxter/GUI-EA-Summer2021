using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GUI_EA_Summer2021.Utility;

namespace GUI_EA_Summer2021
{
    class Person
    {
        public string Name = "Anonymous Person";
        public List<Item> Inventory = new List<Item>();
        public Location CurrentLocation;


        public Person()
        {
            CurrentLocation = new Location("Start");
            Inventory.Add(new Item {Name="Map" });
            Inventory.Add(new Item { Name = "Lunch" });
        }

        public string GetPlayerInformation()
        {
            string output = "";
            output += $"{Name} {Environment.NewLine}";
            output += $"Location: {CurrentLocation.Name} {Environment.NewLine}Inventory: {Environment.NewLine}";
            output += GetAllItemNames(Inventory);
           return output;
        }

        
    }
}
