using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCinema
{
    class Employee
    {
        public int idEmployee;
        public string EmployeeName;
        public string EmployeeLName;
        public int idPosition;

        public Employee()
        {
            idEmployee = 0;
            EmployeeName = "";
            EmployeeLName = "";
            idPosition = 0;
        }

        public Employee(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                idEmployee = Convert.ToInt32(val[0]);
                EmployeeName = val[1];
                EmployeeLName = val[2];
                idPosition = Convert.ToInt32(val[3]);
            }
        }
    }
}
