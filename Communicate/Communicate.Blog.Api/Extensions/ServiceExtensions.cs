using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Communicate.Blog.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCores(this IServiceCollection services) 
        {
            services.AddCors(o => o.AddPolicy("CorePolicy", builder => 
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()));
        }
    }
}
