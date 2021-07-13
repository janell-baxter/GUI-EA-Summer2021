using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_EA_Summer2021
{
    class Utility
    {

        public static string GetAllItemNames(List<Item> list)
        {
            string output = "";
            foreach(Item i in list)
            {
                output += $"    - {i.Name} {Environment.NewLine}";
            }

            return output;
        }
    }
}
