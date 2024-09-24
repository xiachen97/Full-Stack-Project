using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Configure the DataContext with a connection string to a database
        builder.Services.AddDbContext<DataContext>(
            options =>options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Add services like controllers, etc.
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        
        app.UseRouting();
        app.UseAuthorization();
        
        app.MapControllers(); // Add this line

        app.Run();
    }
}