using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.BLL.Services.Implementation;
using reenbitChat.Common.Profiles;
using reenbitChat.DAL.Context;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var migrationAssebly = typeof(ChatContext).Assembly.GetName().Name;
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
   // builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
}));
// Add services to the container.
builder.Services.AddDbContext<ChatContext>(x => 
x.UseSqlServer(builder.Configuration.GetConnectionString("ChatDb"), 
opt => opt.MigrationsAssembly(migrationAssebly)));
builder.Services.AddAutoMapper(typeof(reenbitChat.Common.Profiles.MapperProfile));
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddSignalR();
builder.Services.AddScoped<IPrivateChatService, PrivateChatService>();
builder.Services.AddScoped<IChatService, ChatService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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