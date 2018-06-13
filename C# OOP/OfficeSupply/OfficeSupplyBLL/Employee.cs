using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSupplyBLL
{
    public class Employee
    {
        int _employeeID;
        string _loginName;
        string _password;
        bool _loggedIn = false;

        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public string LoginName { get => _loginName; set => _loginName = value; }
        public string Password { get => _password; set => _password = value; }
        public bool LoggedIn { get => _loggedIn; }

        public Boolean LogIn()
        {
            DALEmployee dbEmp = new DALEmployee();
            int empID;
            empID = dbEmp.LogIn(this.LoginName, this.Password);
            if (empID > 0)
            {
                this.EmployeeID = empID;
                this._loggedIn = true;
                return true;
            }
            else
            {
                this._loggedIn = false;
                return false;
            }
                
        }


    }
}
