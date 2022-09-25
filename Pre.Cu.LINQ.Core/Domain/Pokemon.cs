namespace Pre.Cu.LINQ.Core.Domain;

public class Pokemon
{
    public Pokemon(int id, string name, string type, int hp, int attack, int defense, int spAtk, int spDef, int speed, PokemonGeneration generation, bool legendary)
    {
        Id = id;
        Name = name;
        Type = type;
        Hp = hp;
        Attack = attack;
        Defense = defense;
        SpAtk = spAtk;
        SpDef = spDef;
        Speed = speed;
        Generation = generation;
        Legendary = legendary;
    }

    public Pokemon()
    {
        
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int  Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpAtk { get; set; }
    public int SpDef { get; set; }
    public int Speed { get; set; }
    public PokemonGeneration Generation { get; set; }
    public bool Legendary { get; set; }
}

public enum PokemonGeneration
{
    I=0,
    II=1,
    III=2,
    IV=3,
    V=4,
    VI=5,
    VII=6,
    VIII=7,
    IX=8
}