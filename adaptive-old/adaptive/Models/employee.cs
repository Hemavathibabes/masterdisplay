using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptive.Models
{
   public class employee
    {
        public int sno { get; set; }
        public String id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public float salary { get; set; }
        public string teamname { get; set; }
        public long phoneno {get; set;}
        public  string shift { get; set; }
        public string dob { get; set; }
        public bool status { get; set; }
    }
    class employeemanager
    {
        public static ObservableCollection<employee> getemployeedetails()
        {
            ObservableCollection<employee> employee = new ObservableCollection<employee>();
            employee.Add(new employee() { sno = 1, id = "Vtouch101", firstname = "Hemavathi", lastname = "A", gender = "female", salary = 12000, teamname = "vtouch-cliq", phoneno = 8015726383, shift = "gerneral", dob = "25.12.1999",status=false });
            employee.Add(new employee() { sno = 2, id = "Vtouch102", firstname = "Banumathi", lastname = "Anandan", gender = "female", salary = 15000, teamname = "vtouch-desktop", phoneno = 3333022389, shift = "gerneral", dob = "2.10.1987", status = false });
            employee.Add(new employee() { sno = 3, id = "Vtouch103", firstname = "Hemamalini", lastname = "A", gender = "female", salary = 35000, teamname = "Support", phoneno = 3312783302, shift = "gerneral", dob = "02.01.1996", status = false });
            employee.Add(new employee() { sno = 4, id = "Vtouch104", firstname = "Anandan", lastname = "Lingusamy", gender = "male", salary = 45000, teamname = "CRM Mail", phoneno = 9012783302, shift = "gerneral", dob = "13.11.1963",status=false });
            return employee;
        }
    }
}
