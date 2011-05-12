using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeLibrary
{
    public enum GenderType
    {
        Male,
        Female
    }

    public enum MaritalStatusType
    {
        Single,
        Married,
        Divorced,
        Separated
    }

    public class Employee : IDisposable
    {

        #region Public Properties

        public string EmployeeID { get; set; }
        
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public GenderType Gender { get; set; }

        public MaritalStatusType MaritalStatus { get; set; }

        public string JobTitle { get; set; }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value < DateTime.Now)
                    _birthDate = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "Birth Date must occur before today.");
            }
        }

        private DateTime _hireDate;
        public DateTime HireDate
        {
            get { return _hireDate; }
            set 
            { 
                if (value < DateTime.Now)
                    _hireDate = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "Hire Date must occur before today.");
            }
        }

        public string HomePhone { get; set; }

        public string WorkPhone { get; set; }

        public Decimal Salary { get; set; }

        private Department _department;
        public Department Department
        {
            get { return _department; }
            set { _department = value; }
        }
        
        #endregion

        #region Public Methods

        public string ReverseName()
        {
            return string.Format("{0}, {1} {2}",
                LastName, FirstName, MiddleName);                
        }

        public string FullName()
        {
            return string.Format("{0} {1} {2}",
                FirstName, MiddleName, LastName);
        }

        public override string ToString()
        {
            return string.Format(
                "{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7:d}, {8:d}, {9},  {10}, {11:C}, {12}",
                EmployeeID,
                FirstName,
                MiddleName,
                LastName,
                Gender.ToString(),
                MaritalStatus.ToString(),
                JobTitle,
                BirthDate,
                HireDate,
                HomePhone,
                WorkPhone,
                Salary,
                Department.ToString());
        }

        #endregion

        #region Constructors

        public Employee()
            : base()
        { }
        public Employee(string employeeID,
            string firstName,
            string middleName,
            string lastName,
            string jobTitle,
            GenderType gender,
            MaritalStatusType maritalStatus,
            DateTime birthDate,
            DateTime hireDate,
            string homePone,
            string workPhone,
            decimal salary,
            Department department)
            : base()
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
            this.JobTitle = jobTitle;
            this.BirthDate = birthDate;
            this.HireDate = hireDate;
            this.HomePhone = homePone;
            this.WorkPhone = workPhone;
            this.Salary = salary;
            this.Department = department;
        }

        #endregion

        #region Private Methods

        private int CalculateAge(DateTime birthdate)
        {
            if (birthdate == default(DateTime))
                throw new ArgumentException("BirthDate not defined");

            int age = DateTime.Now.Year - birthdate.Year; ;
            
            // make adjustments to age, if neccessary 
            if (birthdate.Month > DateTime.Now.Month)
                age--;
            else
                if (DateTime.Now.Month == birthdate.Month)
                    if (birthdate.Day > DateTime.Now.Day)
                        age--;

            return age;
        }

        #endregion

        public int Age
        { get { return CalculateAge(BirthDate); } }

        
        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
