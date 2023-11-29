using DevExpress.Data.Browsing;
using Matches;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data.Repositories;
using Solid.Service;
using DataContext = Matches.DataContext;
//using DataContext = DevExpress.Data.Browsing.DataContext;
//using Solid.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<InterfaceMatchmakerRepository, MatchmakerRepository>();
builder.Services.AddScoped<InterfaceMatchmakingRepository, MatchmakingRepository>();
builder.Services.AddScoped<InterfaceMeetingPlaceRepository, MeetingPlaceRepository>();

builder.Services.AddScoped<InterfaceMatchmakerServices, MatchmakerService>();
builder.Services.AddScoped<InterfaceMatchmakingServices, MatchmakingService>();
builder.Services.AddScoped<InterfaceMeetingPlaceServices, MeetingPlaceService>();

builder.Services.AddSingleton<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
