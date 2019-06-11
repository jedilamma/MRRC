using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRRCmanagement;

namespace MRRC
{
    public partial class Form1 : Form
    {
        Random newrand = new Random();
        public CRM ClientMan = new CRM();
        public Fleet fleetMan = new Fleet();

        private bool m_ClModclicked = false;
        private int m_CLModindex = 0;

        private bool m_vehModclicked = false;
        private int m_vehModindex = 0;

        //private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer;
        private static int intervalTime = 4000;

        public Form1()
        {
            InitializeComponent();

            RefreshCustomers();
            RefreshFleet();
            RefreshRentals();

            this.toolStripStatusLabel1.Text = "";
            this.clientListView1.Scrollable = true;
            this.clientListView1.Columns.Add("ID", 40);
            this.clientListView1.Columns.Add("Title", 60);
            this.clientListView1.Columns.Add("Firstname", 90);
            this.clientListView1.Columns.Add("Surname", 90);
            this.clientListView1.Columns.Add("Gender", 50);
            this.clientListView1.Columns.Add("dob", 80);

            this.carListView1.Scrollable = true;
            this.carListView1.Columns.Add("Rego", 60);
            this.carListView1.Columns.Add("Make", 50);
            this.carListView1.Columns.Add("Model", 50);
            this.carListView1.Columns.Add("Year", 50);
            this.carListView1.Columns.Add("Class", 50);
            this.carListView1.Columns.Add("Seats", 50);
            this.carListView1.Columns.Add("Transmission", 60);
            this.carListView1.Columns.Add("Fuel", 50);
            this.carListView1.Columns.Add("Gps", 40);
            this.carListView1.Columns.Add("Sunroof", 40);
            this.carListView1.Columns.Add("Colour", 40);
            this.carListView1.Columns.Add("Daily Rate", 50);

            this.rentListView.Scrollable = true;
            this.rentListView.View = View.Details;
            this.rentListView.GridLines = true;
            this.rentListView.FullRowSelect = true;
            this.rentListView.Columns.Add("Customer ID", 80);
            this.rentListView.Columns.Add("Name", 130);
            this.rentListView.Columns.Add("Registration Number", 80);
            this.rentListView.Columns.Add("Car Details", 200);
            this.rentListView.Columns.Add("Daily Rate", 80);
            this.rentListView.Columns.Add("Rented Since", 100);
            this.rentListView.Columns.Add("Rental Duration", 80);
            this.rentListView.Columns.Add("Est Cost", 60);

            this.carStatuslbl.Text = "";
            this.clientStatuslbl.Text = "";

        }

        private void genIDbtn_Click(object sender, EventArgs e)
        {
            int idnum = 0;
            string outnum = "";
            //for (int i = 0; i < 1; i++)
            //{
            idnum = newrand.Next(99999);
            outnum = outnum + idnum;
            //}
            this.clientIdTbx.Text = outnum;
            this.toolStripStatusLabel1.Text = "Client id Generated";
        }

        private bool clientValidation()
        {
            bool progress = true;            
            this.clientErrorProvider.Clear();

            int idtest;
            if (!int.TryParse(this.clientIdTbx.Text,out idtest))
            {
                this.clientErrorProvider.SetError(this.clientIdTbx, "invalid input");
                progress = false;
            }
            if (this.clientIdTbx.Text == "")
            {
                this.clientErrorProvider.SetError(this.clientIdTbx, "invalid input");
                progress = false;
            }
            if (this.clientTitleCbox.Text == "Mr" || this.clientTitleCbox.Text == "Mrs" || this.clientTitleCbox.Text == "Ms")
            { }
            else
            {
                this.clientErrorProvider.SetError(this.clientTitleCbox, "invalid input");
                progress = false;
            }
            if (this.clientFirstNameTbx.Text == "")
            {
                this.clientErrorProvider.SetError(this.clientFirstNameTbx, "invalid input");
                progress = false;
            }
            if (this.clientSurnameTxtbox.Text == "")
            { 
                this.clientErrorProvider.SetError(this.clientSurnameTxtbox, "invalid input");
                progress = false;
            }
            if (this.clientGenderCbox.Text == "Male" || this.clientGenderCbox.Text == "Female")
            { }
            else
            {
                this.clientErrorProvider.SetError(this.clientGenderCbox, "invalid input");
                progress = false;
            }

            string dateData = this.clientDobTbx.Text;
            var parts = dateData.Split('/');
            bool dtclears = false;

            if (parts.Count() == 3)
            {
                int[] leapyear = { 1904,1908,1912,1916,1920,1924,1928,1932,1936,1940,1944,1948,1952,1956,1960,1964,1968,1972,1976,
                                   1980,1984,1988,1992,1996,2000,2004,2008,2012,2016,2020,2024 };
                int day = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int year = int.Parse(parts[2]);

                bool ly = false;
                foreach (int i in leapyear)
                    if (year == i)
                        ly = true;

                if(year < 2020 && year > 1900)
                    if (month <= 12 && month > 0)
                    {
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                            if (day <= 31 && day > 0)  dtclears = true;
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                            if (day <= 30 && day > 0)  dtclears = true;
                        if (month == 2 && ly)
                            if (day <= 29 && day > 0)  dtclears = true;
                        if (month == 2 && !ly)
                            if (day <= 28 && day > 0)  dtclears = true;
                    }

                if (!dtclears || this.clientDobTbx.Text == "")
                {
                    this.clientErrorProvider.SetError(this.clientDobTbx, "Bad Day/Month/Year format");
                    progress = false;
                }
            }
            else
            {
                this.clientErrorProvider.SetError(this.clientDobTbx, "Date needs Day/Month/Year format");
                progress = false;
            }
            return progress;
        }

        private bool vehicleValidation()
        {
            bool progress = true;

            string rego = this.carRegoTb.Text;
            string Make = this.carMakeTb.Text;
            string Model = this.carModeltb.Text;
            string Year = this.carYeartb.Text;
            string Cclass = this.carClasscb.Text;
            string seats = this.carSeatstb.Text;
            string trans = this.carTranscb.Text;
            string Fuel =  this.carFuelcb.Text;
            bool gps = this.carGpscb.Checked;
            bool Sroof = this.carSunRoofcb.Checked;
            string Colour = this.carColourtb.Text;
            string Dailyrate = this.carDratetb.Text;

            this.clientErrorProvider.Clear();
            int drate;
            if (!int.TryParse(Dailyrate,out drate))
            {
                this.clientErrorProvider.SetError(this.carDratetb, "results not Valid");
                progress = false;
            }
            else
            {
                if (drate < 1)
                {
                    this.clientErrorProvider.SetError(this.carDratetb, "results not Valid");
                    progress = false;
                }
            }

            if (Colour == "")
            {
                this.clientErrorProvider.SetError(this.carColourtb, "results not Valid");
                progress = false;
            }
                if (Fuel == "Petrol" || Fuel == "Diesel")
            { }
            else
            {
                this.clientErrorProvider.SetError(this.carFuelcb, "results not Valid");
                progress = false;
            }

            int sts;
            if (int.TryParse(seats, out sts))
            {
                if(sts < 2 || sts > 10)
                {
                    this.clientErrorProvider.SetError(this.carSeatstb, "results not Valid");
                    progress = false;
                }
            }
            else
            { 
                this.clientErrorProvider.SetError(this.carSeatstb, "results not Valid");
                progress = false;
            }

            if (trans == "Automatic" || trans == "Manual")
            { }
            else
            {
                this.clientErrorProvider.SetError(this.carTranscb, "results not Valid");
                progress = false;
            }

            if (Cclass == "Luxury" || Cclass == "Commercial" || Cclass == "Economy" || Cclass == "Family")
            {  }
            else
            {
                this.clientErrorProvider.SetError(this.carClasscb, "Car Class not Valid");
                progress = false;
            }
            if (Make == "" )
            {
                this.clientErrorProvider.SetError(this.carMakeTb, "Car Make cannot be blank");
                progress = false;
            }

            if (Model == "")
            {
                this.clientErrorProvider.SetError(this.carModeltb, "car Model cannot be blank");
                progress = false;
            }
            int yr;
            if(int.TryParse(Year,out yr))
            {
                if (yr < 1900 || yr > 2018)
                {
                    this.clientErrorProvider.SetError(this.carYeartb, "Year of car must be a valid year");
                    progress = false;
                }
            }

            if (Year == "")
            {
                this.clientErrorProvider.SetError(this.carYeartb, "Year of car must be a valid year");
                progress = false;
            }

            if (rego == "")
            {
                this.clientErrorProvider.SetError(this.carRegoTb, "Registration cannot be blank");
                progress = false;
            }

            if (fleetMan.Exists(rego))
            {
                this.clientErrorProvider.SetError(this.carRegoTb, "This car registration already exists");
                progress = false;
            }
            return progress;
        }

        private void clientAddbtn_Click(object sender, EventArgs e)
        {
            if (clientValidation())
            {
                string ID = this.clientIdTbx.Text;
                string title = this.clientTitleCbox.Text;
                string Firstname = this.clientFirstNameTbx.Text;
                string surname = this.clientSurnameTxtbox.Text;
                string gender = this.clientGenderCbox.Text;
                string dob = this.clientDobTbx.Text;

                bool flag = false;
                bool inList = false;
                while (!flag)
                {
                    foreach (Customer cust in ClientMan.GetList())
                    {
                        if (int.Parse(ID) == cust.c_ID)
                        {
                            inList = true;
                        }
                    }
                    if (inList)
                    {
                        ID = newrand.Next(99999).ToString();
                        flag = true;
                    }
                    if(!inList && !flag)
                    {
                        break;
                    }
                }

                ClientMan.add_DataToList(ID, title, Firstname, surname, gender, dob);
                RefreshCustomers();

                this.clientIdTbx.Text = "";
                this.clientTitleCbox.Text = "";
                this.clientFirstNameTbx.Text = "";
                this.clientSurnameTxtbox.Text = "";
                this.clientGenderCbox.Text = "";
                this.clientDobTbx.Text = "";
                this.toolStripStatusLabel1.Text = "Client added to List";
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshCustomers();
            RefreshFleet();
            RefreshRentals();
            this.toolStripStatusLabel1.Text = "All Lists Refreshed";
        }

        private void RefreshCustomers()
        {
            this.clientListView1.Items.Clear();
            foreach (Customer cust in ClientMan.GetList())
            {
                string[] newArr = new string[6];
                //Add first item
                newArr[0] = cust.c_ID.ToString();
                newArr[1] = cust.c_Title;
                newArr[2] = cust.c_FirstName;
                newArr[3] = cust.c_LastName;
                newArr[4] = cust.c_gender.ToString();
                newArr[5] = cust.c_dob;

                ListViewItem itm = new ListViewItem(newArr);
                this.clientListView1.Items.Add(itm);
            }
        }

        private void RefreshFleet()
        {
            this.carListView1.Items.Clear();
            foreach (Vehicle Veh in fleetMan.GetFleet())
            {
                string[] newArr = new string[12];

                newArr[0] = Veh.car_rego;
                newArr[1] = Veh.car_make;
                newArr[2] = Veh.car_model;
                newArr[3] = Veh.car_year;

                // newArr[4] = Veh.car_class;
                newArr[4] = Veh.car_class.ToString();
                newArr[5] = Veh.car_numSeats.ToString();
                newArr[6] = Veh.car_trans.ToString();
                newArr[7] = Veh.car_fuel.ToString();
                newArr[8] = Veh.car_GPS.ToString();
                newArr[9] = Veh.car_sunroof.ToString();
                newArr[10] = Veh.car_colour;
                decimal dr = decimal.Parse(Veh.car_Drate.ToString());
                string drate = String.Format("{0:C}", dr);
                newArr[11] = drate;

                ListViewItem itm = new ListViewItem(newArr);
                this.carListView1.Items.Add(itm);
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            ClientMan.save_ToFile();
            fleetMan.save_ToFile();
            this.toolStripStatusLabel1.Text = "Data Saved to Disk";
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            ClientMan.load_FromFile();
            this.toolStripStatusLabel1.Text = "Data Loaded from Disk";
        }

        private void clientModbtn_Click(object sender, EventArgs e)
        {
            if (this.clientListView1.SelectedIndices.Count > 0)
            {
                Customer cust = new Customer();

                if (!m_ClModclicked)
                {
                    this.clientModbtn.Text = "Done";
                    this.clientIdTbx.Text = this.clientListView1.SelectedItems[0].SubItems[0].Text;
                    this.clientTitleCbox.Text = this.clientListView1.SelectedItems[0].SubItems[1].Text;
                    this.clientFirstNameTbx.Text = this.clientListView1.SelectedItems[0].SubItems[2].Text;
                    this.clientSurnameTxtbox.Text = this.clientListView1.SelectedItems[0].SubItems[3].Text;
                    this.clientGenderCbox.Text = this.clientListView1.SelectedItems[0].SubItems[4].Text;
                    this.clientDobTbx.Text = this.clientListView1.SelectedItems[0].SubItems[5].Text;

                    m_ClModclicked = true;

                    this.clientAddbtn.Enabled = false;
                    this.clientgenIDbtn.Enabled = false;
                    this.clientRemovebtn.Enabled = false;
                    this.clientIdTbx.Enabled = false;

                    int ID = int.Parse(this.clientListView1.SelectedItems[0].SubItems[0].Text);
                    m_CLModindex = ClientMan.GetList().FindIndex(a => a.c_ID.Equals(ID));

                }
                else if (m_ClModclicked)
                {
                    if (clientValidation())
                    {
                        this.clientModbtn.Text = "Modify Customer";
                        cust.c_ID = int.Parse(this.clientIdTbx.Text);
                        cust.c_Title = this.clientTitleCbox.Text;
                        cust.c_FirstName = this.clientFirstNameTbx.Text;
                        cust.c_LastName = this.clientSurnameTxtbox.Text;
                        cust.c_gender = (Customer.Gender)Enum.Parse(typeof(Customer.Gender), this.clientGenderCbox.Text);
                        cust.c_dob = this.clientDobTbx.Text;

                        ClientMan.GetList()[m_CLModindex] = cust;

                        this.clientListView1.SelectedItems[0].SubItems[0].Text = this.clientIdTbx.Text;
                        this.clientListView1.SelectedItems[0].SubItems[1].Text = this.clientTitleCbox.Text;
                        this.clientListView1.SelectedItems[0].SubItems[2].Text = this.clientFirstNameTbx.Text;
                        this.clientListView1.SelectedItems[0].SubItems[3].Text = this.clientSurnameTxtbox.Text;
                        this.clientListView1.SelectedItems[0].SubItems[4].Text = this.clientGenderCbox.Text;
                        this.clientListView1.SelectedItems[0].SubItems[5].Text = this.clientDobTbx.Text;

                        this.clientIdTbx.Enabled = true;
                        this.clientgenIDbtn.Enabled = true;
                        this.clientAddbtn.Enabled = true;
                        this.clientRemovebtn.Enabled = true;

                        m_ClModclicked = false;

                        this.clientIdTbx.Text = "";
                        this.clientTitleCbox.Text = "";
                        this.clientFirstNameTbx.Text = "";
                        this.clientSurnameTxtbox.Text = "";
                        this.clientGenderCbox.Text = "";
                        this.clientDobTbx.Text = "";
                    }                  
                }
            }
        }

        private void CDaddbtn_Click(object sender, EventArgs e)
        {
            if (vehicleValidation())
            {
                Vehicle car = new Vehicle();
                car.car_rego = this.carRegoTb.Text;
                car.car_make = this.carMakeTb.Text;
                car.car_model = this.carModeltb.Text;
                car.car_year = this.carYeartb.Text;
                car.car_class = (Vehicle.VehClass)Enum.Parse(typeof(Vehicle.VehClass), this.carClasscb.Text);
                car.car_numSeats = int.Parse(this.carSeatstb.Text);
                car.car_trans = (Vehicle.vehTransmission)Enum.Parse(typeof(Vehicle.vehTransmission), this.carTranscb.Text);
                car.car_fuel = (Vehicle.vehFuel)Enum.Parse(typeof(Vehicle.vehFuel), this.carFuelcb.Text);
                if (this.carGpscb.Checked) car.car_GPS = true;
                else car.car_GPS = false;
                if (this.carSunRoofcb.Checked) car.car_sunroof = true;
                else  car.car_sunroof = false;
                car.car_colour = this.carColourtb.Text;
                car.car_Drate = double.Parse(this.carDratetb.Text);

                if (!fleetMan.Exists(car.car_rego))
                {
                    fleetMan.AddVehicle(car);
                    RefreshFleet();

                    this.carRegoTb.Text = "";
                    this.carMakeTb.Text = "";
                    this.carModeltb.Text = "";
                    this.carYeartb.Text = "";
                    this.carClasscb.Text = "";
                    this.carSeatstb.Text = "";
                    this.carTranscb.Text = "";
                    this.carFuelcb.Text = "";
                    this.carGpscb.Checked = false;
                    this.carSunRoofcb.Checked = false;
                    this.carColourtb.Text = "";
                    this.carDratetb.Text = "";

                    this.toolStripStatusLabel1.Text = "Vehicle Added to List";
                }
                else
                {
                    this.toolStripStatusLabel1.Text = "A vehicle with this Registration already exists";
                }
            }
        }

        private void carModbtn_Click(object sender, EventArgs e)
        {
            Vehicle Veh = new Vehicle();
            if (this.carListView1.SelectedIndices.Count > 0)
            {
                if (!m_vehModclicked)
                {
                    this.carModbtn.Text = "Done";

                    this.carRegoTb.Text = this.carListView1.SelectedItems[0].SubItems[0].Text;
                    this.carMakeTb.Text = this.carListView1.SelectedItems[0].SubItems[1].Text;
                    this.carModeltb.Text = this.carListView1.SelectedItems[0].SubItems[2].Text;
                    this.carYeartb.Text = this.carListView1.SelectedItems[0].SubItems[3].Text;
                    this.carClasscb.Text = this.carListView1.SelectedItems[0].SubItems[4].Text;
                    this.carSeatstb.Text = this.carListView1.SelectedItems[0].SubItems[5].Text;
                    this.carTranscb.Text = this.carListView1.SelectedItems[0].SubItems[6].Text;
                    this.carFuelcb.Text = this.carListView1.SelectedItems[0].SubItems[7].Text;

                    if (this.carListView1.SelectedItems[0].SubItems[8].Text == "False") this.carGpscb.Checked = false;
                    else if (this.carListView1.SelectedItems[0].SubItems[8].Text == "True") this.carGpscb.Checked = true;

                    if (this.carListView1.SelectedItems[0].SubItems[9].Text == "False") this.carSunRoofcb.Checked = false;
                    else if (this.carListView1.SelectedItems[0].SubItems[9].Text == "True") this.carSunRoofcb.Checked = true;

                    this.carColourtb.Text = this.carListView1.SelectedItems[0].SubItems[10].Text;
                    this.carDratetb.Text = this.carListView1.SelectedItems[0].SubItems[11].Text;

                    m_vehModclicked = true;

                    this.carAddbtn.Enabled = false;
                    this.carRemCbtn.Enabled = false;

                    string rego = this.carListView1.SelectedItems[0].SubItems[0].Text;
                    m_vehModindex = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(rego));
                }
            
                else if (m_vehModclicked)
                {
                    this.carModbtn.Text = "Modify Vehicle";

                    Veh.car_rego = this.carRegoTb.Text;
                    Veh.car_make = this.carMakeTb.Text;
                    Veh.car_model = this.carModeltb.Text;
                    Veh.car_year = this.carYeartb.Text;
                    Veh.car_class = (Vehicle.VehClass)Enum.Parse(typeof(Vehicle.VehClass), this.carClasscb.Text);

                    Veh.car_numSeats = int.Parse(this.carSeatstb.Text);
                    Veh.car_trans = (Vehicle.vehTransmission)Enum.Parse(typeof(Vehicle.vehTransmission), this.carTranscb.Text);
                    Veh.car_fuel = (Vehicle.vehFuel)Enum.Parse(typeof(Vehicle.vehFuel), this.carFuelcb.Text);

                    if (this.carGpscb.Checked)
                        Veh.car_GPS = true;
                    else
                        Veh.car_GPS = false;
                    if (this.carSunRoofcb.Checked)
                        Veh.car_sunroof = true;
                    else
                        Veh.car_sunroof = false;

                    Veh.car_colour = this.carColourtb.Text;
                    if(this.carDratetb.Text.Contains("$"))
                    {
                        var parts = this.carDratetb.Text.Split('$');
                        Veh.car_Drate = double.Parse(parts[1]);
                    }
                    else
                        Veh.car_Drate = double.Parse(this.carDratetb.Text);



                    //fleetMan.AddVehicle(Veh);

                    fleetMan.GetFleet()[m_vehModindex] = Veh;

                    this.carListView1.SelectedItems[0].SubItems[0].Text = this.carRegoTb.Text;
                    this.carListView1.SelectedItems[0].SubItems[1].Text = this.carMakeTb.Text;
                    this.carListView1.SelectedItems[0].SubItems[2].Text = this.carModeltb.Text;
                    this.carListView1.SelectedItems[0].SubItems[3].Text = this.carYeartb.Text;
                    this.carListView1.SelectedItems[0].SubItems[4].Text = this.carClasscb.Text;
                    this.carListView1.SelectedItems[0].SubItems[5].Text = this.carSeatstb.Text;
                    this.carListView1.SelectedItems[0].SubItems[6].Text = this.carTranscb.Text;
                    this.carListView1.SelectedItems[0].SubItems[7].Text = this.carFuelcb.Text;

                    string outGPS = "";
                    string outSR = "";
                    if (this.carGpscb.Checked) outGPS = "True"; else outGPS = "False";
                    if (this.carSunRoofcb.Checked) outSR = "True"; else outSR = "False";

                    this.carListView1.SelectedItems[0].SubItems[8].Text = outGPS;
                    this.carListView1.SelectedItems[0].SubItems[9].Text = outSR;
                    this.carListView1.SelectedItems[0].SubItems[10].Text = this.carColourtb.Text;
                    this.carListView1.SelectedItems[0].SubItems[11].Text = this.carDratetb.Text;

                    this.carAddbtn.Enabled = true;
                    this.carRemCbtn.Enabled = true;

                    m_vehModclicked = false;

                    this.carRegoTb.Text = "";
                    this.carMakeTb.Text = "";
                    this.carModeltb.Text = "";
                    this.carYeartb.Text = "";
                    this.carClasscb.Text = "";
                    this.carSeatstb.Text = "";
                    this.carTranscb.Text = "";
                    this.carFuelcb.Text = "";
                    this.carGpscb.Checked = false;
                    this.carSunRoofcb.Checked = false;
                    this.carColourtb.Text = "";
                    this.carDratetb.Text = "";                
                }
            }
        }

        private void carListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void clientRemovebtn_Click(object sender, EventArgs e)
        {
            if (this.clientListView1.SelectedIndices.Count > 0)
            {
                int ID = int.Parse(this.clientListView1.SelectedItems[0].SubItems[0].Text);
                int index = ClientMan.GetList().FindIndex(a => a.c_ID.Equals(ID));

                if (!fleetMan.IsRented(ID))
                {
                    ClientMan.GetList().RemoveAt(index);
                    RefreshCustomers();
                }
                else
                {
                    this.clientStatuslbl.Text = "This Client has a vehicle rented.";
                    this.clientErrorProvider.SetError(this.clientStatuslbl, "Cannot be removed");
                }
            }
            else
            {
                this.clientStatuslbl.Text = "Nothing to remove";
                this.clientErrorProvider.SetError(this.clientStatuslbl, "List is not selected");
            }
        }

        private void carRemCbtn_Click(object sender, EventArgs e)
        {
            if (this.carListView1.SelectedIndices.Count > 0)
            {
                string ID = this.carListView1.SelectedItems[0].SubItems[0].Text;
                int index = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(ID));
                if (!fleetMan.IsRented(ID))
                {
                    string Carrego = this.carListView1.SelectedItems[0].SubItems[0].Text;
                    string Make = this.carListView1.SelectedItems[0].SubItems[1].Text;
                    string model = this.carListView1.SelectedItems[0].SubItems[2].Text;
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + Carrego + " " + Make + " " + model, "Remove Vehicle?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        fleetMan.GetFleet().RemoveAt(index);
                        RefreshFleet();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                    }                 
                }
                else
                {
                    this.carStatuslbl.Text = "This Vehicle is rented by a client.";
                    this.clientErrorProvider.SetError(this.carStatuslbl, "Cannot be removed");
                }
            }
            else
            {
                this.carStatuslbl.Text = "Nothing to remove.";
                this.clientErrorProvider.SetError(this.carStatuslbl, "List is not selected");
            }
        }

        private void rentRentCarbtn_Click(object sender, EventArgs e)
        {
            string vehRego = "";
            int vehindex = -1;
            Vehicle RentalVeh;
            bool done = false;
            int ID = 0;
            int custindx = -1;
            string vehdur = "";
            Customer RentalCust;
            this.clientErrorProvider.Clear();
            if (this.rentRegotb.Text == "")
            {
                this.clientErrorProvider.SetError(this.rentRegotb, "Error - Textbox cannot be empty");
            }
            if(this.rentCustIDtb.Text == "")
            {
                this.clientErrorProvider.SetError(this.rentCustIDtb, "Error - Textbox cannot be empty");
            }
            if (this.rentDurationtb.Text == "")
            {
                this.clientErrorProvider.SetError(this.rentDurationtb, "Error - Textbox cannot be empty");
            }
            if (this.rentRegotb.Text.Length > 0 && this.rentCustIDtb.Text.Length > 0 && this.rentDurationtb.Text.Length > 0)
            {
                vehRego = this.rentRegotb.Text;
                vehindex = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(vehRego));
                vehdur = this.rentDurationtb.Text;
                RentalVeh = fleetMan.GetFleet()[vehindex];

                string regoCheck = vehRego;
                int index = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(regoCheck));

                ID = int.Parse(this.rentCustIDtb.Text);
                custindx = ClientMan.GetList().FindIndex(a => a.c_ID.Equals(ID));
                if(fleetMan.IsRented(ID))
                {
                    this.toolStripStatusLabel1.Text = "A Customer with this ID has already Rented a Car.";
                    this.clientErrorProvider.SetError(this.rentCustIDtb, "Error - Customer Already Rented a Car");
                }
                else if (fleetMan.IsRented(regoCheck))
                {
                    this.toolStripStatusLabel1.Text = "A Vehicle with this Registration has already been Rented.";
                    this.clientErrorProvider.SetError(this.rentRegotb, "Error - Vehicle Already Rented");
                }
                else
                {
                    RentalCust = ClientMan.GetList()[custindx];

                    if (custindx > 0 || vehindex > 0)
                    {
                        done = true;
                        rentals newRental = new rentals();
                        newRental.car_rego = RentalVeh.car_rego;
                        newRental.customerID = RentalCust.c_ID;                        

                        DateTime thisDay = DateTime.Today;
                        string DR = thisDay.ToString("d");
                        var parts = DR.Split('/');
                        newRental.DateOfRental = parts[1] + "/" + parts[0] + "/" + parts[2];
                        newRental.RentalDuration = int.Parse(vehdur);                        
                        fleetMan.GetRentals().Add(newRental);
                    }
               
                    if (done)
                    {
                        rentRegotb.Text = "";
                        this.rentCustIDtb.Text = "";
                        this.rentDurationtb.Text = "";
                        RefreshRentals();
                        this.toolStripStatusLabel1.Text = "Added New Rental to List";
                    }
                    else
                    {
                        this.toolStripStatusLabel1.Text = "Could not Find the requested information";
                        //this.clientErrorProvider.SetError(this.toolStripStatusLabel1, "Rental information missing");

                    }
                }
            }
        }

        private void RefreshRentals()
        {
            this.rentListView.Items.Clear();
            foreach (rentals rnts in fleetMan.GetRentals())
            {
                string vehRego = "";
                int vehindex = 0;
                Vehicle RentalVeh;

                int ID = 0;
                int custindx = 0;
                Customer RentalCust;

                vehRego = rnts.car_rego;
                vehindex = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(vehRego));
                RentalVeh = fleetMan.GetFleet()[vehindex];

                ID = int.Parse(rnts.customerID.ToString());
                custindx = ClientMan.GetList().FindIndex(a => a.c_ID.Equals(ID));
                RentalCust = ClientMan.GetList()[custindx];

                string[] newArr = new string[8];
                //Add first item
                newArr[0] = rnts.customerID.ToString();
                newArr[1] = RentalCust.c_Title + " " + RentalCust.c_FirstName + " " + RentalCust.c_LastName;
                newArr[2] = rnts.car_rego;
                newArr[3] = RentalVeh.car_colour + " " + RentalVeh.car_class + " " + RentalVeh.car_year + " " + RentalVeh.car_make + " " + RentalVeh.car_model;
                decimal dr = decimal.Parse(RentalVeh.car_Drate.ToString());
                string drate = String.Format("{0:C}", dr);
                newArr[4] = drate;
                newArr[5] = rnts.DateOfRental;
                newArr[6] = rnts.RentalDuration.ToString();
                double Costings = RentalVeh.car_Drate * rnts.RentalDuration;
                decimal costs = decimal.Parse(Costings.ToString());
                string outCosts = String.Format("{0:C}", costs);
                newArr[7] = outCosts;

                ListViewItem itm = new ListViewItem(newArr);
                this.rentListView.Items.Add(itm);
            }
        }

        private void rentCustIDimportbtn_Click(object sender, EventArgs e)
        {
            this.clientErrorProvider.Clear();
            if (this.clientListView1.SelectedItems.Count > 0)
            {
                this.rentCustIDtb.Text = this.clientListView1.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                if (this.rentCustIDtb.Text == "")
                {
                    this.clientErrorProvider.SetError(this.rentCustIDtb, "Select a client from client list and hit Import to add to rentals");
                }
            }
        }

        private void rentRegoImportbtn_Click(object sender, EventArgs e)
        {
            this.clientErrorProvider.Clear();
            if (this.carListView1.SelectedItems.Count > 0)
            {
                this.rentRegotb.Text = this.carListView1.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                if (this.rentRegotb.Text == "")
                {
                    this.clientErrorProvider.SetError(this.rentRegotb, "Select a Vehicle from Vehicle list and hit Import to add to rentals");
                }
            }
        }

        private void carDispSearchbtn_Click(object sender, EventArgs e)
        {
            string text = this.carSearchBox.Text;
            int v1 = int.Parse(vehMinUD.Value.ToString());
            int v2 = int.Parse(vehMaxUD.Value.ToString());
            //if (text == "")
            // text = "Red AND Luxury AND GPS";
            //text = "Red OR White OR Grey";
            //text = "White AND Luxury";
            //text = "DailyRate > 100";

            if (text == "")
            {
                startTimer();
                this.carStatuslbl.Show();
                this.carStatuslbl.Text = "Cannot Search for nothing";
            }
            else
            {
                startTimer();
                this.carStatuslbl.Show();
                this.carStatuslbl.Text = "Search for " + text;// + " Vehicles Presented";

                string[] results;
                results = fleetMan.search(text,v2,v1);
                this.carListView1.Items.Clear();
                bool foundOne = false;
                for (int i = 0; i < results.Count(); i++)
                {
                    if (results[i] != null)
                    {
                        foundOne = true;
                        foreach (Vehicle Veh in fleetMan.GetFleet())
                        {
                            if (results[i] == Veh.car_rego)
                            {
                                string[] newArr = new string[12];
                                newArr[0] = Veh.car_rego;
                                newArr[1] = Veh.car_make;
                                newArr[2] = Veh.car_model;
                                newArr[3] = Veh.car_year;
                                newArr[4] = Veh.car_class.ToString();
                                newArr[5] = Veh.car_numSeats.ToString();
                                newArr[6] = Veh.car_trans.ToString();
                                newArr[7] = Veh.car_fuel.ToString();
                                newArr[8] = Veh.car_GPS.ToString();
                                newArr[9] = Veh.car_sunroof.ToString();
                                newArr[10] = Veh.car_colour;
                                decimal dr = decimal.Parse(Veh.car_Drate.ToString());
                                string drate = String.Format("{0:C}", dr);
                                newArr[11] = drate;

                                ListViewItem itm = new ListViewItem(newArr);
                                this.carListView1.Items.Add(itm);
                            }
                        }
                    }
                }
                if (!foundOne)
                {
                    startTimer();
                    this.carStatuslbl.Show();
                    this.carStatuslbl.Text = "No Items Found";
                }
            }
        }        

        public void startTimer()
        {
            timer = new System.Windows.Forms.Timer() { Interval = intervalTime };
            timer.Tick += new EventHandler(OnTimerEvent);
            timer.Start();
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            this.carStatuslbl.Visible = false; // hides wordLabel
            timer.Stop();
        }

        private void carClearbtn_Click(object sender, EventArgs e)
        {
            this.carSearchBox.Text = "";
            startTimer();
            this.carStatuslbl.Show();
            this.carStatuslbl.Text = "Search Cleared";
            RefreshFleet();
        }

        private void reportClientbtn_Click(object sender, EventArgs e)
        {
            if (reportsRb1.Checked || reportsRb2.Checked)
            {
                Form2 reportForm = new Form2();
                reportForm.Show();
                int i = 0;
                if (reportsRb1.Checked)
                {
                    string[] textArray = new string[fleetMan.GetRentals().Count()];

                    string vehRego = "";
                    int vehindex = 0;
                    Vehicle RentalVeh;
                    int ID = 0;
                    int custindx = 0;
                    Customer RentalCust;

                    foreach (rentals rnt in fleetMan.GetRentals())
                    {
                        vehRego = rnt.car_rego;
                        vehindex = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(vehRego));
                        RentalVeh = fleetMan.GetFleet()[vehindex];
                        ID = int.Parse(rnt.customerID.ToString());
                        custindx = ClientMan.GetList().FindIndex(a => a.c_ID.Equals(ID));
                        RentalCust = ClientMan.GetList()[custindx];

                        decimal dr = decimal.Parse(RentalVeh.car_Drate.ToString());
                        string drate = String.Format("{0:C}", dr);
                        string ClassOutstr = "";
                        if (RentalVeh.car_class.ToString() == "Family")
                        { ClassOutstr = "Family     ";  }
                        else
                        {
                            ClassOutstr = RentalVeh.car_class.ToString();
                        }

                        textArray[i] = RentalCust.c_ID + "\t " + RentalCust.c_Title + " " + RentalCust.c_FirstName + "\t " + RentalCust.c_LastName + " \t - " +
                                            RentalVeh.car_rego + " \t - " + ClassOutstr + " \t " + RentalVeh.car_year + " \t " + RentalVeh.car_make + "\t " + RentalVeh.car_model
                                       + "\t " + RentalVeh.car_colour + "\t " + RentalVeh.car_fuel + "\t " + drate + " per day";
                        i++;
                    }

                    Array.Sort(textArray, StringComparer.InvariantCulture);
                    reportForm.set_ReportText(textArray);
                }
                if (reportsRb2.Checked)
                {
                    string[] textArray = new string[fleetMan.GetRentals().Count()];

                    string vehRego = "";
                    int vehindex = 0;
                    Vehicle RentalVeh;
                    int ID = 0;
                    int custindx = 0;
                    Customer RentalCust;

                    foreach (rentals rnt in fleetMan.GetRentals())
                    {
                        vehRego = rnt.car_rego;
                        vehindex = fleetMan.GetFleet().FindIndex(a => a.car_rego.Equals(vehRego));
                        RentalVeh = fleetMan.GetFleet()[vehindex];
                        ID = int.Parse(rnt.customerID.ToString());
                        custindx = ClientMan.GetList().FindIndex(a => a.c_ID.Equals(ID));
                        RentalCust = ClientMan.GetList()[custindx];

                        textArray[i] = RentalVeh.car_rego + " - " + RentalVeh.car_class + "\t " + RentalVeh.car_year + "\t " + RentalVeh.car_make + "\t " + RentalVeh.car_model
                                       + "\t " + RentalVeh.car_colour + "\t " + RentalVeh.car_fuel + "\t $" + RentalVeh.car_Drate +" per day"
                                       + "\t - " + RentalCust.c_ID + " " + RentalCust.c_Title + " " + RentalCust.c_FirstName + " " + RentalCust.c_LastName;
                        i++;

                    }
                    Array.Sort(textArray, StringComparer.InvariantCulture);
                    reportForm.set_ReportText(textArray);
                }
            }
        }

        private void rentReturnCarbtn_Click(object sender, EventArgs e)
        {
            if (this.rentListView.SelectedIndices.Count > 0)
            {
                string ID = this.rentListView.SelectedItems[0].SubItems[2].Text;
                int index = fleetMan.GetRentals().FindIndex(a => a.car_rego.Equals(ID));

                string Name = this.rentListView.SelectedItems[0].SubItems[1].Text;
                string Owing = this.rentListView.SelectedItems[0].SubItems[7].Text;
                string Car = this.rentListView.SelectedItems[0].SubItems[3].Text;
                string MboxOut = Name + " returned " + Car + " and owes " + Owing;
                System.Windows.Forms.MessageBox.Show(MboxOut);

                fleetMan.GetRentals().RemoveAt(index);
                RefreshRentals();
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Nothing to remove.";
                this.clientErrorProvider.SetError(this.rentReturnCarbtn, "List is not selected");
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
