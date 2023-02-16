using System.Runtime.CompilerServices;
using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core;

public interface IProductFactory : IFactory<Product>
{
    IEnumerable<Product> CreateDefaults(IEnumerable<Category> categories);
}