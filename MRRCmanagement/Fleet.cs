using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRCmanagement
{
    public class Fleet
    {
        List<Vehicle> carsList = new List<Vehicle>();
        List<rentals> vehRentalsList = new List<rentals>();

        public Fleet()
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\Data\fleet.csv");
            splitVehicleData(lines);
            string[] lines2 = System.IO.File.ReadAllLines(@"..\..\..\Data\rentals.csv");
            splitRentalData(lines2);
        }

        ~Fleet()
        {
            save_ToFile();
        }
        public void splitRentalData(string[] inStr)
        {
            for (int i = 1; i < inStr.Length; i++)
            {
                var tmpValue = inStr[i];
                var parts = tmpValue.Split(',');

                rentals rent = new rentals();

                rent.car_rego = parts[0];
                rent.customerID = int.Parse(parts[1]);
                rent.DateOfRental = parts[2];
                rent.RentalDuration = int.Parse(parts[3]);
                vehRentalsList.Add(rent);
            }
        }
        public void splitVehicleData(string[] inStr)
        {
            for (int i = 1; i < inStr.Length; i++)
            {
                var tmpValue = inStr[i];
                var parts = tmpValue.Split(',');

                Vehicle cars = new Vehicle();

                cars.car_rego = parts[0];
                cars.car_make = parts[1];
                cars.car_model = parts[2];
                cars.car_year = parts[3];
                cars.car_class = (Vehicle.VehClass)Enum.Parse(typeof(Vehicle.VehClass), parts[4]);
                //cars.car_class = parts[4];
                cars.car_numSeats = int.Parse(parts[5]);
                cars.car_trans = (Vehicle.vehTransmission)Enum.Parse(typeof(Vehicle.vehTransmission), parts[6]);
                cars.car_fuel = (Vehicle.vehFuel)Enum.Parse(typeof(Vehicle.vehFuel), parts[7]);

                if (parts[8] == "False") cars.car_GPS = false;
                else if (parts[8] == "True") cars.car_GPS = true;

                if (parts[9] == "False") cars.car_sunroof = false;
                else if (parts[9] == "True") cars.car_sunroof = true;

                cars.car_colour = parts[10];
                cars.car_Drate = double.Parse(parts[11]);
                carsList.Add(cars);
            }
        }

        public void load_FromFile()
        {
            if (carsList.Count > 0)
            {
                carsList.Clear();
            }
            if (vehRentalsList.Count > 0)
            {
                vehRentalsList.Clear();
            }
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\Data\fleet.csv");
            splitVehicleData(lines);
            string[] lines2 = System.IO.File.ReadAllLines(@"..\..\..\Data\rentals.csv");
            splitRentalData(lines2);
        }

        public void save_ToFile()
        {
            //System.IO.File.WriteAllBytes(@"..\..\customer.csv", new byte[0]);
            string titleStr = "Rego,Make,Model,Year,VehicleClass,NumSeats,Transmission,Fuel,GPS,SunRoof,Colour,DailyRate";
            string[] outArray = new string[carsList.Count() + 1];

            outArray[0] = titleStr;
            int i = 1;

            foreach (Vehicle outcar in carsList)
            {
                string outGPS = "";
                string outSR = "";
                if (outcar.car_GPS) outGPS = "True"; else outGPS = "False";
                if (outcar.car_sunroof) outSR = "True"; else outSR = "False";

                outArray[i] = outcar.car_rego + "," + outcar.car_make + "," + outcar.car_model + "," + outcar.car_year
                             + "," + outcar.car_class + "," + outcar.car_numSeats + "," + outcar.car_trans + "," + outcar.car_fuel
                             + "," + outGPS + "," + outSR + "," + outcar.car_colour + "," + outcar.car_Drate;
                i++;
            }
            System.IO.File.WriteAllLines(@"..\..\..\Data\fleet.csv", outArray);


            string titleStr2 = "Vehicle,Customer,RentalDate,EstimatedDuration";
            string[] outArray2 = new string[vehRentalsList.Count() + 1];

            outArray2[0] = titleStr2;
            int i2 = 1;
            foreach (rentals outRents in vehRentalsList)
            {
                outArray2[i2] = outRents.car_rego + "," + outRents.customerID + "," + outRents.DateOfRental + "," + outRents.RentalDuration;
                i2++;
            }
            System.IO.File.WriteAllLines(@"..\..\..\Data\rentals.csv", outArray2);
        }
        public void AddVehicle(string rego, string make, string model, string year, Vehicle.VehClass Vclass, int numseats,
                                Vehicle.vehTransmission trans, Vehicle.vehFuel fuel, bool gps, bool sunroof, string colour, string dailyrate)
        {

            Vehicle cars = new Vehicle();
            cars.car_rego = rego;
            cars.car_make = make;
            cars.car_model = model;
            cars.car_year = year;
            cars.car_class = Vclass;
            cars.car_numSeats = numseats;
            cars.car_trans = trans;
            cars.car_fuel = fuel;
            cars.car_GPS = gps;
            cars.car_sunroof = sunroof;
            cars.car_colour = colour;
            cars.car_Drate = double.Parse(dailyrate);
            carsList.Add(cars);
        }
        public bool Exists(string Rego)
        {
            bool exists = false;
            foreach (Vehicle veh in GetFleet())
            {
                if (veh.car_rego == Rego)
                {
                    exists = true;
                }
            }
            return exists;
        }
        public void AddVehicle(Vehicle car)
        {
            carsList.Add(car);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            GetFleet().Remove(vehicle);
        }
        public bool RemoveVehicle(string Rego)
        {
            string vehRego = Rego;
            int vehindex = -1;
            vehindex = GetFleet().FindIndex(a => a.car_rego.Equals(vehRego));
            if (vehindex > 0)
            {
                GetFleet().RemoveAt(vehindex);
                return true;
            }
            else
                return false;

        }
        public List<Vehicle> GetFleet()
        {
            return carsList;
        }
        public List<rentals> GetRentals()
        {
            return vehRentalsList;
        }

        public bool IsRented(string vehicleRego)
        {
            bool flag = false;
            foreach (rentals car in GetRentals())
            {
                if (car.car_rego == vehicleRego)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public bool IsRented(int customerID)
        {
            bool flag = false;
            foreach (rentals car in GetRentals())
            {
                if (car.customerID == customerID)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public int RentedBy(string vehicleRego)
        {
            int ID = -1;
            foreach (rentals car in GetRentals())
            {
                if (car.car_rego == vehicleRego)
                {
                    ID = car.customerID;
                }
            }
            return ID;
        }
        public string RentedBy(int customerID)
        {
            string Rego = "Nobody";
            foreach (rentals car in GetRentals())
            {
                if (car.customerID == customerID)
                {
                    Rego = car.car_rego;
                }
            }
            return Rego;
        }
        public bool RentCar(string vehicleRego, int CustomerID)
        {
            return false;
        }
        public string[] search(string text,int upperLim, int lowerLim)
        {
            string[] localstr = new string[GetFleet().Count()];
            int i = 0;
            var tmpValue = text;
            var parts = tmpValue.Split(' ');
            string PrimaryStr = "";
            List<string> orStr = new List<string>();
            List<string> andStr = new List<string>();

            PrimaryStr = parts[0];

            for (int j = 0; j < parts.Count(); j++)
            {
                if ((j + 1) == parts.Count())
                { }
                else
                {
                    if (parts[j] == "OR")
                    {
                        orStr.Add(parts[j + 1]);
                    }
                    if (parts[j] == "AND")
                    {
                        andStr.Add(parts[j + 1]);
                    }
                }
            }

            int size1 = orStr.Count();
            int size2 = andStr.Count();

            foreach (Vehicle veh in GetFleet())
            {
                bool flag = false;
                string str = veh.ToCSVString();

                foreach (rentals car in GetRentals())
                {
                    if (car.car_rego == veh.car_rego)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    if (veh.car_Drate < double.Parse(upperLim.ToString()) && veh.car_Drate > double.Parse(lowerLim.ToString()))
                    {
                        if (text.Contains("Any"))
                        {
                            localstr[i] = veh.car_rego;
                            i++;
                        }

                        else if (!text.Contains(" OR ") && text.Contains(" AND "))
                        {
                            bool passed = false;
                            int count = 0;

                            if (str.Contains(PrimaryStr))
                            {
                                foreach (string tempStr in andStr)
                                {
                                    if (str.Contains(tempStr))
                                    {
                                        count++;
                                    }
                                }
                            }
                            if (count == size2)
                            { 
                                passed = true;
                            }

                            if (passed)
                            {
                                localstr[i] = veh.car_rego;
                                i++;
                            }
                        }
                        else if (text.Contains(" OR ") && !text.Contains(" AND "))
                        {
                            bool passed = false;
                            if (str.Contains(PrimaryStr))
                            {
                                passed = true;
                            }

                            foreach (string tempStr in orStr)
                            {
                                if (str.Contains(tempStr))
                                {
                                    passed = true;
                                }
                            }

                            if (passed)
                            {
                                localstr[i] = veh.car_rego;
                                i++;
                            }
                        }
                        else if (text.Contains(" OR ") && text.Contains(" AND "))
                        {
                            bool passed = false;
                            bool check1 = false;
                            bool check2 = false;
                            int count = 0;
                            //bool check3 = false;
                            if (parts[1] == "AND")
                            {
                                if (str.Contains(PrimaryStr))
                                {
                                    foreach (string tempStr in orStr)
                                    {
                                        if (str.Contains(tempStr))
                                        {
                                            check1 = true;
                                        }
                                    }
                                    foreach (string tempStr in andStr)
                                    {
                                        if (str.Contains(tempStr))
                                        {
                                            count++;
                                        }
                                    }
                                }
                                if (count == size2 && check1)
                                {
                                    passed = true;
                                }
                            }
                            else if (parts[1] == "OR")
                            {
                            
                                if (str.Contains(PrimaryStr))
                                {
                                    check1 = true;
                                }

                                foreach (string tempStr in orStr)
                                {
                                    if (str.Contains(tempStr))
                                    {
                                        check1 = true;
                                    }
                                }

                                foreach (string tempStr in andStr)
                                {
                                    if (str.Contains(tempStr))
                                    {
                                        count++;
                                    }
                                }
                                if (count == size2)
                                    check2 = true;

                                if (check1 && check2)
                                    passed = true;
                            }

                            if (passed)
                            {
                                localstr[i] = veh.car_rego;
                                i++;
                            }                        
                        }
                    
                        else if (str.Contains(text))
                        {
                            localstr[i] = veh.car_rego;
                            i++;
                        }
                    }
                }
            }
            return localstr;
        }
    }   
}
