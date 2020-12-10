using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemPeople.Service.Core
{
    public class ClientResponse<T> : ClientResponse
    {
        public T Data { get; set; }
    }

    public class ClientResponse
    {
        public string Message { get; set; }

        public bool HasErrors { get; set; }

        public ClientResponse()
        {
            HasErrors = false;
        }
    }
}
