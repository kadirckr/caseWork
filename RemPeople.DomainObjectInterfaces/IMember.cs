using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.DomainObjectInterfaces
{
    public interface IMember
    {
        long IDNumber { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int DaysWorked { get; set; }
        int OvertimeWorkedHours { get; set; }
    }
}
