namespace Library.Application;

using Library.Application.Services;
using Library.Domain.Interfaces;
using Library.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<LibraryService>();
        services.AddSingleton<IBookRepository, BookRepository>();
        return services;
    }
}