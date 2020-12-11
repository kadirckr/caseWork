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
        public ClientResponse<PersonnelDTO> GetPersonnelByIdNumber(long idNumber)
        {

            #region Adding data manually
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
                Name = "Name3",
                SurName = "Surname3"
            };
            tbPersonnels.Add(personnel3);

            tbPersonnel personnel4 = new tbPersonnel()
            {
                PersonnelId = 4,
                IDNumber = 456789,
                PersonnelTypeId = 4,
                DaysWorked = 22,
                OvertimeWorkedHours = 10,
                Name = "Name4",
                SurName = "Surname4"
            };
            tbPersonnels.Add(personnel4);
            #endregion

            ClientResponse<PersonnelDTO> response = new ClientResponse<PersonnelDTO>();

            try
            {
                response.Data = tbPersonnels.Where(w => w.IDNumber == idNumber).Select(w => new PersonnelDTO
                {
                    DaysWorked = w.DaysWorked,
                    IDNumber = w.IDNumber,
                    Name = w.Name,
                    SurName = w.SurName,
                    OvertimeWorkedHours = w.OvertimeWorkedHours,
                    PersonnelId = w.PersonnelId,
                    PersonnelTypeId = w.PersonnelTypeId
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                response.HasErrors = true;
                response.Message = ex.Message;
            }

            return response;
        }

        public ClientResponse<List<SalaryTypeDTO>> GetSalaryTypeList()
        {
            #region Adding data manually

            List<tbSalaryType> tbSalaryTypes = new List<tbSalaryType>();

            tbSalaryType salaryTypeFirst = new tbSalaryType
            {
                SalaryTypeId = 1,
                SalaryTypeText = "Sabit Aylık Maaş",
                SalaryTypeValue = 500
            };
            tbSalaryTypes.Add(salaryTypeFirst);

            tbSalaryType salaryTypeSecond = new tbSalaryType
            {
                SalaryTypeId = 2,
                SalaryTypeText = "Günlük Ücret",
                SalaryTypeValue = 20
            };
            tbSalaryTypes.Add(salaryTypeSecond);

            tbSalaryType salaryTypeThird = new tbSalaryType
            {
                SalaryTypeId = 3,
                SalaryTypeText = "Mesai Saati Ücreti",
                SalaryTypeValue = 5
            };
            tbSalaryTypes.Add(salaryTypeThird);

            #endregion

            ClientResponse<List<SalaryTypeDTO>> response = new ClientResponse<List<SalaryTypeDTO>>();

            try
            {
                response.Data = tbSalaryTypes.Select(w => new SalaryTypeDTO
                {
                    SalaryTypeId = w.SalaryTypeId,
                    SalaryTypeText = w.SalaryTypeText,
                    SalaryTypeValue = w.SalaryTypeValue
                }).ToList();

            }
            catch (Exception ex)
            {
                response.HasErrors = true;
                response.Message = ex.Message;
            }
            return response;

        }
    }
}
