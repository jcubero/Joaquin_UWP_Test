using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Cubero_UWP.Model
{
    public class Comment
    {
        public string id { get; set; }
        public int downs { get; set; }
        public int ups { get; set; }
        public int score { get; set; }
        public int created { get; set; }
        public DateTime createdDt { get; set; }
        public string link_url { get; set; }
    }
}
