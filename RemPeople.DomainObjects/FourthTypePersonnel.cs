using RemPeople.DomainObjectInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.DomainObjects
{
    public class FourthTypePersonnel : IPersonnel
    {
        public long IDNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DaysWorked { get; set; }
        public int OvertimeWorkedHours { get; set; }
        public int MonthlySalary { get; set; }
        public int DailySalary { get; set; }
        public int OvertimeWorkedHourlySalary { get; set; }

        public int Salary()
        {
            return (DaysWorked * DailySalary) + (OvertimeWorkedHours * OvertimeWorkedHourlySalary);
        }
    }
}
