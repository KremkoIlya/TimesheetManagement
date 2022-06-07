using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using NLog;
using TimesheetManagement.API.Infrastructure.Extensions;
using TimesheetManagement.Contracts.Timesheet;
using TimesheetManagement.Data.Contexts;
using TimesheetManagement.Services.Timesheet.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.ConfigureCors(); 
builder.Services.ConfigureLoggerService();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Audience = builder.Configuration["ADD:ApplicationId"];
        options.Authority = $"{builder.Configuration["ADD:InstanceId"]}{builder.Configuration["ADD:TenantId"]}";
    });

builder.Services.AddDbContext<TimesheetManagementContext>(options => 
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("TimesheetManagementSQL"));
    });

builder.Services.AddTransient<ITimesheetDayService, TimesheetDayService>();
builder.Services.AddTransient<ITimesheetPeriodService, TimesheetPeriodService>();

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
else
{
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("TM.APICorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
