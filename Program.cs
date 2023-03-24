using Aportaciones.Data;
using Aportaciones.Interfaces;
using Aportaciones.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Aportaciones
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var cors = "cors";
			// Add services to the container.

			builder.Services.AddCors(options =>
			{
				options.AddPolicy(name: cors, policy =>
				{
					policy.WithOrigins("http://localhost:4200")
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials();
				});
			});

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});

			builder.Services.AddStackExchangeRedisCache(options =>
			{
				options.Configuration = "localhost:6379";
			});

			builder.Services.AddAutoMapper(typeof(Program));
			builder.Services.AddScoped<IInputRepository, InputRepository>();
			builder.Services.AddScoped<IAddressRepository, AddressRepository>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseCors(cors);

			app.UseAuthorization();

			app.MapControllers();

			app.MigrateDatabase();

			app.Run();
		}
	}
}