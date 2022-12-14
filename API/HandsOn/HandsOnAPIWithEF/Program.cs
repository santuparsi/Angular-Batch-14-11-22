using HandsOnAPIWithEF.Contracts;
using HandsOnAPIWithEF.Entities;
using HandsOnAPIWithEF.Services;
using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIWithEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connection = builder.Configuration.GetConnectionString("TestDBConnection");
            // Add services to the container.
            builder.Services.AddDbContext<ProductContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IProductContract, ProductRepository>();
            builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options =>
       options.AllowAnyOrigin() //allow any client url
                .AllowAnyMethod() //allow any http method like get,post,put and delete
                .AllowAnyHeader() // allow all the headers like response,authorize etc.
                );
            });
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
                app.UseCors("AllowOrigin"); //configure cors the app
                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            }
    }
    }