<Query Kind="Program" />

void Main()
{
	string[] names = new[] { "Tom", "Dick", "Harry", "Mary", "Jay" };
	
	// extension mehods
	var temp = names
		.Select( n => new TempProjectionItem
			{
				Original  = n,
				Vowelless = n.Replace ("a", "").Replace ("e", "").Replace ("i", "").Replace ("o", "").Replace ("u", "")
			}
		);
	temp.Dump();

	// query syntax
	var temp2 =
		from n in names
		select new TempProjectionItem
		{
			Original = n,
			Vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
		};
	temp2.Dump();
}

class TempProjectionItem
{
	public string Original;      // Original name
	public string Vowelless;     // Vowel-stripped name
}
