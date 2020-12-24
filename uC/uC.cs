/*
Editors : D. A. Dineth De Silva / Senith Galakumbura
*/
//A library that only compatiable with  ESODS UnitConverter.dll library created for Susen version 1 program

namespace uC
{
    public static class uC
    {
        public static string Unitditerminer(string Unit)
        {
            switch (Unit)
            {
                //Masstomass
                case "tonne":
                    return "Masstomass";
                case "Kilogram":
                    return "Masstomass";
                case "Gram":
                    return "Masstomass";
                case "Milligram":
                    return "Masstomass";
                case "Microgram":
                    return "Masstomass";
                case "Imperial ton":
                    return "Masstomass";
                case "US ton":
                    return "Masstomass";
                case "Stone":
                    return "Masstomass";
                case "Pound":
                    return "Masstomass";
                case "Ounce":
                    return "Masstomass";
                //Symbol cases
                case "kg":
                    goto case "Kilogram";
                case "g":
                    goto case "Gram";
                case "mg":
                    goto case "Milligram";
                case "µg":
                    goto case "Microgram";
                default:
                    return null;
            }
        }
    }
}
