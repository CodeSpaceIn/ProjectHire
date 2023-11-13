using HiringPortal.Core.Interfaces;
using HiringPortal.Infrastructure.Repositories;
using HiringPortal.Infrastructure.ServiceExtension;
using HiringPortal.Services;
using HiringPortal.Services.Interfaces;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add services to the container.
builder.Services.AddDIServices(builder.Configuration);
builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<IMasterDataSerivice,MasterDataService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
