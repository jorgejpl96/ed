using System;
using System.Collections.Generic;
using Gdk;
namespace Bingo2_0
{
	public class Bombo
	{
		private IList<int>bolas= new List<int>();
		private Random random = new Random();

		public Bombo ()
		{
			for (int bola = 1; bola <= 90; bola++) {
				bolas.Add (bola);
			}
		}

		public int SacarBola (){
		
			int aleatorio = random.Next(bolas.Count);
			int bola = bolas[aleatorio];
			bolas.RemoveAt(aleatorio);

			return bola;

		}
	}
}

