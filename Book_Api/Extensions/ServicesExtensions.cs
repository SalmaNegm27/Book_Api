namespace Book_Api.Extensions
{
    using Contracts;
    using LoggerServices;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ServicesExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(option =>
             {
                 option.AddPolicy("CorsPolicy", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
             });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddScoped<ILoggerManger, LoggerManger>();


    }
}
