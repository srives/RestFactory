using RestSharp;
using RestSharp;
using RestSharp.Authenticators;

namespace RestFactory
{
    public class RestClientFactory : IRestClientFactory
    {
        public RestClient Create(string baseUrl, IAPIHeader auth)
        {
            var client = new RestClient(baseUrl);
            if (!string.IsNullOrEmpty(auth.User) && !string.IsNullOrEmpty(auth.Password))
            {
                if (auth.Base64Encode)
                    client.Authenticator = new HttpBasicAuthenticator(auth.User, auth.Password, System.Text.Encoding.UTF8);
                else
                    client.Authenticator = new HttpBasicAuthenticator(auth.User, auth.Password);
            }           
            return client;
        }
    }

    public class RestRequestFactory : IRestRequestFactory
    {
        public RestRequest Create(string url, Method method)
        {
            return new RestRequest(url, method);
        }
    }
}
