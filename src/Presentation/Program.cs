namespace Presentation;
using Business.ServiceRegistration;
using DataAccess.Contexts;
using DataAccess.ServiceRegistration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Presentation.Extensions;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDataServices(builder.Configuration);
        builder.Services.AddBusinessServices(builder.Configuration);




        builder.Services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id="Bearer"
                        }
                    },
                    new string[]{}
                }
            });
        });


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        using (var ts = app.Services.CreateScope())
        {
            var t =ts.ServiceProvider.GetRequiredService<AppDbContext>();
            t.Database.Migrate();
        }


        app.UseHttpsRedirection();

        app.AddExceptionHandlerService();

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers().AllowAnonymous();


        app.Run();
    }
}