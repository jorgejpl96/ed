using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	private char operando;
	private float numero1;
	private float numero2;
	private float Total;
	private int punto = 0;
	private int igual = 0;
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
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "1");
		}
	}

	protected void OnB2Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "2");
		}
	}

	protected void OnB3Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "3");
		}
	}

	protected void OnB4Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "4");
		}
	}

	protected void OnB5Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "5");
		}
	}

	protected void OnB6Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "6");
		}
	}

	protected void OnB7Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "7");
		}
	}


	protected void OnB8Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "8");
		}
	}

	protected void OnB9Clicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "9");
		}
	}

	protected void OnBClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			Entrada.DeleteText (0, Entrada.Text.Length);
			Entrada.InsertText (display + "0");
		}
	}

	protected void OnBborrarClicked (object sender, EventArgs e)
		{
												if (igual == 0) {
			Entrada.DeleteText (Entrada.Text.Length - 1, Entrada.Text.Length);
		}
		}

	protected void OnBvaciarClicked (object sender, EventArgs e)
	{
		Entrada.DeleteText (0, Entrada.Text.Length);
		operando = ' ';
		numero1 = 0;
		numero2 = 0;
		Total = 0;
		igual = 0;
		punto = 0;

	}
	 
	protected void OnBdividirClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			operando = '/';
			String display = Entrada.Text.ToString ();
			numero1 = float.Parse (display);
			Entrada.DeleteText (0, Entrada.Text.Length);
			punto--;

		}
	}


	protected void OnBmultiplicarClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			operando = '*';
			String display = Entrada.Text.ToString ();
			numero1 = float.Parse (display);
			Entrada.DeleteText (0, Entrada.Text.Length);
			punto--;

		}
	}

	protected void OnBrestaClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			operando = '-';
			String display = Entrada.Text.ToString ();
			numero1 = float.Parse (display);
			Entrada.DeleteText (0, Entrada.Text.Length);
			punto--;

		}
	}

	protected void OnBsumaClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			operando = '+';
			String display = Entrada.Text.ToString ();
			numero1 = float.Parse (display);
			Entrada.DeleteText (0, Entrada.Text.Length);
			punto--;

		}
	}

	protected void OnBigualClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			String display = Entrada.Text.ToString ();
			numero2 = float.Parse (display);
			Entrada.DeleteText (0, Entrada.Text.Length);
			igual++;
			switch (operando) {
			case '/':
				Total = numero1 / numero2;
				break;
			case '*':
				Total = numero1 * numero2;
				break;
			case '-':
				Total = numero1 - numero2;
				break;
			case '+':
				Total = numero1 + numero2;
				break;
			}

			Entrada.InsertText (Total.ToString ());
		}
	}


	protected void OnBpuntoClicked (object sender, EventArgs e)
	{
		if (igual == 0) {
			if (Entrada.Text.ToString () == "") {
				punto++;
				String display = Entrada.Text.ToString ();
				Entrada.DeleteText (0, Entrada.Text.Length);
				Entrada.InsertText (display + "0,");
			}
			if (punto == 0) {
				punto++;
				String display = Entrada.Text.ToString ();
				Entrada.DeleteText (0, Entrada.Text.Length);
				Entrada.InsertText (display + ",");
			}
			
		}

	}
}
