using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Cubero_UWP.Model
{
    public class TokenInfo
    {
        public String token { get; set; }
        public String tokenType { get; set; }
        public DateTime expiresAt { get; set; }
        public String baseUsageUrl { get; set; }
    }
}
