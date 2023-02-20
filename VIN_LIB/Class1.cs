using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public static bool CheckVIN(string vin)
        {
            if (!Regex.IsMatch(vin, "^[A-HJ-NPR-Z0-9]{17}$"))
                return false;
            else
                return true;
        }

        public static string GetVINCountry(string vin)
        {
            if (CheckVIN(vin))
            {
                if (vin[0] == 'A' || vin[0] == 'C' || vin[0] == 'D' || vin[0] == 'E' || vin[0] == 'H')
                    return "Африка";
            }
            return "";
        }
    }
}
