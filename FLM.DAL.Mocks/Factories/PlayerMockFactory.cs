﻿using FLM.Model.Entities;
using System;

namespace FLM.DAL.Mocks.Factories
{
	public class PlayerMockFactory
	{
		private Random _random = new Random();

		public PlayerMockFactory()
		{
		}

		public Player CreateRandomPlayer()
		{
			var result = new Player();

			result.FirstName = Names[_random.Next(Names.Length)];
			result.LastName = Surnames[_random.Next(Surnames.Length)];

			result.DateOfBirth = RandomDate();

			result.CreationUser = Constants.AutoGenerated;
			result.CreationDateTime = DateTime.Now;

			return result;
		}

		private DateTime RandomDate()
		{
			DateTime start = new DateTime(1980, 1, 1);
			int range = (DateTime.Today.AddYears(-18) - start).Days;
			return start.AddDays(_random.Next(range));
		}

		private string[] Names =
		{
			"Joseph",
			"David",
			"Michael",
			"Moshe",
			"Jacob",
			"Benjamin",
			"Alexander",
			"Daniel",
			"Samuel",
			"Jack",
			"William",
			"Lucas",
			"Liam",
			"Oscar",
			"Elias",
			"Hugo",
			"Oliver",
			"Charlie",
			"Axel",
			"Vincent",
			"Mohamed",
			"Hassan",
			"Ahmed",
			"Omar",
			"Ibrahim",
			"Manuel",
			"Said",
			"Djamel",
			"Santiago",
			"Juan",
			"Matías",
			"Pedro",
			"Thiago",
			"Lucas",
			"Carlos",
			"Diego",
			"Dong",
			"Wei",
			"Yong",
			"Itsuki",
			"Ren",
			"Abdul",
			"Khaled",
			"Chih-ming",
			"Chih-wei",
			"Noel",
			"Luis",
			"Aron",
			"Marc",
			"Eric",
			"Jan",
			"Daniel",
			"Enzo",
			"Ian",
			"Lukas",
			"Maximilian",
			"Jakob",
			"Victor",
			"Oliver",
			"Oscar",
			"William",
			"Oliver",
			"George",
			"Harry",
			"Jack",
			"Eino",
			"Francesco",
			"Alessandro",
			"Tom",
			"Ben",
			"Nikola",
			"Marko",
			"Maxim",
			"Mikhail",
			"Dmitry",
			"Sergei",
			"Alexey",
			"Andrei",
			"Liam",
			"Gabriel",
			"Noel",
			"Leevi",
			"Arthur",
			"Paul",
			"Alexandre",
		};

		private string[] Surnames =
		{
			"Brown",
			"Smith",
			"Patel",
			"Jones",
			"Williams",
			"Johnson",
			"Taylor",
			"Thomas",
			"Roberts",
			"Khan",
			"Lewis",
			"Jackson",
			"Clarke",
			"James",
			"Phillips",
			"Wilson",
			"Ali",
			"Mason",
			"Mitchell",
			"Rose",
			"Gruber",
			"Bauer",
			"Wagner",
			"Müller",
			"Steiner",
			"Mayer",
			"Schmid",
			"Winkler",
			"Weber",
			"Schwarz",
			"Hasanov",
			"Peeters",
			"Dubois",
			"Lambert",
			"Dupont",
			"Zukić",
			"Petrov",
			"Ivanov",
			"Babić",
			"Novak",
			"Nielsen",
			"Hansen",
			"Andersen",
			"Larsen",
			"Kristensen",
			"Koppel",
			"Smirnov",
			"Kuznetsov",
			"Pavlov",
			"Korhonen",
			"Laine",
			"Salo",
			"Lindholm",
			"Bernard",
			"Richard",
			"Durand",
			"Leroy",
			"Garcia",
			"Bertrand",
			"Dupont",
			"Kapanadze",
			"Tsiklauri",
			"Schulz",
			"Hoffmann",
			"Murphy",
			"O'Brien",
			"O'Connor",
			"O'Neill",
			"Doyle",
			"McCarthy",
			"Rossi",
			"De Luca",
			"Conti",
			"Costa",
			"Lombardi",
			"Borg",
			"De Jong",
			"Van Dyk",
			"Hendriks",
			"Kowalski",
			"Woźniak",
			"Krawczyk",
			"Silva",
			"Santos",
			"Ferreira",
			"Oliveira",
			"Rodrigues",
			"Gomes",
			"Lopes",
			"Lebedev",
			"Vinogradov",
		};
	}
}