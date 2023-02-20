// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pre.Cu.LINQ.Cons;
using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Core.Factories;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddDbContext<LinqExerciseContext>(opt => opt.UseInMemoryDatabase("pre.exercises"));
        services.AddTransient<ICategoryFactory, CategoryFactory>();
        services.AddTransient<IProductFactory, ProductFactory>();
        services.AddTransient<ICustomerFactory, CustomerFactory>();
        services.AddTransient<IEmployeeFactory, EmployeeFactory>();
        services.AddTransient<IOrderFactory, OrderFactory>();
        services.AddTransient<IPokemonFactory, PokemonFactory>();
        services.AddTransient<ISeeder, DataSeeder>();
    })
    .Build();

host.Services.GetService<ISeeder>()!.Seed();

var exercises = new ExerciseRunner(host.Services.GetService<LinqExerciseContext>());

exercises.Run(Runner.Dump);
