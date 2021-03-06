using Microsoft.AspNetCore.Builder;

namespace MiddlewareExtensibilitySample.Middleware
{
    #region snippet1
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseConventionalMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConventionalMiddleware>();
        }

        public static IApplicationBuilder UseIMiddlewareMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IMiddlewareMiddleware>();
        }
    }
    #endregion
}
