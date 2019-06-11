using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRCmanagement
{
    public class CRM
    {
        public Customer customers = new Customer();
        List<Customer> cList = new List<Customer>();
        public CRM()
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\Data\customer.csv");
            splitData(lines);
        }

        ~CRM()
        {
            save_ToFile();
        }
        public List<Customer> GetList()
        {
            return cList;
        }
        public void splitData(string[] inStr)
        {
            for (int i = 1; i < inStr.Length; i++)
            {
                var tmpValue = inStr[i];
                var parts = tmpValue.Split(',');
                Customer customers = new Customer();

                customers.c_ID = int.Parse(parts[0]);
                customers.c_Title = parts[1];
                customers.c_FirstName = parts[2];
                customers.c_LastName = parts[3];
                customers.c_gender = (Customer.Gender)Enum.Parse(typeof(Customer.Gender), parts[4]);
                customers.c_dob = parts[5];
                cList.Add(customers);
            }
        }
        public void add_DataToList(string ID, string Title, string FirstName, string LastName, string Gender, string Dob)
        {
            Customer customers = new Customer();
            customers.c_ID = int.Parse(ID);
            customers.c_Title = Title;
            customers.c_FirstName = FirstName;
            customers.c_LastName = LastName;
            customers.c_gender = (Customer.Gender)Enum.Parse(typeof(Customer.Gender), Gender);
            customers.c_dob = Dob;
            cList.Add(customers);
        }
        public void save_ToFile()
        {
            //System.IO.File.WriteAllBytes(@"..\..\customer.csv", new byte[0]);
            string titleStr = "CustomerID,Title,FirstName,LastName,Gender,DOB";
            cList.Count();
            string[] outArray = new string[cList.Count() + 1];

            outArray[0] = titleStr;
            int i = 1;
            foreach (Customer outcust in cList)
            {
                outArray[i] = outcust.c_ID + "," + outcust.c_Title + "," + outcust.c_FirstName + "," + outcust.c_LastName
                             + "," + outcust.c_gender + "," + outcust.c_dob;
                i++;
            }
            System.IO.File.WriteAllLines(@"..\..\..\Data\customer.csv", outArray);
            // string[] outArray2 = outArray;

        }
        public void load_FromFile()
        {
            if (cList.Count > 0)
            {
                cList.Clear();
            }
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\Data\customer.csv");
            splitData(lines);
        }
        public string[] Refresh_listbox()
        {
            cList.Count();
            int i = 0;
            string[] outArray = new string[cList.Count()];
            foreach (Customer outcust in cList)
            {
                outArray[i] = outcust.c_ID + " - " + outcust.c_Title + " " + outcust.c_FirstName + " " + outcust.c_LastName;
                i++;
            }
            return outArray;
        }
    }
}
