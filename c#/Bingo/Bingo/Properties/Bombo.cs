using System;
using Gtk;

namespace Bingo
{
	public class Bombo
	{
		private IList<int> bolas = new List<int>();
		private Random Random = new Random();

		public Bombo ()
		{
			for (int i = 1; i <= 90; i++)
				bolas.add (i);
		};

		public int sacarBola()
		{
			int indexAleatorio = Random.Next (bolas.Count);

			int bola = bolas[indexAleatorio];
			bolas.RemoveAt (indexAleatorio);
			return bola;
		};
	}
}

