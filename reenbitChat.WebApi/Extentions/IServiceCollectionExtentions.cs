using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using reenbitChat.DAL.Context;
using System.Text;

namespace reenbitChat.WebApi.Extentions;

public static class IServiceCollectionExtentions
{
    public static IServiceCollection AddChatDbContext(this IServiceCollection services, WebApplicationBuilder builder)
    {
        var migrationAssebly = typeof(ChatContext).Assembly.GetName().Name;
        var connectionString = "";
        if (builder.Environment.IsDevelopment())
        {
            connectionString = builder.Configuration.GetConnectionString("ChatDb");
        }
        else
        {
            connectionString = builder.Configuration.GetConnectionString("AzureChatDb");
        }

        services.AddDbContext<ChatContext>(x => x.UseSqlServer(connectionString, 
            opt => opt.MigrationsAssembly(migrationAssebly)));

        return services;
    }

    public static IServiceCollection AddJwtAuth(this IServiceCollection services,ConfigurationManager conf)
    {
        var jwtSettings = conf.GetSection("JwtSettings");
        services.AddAuthentication(opt =>
        {
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                    .GetBytes(jwtSettings.GetSection("securityKey").Value)),
                
            };

            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var accessToken = context.Request.Query["access_token"];

                    var path = context.HttpContext.Request.Path;
                    if (!string.IsNullOrEmpty(accessToken) &&
                        (path.StartsWithSegments("/chat")))
                    {
                        context.Token = accessToken;
                    }
                    return Task.CompletedTask;
                }
            };
        });

        return services;
    }
}
