using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.BLL.Jwt;
using reenbitChat.BLL.Services.Implementation;
using reenbitChat.DAL.IdentityProvider;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;
using reenbitChat.WebApi.Extentions;
using System.Text.Json.Serialization;
using reenbitChat.DAL.Factories;
using Microsoft.AspNetCore.Builder;

var origins = new string[] { "http://localhost:4200", "https://localhols:7139",
"https://nice-field-095044d10.2.azurestaticapps.net"};
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder
    .WithOrigins(origins)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(_ => true)
    .AllowCredentials();
}));
// Add services to the container.
builder.Services.AddChatDbContext(builder);
builder.Services.AddIdentity<reenbitChat.DAL.Entities.User, IdentityRole<int>>()
    .AddEntityFrameworkStores<ChatContext>();

builder.Services.Configure<IdentityOptions>(opts => {
    opts.Password.RequiredLength = 8;
    opts.Password.RequireDigit = false;
    opts.Password.RequireLowercase = true;
    opts.User.RequireUniqueEmail = true;
});

builder.Services.AddJwtAuth(builder.Configuration);
builder.Services.AddAutoMapper(typeof(reenbitChat.DAL.Profiles.MapperProfile));
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddScoped<IMemberFactory, MemberFactory>();
builder.Services.AddScoped<IMessagesService, MessagesService>();
builder.Services.AddScoped<IChatsService, ChatsService>();
builder.Services.AddScoped<ITokenProvider, JwtHandler>();
builder.Services.AddScoped<IMembersService, MembersService>();
builder.Services.AddScoped<IPermissionsService, PermissionsService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IPresenceService, PresenceTracker>();
builder.Services.AddSignalR();
builder.Services.AddSingleton<IUserIdProvider, CustomIdentityProvider>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
 app.UseDeveloperExceptionPage();
// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseCors("corsapp");
app.MapControllers();
app.MapHub<ChatHub>("/chat", opt =>
        opt.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets);
InitializeDb(app);

app.Run();
void InitializeDb(IApplicationBuilder app)
{
    using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
    using var context = scope.ServiceProvider.GetRequiredService<ChatContext>();
    context.Database.Migrate();
}