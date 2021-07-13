using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_EA_Summer2021
{
    class Location
    {
        public string Name;
        public string Description;
        public List<Item> RandomFinds = new List<Item>();
        // add a bitmap image here for the graphic

        public Location(string _name)
        {
            Name = _name;
        }

        public Location()
        {

        }
    }
}
