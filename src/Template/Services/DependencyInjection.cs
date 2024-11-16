using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Template.Domain.Services;
using Template.Services.Builder;
using Template.Services.Services;

namespace Template.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {


            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IPizzaBuilder, PizzaPersonalizedBuilder>();
            services.AddScoped<IPizzaBuilder, PizzaRecipeBuilder>();
            services.AddScoped<IPizzaBuilderFactory, PizzaBuilderFactory>(); // Fábrica
            services.AddScoped<PizzaDirector>(); // Fábrica

            return services;
        }

    }
}
