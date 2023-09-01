using Microsoft.AspNetCore.Mvc;

namespace ApiKeyAuth.Filters
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute() : base(typeof(ApiKeyAuthorizationFilter))
        {
        }
    }
}
