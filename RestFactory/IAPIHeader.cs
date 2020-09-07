using System;
using System.Collections.Generic;
using System.Text;

namespace RestFactory
{ 
    public interface IAPIHeader
    {
        string ApiKey { get; set; }
        string AppName { get; set; }
        string OrgId { get; set; }
        bool Base64Encode { get; set; }
        string User { get; set; } // for BASIC auth
        string Password { get; set; }   // for BASIC auth
    }

}
