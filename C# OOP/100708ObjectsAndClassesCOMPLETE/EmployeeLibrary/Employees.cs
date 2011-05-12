using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace EmployeeLibrary
{
    public class Employees : CollectionBase
    {

        #region Constructors

        public Employees()
            : base()
        { }

        public Employees(int capacity)
            : base(capacity)
        {
        }

        public Employees(Employee[] empArray)
            : base()
        {
            foreach (Employee emp in empArray)
                List.Add(emp);
        }

        #endregion

        #region Public Methods

        public int Add(Employee employee)
        {
            return List.Add(employee);
        }

        public Employee this[int i]
        {
            get { return (Employee)List[i]; }
            set { List[i] = value; }
        }

        public Employee this[string employeeID]
        {
            get
            {
                if (string.IsNullOrEmpty(employeeID))
                    return null;

                foreach (Employee employee in List)
                {
                    if (employee.EmployeeID == employeeID)
                        return employee;
                }
                return null;
            }
            set { this[employeeID] = value; }
        }

        public Employee this[Employee employee]
        {
            get
            {
                if (employee == null)
                    return null;
                return this[employee.EmployeeID];
            }
            set { this[employee.EmployeeID] = value; }
        }

        public bool Contains(Employee employee)
        {
            if (employee == null)
                return false;

            return (this[employee] != null);
        }

        public void Remove(Employee employee)
        {
            List.Remove(employee);
        }

        public void Remove(int index)
        {
            List.RemoveAt(index);
        }

        #endregion
    }
}
