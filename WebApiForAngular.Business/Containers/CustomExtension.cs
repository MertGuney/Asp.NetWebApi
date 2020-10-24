using Microsoft.Extensions.DependencyInjection;
using WebApiForAngular.Business.Concrete;
using WebApiForAngular.Business.Interfaces;
using WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using WebApiForAngular.DataAccess.Interfaces;

namespace WebApiForAngular.Business.Containers
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            //services.AddTransient<IValidator<EmployeeDto>, EmployeeAddValidator>();

        }
    }
}
