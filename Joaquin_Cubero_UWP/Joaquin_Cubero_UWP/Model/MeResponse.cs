using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Cubero_UWP.Model
{
    public class MeResponse
    {
        public string name { get; set; }
        public double created { get; set; }
        public double created_utc { get; set; }
        public int comment_karma { get; set; }
        public int link_karma { get; set; }
    }
}
