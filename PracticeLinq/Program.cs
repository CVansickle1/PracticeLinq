

var videoGames = new List<string>() {"Fall Guys", "Morturary Assistant", "Apex", "Overwatch", "Vampire Surviors", "Powerwashing Simulator"};

videoGames.OrderBy(x => x.Length).ToList().ForEach(game => Console.WriteLine(game));

