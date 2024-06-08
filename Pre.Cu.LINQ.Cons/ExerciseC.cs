using Pre.Cu.LINQ.Core;
using Pre.Cu.LINQ.Core.Domain;
using Pre.Cu.LINQ.Printing;

namespace Pre.Cu.LINQ.Cons;

public class ExerciseC : IExercise
{
    private readonly LinqExerciseContext _dbContext;

    public ExerciseC(LinqExerciseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Run()
    {
        // Dit is een voorbeeld van hoe je alle Pokemon weergeeft die terug te vinden zijn in je In-Memory databank
        // _dbContext.Pokemon.ToList().Dump("List all pokemon");
        var pokemon = _dbContext.Pokemon;

        // Geef alle Pokemon weer die niet tot generatie 1, 2 of 4 behoren en legendary zijn
        List<PokemonGeneration> notAllowed = new List<PokemonGeneration> { PokemonGeneration.I, PokemonGeneration.II, PokemonGeneration.IV };
        pokemon.Where(p => !notAllowed.Contains(p.Generation) && p.Legendary).Dump("Niet Gen I/II/IV & wel Legendary");

        // Geef de Pokemon weer die behoren tot Gen II, behoren tot de category Fire, Psychic of Rock en hebben binnen hun categorie een attackbonus 
        // die hoger ligt dan het gemiddelde.
        List<string> allowed = new List<string> { "Fire", "Psychic", "Rock" };
        pokemon.Where(p => allowed.Contains(p.Type) && p.Generation == PokemonGeneration.II)
            .Where(p => p.Attack > pokemon.Where(a => a.Type == p.Type).Average(a => a.Attack))
            .Dump("Gen II, Fire/Psychic/Rock, Attack > mean Attack of own Type");

        var fireMeanAttack = pokemon.Where(p => p.Type == "Fire").Average(p => p.Attack).Dump("fire mean attack");
        var psychicMeanAttack = pokemon.Where(p => p.Type == "Psychic").Average(p => p.Attack).Dump("psychic mean attack");
        var rockMeanAttack = pokemon.Where(p => p.Type == "Rock").Average(p => p.Attack).Dump("rock mean attack");

        // Geef de gemiddelde Hp, Attack en Defense weer voor de pokemon van Generation I per type
        pokemon.AsEnumerable()
            .Where(p => p.Generation == PokemonGeneration.I)
            .GroupBy(p => p.Type)
            .Select(group => new { Type = group.Key, Amount = group.Count(), MeanHp = group.Average(g => g.Hp), MeanAttack = group.Average(g => g.Attack), MeanDefense = group.Average(g => g.Defense) })
            .OrderByDescending(group => group.MeanAttack)
            .Dump("Gen I, grouped per Type, Mean Hp/Attack/Defense");
    }
}