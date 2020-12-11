using RemPeople.DomainObjectInterfaces;
using RemPeople.DomainObjects;
using RemPeople.DomainObjectsController;
using RemPeople.DTO;
using RemPeople.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static RemPeople.DTO.Enums;

namespace RemPeople.Api.Controllers
{
    [RoutePrefix("api/personnel")]
    public class PersonnelController : ApiController
    {
        IPersonnelService personnelService;

        public PersonnelController(IPersonnelService personnelService)
        {
            this.personnelService = personnelService;
        }


        [HttpGet, Route("getpersonnelinformation")]
        public ApiResult<PersonnelResponse> GetPersonnelInformation(long identificationNumber)
        {
            ApiResult<PersonnelResponse> apiResult = new ApiResult<PersonnelResponse>();

            var responsePersonnel = personnelService.GetPersonnelByIdNumber(identificationNumber);
            var responseSalary = personnelService.GetSalaryTypeList();

            if (!responsePersonnel.HasErrors && !responseSalary.HasErrors)
            {
                if (responsePersonnel.Data != null)
                {
                    IPersonnel personnel = null;
                    switch (responsePersonnel.Data.PersonnelTypeId)
                    {
                        case (int)PersonnelType.FirstType:

                            personnel = new FirstTypePersonnel();

                            break;
                        case (int)PersonnelType.SecondType:

                            personnel = new SecondTypePersonnel();

                            break;
                        case (int)PersonnelType.ThirdType:

                            personnel = new ThirdTypePersonnel();

                            break;
                        case (int)PersonnelType.FourthType:

                            personnel = new FourthTypePersonnel();

                            break;
                    }

                    personnel.Name = responsePersonnel.Data.Name;
                    personnel.Surname = responsePersonnel.Data.SurName;
                    personnel.IDNumber = responsePersonnel.Data.IDNumber;
                    personnel.DaysWorked = responsePersonnel.Data.DaysWorked;
                    personnel.OvertimeWorkedHours = responsePersonnel.Data.OvertimeWorkedHours;
                    personnel.DailySalary = responseSalary.Data.FirstOrDefault(w => w.SalaryTypeId == (int)SalaryType.DailySalary).SalaryTypeValue;
                    personnel.MonthlySalary = responseSalary.Data.FirstOrDefault(w => w.SalaryTypeId == (int)SalaryType.MonthlySalary).SalaryTypeValue;
                    personnel.OvertimeWorkedHourlySalary = responseSalary.Data.FirstOrDefault(w => w.SalaryTypeId == (int)SalaryType.OvertimeWorkedHourlySalary).SalaryTypeValue;

                    PersonnelControlService control = new PersonnelControlService(personnel);

                    apiResult.Status = "Success";
                    apiResult.Data = control.GetPersonnelInfo();
                }
                else
                {
                    apiResult.Status = "InvalidIdentification";
                    apiResult.Message = "Invalid Identification Number";
                }
            }
            else
            {
                apiResult.Status = "Error";
                apiResult.Message = "Something wrong!";
            }
            return apiResult;
        }
    }
}
