using EComm.ProductService.Contracts;
using EComm.ProductService.Entities;
using EComm.ProductService.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EComm.ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connection = builder.Configuration.GetConnectionString("ProductDBConnection");
            builder.Services.AddDbContext<ProductDB1219Context>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IProductContract, ProductRepository>();
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