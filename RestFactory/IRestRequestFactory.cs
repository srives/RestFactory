using RestSharp;

namespace RestFactory
{
    public interface IRestRequestFactory
    {
        RestRequest Create(string url, Method method);
    }
}
