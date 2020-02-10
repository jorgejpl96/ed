using System;
using Gtk;

namespace bingo
{
	public class Panel
	{
		public Panel (VBox vbox1)
		{
			Table table = new Table (10, 9, true);
			int index = 0;
			for (int row = 0; row < 10; row++)
				for (int column = 0; column < 9; column++) 
			{
				index++;
				Button Boton = new Button();
				table.Attach (Boton, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
				Boton.Label= " " + index.ToString();
				Boton.Clicked += delegate {
					Boton.ModifyBg(StateType.Normal, new Gdk.Color(255,0,0));
				};
			}
			vbox1.Add(table);
			table.ShowAll ();
		}
	}
}

