using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	private String numero1;
	private String numero2;
	private String Total;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnB1Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "1");
	}

	protected void OnB2Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "2");
	}

	protected void OnB3Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "3");
	}

	protected void OnB4Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "4");
	}

	protected void OnB5Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "5");
	}

	protected void OnB6Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "6");
	}

	protected void OnB7Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "7");
	}

	protected void OnB8Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "8");
	}

	protected void OnB9Clicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "9");
	}

	protected void OnBClicked (object sender, EventArgs e)
	{
		String display = Entrada.Text.ToString ();
		Entrada.DeleteText (0, Entrada.Text.Length);
		Entrada.InsertText (display + "0");
	}

	protected void OnBborrarClicked (object sender, EventArgs e)
	{
		Entrada.DeleteText (Entrada.Text.Length-1, Entrada.Text.Length);
	}

	protected void OnBvaciarClicked (object sender, EventArgs e)
	{
		Entrada.DeleteText (0, Entrada.Text.Length);
	}
	 
}
