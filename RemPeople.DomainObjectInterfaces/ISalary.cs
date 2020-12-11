using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.DomainObjectInterfaces
{
    public interface ISalary
    {
        int MonthlySalary { get; set; }
        int DailySalary { get; set; }
        int OvertimeWorkedHourlySalary { get; set; }
        int Salary();
    }
}