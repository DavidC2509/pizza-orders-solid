using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Template.Domain.Services;
using Template.Services.Services;

namespace Template.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //var serviceClientSettings = new RabbitConfigurationProvider().GetConfiguration();

            //services.AddSingleton<IRabbitConfigurationProvider, RabbitConfigurationProvider>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IPizzaBuilder, PizzaPersonalizedBuilder>();
            services.AddScoped<IPizzaBuilder, PizzaRecipeBuilder>();
            services.AddScoped<IPizzaBuilderFactory, PizzaBuilderFactory>(); // Fábrica

            // Todos los repositorys


            return services;
        }

    }
}
