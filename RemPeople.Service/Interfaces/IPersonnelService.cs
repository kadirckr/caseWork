using RemPeople.DTO;
using RemPeople.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Service.Interfaces
{
    public interface IPersonnelService
    {
        Task<ClientResponse<Personnel>> GetPersonnelByIdNumber(long idNumber);
    }
}
