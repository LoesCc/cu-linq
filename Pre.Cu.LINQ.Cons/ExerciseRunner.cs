using Pre.Cu.LINQ.Cons.Examples;
using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseRunner
{
    private readonly LinqExerciseContext _dbContext;

    public ExerciseRunner(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run(params Runner[] runners)
    {
        foreach (var runner in runners)
        {
            Run(runner);
        }
    }

    public void Run(Runner runner)
    {
        List<IExercise> exercises = new List<IExercise>();

        switch (runner)
        {
            case Runner.ExerciseA:
                exercises.Add(new ExerciseA());
                break;
            case Runner.ExerciseB:
                exercises.Add(new ExerciseB());
                break;
            case Runner.ExerciseC:
                exercises.Add(new ExerciseC(_dbContext));
                break;
            case Runner.ExerciseD:
                exercises.Add(new ExerciseD(_dbContext));
                break;
            case Runner.BasicOperators:
                exercises.Add(new BasicOperators());
                break;
            case Runner.Chaining:
                exercises.Add(new Chaining());
                break;
            case Runner.DbQueries:
                exercises.Add(new DbQueries(_dbContext));
                break;
            case Runner.DbGrouping:
                exercises.Add(new DbGrouping(_dbContext));
                break;
            case Runner.DbProjection:
                exercises.Add(new DbProjection(_dbContext));
                break;
            case Runner.Deferred:
                exercises.Add(new Deferred());
                break;
            case Runner.Dump:
                exercises.Add(new Dump());
                break;
            case Runner.Expression:
                exercises.Add(new Expression());
                break;
            case Runner.Introduction:
                exercises.Add(new Introduction());
                break;
            case Runner.Projection:
                exercises.Add(new Projection1());
                exercises.Add(new Projection2());
                exercises.Add(new Projection3());
                break;
            case Runner.SubQueries:
                exercises.Add(new SubQueries());
                break;
            case Runner.ALL:
                exercises.Add(new ExerciseA());
                exercises.Add(new ExerciseB());
                exercises.Add(new ExerciseC(_dbContext));
                exercises.Add(new ExerciseD(_dbContext));
                exercises.Add(new BasicOperators());
                exercises.Add(new DbGrouping(_dbContext));
                exercises.Add(new DbProjection(_dbContext));
                exercises.Add(new Deferred());
                exercises.Add(new Dump());
                exercises.Add(new Expression());
                exercises.Add(new Introduction());
                exercises.Add(new Projection1());
                exercises.Add(new Projection2());
                exercises.Add(new Projection3());
                exercises.Add(new SubQueries());
                break;
        }

        exercises.ForEach(e => e.Run());
    }
}

public enum Runner
{
    ALL,
    ExerciseA,
    ExerciseB,
    ExerciseD,
    BasicOperators,
    Chaining,
    DbQueries,
    DbGrouping,
    DbProjection,
    Deferred,
    Dump,
    Introduction,
    Expression,
    Projection,
    SubQueries,
    ExerciseC
}
