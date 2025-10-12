using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Data;
using WebApplication1.Repository;
using WebApplication1.Services;



var builder = WebApplication.CreateBuilder(args);
var connectionString = "Host=ep-calm-boat-adozjp50-pooler.c-2.us-east-1.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_6TUc8JsiMVmW; SSL Mode=VerifyFull; Channel Binding=Require;";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString, o => o.UseNetTopologySuite()));

builder.Services.AddScoped<UsuariosRepository>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
