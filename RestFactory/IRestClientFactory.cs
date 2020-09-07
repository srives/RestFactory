using RestSharp;

namespace RestFactory
{
    public interface IRestClientFactory
    {
        RestClient Create(string baseUrl, IAPIHeader auth);
    }
}
