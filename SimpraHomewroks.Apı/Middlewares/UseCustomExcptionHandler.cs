using Microsoft.AspNetCore.Diagnostics;
using Simpra_Homework_Core.RequestResponseModel;
using SimpraHomework.Service.Exceptions;
using System.Text.Json;

namespace SimpraHomewroks.Apı.Middlewares
{
    public static class UseCustomExcptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "applicaiton/json";

                    var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();

                    var statusCode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;

                    var response = CustomResponse<NoContent>.Fail(statusCode, exceptionFeature.Error.Message);

                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));

                });
            });
        }
    }
}
