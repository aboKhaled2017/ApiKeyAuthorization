using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiKeyAuth.Filters
{
    public class ApiKeyAuthorizationFilter : IAuthorizationFilter
    {
        private const string ApiKeyHeaderName = "X-API-Key";
        private readonly IApiKeyValidator _apiKeyValidator;

        public ApiKeyAuthorizationFilter(IApiKeyValidator apiKeyValidator)
        {
            _apiKeyValidator = apiKeyValidator;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var apiKey = context.HttpContext.Request.Headers[ApiKeyHeaderName];
            if(string.IsNullOrEmpty(apiKey)) 
            apiKey = context.HttpContext.Request.Query[ApiKeyHeaderName].FirstOrDefault()!;

            if (string.IsNullOrEmpty(apiKey) || !_apiKeyValidator.IsValid(apiKey))
                context.Result = new UnauthorizedResult();
        }
    }
}
