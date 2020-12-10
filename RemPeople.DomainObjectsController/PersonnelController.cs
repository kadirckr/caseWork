using RemPeople.DomainObjectInterfaces;
using RemPeople.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.DomainObjectsController
{
    public class PersonnelController
    {
        IPersonnel _personnel;

        public PersonnelController(IPersonnel personnel)
        {
            _personnel = personnel;
        }

        public int CalculateSalary()
        {
            return _personnel.Salary();
        }

        public PersonnelResponse ServiceResult()
        {
            PersonnelResponse personnelResponse = new PersonnelResponse
            {
                Name = _personnel.Name,
                Surname = _personnel.Surname,
                IDNumber = _personnel.IDNumber,
                Salary = _personnel.Salary()
            };
            return personnelResponse;
        }
    }
}
