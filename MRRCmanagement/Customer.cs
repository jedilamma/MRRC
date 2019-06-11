using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRCmanagement
{
    public class Customer
    {
        public int c_ID { get; set; }
        public string c_Title { get; set; }
        public string c_FirstName { get; set; }
        public string c_LastName { get; set; }
        public string c_dob { get; set; }
        public enum Gender { Male, Female }
        public Gender c_gender { get; set; }
        public Customer()
        { }

        public string ToCSVString()
        {
            string outStr = c_ID + "," + c_Title + "," + c_FirstName + "," + c_LastName + "," + c_gender + "," + c_dob;
            return outStr;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}


    }
}
