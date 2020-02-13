using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joaquin_Cubero_UWP.Model;

namespace Joaquin_Cubero_UWP.Interface
{
    public interface IAuthenticationService
    {
        Task<TokenInfo> Authenticate(String userName, String password, String appId, String secret);
    }
}
