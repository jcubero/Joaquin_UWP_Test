using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reddit;
using Reddit.AuthTokenRetriever;
using Reddit.Controllers;

namespace Joaquin_Cubero_UWP.ViewModel
{
    public class MainPageViewModel
    {
        public IEnumerable<Post> ListTop { get; set; }
        public Post SelectedTop { get; set; }

        public MainPageViewModel() 
        {
            //var token = AuthorizeUser("r0R_pygEcI5UDg");
            var reddit = new RedditClient("r0R_pygEcI5UDg", Guid.NewGuid().ToString());
            // Get info on another subreddit.
            var askReddit = reddit.Subreddit("AskReddit").About();
            // Get the top post from a subreddit.
            ListTop = askReddit.Posts.Top.Take(50);
        }



        public static string AuthorizeUser(string appId, string appSecret = null, int port = 8080)
        {
            // Create a new instance of the auth token retrieval library.  --Kris
            AuthTokenRetrieverLib authTokenRetrieverLib = new AuthTokenRetrieverLib(appId, appSecret, port);
            // Start the callback listener.
            authTokenRetrieverLib.AwaitCallback();

            // Open the browser to the Reddit authentication page.  Once the user clicks "accept", Reddit will redirect the browser to localhost:8080, where AwaitCallback will take over.
            OpenBrowser(authTokenRetrieverLib.AuthURL());

            while (true) { }

            // Cleanup.
            authTokenRetrieverLib.StopListening();

            return authTokenRetrieverLib.RefreshToken;
        }

        public static void OpenBrowser(string authUrl, string browserPath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(authUrl);
                Process.Start(processStartInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // This typically occurs if the runtime doesn't know where your browser is.  Use BrowserPath for when this happens.  --Kris
                ProcessStartInfo processStartInfo = new ProcessStartInfo(browserPath)
                {
                    Arguments = authUrl
                };
                Process.Start(processStartInfo);
            }
        }
    }


}
