using RemPeople.DomainObjectInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemPeople.DomainObjects
{
    public class FirstTypePersonnel : IPersonnel
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
            return MonthlySalary;
        }
    }
}
