/*
Editors : D. A. Dineth De Silva / Senith Galakumbura
*/
//Library of converting one unit to anouther created by ESODS

namespace UnitConverter
{
    public static class Unittounit
    {
        private static string Password = "printvhlwh";
        public static double Masstomass(double mass, string unit, string to_unit, string password)
        {
            if (password == Password)
            {
                if (to_unit == unit)
                {
                    return mass * 1;
                }
                else
                {
                    switch (unit)
                    {
                        case "tonne":
                            switch (to_unit)
                            {
                                case "Kilogram":
                                    return mass * 1000;
                                case "Gram":
                                    return mass * 1e+6;
                                case "Milligram":
                                    return mass * 1e+9;
                                case "Microgram":
                                    return mass * 1e+12;
                                case "Imperial ton":
                                    return mass / 1.016;
                                case "US ton":
                                    return mass * 1.102;
                                case "Stone":
                                    return mass * 157;
                                case "Pound":
                                    return mass * 2205;
                                case "Ounce":
                                    return mass * 35274;
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
                                    return 0;
                            }
                        case "Kilogram":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 1000;
                                case "Gram":
                                    return mass * 1000;
                                case "Milligram":
                                    return mass * 1e+6;
                                case "Microgram":
                                    return mass * 1e+9;
                                case "Imperial ton":
                                    return mass / 1016;
                                case "US ton":
                                    return mass / 907;
                                case "Stone":
                                    return mass / 6.35;
                                case "Pound":
                                    return mass * 2.205;
                                case "Ounce":
                                    return mass * 35.274;
                                //Symbol cases
                                case "g":
                                    goto case "Gram";
                                case "mg":
                                    goto case "Milligram";
                                case "µg":
                                    goto case "Microgram";
                                default:
                                    return 0;
                            }
                        case "Gram":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 1e+6;
                                case "Kilogram":
                                    return mass / 1000;
                                case "Milligram":
                                    return mass * 1000;
                                case "Microgram":
                                    return mass * 1e+6;
                                case "Imperial ton":
                                    return mass / 1.016e+6;
                                case "US ton":
                                    return mass / 907185;
                                case "Stone":
                                    return mass / 6350;
                                case "Pound":
                                    return mass / 454;
                                case "Ounce":
                                    return mass / 28.35;
                                    //Symbol cases
                                case "kg":
                                    goto case "Kilogram";
                                case "mg":
                                    goto case "Milligram";
                                case "µg":
                                    goto case "Microgram";
                                default:
                                    return 0;
                            }
                        case "Milligram":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 1e+9;
                                case "Kilogram":
                                    return mass / 1e+6;
                                case "Gram":
                                    return mass / 1000;
                                case "Microgram":
                                    return mass * 1000;
                                case "Imperial ton":
                                    return mass / 1.016e+9;
                                case "US ton":
                                    return mass / 9.072e+8;
                                case "Stone":
                                    return mass / 6.35e+6;
                                case "Pound":
                                    return mass / 453592;
                                case "Ounce":
                                    return mass / 28350;
                                //Symbol cases
                                case "kg":
                                    goto case "Kilogram";
                                case "g":
                                    goto case "Gram";
                                case "µg":
                                    goto case "Microgram";
                                default:
                                    return 0;
                            }
                        case "Microgram":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 1e+12;
                                case "Kilogram":
                                    return mass / 1e+9;
                                case "Gram":
                                    return mass / 1e+6;
                                case "Milligram":
                                    return mass / 1000;
                                case "Imperial ton":
                                    return mass / 1.016e+12;
                                case "US ton":
                                    return mass / 9.072e+11;
                                case "Stone":
                                    return mass / 6.35e+9;
                                case "Pound":
                                    return mass / 4.536e+8;
                                case "Ounce":
                                    return mass / 2.835e+7;
                                //Symbol cases
                                case "kg":
                                    goto case "Kilogram";
                                case "g":
                                    goto case "Gram";
                                case "mg":
                                    goto case "Milligram";
                                default:
                                    return 0;
                            }
                        case "Imperial ton":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass * 1.016;
                                case "Kilogram":
                                    return mass * 1016;
                                case "Gram":
                                    return mass * 1.016e+6;
                                case "Milligram":
                                    return mass * 1.016e+9;
                                case "Microgram":
                                    return mass * 1.016e+12;
                                case "US ton":
                                    return mass * 1.12;
                                case "Stone":
                                    return mass * 160;
                                case "Pound":
                                    return mass * 2240;
                                case "Ounce":
                                    return mass * 35840;
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
                                    return 0;
                            }
                        case "US ton":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 1.102;
                                case "Kilogram":
                                    return mass * 907;
                                case "Gram":
                                    return mass * 907185;
                                case "Milligram":
                                    return mass * 9.072e+8;
                                case "Microgram":
                                    return mass * 9.072e+11;
                                case "Imperial ton":
                                    return mass / 1.12;
                                case "Stone":
                                    return mass * 143;
                                case "Pound":
                                    return mass * 2000;
                                case "Ounce":
                                    return mass * 32000;
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
                                    return 0;
                            }
                        case "Stone":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 157;
                                case "Kilogram":
                                    return mass * 6.35;
                                case "Gram":
                                    return mass * 6350;
                                case "Milligram":
                                    return mass * 6.35e+6;
                                case "Microgram":
                                    return mass * 6.35e+9;
                                case "Imperial ton":
                                    return mass / 160;
                                case "US ton":
                                    return mass / 143;
                                case "Pound":
                                    return mass * 14;
                                case "Ounce":
                                    return mass * 224;
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
                                    return 0;
                            }
                        case "Pound":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 2205;
                                case "Kilogram":
                                    return mass / 2.205;
                                case "Gram":
                                    return mass * 454;
                                case "Milligram":
                                    return mass * 453592;
                                case "Microgram":
                                    return mass * 4.536e+8;
                                case "Imperial ton":
                                    return mass / 2240;
                                case "US ton":
                                    return mass / 2000;
                                case "Stone":
                                    return mass / 14;
                                case "Ounce":
                                    return mass * 16;
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
                                    return 0;
                            }
                        case "Ounce":
                            switch (to_unit)
                            {
                                case "tonne":
                                    return mass / 35274;
                                case "Kilogram":
                                    return mass / 35.274;
                                case "Gram":
                                    return mass * 28.35;
                                case "Milligram":
                                    return mass * 28350;
                                case "Microgram":
                                    return mass * 2.835e+7;
                                case "Imperial ton":
                                    return mass / 35840;
                                case "US ton":
                                    return mass / 32000;
                                case "Stone":
                                    return mass / 224;
                                case "Pound":
                                    return mass / 16;
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
                                    return 0;
                            }
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
                            return 0;
                    }
                }
            }
            else
            {
                return 0e-0;
            }
        }
        public static double Lengthtolength(double length, string unit, string to_unit, string password)
        {
            if (password == Password)
            {
                if (to_unit == unit)
                {
                    return length * 1;
                }
                else
                {
                    switch (unit)
                    {
                        case "Kilometre":
                            switch (to_unit)
                            {
                                case "Meter":
                                    return length * 1000;
                                case "Centimeter":
                                    return length * 100000;
                                case "Millimetre":
                                    return length * 1e+6;
                                case "micrometres":
                                    return length * 1e+9;
                                case "Nanometre":
                                    return length * 1e+12;
                                case "Mile":
                                    return length / 1.609;
                                case "Yard":
                                    return length * 1094;
                                case "Foot":
                                    return length * 3281;
                                case "Inch":
                                    return length * 39370;
                                case "Nautical mile":
                                    return length / 1.852;
                                default:
                                    return 0;
                            }
                        case "Meter":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 1000;
                                case "Centimeter":
                                    return length * 100;
                                case "Millimetre":
                                    return length * 1000;
                                case "micrometres":
                                    return length * 1e+6;
                                case "Nanometre":
                                    return length * 1e+9;
                                case "Mile":
                                    return length / 1609;
                                case "Yard":
                                    return length * 1.094;
                                case "Foot":
                                    return length * 3.281;
                                case "Inch":
                                    return length * 39.37;
                                case "Nautical mile":
                                    return length / 1852;
                                default:
                                    return 0;
                            }
                        case "Centimeter":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 100000;
                                case "Meter":
                                    return length / 100;
                                case "Millimetre":
                                    return length * 10;
                                case "micrometres":
                                    return length * 10000;
                                case "Nanometre":
                                    return length * 1e+7;
                                case "Mile":
                                    return length / 160934;
                                case "Yard":
                                    return length / 91.44;
                                case "Foot":
                                    return length / 30.48;
                                case "Inch":
                                    return length / 2.54;
                                case "Nautical mile":
                                    return length / 185200;
                                default:
                                    return 0;
                            }
                        case "Millimetre":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 1e+6;
                                case "Meter":
                                    return length / 1000;
                                case "Centimeter":
                                    return length / 10;
                                case "micrometres":
                                    return length * 1000;
                                case "Nanometre":
                                    return length * 1e+6;
                                case "Mile":
                                    return length / 1.609e+6;
                                case "Yard":
                                    return length / 914;
                                case "Foot":
                                    return length / 305;
                                case "Inch":
                                    return length / 254;
                                case "Nautical mile":
                                    return length / 1.852e+6;
                                default:
                                    return 0;
                            }
                        case "micrometres":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 1e+9;
                                case "Meter":
                                    return length / 1e+6;
                                case "Centimeter":
                                    return length / 10000;
                                case "Millimetre":
                                    return length / 1000;
                                case "Nanometre":
                                    return length * 1000;
                                case "Mile":
                                    return length / 1.609e+9;
                                case "Yard":
                                    return length / 914400;
                                case "Foot":
                                    return length / 304800;
                                case "Inch":
                                    return length / 25400;
                                case "Nautical mile":
                                    return length / 1.852e+9;
                                default:
                                    return 0;
                            }
                        case "Nanometre":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 1e+12;
                                case "Meter":
                                    return length / 1e+9;
                                case "Centimeter":
                                    return length / 1e+7;
                                case "Millimetre":
                                    return length / 1e+6;
                                case "micrometres":
                                    return length / 1000;
                                case "Mile":
                                    return length / 1.609e+12;
                                case "Yard":
                                    return length / 9.144e+8;
                                case "Foot":
                                    return length / 3.048e+8;
                                case "Inch":
                                    return length / 2.54e+7;
                                case "Nautical mile":
                                    return length / 1.852e+12;
                                default:
                                    return 0;
                            }
                        case "Mile":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length * 1.609;
                                case "Meter":
                                    return length * 1609;
                                case "Centimeter":
                                    return length * 160934;
                                case "Millimetre":
                                    return length * 1.609e+6;
                                case "micrometres":
                                    return length * 1.609e+9;
                                case "Nanometre":
                                    return length * 1.609e+12;
                                case "Yard":
                                    return length * 1760;
                                case "Foot":
                                    return length * 5280;
                                case "Inch":
                                    return length * 63360;
                                case "Nautical mile":
                                    return length / 1.151;
                                default:
                                    return 0;
                            }
                        case "Yard":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 1094;
                                case "Meter":
                                    return length / 1.094;
                                case "Centimeter":
                                    return length * 91.44;
                                case "Millimetre":
                                    return length * 914;
                                case "micrometres":
                                    return length * 914400;
                                case "Nanometre":
                                    return length * 9.144e+8;
                                case "Mile":
                                    return length / 1760;
                                case "Foot":
                                    return length * 3;
                                case "Inch":
                                    return length * 36;
                                case "Nautical mile":
                                    return length / 2025;
                                default:
                                    return 0;
                            }
                        case "Foot":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 3281;
                                case "Meter":
                                    return length / 3.281;
                                case "Centimeter":
                                    return length * 30.48;
                                case "Millimetre":
                                    return length * 305;
                                case "micrometres":
                                    return length * 304800;
                                case "Nanometre":
                                    return length * 3.048e+8;
                                case "Mile":
                                    return length / 5280;
                                case "Yard":
                                    return length / 3;
                                case "Inch":
                                    return length * 12;
                                case "Nautical mile":
                                    return length / 6076;
                                default:
                                    return 0;
                            }
                        case "Inch":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length / 39370;
                                case "Meter":
                                    return length / 39.37;
                                case "Centimeter":
                                    return length * 2.54;
                                case "Millimetre":
                                    return length * 25.4;
                                case "micrometres":
                                    return length * 25400;
                                case "Nanometre":
                                    return length * 2.54e+7;
                                case "Mile":
                                    return length / 63360;
                                case "Yard":
                                    return length / 36;
                                case "Foot":
                                    return length / 12;
                                case "Nautical mile":
                                    return length / 72913;
                                default:
                                    return 0;
                            }
                        case "Nautical mile":
                            switch (to_unit)
                            {
                                case "Kilometre":
                                    return length * 1.852;
                                case "Meter":
                                    return length * 1852;
                                case "Centimeter":
                                    return length * 185200;
                                case "Millimetre":
                                    return length * 1.852e+6;
                                case "micrometres":
                                    return length * 1.852e+9;
                                case "Nanometre":
                                    return length * 1.852e+12;
                                case "Mile":
                                    return length * 1.151;
                                case "Yard":
                                    return length * 2025;
                                case "Foot":
                                    return length * 6076;
                                case "Inch":
                                    return length * 72913;
                                default:
                                    return 0;
                            }
                        default:
                            return 0;
                    }
                }
            }
            else
            {
                return 0e-0;
            }
        }
        public static double Temptotemp(double temp, string unit, string to_unit, string password)
        {
            if(password == Password)
            {
                if (to_unit == unit)
                {
                    return temp * 1;
                }
                else
                {
                    switch (unit)
                    {
                        case "Celsius":
                            switch (to_unit)
                            {
                                case "Fahrenheit":
                                    return (temp * 9 / 5) + 32;
                                case "Kelvin":
                                    return temp + 273.15;
                                default:
                                    return 0;
                            }
                        case "Fahrenheit":
                            switch (to_unit)
                            {
                                case "Celsius":
                                    return (temp - 32) * 5 / 9;
                                case "Kelvin":
                                    return (temp - 32) * 5 / 9 + 273.15;
                                default:
                                    return 0;
                            }
                        case "Kelvin":
                            switch (to_unit)
                            {
                                case "Celsius":
                                    return temp - 273.15;
                                case "Fahrenheit":
                                    return (temp - 273.15) * 9 / 5 + 32;
                                default:
                                    return 0;
                            }
                        default:
                            return 0;
                    }
                }
            }
            else
            {
                return 0e-0;
            }
        }
    }
}
