using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRCmanagement
{
    public class Vehicle
    {
        public string car_rego { get; set; }
        public string car_make { get; set; }
        public string car_model { get; set; }
        public string car_year { get; set; }
        public enum VehClass { Luxury, Economy, Family, Commercial }
        public VehClass car_class { get; set; }
        public enum vehTransmission { Automatic, Manual }
        public vehTransmission car_trans { get; set; }
        public enum vehFuel { Petrol, Diesel }
        public vehFuel car_fuel { get; set; }
        public bool car_GPS { get; set; }
        public bool car_sunroof { get; set; }
        public string car_colour { get; set; }
        public double car_Drate { get; set; }
        public int car_numSeats { get; set; }

        public Vehicle()
        { }
        public string ToCSVString()
        {
            string seats = car_numSeats.ToString() + "-Seater";
            string gps;
            if (car_GPS)
            { gps = "GPS"; }
            else { gps = " "; }
            string Sunroof;
            if (car_GPS)
            { Sunroof = "Sunroof"; }
            else { Sunroof = " "; }
            //string titleStr = "Rego,Make,Model,Year,VehicleClass,NumSeats,Transmission,Fuel,GPS,SunRoof,Colour,DailyRate";
            string outStr = car_rego + "," + car_make + "," + car_model + "," + car_year + "," + car_class.ToString() + "," + car_trans.ToString()
                                + "," + car_fuel.ToString() + "," + gps + "," + Sunroof + "," + seats + "," + car_colour + "," + car_Drate.ToString()
                                + "," + car_numSeats.ToString();
            return outStr;
        }
    }
}
