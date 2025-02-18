using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PrestamosSegurosAPI.Data;
using PrestamosSegurosAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AplicactionDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<AplicactionDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
