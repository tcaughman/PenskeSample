using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PenskeSampleApi.Server.Entities;
using PenskeSampleApi.Server.Mapping;
using PenskeSampleApi.Server.Repository;
using PenskeSampleSdk.Shared.ViewModel_Dto;
using System.Collections.Immutable;
using System.Text.Json;
using System.Xml;

namespace PenskeSampleApi.Server
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Configure logging

            builder.Logging.SetMinimumLevel(LogLevel.Information);
            builder.Logging.AddConsole().AddJsonConsole();

            //Register 
            builder.Services.AddScoped<INascarRepository, NascarRepo>();
            builder.Services.AddScoped<IRaceSeriesMapping, RaceSeriesMapping>();

            var app = builder.Build();

            //Initialize on disk document database and create sample data 
            var serviceScope = app.Services.CreateScope();
            await serviceScope.ServiceProvider.GetService<INascarRepository>().InitializeNascarRepositoryAsync();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
                app.UseExceptionHandler("/error-development");
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor API V1");
            });

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}