using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons.Examples;

public class BasicOperators : IExercise
{
    public void Run()
    {
        int[] numbers = { 10, 9, 8, 7, 6 };
        
        // Element operators:
        numbers.First().Dump("First");
        numbers.Last().Dump("Last");

        numbers.ElementAt(1).Dump("Second number");
        numbers.OrderBy(n => n).First().Dump("Lowest number");
        numbers.OrderBy(n => n).Skip(1).First().Dump("Second lowest number");

        // Sequence operators:
        numbers.Take(3).Dump("Take(3) returns the first three numbers in the sequence");
        numbers.Skip(3).Dump("Skip(3) returns all but the first three numbers in the sequence");
        numbers.Reverse().Dump("Reverse does exactly as it says");

        // Aggregation operators:
        numbers.Count().Dump("Count");
        numbers.Min().Dump("Min");

        // Quantifiers:
        numbers.Contains(9).Dump("Contains (9)");
        numbers.Any().Dump("Any");
        numbers.Any(n => n % 2 != 0).Dump("Has an odd numbered element");

        // Set based operators:
        int[] seq1 = { 1, 2, 3 };
        int[] seq2 = { 3, 4, 5 };
        seq1.Concat(seq2).Dump("Concat");
        seq1.Union(seq2).Dump("Union");

        // Zip(): synchronous elements in 2 sequences
        int[] s1 = { 1, 2, 3 }; //First sequence
        int[] s2 = { 3, 2, 8 }; //Second sequence
        //dot product of sequence
        s1.Zip(s2, (a, b) => a * b).Dump("Dot Product");

        // Zip() and sum
        int[] values = { 1, 2, 3 };
        int[] weights = { 3, 2, 8 };
        values.Zip(weights, (value, weight) => value * weight) //same as a dot product
            .Sum() //sum of the multiplications of values and weights
            .Dump("Weighted Sum");
    }
}