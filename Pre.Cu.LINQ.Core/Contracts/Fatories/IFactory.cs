namespace Pre.Cu.LINQ.Core;

public interface IFactory<T>
{
    IEnumerable<T> CreateDefaults();
}