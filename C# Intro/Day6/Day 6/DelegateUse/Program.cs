using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Company.DoctorOffice docsOffice = new Company.DoctorOffice();
            Company.Manager aManager = new Company.Manager();
            Company.Laborer aLaborer = new Company.Laborer();

            docsOffice.ScheduleCheckup(new
            Company.DoctorOffice.TypeAppointment(aManager.CheckBrain));
            docsOffice.ProcessNextEmployee();

            docsOffice.ScheduleCheckup(new
            Company.DoctorOffice.TypeAppointment(aLaborer.CheckMuscles));
            docsOffice.ProcessNextEmployee();
        }
    }
}
  