using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateUse
{
    class Company
    {
        public abstract class Employee { }

        public class Manager : Employee
        {
            public void CheckBrain()
            {
                Console.WriteLine("Schedule brain checkup...");
            }
        }

        public class Laborer : Employee
        {
            public void CheckMuscles()
            {
                Console.WriteLine("Schedule muscles checkup...");
            }
        }

        public class DoctorOffice
        {
            public delegate void TypeAppointment();
            public TypeAppointment employeeCheckup;

            public void ScheduleCheckup(TypeAppointment aCheckup)
            {
                employeeCheckup = aCheckup;
            }

            public void ProcessNextEmployee()
            {
                if (employeeCheckup != null)
                {
                    employeeCheckup();
                }
            }
        }
    }
}
