using System;
using Gtk;
using System.Collections.Generic;


namespace Bingo2_0
{
	public class Panel
	{
		private static uint rows = 9;
		private static uint columns = 10;
		private IList<Button> buttons = new List<Button>();
		public Panel (VBox vbox1)
		{
			Table table = new Table (rows, columns, true);
			int index = 0;
			for (int row = 0; row < rows ; row++)
				for (int column = 0; column < columns ; column++)
			{
				index++;
				Button boton = new Button();
				table.Attach (boton, (uint)columns, (uint)column + 1, (uint)row, (uint)row + 1);
				buttons.Add (boton);
				boton.Label= index.ToString();
				

		}
			vbox1.Add (table);
			table.ShowAll ();
	}
	public void Marcar(int numero)
	{
		buttons[numero-1].ModifyBg(StateType.Normal, new Gdk.Color(100,200,250));
	}

}
}

