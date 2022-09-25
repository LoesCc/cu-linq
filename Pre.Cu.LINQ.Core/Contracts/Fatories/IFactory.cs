namespace Pre.Cu.LINQ.Core;

public interface IFactory<T>
{
    List<T> CreateDefaults();
}