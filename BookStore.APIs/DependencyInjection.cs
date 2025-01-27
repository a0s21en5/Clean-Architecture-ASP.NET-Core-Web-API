using BookStore.Application;
using BookStore.Infrastructure;

namespace BookStore.APIs
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBookStoreDI(this IServiceCollection services)
        {
            services.AddApplicationDI().AddInfrastructureDI();
            return services;
        }
    }
}
