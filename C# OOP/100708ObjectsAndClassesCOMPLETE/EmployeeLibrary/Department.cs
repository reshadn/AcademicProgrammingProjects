using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeLibrary
{
    public class Department
    {
        #region Public Properties

        private string _departmentID;
        public string DepartmentID
        {
            get { return _departmentID; }
            set { _departmentID = value; }
        }

        private string _departmentName;
        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        #endregion 

        #region Public Methods

        public override string ToString()
        {
            return string.Format("{0} ({1})",
                _departmentName, _departmentID);
        }

        #endregion

        #region Constructors 

        public Department()
            : base()
        { }

        public Department(string departmentID,
            string departmentName)
        {
            this.DepartmentID = departmentID;
            this.DepartmentName = departmentName;
        }

        #endregion


    }
}
