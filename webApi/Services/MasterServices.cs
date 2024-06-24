using Microsoft.AspNetCore.Http.Features;
using webApi.Interface;
using webApi.Repository;

namespace webApi.Data
{
    public static class MasterServices
    {

        public static void ConfigureServices(this IServiceCollection services) 
        {
            services.AddScoped<IEmployee, BasicRepo>();




            services.Configure<FormOptions>(opt =>
            {
                opt.MultipartBodyLengthLimit = 536870912000;
            });
        }

    }
}
