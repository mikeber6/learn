using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity6_2
{
    class Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        private int _SSN;
        private string _department;

        public int EmpID
        {
            get { return _empID; }
        }
        
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
       
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
       
        public int SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
       
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }


        public Employee()
        {
            _empID = GetNextID();
        }

        public Employee(int empID)
        {
            if (empID == 1)
            {
                _empID = empID;
                LoginName = "smith";
                Password = "js";
                SSN = 123456789;
                Department = "IS";
            }
            else if (empID == 2)
            {
                _empID = empID;
                LoginName = "jones";
                Password = "mj";
                SSN = 987654321;
                Department = "HR";
            }
            else
            {
                throw new Exception("Invalid Employee ID");
            }
        }


        private int GetNextID()
        {
            return 100;
        }

        public string Update(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            return "Security info updated.";
        }

        public string Update(int ssNumber, string department)
        {
            SSN = ssNumber;
            Department = department;
            return "HR info updated.";
        }
    }
}
