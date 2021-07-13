using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_EA_Summer2021
{
    class World
    {
        public Person Player = new Person();
        public List<Location> Locations = new List<Location>();

        private void SetUpLocations()
        {
            Locations.Add(new Location("Desert of Sand"));
            Locations.Add(new Location("Lake of Water"));
            Locations.Add(new Location("Mountain"));
            Locations.Add(new Location("Sea of Water"));

        }
    }
}
