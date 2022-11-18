using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Handlers;
using reenbitChat.BLL.Hubs;
using reenbitChat.BLL.Jwt;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.BLL.Services.Implementation;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.WebApi.Extentions;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("http://localhost:4200","https://localhols:7139").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
   // builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
}));
// Add services to the container.
builder.Services.AddChatDbContext(builder);
builder.Services.AddMediatR(typeof(GetUsersChatQueryHandler).Assembly);
builder.Services.AddIdentity<User, IdentityRole<int>>()
    .AddEntityFrameworkStores<ChatContext>();

builder.Services.Configure<IdentityOptions>(opts => {
    opts.Password.RequiredLength = 8;
    opts.Password.RequireDigit = false;
    opts.Password.RequireLowercase = true;
    opts.User.RequireUniqueEmail = true;
});
builder.Services.AddJwtAuth(builder.Configuration);
builder.Services.AddAutoMapper(typeof(reenbitChat.Common.Profiles.MapperProfile));
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddSignalR();
builder.Services.AddScoped<IPrivateChatService, PrivateChatService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<ITokenProvider, JwtHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseCors("corsapp");
app.UseAuthorization();

app.MapControllers();
app.MapHub<ChatHub>("/chat");
InitializeDb(app);


app.Run();

void InitializeDb(IApplicationBuilder app)
{
    using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
    {
        using var context = scope.ServiceProvider.GetRequiredService<ChatContext>();
        context.Database.Migrate();
    };
}