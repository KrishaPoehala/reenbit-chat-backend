using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using reenbitChat.DAL.Context;
using System.Text;

namespace reenbitChat.WebApi.Extentions;

public static class IServiceCollectionExtentions
{
    public static void AddChatDbContext(this IServiceCollection services, WebApplicationBuilder builder)
    {
        var migrationAssebly = typeof(ChatContext).Assembly.GetName().Name;

        services.AddDbContext<ChatContext>(x =>
x.UseSqlServer(builder.Configuration.GetConnectionString("AzureChatDb"),
opt => opt.MigrationsAssembly(migrationAssebly)));
    }

    public static IServiceCollection AddJwtAuth(this IServiceCollection services,ConfigurationManager conf)
    {
        var jwtSettings = conf.GetSection("JwtSettings");
        services.AddAuthentication(opt =>
        {
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddGoogle(opt => {
            opt.ClientId = "1061658422584-ggdbk0sitpohbhftak1ga59ehde2e8cs.apps.googleusercontent.com";
            opt.ClientSecret = "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";
        })
            .AddJwtBearer(options =>
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
                    .GetBytes(jwtSettings.GetSection("securityKey").Value))
            };
        });

        return services;
    }
}
