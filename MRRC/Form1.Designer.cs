using System.Windows.Forms;

namespace MRRC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clientFirstNamelbl = new System.Windows.Forms.Label();
            this.clientAddbtn = new System.Windows.Forms.Button();
            this.clientRemovebtn = new System.Windows.Forms.Button();
            this.clientModbtn = new System.Windows.Forms.Button();
            this.clientIdlbl = new System.Windows.Forms.Label();
            this.clientIdTbx = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.GroupBox();
            this.clientStatuslbl = new System.Windows.Forms.Label();
            this.clientListView1 = new System.Windows.Forms.ListView();
            this.clientGenderCbox = new System.Windows.Forms.ComboBox();
            this.clientGenderlbl = new System.Windows.Forms.Label();
            this.clientSurnameTxtbox = new System.Windows.Forms.TextBox();
            this.clientSurnamelbl = new System.Windows.Forms.Label();
            this.clientTitleCbox = new System.Windows.Forms.ComboBox();
            this.clientTitlelbl = new System.Windows.Forms.Label();
            this.clientgenIDbtn = new System.Windows.Forms.Button();
            this.clientDobTbx = new System.Windows.Forms.TextBox();
            this.clientFirstNameTbx = new System.Windows.Forms.TextBox();
            this.clientDoblbl = new System.Windows.Forms.Label();
            this.clientLoadbtn = new System.Windows.Forms.Button();
            this.clientSavebtn = new System.Windows.Forms.Button();
            this.clientRefreshbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carClearbtn = new System.Windows.Forms.Button();
            this.carStatuslbl = new System.Windows.Forms.Label();
            this.carListView1 = new System.Windows.Forms.ListView();
            this.carDispSearchbtn = new System.Windows.Forms.Button();
            this.carSearchBox = new System.Windows.Forms.TextBox();
            this.carSearchlbl = new System.Windows.Forms.Label();
            this.carClasscb = new System.Windows.Forms.ComboBox();
            this.carFuelcb = new System.Windows.Forms.ComboBox();
            this.carTranscb = new System.Windows.Forms.ComboBox();
            this.carGpscb = new System.Windows.Forms.CheckBox();
            this.carSunRoofcb = new System.Windows.Forms.CheckBox();
            this.carDratetb = new System.Windows.Forms.TextBox();
            this.carDratelbl = new System.Windows.Forms.Label();
            this.carColourtb = new System.Windows.Forms.TextBox();
            this.carColourlbl = new System.Windows.Forms.Label();
            this.carFuellbl = new System.Windows.Forms.Label();
            this.carTranslbl = new System.Windows.Forms.Label();
            this.carSeatstb = new System.Windows.Forms.TextBox();
            this.carNseatslbl = new System.Windows.Forms.Label();
            this.carClasslbl = new System.Windows.Forms.Label();
            this.carYeartb = new System.Windows.Forms.TextBox();
            this.carYearlbl = new System.Windows.Forms.Label();
            this.carModeltb = new System.Windows.Forms.TextBox();
            this.carModbtn = new System.Windows.Forms.Button();
            this.carRemCbtn = new System.Windows.Forms.Button();
            this.carAddbtn = new System.Windows.Forms.Button();
            this.carModellbl = new System.Windows.Forms.Label();
            this.carMakeTb = new System.Windows.Forms.TextBox();
            this.carMakelbl = new System.Windows.Forms.Label();
            this.carRegoTb = new System.Windows.Forms.TextBox();
            this.carRegolbl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataHandling = new System.Windows.Forms.GroupBox();
            this.rentalsGB = new System.Windows.Forms.GroupBox();
            this.rentDurationtb = new System.Windows.Forms.TextBox();
            this.rentDurationlbl = new System.Windows.Forms.Label();
            this.rentRegoImportbtn = new System.Windows.Forms.Button();
            this.rentCustIDimportbtn = new System.Windows.Forms.Button();
            this.rentRentCarbtn = new System.Windows.Forms.Button();
            this.rentReturnCarbtn = new System.Windows.Forms.Button();
            this.rentRegotb = new System.Windows.Forms.TextBox();
            this.rentCarRegolbl = new System.Windows.Forms.Label();
            this.rentCustIDtb = new System.Windows.Forms.TextBox();
            this.rentCustIDlbl = new System.Windows.Forms.Label();
            this.rentListView = new System.Windows.Forms.ListView();
            this.reportClientbtn = new System.Windows.Forms.Button();
            this.ReportingBox = new System.Windows.Forms.GroupBox();
            this.reportsRb2 = new System.Windows.Forms.RadioButton();
            this.reportsRb1 = new System.Windows.Forms.RadioButton();
            this.clientErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.vehMinUD = new System.Windows.Forms.NumericUpDown();
            this.vehMaxUD = new System.Windows.Forms.NumericUpDown();
            this.vehCostRangelbl = new System.Windows.Forms.Label();
            this.clientBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.rentalsGB.SuspendLayout();
            this.ReportingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehMinUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehMaxUD)).BeginInit();
            this.SuspendLayout();
            // 
            // clientFirstNamelbl
            // 
            this.clientFirstNamelbl.AutoSize = true;
            this.clientFirstNamelbl.Location = new System.Drawing.Point(442, 124);
            this.clientFirstNamelbl.Name = "clientFirstNamelbl";
            this.clientFirstNamelbl.Size = new System.Drawing.Size(57, 13);
            this.clientFirstNamelbl.TabIndex = 0;
            this.clientFirstNamelbl.Text = "First Name";
            // 
            // clientAddbtn
            // 
            this.clientAddbtn.Location = new System.Drawing.Point(6, 21);
            this.clientAddbtn.Name = "clientAddbtn";
            this.clientAddbtn.Size = new System.Drawing.Size(95, 35);
            this.clientAddbtn.TabIndex = 6;
            this.clientAddbtn.Text = "Add Customer";
            this.clientAddbtn.UseVisualStyleBackColor = true;
            this.clientAddbtn.Click += new System.EventHandler(this.clientAddbtn_Click);
            // 
            // clientRemovebtn
            // 
            this.clientRemovebtn.Location = new System.Drawing.Point(107, 21);
            this.clientRemovebtn.Name = "clientRemovebtn";
            this.clientRemovebtn.Size = new System.Drawing.Size(95, 35);
            this.clientRemovebtn.TabIndex = 7;
            this.clientRemovebtn.Text = "Remove Customer";
            this.clientRemovebtn.UseVisualStyleBackColor = true;
            this.clientRemovebtn.Click += new System.EventHandler(this.clientRemovebtn_Click);
            // 
            // clientModbtn
            // 
            this.clientModbtn.Location = new System.Drawing.Point(208, 21);
            this.clientModbtn.Name = "clientModbtn";
            this.clientModbtn.Size = new System.Drawing.Size(95, 35);
            this.clientModbtn.TabIndex = 8;
            this.clientModbtn.Text = "Modify Customer";
            this.clientModbtn.UseVisualStyleBackColor = true;
            this.clientModbtn.Click += new System.EventHandler(this.clientModbtn_Click);
            // 
            // clientIdlbl
            // 
            this.clientIdlbl.AutoSize = true;
            this.clientIdlbl.Location = new System.Drawing.Point(442, 45);
            this.clientIdlbl.Name = "clientIdlbl";
            this.clientIdlbl.Size = new System.Drawing.Size(57, 13);
            this.clientIdlbl.TabIndex = 11;
            this.clientIdlbl.Text = "Client ID #";
            // 
            // clientIdTbx
            // 
            this.clientIdTbx.Location = new System.Drawing.Point(445, 61);
            this.clientIdTbx.Name = "clientIdTbx";
            this.clientIdTbx.Size = new System.Drawing.Size(126, 20);
            this.clientIdTbx.TabIndex = 12;
            // 
            // clientBox
            // 
            this.clientBox.Controls.Add(this.clientStatuslbl);
            this.clientBox.Controls.Add(this.clientListView1);
            this.clientBox.Controls.Add(this.clientGenderCbox);
            this.clientBox.Controls.Add(this.clientGenderlbl);
            this.clientBox.Controls.Add(this.clientAddbtn);
            this.clientBox.Controls.Add(this.clientRemovebtn);
            this.clientBox.Controls.Add(this.clientSurnameTxtbox);
            this.clientBox.Controls.Add(this.clientIdlbl);
            this.clientBox.Controls.Add(this.clientIdTbx);
            this.clientBox.Controls.Add(this.clientSurnamelbl);
            this.clientBox.Controls.Add(this.clientTitleCbox);
            this.clientBox.Controls.Add(this.clientTitlelbl);
            this.clientBox.Controls.Add(this.clientgenIDbtn);
            this.clientBox.Controls.Add(this.clientModbtn);
            this.clientBox.Controls.Add(this.clientDobTbx);
            this.clientBox.Controls.Add(this.clientFirstNamelbl);
            this.clientBox.Controls.Add(this.clientFirstNameTbx);
            this.clientBox.Controls.Add(this.clientDoblbl);
            this.clientBox.Location = new System.Drawing.Point(12, 12);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(600, 466);
            this.clientBox.TabIndex = 13;
            this.clientBox.TabStop = false;
            this.clientBox.Text = "Client Details";
            // 
            // clientStatuslbl
            // 
            this.clientStatuslbl.AutoSize = true;
            this.clientStatuslbl.Location = new System.Drawing.Point(14, 434);
            this.clientStatuslbl.Name = "clientStatuslbl";
            this.clientStatuslbl.Size = new System.Drawing.Size(35, 13);
            this.clientStatuslbl.TabIndex = 22;
            this.clientStatuslbl.Text = "label1";
            // 
            // clientListView1
            // 
            this.clientListView1.FullRowSelect = true;
            this.clientListView1.GridLines = true;
            this.clientListView1.Location = new System.Drawing.Point(9, 68);
            this.clientListView1.Name = "clientListView1";
            this.clientListView1.Size = new System.Drawing.Size(427, 353);
            this.clientListView1.TabIndex = 21;
            this.clientListView1.UseCompatibleStateImageBehavior = false;
            this.clientListView1.View = System.Windows.Forms.View.Details;
            // 
            // clientGenderCbox
            // 
            this.clientGenderCbox.FormattingEnabled = true;
            this.clientGenderCbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.clientGenderCbox.Location = new System.Drawing.Point(445, 218);
            this.clientGenderCbox.Name = "clientGenderCbox";
            this.clientGenderCbox.Size = new System.Drawing.Size(126, 21);
            this.clientGenderCbox.TabIndex = 17;
            // 
            // clientGenderlbl
            // 
            this.clientGenderlbl.AutoSize = true;
            this.clientGenderlbl.Location = new System.Drawing.Point(442, 202);
            this.clientGenderlbl.Name = "clientGenderlbl";
            this.clientGenderlbl.Size = new System.Drawing.Size(42, 13);
            this.clientGenderlbl.TabIndex = 16;
            this.clientGenderlbl.Text = "Gender";
            // 
            // clientSurnameTxtbox
            // 
            this.clientSurnameTxtbox.Location = new System.Drawing.Point(445, 179);
            this.clientSurnameTxtbox.Name = "clientSurnameTxtbox";
            this.clientSurnameTxtbox.Size = new System.Drawing.Size(126, 20);
            this.clientSurnameTxtbox.TabIndex = 15;
            // 
            // clientSurnamelbl
            // 
            this.clientSurnamelbl.AutoSize = true;
            this.clientSurnamelbl.Location = new System.Drawing.Point(442, 163);
            this.clientSurnamelbl.Name = "clientSurnamelbl";
            this.clientSurnamelbl.Size = new System.Drawing.Size(49, 13);
            this.clientSurnamelbl.TabIndex = 14;
            this.clientSurnamelbl.Text = "Surname";
            // 
            // clientTitleCbox
            // 
            this.clientTitleCbox.FormattingEnabled = true;
            this.clientTitleCbox.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms"});
            this.clientTitleCbox.Location = new System.Drawing.Point(445, 100);
            this.clientTitleCbox.Name = "clientTitleCbox";
            this.clientTitleCbox.Size = new System.Drawing.Size(126, 21);
            this.clientTitleCbox.TabIndex = 13;
            // 
            // clientTitlelbl
            // 
            this.clientTitlelbl.AutoSize = true;
            this.clientTitlelbl.Location = new System.Drawing.Point(442, 84);
            this.clientTitlelbl.Name = "clientTitlelbl";
            this.clientTitlelbl.Size = new System.Drawing.Size(27, 13);
            this.clientTitlelbl.TabIndex = 12;
            this.clientTitlelbl.Text = "Title";
            // 
            // clientgenIDbtn
            // 
            this.clientgenIDbtn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientgenIDbtn.Location = new System.Drawing.Point(505, 36);
            this.clientgenIDbtn.Name = "clientgenIDbtn";
            this.clientgenIDbtn.Size = new System.Drawing.Size(66, 20);
            this.clientgenIDbtn.TabIndex = 11;
            this.clientgenIDbtn.Text = "Generate";
            this.clientgenIDbtn.UseVisualStyleBackColor = true;
            this.clientgenIDbtn.Click += new System.EventHandler(this.genIDbtn_Click);
            // 
            // clientDobTbx
            // 
            this.clientDobTbx.Location = new System.Drawing.Point(445, 258);
            this.clientDobTbx.Name = "clientDobTbx";
            this.clientDobTbx.Size = new System.Drawing.Size(126, 20);
            this.clientDobTbx.TabIndex = 5;
            // 
            // clientFirstNameTbx
            // 
            this.clientFirstNameTbx.Location = new System.Drawing.Point(445, 140);
            this.clientFirstNameTbx.Name = "clientFirstNameTbx";
            this.clientFirstNameTbx.Size = new System.Drawing.Size(126, 20);
            this.clientFirstNameTbx.TabIndex = 1;
            // 
            // clientDoblbl
            // 
            this.clientDoblbl.AutoSize = true;
            this.clientDoblbl.Location = new System.Drawing.Point(442, 242);
            this.clientDoblbl.Name = "clientDoblbl";
            this.clientDoblbl.Size = new System.Drawing.Size(65, 13);
            this.clientDoblbl.TabIndex = 4;
            this.clientDoblbl.Text = "Date of birth";
            // 
            // clientLoadbtn
            // 
            this.clientLoadbtn.Location = new System.Drawing.Point(26, 582);
            this.clientLoadbtn.Name = "clientLoadbtn";
            this.clientLoadbtn.Size = new System.Drawing.Size(75, 34);
            this.clientLoadbtn.TabIndex = 20;
            this.clientLoadbtn.Text = "Load";
            this.clientLoadbtn.UseVisualStyleBackColor = true;
            this.clientLoadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // clientSavebtn
            // 
            this.clientSavebtn.Location = new System.Drawing.Point(26, 542);
            this.clientSavebtn.Name = "clientSavebtn";
            this.clientSavebtn.Size = new System.Drawing.Size(75, 34);
            this.clientSavebtn.TabIndex = 19;
            this.clientSavebtn.Text = "Save";
            this.clientSavebtn.UseVisualStyleBackColor = true;
            this.clientSavebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // clientRefreshbtn
            // 
            this.clientRefreshbtn.Location = new System.Drawing.Point(26, 501);
            this.clientRefreshbtn.Name = "clientRefreshbtn";
            this.clientRefreshbtn.Size = new System.Drawing.Size(75, 35);
            this.clientRefreshbtn.TabIndex = 18;
            this.clientRefreshbtn.Text = "Refresh";
            this.clientRefreshbtn.UseVisualStyleBackColor = true;
            this.clientRefreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vehCostRangelbl);
            this.groupBox1.Controls.Add(this.vehMaxUD);
            this.groupBox1.Controls.Add(this.vehMinUD);
            this.groupBox1.Controls.Add(this.carClearbtn);
            this.groupBox1.Controls.Add(this.carStatuslbl);
            this.groupBox1.Controls.Add(this.carListView1);
            this.groupBox1.Controls.Add(this.carDispSearchbtn);
            this.groupBox1.Controls.Add(this.carSearchBox);
            this.groupBox1.Controls.Add(this.carSearchlbl);
            this.groupBox1.Controls.Add(this.carClasscb);
            this.groupBox1.Controls.Add(this.carFuelcb);
            this.groupBox1.Controls.Add(this.carTranscb);
            this.groupBox1.Controls.Add(this.carGpscb);
            this.groupBox1.Controls.Add(this.carSunRoofcb);
            this.groupBox1.Controls.Add(this.carDratetb);
            this.groupBox1.Controls.Add(this.carDratelbl);
            this.groupBox1.Controls.Add(this.carColourtb);
            this.groupBox1.Controls.Add(this.carColourlbl);
            this.groupBox1.Controls.Add(this.carFuellbl);
            this.groupBox1.Controls.Add(this.carTranslbl);
            this.groupBox1.Controls.Add(this.carSeatstb);
            this.groupBox1.Controls.Add(this.carNseatslbl);
            this.groupBox1.Controls.Add(this.carClasslbl);
            this.groupBox1.Controls.Add(this.carYeartb);
            this.groupBox1.Controls.Add(this.carYearlbl);
            this.groupBox1.Controls.Add(this.carModeltb);
            this.groupBox1.Controls.Add(this.carModbtn);
            this.groupBox1.Controls.Add(this.carRemCbtn);
            this.groupBox1.Controls.Add(this.carAddbtn);
            this.groupBox1.Controls.Add(this.carModellbl);
            this.groupBox1.Controls.Add(this.carMakeTb);
            this.groupBox1.Controls.Add(this.carMakelbl);
            this.groupBox1.Controls.Add(this.carRegoTb);
            this.groupBox1.Controls.Add(this.carRegolbl);
            this.groupBox1.Location = new System.Drawing.Point(618, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 466);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Details";
            // 
            // carClearbtn
            // 
            this.carClearbtn.Location = new System.Drawing.Point(274, 434);
            this.carClearbtn.Name = "carClearbtn";
            this.carClearbtn.Size = new System.Drawing.Size(60, 23);
            this.carClearbtn.TabIndex = 49;
            this.carClearbtn.Text = "Clear";
            this.carClearbtn.UseVisualStyleBackColor = true;
            this.carClearbtn.Click += new System.EventHandler(this.carClearbtn_Click);
            // 
            // carStatuslbl
            // 
            this.carStatuslbl.AutoSize = true;
            this.carStatuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carStatuslbl.Location = new System.Drawing.Point(340, 439);
            this.carStatuslbl.Name = "carStatuslbl";
            this.carStatuslbl.Size = new System.Drawing.Size(35, 13);
            this.carStatuslbl.TabIndex = 48;
            this.carStatuslbl.Text = "status";
            // 
            // carListView1
            // 
            this.carListView1.FullRowSelect = true;
            this.carListView1.GridLines = true;
            this.carListView1.Location = new System.Drawing.Point(6, 68);
            this.carListView1.Name = "carListView1";
            this.carListView1.Size = new System.Drawing.Size(597, 327);
            this.carListView1.TabIndex = 47;
            this.carListView1.UseCompatibleStateImageBehavior = false;
            this.carListView1.View = System.Windows.Forms.View.Details;
            this.carListView1.SelectedIndexChanged += new System.EventHandler(this.carListView1_SelectedIndexChanged);
            // 
            // carDispSearchbtn
            // 
            this.carDispSearchbtn.Location = new System.Drawing.Point(208, 434);
            this.carDispSearchbtn.Name = "carDispSearchbtn";
            this.carDispSearchbtn.Size = new System.Drawing.Size(60, 23);
            this.carDispSearchbtn.TabIndex = 46;
            this.carDispSearchbtn.Text = "Search";
            this.carDispSearchbtn.UseVisualStyleBackColor = true;
            this.carDispSearchbtn.Click += new System.EventHandler(this.carDispSearchbtn_Click);
            // 
            // carSearchBox
            // 
            this.carSearchBox.Location = new System.Drawing.Point(10, 437);
            this.carSearchBox.Name = "carSearchBox";
            this.carSearchBox.Size = new System.Drawing.Size(192, 20);
            this.carSearchBox.TabIndex = 45;
            // 
            // carSearchlbl
            // 
            this.carSearchlbl.AutoSize = true;
            this.carSearchlbl.Location = new System.Drawing.Point(10, 421);
            this.carSearchlbl.Name = "carSearchlbl";
            this.carSearchlbl.Size = new System.Drawing.Size(41, 13);
            this.carSearchlbl.TabIndex = 44;
            this.carSearchlbl.Text = "Search";
            // 
            // carClasscb
            // 
            this.carClasscb.FormattingEnabled = true;
            this.carClasscb.Items.AddRange(new object[] {
            "Luxury",
            "Family",
            "Commercial",
            "Economy"});
            this.carClasscb.Location = new System.Drawing.Point(612, 217);
            this.carClasscb.Name = "carClasscb";
            this.carClasscb.Size = new System.Drawing.Size(126, 21);
            this.carClasscb.TabIndex = 43;
            // 
            // carFuelcb
            // 
            this.carFuelcb.FormattingEnabled = true;
            this.carFuelcb.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.carFuelcb.Location = new System.Drawing.Point(612, 338);
            this.carFuelcb.Name = "carFuelcb";
            this.carFuelcb.Size = new System.Drawing.Size(126, 21);
            this.carFuelcb.TabIndex = 42;
            // 
            // carTranscb
            // 
            this.carTranscb.FormattingEnabled = true;
            this.carTranscb.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.carTranscb.Location = new System.Drawing.Point(612, 297);
            this.carTranscb.Name = "carTranscb";
            this.carTranscb.Size = new System.Drawing.Size(126, 21);
            this.carTranscb.TabIndex = 41;
            // 
            // carGpscb
            // 
            this.carGpscb.AutoSize = true;
            this.carGpscb.Location = new System.Drawing.Point(696, 440);
            this.carGpscb.Name = "carGpscb";
            this.carGpscb.Size = new System.Drawing.Size(48, 17);
            this.carGpscb.TabIndex = 40;
            this.carGpscb.Text = "GPS";
            this.carGpscb.UseVisualStyleBackColor = true;
            // 
            // carSunRoofcb
            // 
            this.carSunRoofcb.AutoSize = true;
            this.carSunRoofcb.Location = new System.Drawing.Point(612, 440);
            this.carSunRoofcb.Name = "carSunRoofcb";
            this.carSunRoofcb.Size = new System.Drawing.Size(68, 17);
            this.carSunRoofcb.TabIndex = 39;
            this.carSunRoofcb.Text = "SunRoof";
            this.carSunRoofcb.UseVisualStyleBackColor = true;
            // 
            // carDratetb
            // 
            this.carDratetb.Location = new System.Drawing.Point(612, 414);
            this.carDratetb.Name = "carDratetb";
            this.carDratetb.Size = new System.Drawing.Size(126, 20);
            this.carDratetb.TabIndex = 38;
            // 
            // carDratelbl
            // 
            this.carDratelbl.AutoSize = true;
            this.carDratelbl.Location = new System.Drawing.Point(609, 398);
            this.carDratelbl.Name = "carDratelbl";
            this.carDratelbl.Size = new System.Drawing.Size(56, 13);
            this.carDratelbl.TabIndex = 37;
            this.carDratelbl.Text = "Daily Rate";
            // 
            // carColourtb
            // 
            this.carColourtb.Location = new System.Drawing.Point(612, 375);
            this.carColourtb.Name = "carColourtb";
            this.carColourtb.Size = new System.Drawing.Size(126, 20);
            this.carColourtb.TabIndex = 36;
            // 
            // carColourlbl
            // 
            this.carColourlbl.AutoSize = true;
            this.carColourlbl.Location = new System.Drawing.Point(609, 360);
            this.carColourlbl.Name = "carColourlbl";
            this.carColourlbl.Size = new System.Drawing.Size(37, 13);
            this.carColourlbl.TabIndex = 35;
            this.carColourlbl.Text = "Colour";
            // 
            // carFuellbl
            // 
            this.carFuellbl.AutoSize = true;
            this.carFuellbl.Location = new System.Drawing.Point(609, 321);
            this.carFuellbl.Name = "carFuellbl";
            this.carFuellbl.Size = new System.Drawing.Size(27, 13);
            this.carFuellbl.TabIndex = 33;
            this.carFuellbl.Text = "Fuel";
            // 
            // carTranslbl
            // 
            this.carTranslbl.AutoSize = true;
            this.carTranslbl.Location = new System.Drawing.Point(609, 278);
            this.carTranslbl.Name = "carTranslbl";
            this.carTranslbl.Size = new System.Drawing.Size(68, 13);
            this.carTranslbl.TabIndex = 31;
            this.carTranslbl.Text = "Transmission";
            // 
            // carSeatstb
            // 
            this.carSeatstb.Location = new System.Drawing.Point(612, 255);
            this.carSeatstb.Name = "carSeatstb";
            this.carSeatstb.Size = new System.Drawing.Size(126, 20);
            this.carSeatstb.TabIndex = 30;
            // 
            // carNseatslbl
            // 
            this.carNseatslbl.AutoSize = true;
            this.carNseatslbl.Location = new System.Drawing.Point(609, 239);
            this.carNseatslbl.Name = "carNseatslbl";
            this.carNseatslbl.Size = new System.Drawing.Size(54, 13);
            this.carNseatslbl.TabIndex = 29;
            this.carNseatslbl.Text = "# of seats";
            // 
            // carClasslbl
            // 
            this.carClasslbl.AutoSize = true;
            this.carClasslbl.Location = new System.Drawing.Point(609, 200);
            this.carClasslbl.Name = "carClasslbl";
            this.carClasslbl.Size = new System.Drawing.Size(32, 13);
            this.carClasslbl.TabIndex = 27;
            this.carClasslbl.Text = "Class";
            // 
            // carYeartb
            // 
            this.carYeartb.Location = new System.Drawing.Point(612, 176);
            this.carYeartb.Name = "carYeartb";
            this.carYeartb.Size = new System.Drawing.Size(126, 20);
            this.carYeartb.TabIndex = 26;
            // 
            // carYearlbl
            // 
            this.carYearlbl.AutoSize = true;
            this.carYearlbl.Location = new System.Drawing.Point(609, 160);
            this.carYearlbl.Name = "carYearlbl";
            this.carYearlbl.Size = new System.Drawing.Size(29, 13);
            this.carYearlbl.TabIndex = 25;
            this.carYearlbl.Text = "Year";
            // 
            // carModeltb
            // 
            this.carModeltb.Location = new System.Drawing.Point(612, 137);
            this.carModeltb.Name = "carModeltb";
            this.carModeltb.Size = new System.Drawing.Size(126, 20);
            this.carModeltb.TabIndex = 24;
            // 
            // carModbtn
            // 
            this.carModbtn.Location = new System.Drawing.Point(208, 20);
            this.carModbtn.Name = "carModbtn";
            this.carModbtn.Size = new System.Drawing.Size(95, 35);
            this.carModbtn.TabIndex = 18;
            this.carModbtn.Text = "Modify Car details";
            this.carModbtn.UseVisualStyleBackColor = true;
            this.carModbtn.Click += new System.EventHandler(this.carModbtn_Click);
            // 
            // carRemCbtn
            // 
            this.carRemCbtn.Location = new System.Drawing.Point(107, 20);
            this.carRemCbtn.Name = "carRemCbtn";
            this.carRemCbtn.Size = new System.Drawing.Size(95, 35);
            this.carRemCbtn.TabIndex = 17;
            this.carRemCbtn.Text = "Remove Car";
            this.carRemCbtn.UseVisualStyleBackColor = true;
            this.carRemCbtn.Click += new System.EventHandler(this.carRemCbtn_Click);
            // 
            // carAddbtn
            // 
            this.carAddbtn.Location = new System.Drawing.Point(6, 19);
            this.carAddbtn.Name = "carAddbtn";
            this.carAddbtn.Size = new System.Drawing.Size(95, 35);
            this.carAddbtn.TabIndex = 16;
            this.carAddbtn.Text = "Add Car";
            this.carAddbtn.UseVisualStyleBackColor = true;
            this.carAddbtn.Click += new System.EventHandler(this.CDaddbtn_Click);
            // 
            // carModellbl
            // 
            this.carModellbl.AutoSize = true;
            this.carModellbl.Location = new System.Drawing.Point(609, 121);
            this.carModellbl.Name = "carModellbl";
            this.carModellbl.Size = new System.Drawing.Size(36, 13);
            this.carModellbl.TabIndex = 23;
            this.carModellbl.Text = "Model";
            // 
            // carMakeTb
            // 
            this.carMakeTb.Location = new System.Drawing.Point(612, 97);
            this.carMakeTb.Name = "carMakeTb";
            this.carMakeTb.Size = new System.Drawing.Size(126, 20);
            this.carMakeTb.TabIndex = 22;
            // 
            // carMakelbl
            // 
            this.carMakelbl.AutoSize = true;
            this.carMakelbl.Location = new System.Drawing.Point(609, 81);
            this.carMakelbl.Name = "carMakelbl";
            this.carMakelbl.Size = new System.Drawing.Size(34, 13);
            this.carMakelbl.TabIndex = 21;
            this.carMakelbl.Text = "Make";
            // 
            // carRegoTb
            // 
            this.carRegoTb.Location = new System.Drawing.Point(612, 58);
            this.carRegoTb.Name = "carRegoTb";
            this.carRegoTb.Size = new System.Drawing.Size(126, 20);
            this.carRegoTb.TabIndex = 20;
            // 
            // carRegolbl
            // 
            this.carRegolbl.AutoSize = true;
            this.carRegolbl.Location = new System.Drawing.Point(609, 45);
            this.carRegolbl.Name = "carRegolbl";
            this.carRegolbl.Size = new System.Drawing.Size(63, 13);
            this.carRegolbl.TabIndex = 19;
            this.carRegolbl.Text = "Registration";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 738);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1385, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // DataHandling
            // 
            this.DataHandling.Location = new System.Drawing.Point(12, 485);
            this.DataHandling.Name = "DataHandling";
            this.DataHandling.Size = new System.Drawing.Size(101, 250);
            this.DataHandling.TabIndex = 21;
            this.DataHandling.TabStop = false;
            this.DataHandling.Text = "Menu Options";
            // 
            // rentalsGB
            // 
            this.rentalsGB.Controls.Add(this.rentDurationtb);
            this.rentalsGB.Controls.Add(this.rentDurationlbl);
            this.rentalsGB.Controls.Add(this.rentRegoImportbtn);
            this.rentalsGB.Controls.Add(this.rentCustIDimportbtn);
            this.rentalsGB.Controls.Add(this.rentRentCarbtn);
            this.rentalsGB.Controls.Add(this.rentReturnCarbtn);
            this.rentalsGB.Controls.Add(this.rentRegotb);
            this.rentalsGB.Controls.Add(this.rentCarRegolbl);
            this.rentalsGB.Controls.Add(this.rentCustIDtb);
            this.rentalsGB.Controls.Add(this.rentCustIDlbl);
            this.rentalsGB.Controls.Add(this.rentListView);
            this.rentalsGB.Location = new System.Drawing.Point(119, 485);
            this.rentalsGB.Name = "rentalsGB";
            this.rentalsGB.Size = new System.Drawing.Size(1121, 250);
            this.rentalsGB.TabIndex = 22;
            this.rentalsGB.TabStop = false;
            this.rentalsGB.Text = "Vehicle Rentals";
            // 
            // rentDurationtb
            // 
            this.rentDurationtb.Location = new System.Drawing.Point(6, 114);
            this.rentDurationtb.Name = "rentDurationtb";
            this.rentDurationtb.Size = new System.Drawing.Size(114, 20);
            this.rentDurationtb.TabIndex = 10;
            // 
            // rentDurationlbl
            // 
            this.rentDurationlbl.AutoSize = true;
            this.rentDurationlbl.Location = new System.Drawing.Point(6, 98);
            this.rentDurationlbl.Name = "rentDurationlbl";
            this.rentDurationlbl.Size = new System.Drawing.Size(81, 13);
            this.rentDurationlbl.TabIndex = 9;
            this.rentDurationlbl.Text = "Rental Duration";
            // 
            // rentRegoImportbtn
            // 
            this.rentRegoImportbtn.Location = new System.Drawing.Point(138, 69);
            this.rentRegoImportbtn.Name = "rentRegoImportbtn";
            this.rentRegoImportbtn.Size = new System.Drawing.Size(49, 23);
            this.rentRegoImportbtn.TabIndex = 8;
            this.rentRegoImportbtn.Text = "Import";
            this.rentRegoImportbtn.UseVisualStyleBackColor = true;
            this.rentRegoImportbtn.Click += new System.EventHandler(this.rentRegoImportbtn_Click);
            // 
            // rentCustIDimportbtn
            // 
            this.rentCustIDimportbtn.Location = new System.Drawing.Point(138, 28);
            this.rentCustIDimportbtn.Name = "rentCustIDimportbtn";
            this.rentCustIDimportbtn.Size = new System.Drawing.Size(49, 23);
            this.rentCustIDimportbtn.TabIndex = 7;
            this.rentCustIDimportbtn.Text = "Import";
            this.rentCustIDimportbtn.UseVisualStyleBackColor = true;
            this.rentCustIDimportbtn.Click += new System.EventHandler(this.rentCustIDimportbtn_Click);
            // 
            // rentRentCarbtn
            // 
            this.rentRentCarbtn.Location = new System.Drawing.Point(6, 149);
            this.rentRentCarbtn.Name = "rentRentCarbtn";
            this.rentRentCarbtn.Size = new System.Drawing.Size(105, 34);
            this.rentRentCarbtn.TabIndex = 5;
            this.rentRentCarbtn.Text = "Rent Vehicle";
            this.rentRentCarbtn.UseVisualStyleBackColor = true;
            this.rentRentCarbtn.Click += new System.EventHandler(this.rentRentCarbtn_Click);
            // 
            // rentReturnCarbtn
            // 
            this.rentReturnCarbtn.Location = new System.Drawing.Point(1010, 19);
            this.rentReturnCarbtn.Name = "rentReturnCarbtn";
            this.rentReturnCarbtn.Size = new System.Drawing.Size(92, 34);
            this.rentReturnCarbtn.TabIndex = 6;
            this.rentReturnCarbtn.Text = "Return Vehicle";
            this.rentReturnCarbtn.UseVisualStyleBackColor = true;
            this.rentReturnCarbtn.Click += new System.EventHandler(this.rentReturnCarbtn_Click);
            // 
            // rentRegotb
            // 
            this.rentRegotb.Location = new System.Drawing.Point(6, 71);
            this.rentRegotb.Name = "rentRegotb";
            this.rentRegotb.Size = new System.Drawing.Size(115, 20);
            this.rentRegotb.TabIndex = 4;
            // 
            // rentCarRegolbl
            // 
            this.rentCarRegolbl.AutoSize = true;
            this.rentCarRegolbl.Location = new System.Drawing.Point(6, 57);
            this.rentCarRegolbl.Name = "rentCarRegolbl";
            this.rentCarRegolbl.Size = new System.Drawing.Size(92, 13);
            this.rentCarRegolbl.TabIndex = 3;
            this.rentCarRegolbl.Text = "Car Registration #";
            // 
            // rentCustIDtb
            // 
            this.rentCustIDtb.Location = new System.Drawing.Point(6, 30);
            this.rentCustIDtb.Name = "rentCustIDtb";
            this.rentCustIDtb.Size = new System.Drawing.Size(115, 20);
            this.rentCustIDtb.TabIndex = 2;
            // 
            // rentCustIDlbl
            // 
            this.rentCustIDlbl.AutoSize = true;
            this.rentCustIDlbl.Location = new System.Drawing.Point(3, 15);
            this.rentCustIDlbl.Name = "rentCustIDlbl";
            this.rentCustIDlbl.Size = new System.Drawing.Size(75, 13);
            this.rentCustIDlbl.TabIndex = 1;
            this.rentCustIDlbl.Text = "Customer ID #";
            // 
            // rentListView
            // 
            this.rentListView.Location = new System.Drawing.Point(193, 15);
            this.rentListView.Name = "rentListView";
            this.rentListView.Size = new System.Drawing.Size(811, 229);
            this.rentListView.TabIndex = 0;
            this.rentListView.UseCompatibleStateImageBehavior = false;
            // 
            // reportClientbtn
            // 
            this.reportClientbtn.Location = new System.Drawing.Point(7, 87);
            this.reportClientbtn.Name = "reportClientbtn";
            this.reportClientbtn.Size = new System.Drawing.Size(105, 34);
            this.reportClientbtn.TabIndex = 23;
            this.reportClientbtn.Text = "Generate Client Report";
            this.reportClientbtn.UseVisualStyleBackColor = true;
            this.reportClientbtn.Click += new System.EventHandler(this.reportClientbtn_Click);
            // 
            // ReportingBox
            // 
            this.ReportingBox.Controls.Add(this.reportsRb2);
            this.ReportingBox.Controls.Add(this.reportsRb1);
            this.ReportingBox.Controls.Add(this.reportClientbtn);
            this.ReportingBox.Location = new System.Drawing.Point(1246, 485);
            this.ReportingBox.Name = "ReportingBox";
            this.ReportingBox.Size = new System.Drawing.Size(134, 250);
            this.ReportingBox.TabIndex = 23;
            this.ReportingBox.TabStop = false;
            this.ReportingBox.Text = "Reports";
            // 
            // reportsRb2
            // 
            this.reportsRb2.AutoSize = true;
            this.reportsRb2.Location = new System.Drawing.Point(7, 52);
            this.reportsRb2.Name = "reportsRb2";
            this.reportsRb2.Size = new System.Drawing.Size(101, 17);
            this.reportsRb2.TabIndex = 25;
            this.reportsRb2.TabStop = true;
            this.reportsRb2.Text = "Sort by Vehicles";
            this.reportsRb2.UseVisualStyleBackColor = true;
            // 
            // reportsRb1
            // 
            this.reportsRb1.AutoSize = true;
            this.reportsRb1.Location = new System.Drawing.Point(6, 25);
            this.reportsRb1.Name = "reportsRb1";
            this.reportsRb1.Size = new System.Drawing.Size(92, 17);
            this.reportsRb1.TabIndex = 24;
            this.reportsRb1.TabStop = true;
            this.reportsRb1.Text = "Sort by Clients";
            this.reportsRb1.UseVisualStyleBackColor = true;
            // 
            // clientErrorProvider
            // 
            this.clientErrorProvider.BlinkRate = 0;
            this.clientErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.clientErrorProvider.ContainerControl = this;
            this.clientErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("clientErrorProvider.Icon")));
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // vehMinUD
            // 
            this.vehMinUD.Location = new System.Drawing.Point(79, 400);
            this.vehMinUD.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.vehMinUD.Name = "vehMinUD";
            this.vehMinUD.Size = new System.Drawing.Size(49, 20);
            this.vehMinUD.TabIndex = 50;
            // 
            // vehMaxUD
            // 
            this.vehMaxUD.Location = new System.Drawing.Point(134, 400);
            this.vehMaxUD.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.vehMaxUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vehMaxUD.Name = "vehMaxUD";
            this.vehMaxUD.Size = new System.Drawing.Size(41, 20);
            this.vehMaxUD.TabIndex = 51;
            this.vehMaxUD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // vehCostRangelbl
            // 
            this.vehCostRangelbl.AutoSize = true;
            this.vehCostRangelbl.Location = new System.Drawing.Point(10, 401);
            this.vehCostRangelbl.Name = "vehCostRangelbl";
            this.vehCostRangelbl.Size = new System.Drawing.Size(63, 13);
            this.vehCostRangelbl.TabIndex = 52;
            this.vehCostRangelbl.Text = "Cost Range";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 760);
            this.Controls.Add(this.ReportingBox);
            this.Controls.Add(this.rentalsGB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.clientLoadbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientSavebtn);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.clientRefreshbtn);
            this.Controls.Add(this.DataHandling);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mates Rates Rental Company";
            this.clientBox.ResumeLayout(false);
            this.clientBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.rentalsGB.ResumeLayout(false);
            this.rentalsGB.PerformLayout();
            this.ReportingBox.ResumeLayout(false);
            this.ReportingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehMinUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehMaxUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientFirstNamelbl;
        private System.Windows.Forms.Button clientAddbtn;
        private System.Windows.Forms.Button clientRemovebtn;
        private System.Windows.Forms.Button clientModbtn;
        private System.Windows.Forms.Label clientIdlbl;
        private System.Windows.Forms.TextBox clientIdTbx;
        private System.Windows.Forms.GroupBox clientBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button carModbtn;
        private System.Windows.Forms.Button carAddbtn;
        private System.Windows.Forms.Button carRemCbtn;
        private System.Windows.Forms.TextBox clientFirstNameTbx;
        private System.Windows.Forms.Button clientgenIDbtn;
        private System.Windows.Forms.Label clientDoblbl;
        private System.Windows.Forms.TextBox clientDobTbx;
        private System.Windows.Forms.ComboBox clientTitleCbox;
        private System.Windows.Forms.Label clientTitlelbl;
        private System.Windows.Forms.TextBox clientSurnameTxtbox;
        private System.Windows.Forms.Label clientSurnamelbl;
        private System.Windows.Forms.ComboBox clientGenderCbox;
        private System.Windows.Forms.Label clientGenderlbl;
        private System.Windows.Forms.Button clientLoadbtn;
        private System.Windows.Forms.Button clientSavebtn;
        private System.Windows.Forms.Button clientRefreshbtn;
        private System.Windows.Forms.TextBox carDratetb;
        private System.Windows.Forms.Label carDratelbl;
        private System.Windows.Forms.TextBox carColourtb;
        private System.Windows.Forms.Label carColourlbl;
        private System.Windows.Forms.Label carFuellbl;
        private System.Windows.Forms.Label carTranslbl;
        private System.Windows.Forms.TextBox carSeatstb;
        private System.Windows.Forms.Label carNseatslbl;
        private System.Windows.Forms.Label carClasslbl;
        private System.Windows.Forms.TextBox carYeartb;
        private System.Windows.Forms.Label carYearlbl;
        private System.Windows.Forms.TextBox carModeltb;
        private System.Windows.Forms.Label carModellbl;
        private System.Windows.Forms.TextBox carMakeTb;
        private System.Windows.Forms.Label carMakelbl;
        private System.Windows.Forms.TextBox carRegoTb;
        private System.Windows.Forms.Label carRegolbl;
        private System.Windows.Forms.CheckBox carGpscb;
        private System.Windows.Forms.CheckBox carSunRoofcb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox carClasscb;
        private System.Windows.Forms.ComboBox carFuelcb;
        private System.Windows.Forms.ComboBox carTranscb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button carDispSearchbtn;
        private System.Windows.Forms.TextBox carSearchBox;
        private System.Windows.Forms.Label carSearchlbl;
        private System.Windows.Forms.ListView clientListView1;
        private System.Windows.Forms.ListView carListView1;
        private GroupBox DataHandling;
        private GroupBox rentalsGB;
        private ListView rentListView;
        private Button rentReturnCarbtn;
        private Button rentRentCarbtn;
        private TextBox rentRegotb;
        private Label rentCarRegolbl;
        private TextBox rentCustIDtb;
        private Label rentCustIDlbl;
        private Button rentRegoImportbtn;
        private Button rentCustIDimportbtn;
        private Label carStatuslbl;
        private Button carClearbtn;
        private Button reportClientbtn;
        private GroupBox ReportingBox;
        private RadioButton reportsRb2;
        private RadioButton reportsRb1;
        private Label clientStatuslbl;
        private ErrorProvider clientErrorProvider;
        private TextBox rentDurationtb;
        private Label rentDurationlbl;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label vehCostRangelbl;
        private NumericUpDown vehMaxUD;
        private NumericUpDown vehMinUD;
    }
}

