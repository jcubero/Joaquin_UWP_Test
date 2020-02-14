using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Cubero_UWP.Model
{
    public class TopReddit
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime EntryDate { get; set; }
        public string ThumbnailURL { get; set; }

        public int NumberOfComments { get; set; }

        public bool IsRead { get; set; }
    }
}
