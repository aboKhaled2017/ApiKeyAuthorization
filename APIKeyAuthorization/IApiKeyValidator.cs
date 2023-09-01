namespace ApiKeyAuth.Filters
{
    public interface IApiKeyValidator
    {
        bool IsValid(string apiKey);
    }
}
