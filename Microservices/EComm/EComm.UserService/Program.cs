using EComm.UserService.Contracts;
using EComm.UserService.Entities;
using EComm.UserService.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EComm.UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connection = builder.Configuration.GetConnectionString("UserDBConnection");
            builder.Services.AddDbContext<UserDB1219Context>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IUserContract, UserRepository>();
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}