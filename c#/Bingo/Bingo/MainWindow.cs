using System;
using bingo;
using Gtk;
using Bingo;


public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Panel panel = new Panel(vbox1);

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnBJugarClicked (object sender, EventArgs e)
	{
		int x;
		Bombo bombo1 = new Bombo();

		x = bombo1.sacarBola();


	}




}
