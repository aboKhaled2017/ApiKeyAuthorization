using ApiKeyAuth.FakeDatabase;

namespace ApiKeyAuth.Filters
{
    public class ApiKeyValidator : IApiKeyValidator
    {
        private readonly IFakeDatabase _fakeDatabase;

        public ApiKeyValidator(IFakeDatabase fakeDatabase)
        {
            _fakeDatabase = fakeDatabase;
        }

        public bool IsValid(string apiKey)
        {
            //implement lgic for validating api key

            return _fakeDatabase.GetApiKey()==apiKey;
        }
    }
}
