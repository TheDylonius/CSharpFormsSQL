using SpotifyAPI.Web;
using System.Threading.Tasks;

namespace CSharpWinFormsSQLCourse.Integration.Spotify
{
    class Spotify
    {
        public static async Task<SpotifyClient> GetAccessToken()
        {
            // Create the default Spotify Client configuration.
            var config = SpotifyClientConfig.CreateDefault();

            // Create the request authenticating using Client Credentials (Client ID, Client Secret).
            var request = new ClientCredentialsRequest("bffa89f70fea4d84b2bb4eb014979ee3", "1d55ca4d58594d47a42133eacc82a133");
            var response = await new OAuthClient(config).RequestToken(request);

            return new SpotifyClient(config.WithToken(response.AccessToken));
        }


    }
}