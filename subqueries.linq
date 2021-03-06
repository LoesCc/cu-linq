<Query Kind="Statements" />

string[] musos = { "Roger Waters", "David Gilmour", "Rick Wright", "Nick Mason"  };
musos.OrderBy(m => m.Split().Last()) // each musician name gets split, lastname is kept --> subquery
	 .Take(3)
	 .Dump ("First three musicians sorted by last name");  
