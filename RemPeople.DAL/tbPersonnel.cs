using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.DAL
{
    public class tbPersonnel
    {
        public int PersonnelId { get; set; }
        public long IDNumber { get; set; }
        public int PersonnelTypeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int DaysWorked { get; set; }
        public int OvertimeWorkedHours { get; set; }
    }
}
