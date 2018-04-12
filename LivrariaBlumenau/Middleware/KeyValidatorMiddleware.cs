using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using LivrariaBlumenau.Repository;

namespace LivrariaBlumenau.Middleware
{
    public class KeyValidatorMiddleware
    {
        private readonly RequestDelegate request;
        private readonly ISecurityKeyRepository repository;

        public KeyValidatorMiddleware(RequestDelegate request, ISecurityKeyRepository repository)
        {
            this.request = request;
            this.repository = repository;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.Keys.Contains("user-key"))
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Chave não informada");
                return;
            }
            else
            if (!repository.IsValidKey(context.Request.Headers["user-key"]))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Chave inválida");
                return;
            }

            await request.Invoke(context);
        }

    }

    public static class KeyValidatorMiddlewareExtension
    {
        public static IApplicationBuilder ApplyUserKeyValidation(this IApplicationBuilder app)
        {
            app.UseMiddleware<KeyValidatorMiddleware>();
            return app;
        }
    }
}
