using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRRC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void set_ReportText(string[] Text)
        {
            string Textout = "";
            for (int i = 0; i < Text.Count(); i++)
            {
                Textout = Text[i] + "\n";
                reportRt.AppendText(Textout);
            }
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
