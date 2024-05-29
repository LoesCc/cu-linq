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
        // 0. Dit is een voorbeeld van hoe je alle Pokemon weergeeft die terug te vinden zijn in je In-Memory databank
        // _dbContext.Pokemon.ToList().Dump("List all pokemon");

        // 1. Geef alle Pokemon weer die niet tot generatie 1, 2 of 4 behoren en legendary zijn
        List<PokemonGeneration> excludedGens = new List<PokemonGeneration>() { PokemonGeneration.I, PokemonGeneration.II, PokemonGeneration.IV };

        _dbContext.Pokemon
            .Where(p => !excludedGens.Contains(p.Generation) && p.Legendary)
            .Dump("Legendary pokemon niet in Gen I, II of IV.");

        // 2. Geef de Pokemon weer die behoren tot Gen II, behoren tot de category Fire, Psychic of Rock en hebben binnen hun categorie een attackbonus 
        // die hoger ligt dan het gemiddelde.
        List<string> includedCats = new List<string>() { "Fire", "Psychic", "Rock" };

        _dbContext.Pokemon
            .Where(p => p.Generation == PokemonGeneration.II && includedCats.Contains(p.Type))
            .Where(p => p.Attack > _dbContext.Pokemon.Where(q => q.Type == p.Type).Average(r => r.Attack))
            .Dump("Gen II, Fire/Psychic/Rock, binnen hun cat een Attackbonus die hoger ligt dan het gemiddelde in die categorie.");

        // 3. Geef de gemiddelde Hp, Attack en Defense weer voor de pokemon van Generation I per type
        _dbContext.Pokemon
            .Where(p => p.Generation == PokemonGeneration.I)
            .GroupBy(p => p.Type)
            .Select(group => new
            {
                Type = group.Key,
                MeanHp = group.Average(p => p.Hp),
                MeanAttack = group.Average(p => p.Attack),
                MeanDefense = group.Average(p => p.Defense)
            })
            .Dump("Gen I pokemon, per type: gemiddelde Hp, Attack en Defense.");
    }
}