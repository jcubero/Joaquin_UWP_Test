using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joaquin_Cubero_UWP.Model
{
    public class CommentResponse
    {
        public bool IsSuccess { get; set; }
        public string after { get; set; }
        public string before { get; set; }
        public Comment[] children { get; set; }
    }
}
