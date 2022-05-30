using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using TimesheetManagement.Data.Contexts;
using TimesheetManagement.Services.DbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

builder.Services.AddScoped<ITimesheetManagementContext, TimesheetManagementContext>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
