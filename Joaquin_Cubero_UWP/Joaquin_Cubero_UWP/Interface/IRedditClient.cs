using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joaquin_Cubero_UWP.Model;

namespace Joaquin_Cubero_UWP.Interface
{
    public interface IRedditClient
    {
        Task<MeResponse> me();
        Task<CommentResponse> comments(string user, string before, string after, int limit);
    }
}
