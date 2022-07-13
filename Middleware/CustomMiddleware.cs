using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Template;
using Middleware.Options;
using System.Threading.Tasks;

namespace Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly CustomOptions _options;
        private readonly TemplateMatcher _requestMatcher;
        public CustomMiddleware(RequestDelegate next, CustomOptions options)
        {
            _next = next;
            _options = options ?? new CustomOptions();
            _requestMatcher = new TemplateMatcher(TemplateParser.Parse(_options.RouteTemplate), new RouteValueDictionary());
        }

        public async Task Invoke(HttpContext httpContext)
        {

        }
    }
}
