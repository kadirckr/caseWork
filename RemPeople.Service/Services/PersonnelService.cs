using RemPeople.DAL;
using RemPeople.DTO;
using RemPeople.Service.Core;
using RemPeople.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Service.Services
{
    public class PersonnelService : IPersonnelService
    {
        public async Task<ClientResponse<Personnel>> GetPersonnelByIdNumber(long idNumber)
        {
            List<tbPersonnelType> tbPersonnelTypes = new List<tbPersonnelType>();

            tbPersonnelType personnelTypeFirst = new tbPersonnelType
            {
                PersonnelTypeId = 1,
                PersonnelTypeText = "1. tip çalışanlar"
            };
            tbPersonnelTypes.Add(personnelTypeFirst);
            tbPersonnelType personnelTypeSecond = new tbPersonnelType
            {
                PersonnelTypeId = 2,
                PersonnelTypeText = "2. tip çalışanlar"
            };
            tbPersonnelTypes.Add(personnelTypeSecond);
            tbPersonnelType personnelTypeThird = new tbPersonnelType
            {
                PersonnelTypeId = 3,
                PersonnelTypeText = "3. tip çalışanlar"
            };
            tbPersonnelTypes.Add(personnelTypeThird);
            tbPersonnelType personnelTypeFourth = new tbPersonnelType
            {
                PersonnelTypeId = 4,
                PersonnelTypeText = "4. tip çalışanlar"
            };
            tbPersonnelTypes.Add(personnelTypeFourth);

            List<tbPersonnel> tbPersonnels = new List<tbPersonnel>();

            tbPersonnel personnel1 = new tbPersonnel()
            {
                PersonnelId = 1,
                IDNumber = 123456,
                PersonnelTypeId = 1,
                DaysWorked = 22,
                OvertimeWorkedHours = 0,
                Name = "Name1",
                SurName = "Surname1"
            };
            tbPersonnels.Add(personnel1);

            tbPersonnel personnel2 = new tbPersonnel()
            {
                PersonnelId = 2,
                IDNumber = 234567,
                PersonnelTypeId = 2,
                DaysWorked = 20,
                OvertimeWorkedHours = 0,
                Name = "Name2",
                SurName = "Surname2"
            };
            tbPersonnels.Add(personnel2);

            tbPersonnel personnel3 = new tbPersonnel()
            {
                PersonnelId = 3,
                IDNumber = 345678,
                PersonnelTypeId = 3,
                DaysWorked = 22,
                OvertimeWorkedHours = 10,
                Name = "Name2",
                SurName = "Surname2"
            };
            tbPersonnels.Add(personnel2);


            ClientResponse<Personnel> response = new ClientResponse<Personnel>();

            response.Data =  tbPersonnels.Where(w => w.IDNumber == idNumber).Select()


            return response;
        }
    }
}
