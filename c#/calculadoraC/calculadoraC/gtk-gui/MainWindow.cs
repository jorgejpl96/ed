
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label Titulo;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Entry Entrada;
	private global::Gtk.HBox hbox13;
	private global::Gtk.Button bvaciar;
	private global::Gtk.Button bborrar;
	private global::Gtk.HBox hbox10;
	private global::Gtk.HBox hbox12;
	private global::Gtk.Button b7;
	private global::Gtk.Button b8;
	private global::Gtk.HBox hbox11;
	private global::Gtk.Button b9;
	private global::Gtk.Button bdividir;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox7;
	private global::Gtk.HBox hbox9;
	private global::Gtk.Button b4;
	private global::Gtk.Button b5;
	private global::Gtk.HBox hbox8;
	private global::Gtk.Button b6;
	private global::Gtk.Button bmultiplicar;
	private global::Gtk.HBox hbox4;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Button b1;
	private global::Gtk.Button b2;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Button b3;
	private global::Gtk.Button bresta;
	private global::Gtk.HBox hbox1;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Button bpunto;
	private global::Gtk.Button b;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button bigual;
	private global::Gtk.Button bsuma;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.Titulo = new global::Gtk.Label ();
		this.Titulo.Name = "Titulo";
		this.Titulo.LabelProp = global::Mono.Unix.Catalog.GetString ("Calculadora");
		this.vbox1.Add (this.Titulo);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.Titulo]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.Entrada = new global::Gtk.Entry ();
		this.Entrada.CanFocus = true;
		this.Entrada.Name = "Entrada";
		this.Entrada.IsEditable = false;
		this.Entrada.InvisibleChar = '●';
		this.vbox3.Add (this.Entrada);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.Entrada]));
		w2.Position = 0;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox ();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 6;
		// Container child hbox13.Gtk.Box+BoxChild
		this.bvaciar = new global::Gtk.Button ();
		this.bvaciar.WidthRequest = 266;
		this.bvaciar.CanFocus = true;
		this.bvaciar.Name = "bvaciar";
		this.bvaciar.UseUnderline = true;
		this.bvaciar.Label = global::Mono.Unix.Catalog.GetString ("AC");
		this.hbox13.Add (this.bvaciar);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.bvaciar]));
		w3.Position = 0;
		// Container child hbox13.Gtk.Box+BoxChild
		this.bborrar = new global::Gtk.Button ();
		this.bborrar.WidthRequest = 0;
		this.bborrar.CanFocus = true;
		this.bborrar.Name = "bborrar";
		this.bborrar.UseUnderline = true;
		this.bborrar.Label = global::Mono.Unix.Catalog.GetString ("C");
		this.hbox13.Add (this.bborrar);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.bborrar]));
		w4.Position = 1;
		this.vbox3.Add (this.hbox13);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox13]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.hbox12 = new global::Gtk.HBox ();
		this.hbox12.Name = "hbox12";
		this.hbox12.Spacing = 6;
		// Container child hbox12.Gtk.Box+BoxChild
		this.b7 = new global::Gtk.Button ();
		this.b7.WidthRequest = 100;
		this.b7.HeightRequest = 40;
		this.b7.CanFocus = true;
		this.b7.Name = "b7";
		this.b7.UseUnderline = true;
		this.b7.Label = global::Mono.Unix.Catalog.GetString ("7");
		this.hbox12.Add (this.b7);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.b7]));
		w6.Position = 0;
		// Container child hbox12.Gtk.Box+BoxChild
		this.b8 = new global::Gtk.Button ();
		this.b8.WidthRequest = 100;
		this.b8.CanFocus = true;
		this.b8.Name = "b8";
		this.b8.UseUnderline = true;
		this.b8.Label = global::Mono.Unix.Catalog.GetString ("8");
		this.hbox12.Add (this.b8);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.b8]));
		w7.Position = 1;
		this.hbox10.Add (this.hbox12);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.hbox12]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.b9 = new global::Gtk.Button ();
		this.b9.WidthRequest = 100;
		this.b9.CanFocus = true;
		this.b9.Name = "b9";
		this.b9.UseUnderline = true;
		this.b9.Label = global::Mono.Unix.Catalog.GetString ("9");
		this.hbox11.Add (this.b9);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.b9]));
		w9.Position = 0;
		// Container child hbox11.Gtk.Box+BoxChild
		this.bdividir = new global::Gtk.Button ();
		this.bdividir.WidthRequest = 65;
		this.bdividir.CanFocus = true;
		this.bdividir.Name = "bdividir";
		this.bdividir.UseUnderline = true;
		this.bdividir.Label = global::Mono.Unix.Catalog.GetString ("/");
		this.hbox11.Add (this.bdividir);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.bdividir]));
		w10.Position = 1;
		this.hbox10.Add (this.hbox11);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.hbox11]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox3.Add (this.hbox10);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox10]));
		w12.Position = 2;
		w12.Expand = false;
		this.vbox1.Add (this.vbox3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox3]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox ();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.b4 = new global::Gtk.Button ();
		this.b4.WidthRequest = 100;
		this.b4.HeightRequest = 40;
		this.b4.CanFocus = true;
		this.b4.Name = "b4";
		this.b4.UseUnderline = true;
		this.b4.Label = global::Mono.Unix.Catalog.GetString ("4");
		this.hbox9.Add (this.b4);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.b4]));
		w14.Position = 0;
		// Container child hbox9.Gtk.Box+BoxChild
		this.b5 = new global::Gtk.Button ();
		this.b5.WidthRequest = 100;
		this.b5.CanFocus = true;
		this.b5.Name = "b5";
		this.b5.UseUnderline = true;
		this.b5.Label = global::Mono.Unix.Catalog.GetString ("5");
		this.hbox9.Add (this.b5);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.b5]));
		w15.Position = 1;
		this.hbox7.Add (this.hbox9);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.hbox9]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.b6 = new global::Gtk.Button ();
		this.b6.WidthRequest = 100;
		this.b6.CanFocus = true;
		this.b6.Name = "b6";
		this.b6.UseUnderline = true;
		this.b6.Label = global::Mono.Unix.Catalog.GetString ("6");
		this.hbox8.Add (this.b6);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.b6]));
		w17.Position = 0;
		// Container child hbox8.Gtk.Box+BoxChild
		this.bmultiplicar = new global::Gtk.Button ();
		this.bmultiplicar.WidthRequest = 65;
		this.bmultiplicar.CanFocus = true;
		this.bmultiplicar.Name = "bmultiplicar";
		this.bmultiplicar.UseUnderline = true;
		this.bmultiplicar.Label = global::Mono.Unix.Catalog.GetString ("*");
		this.hbox8.Add (this.bmultiplicar);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.bmultiplicar]));
		w18.Position = 1;
		this.hbox7.Add (this.hbox8);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.hbox8]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		this.vbox2.Add (this.hbox7);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox7]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.b1 = new global::Gtk.Button ();
		this.b1.WidthRequest = 100;
		this.b1.HeightRequest = 40;
		this.b1.CanFocus = true;
		this.b1.Name = "b1";
		this.b1.UseUnderline = true;
		this.b1.Label = global::Mono.Unix.Catalog.GetString ("1");
		this.hbox5.Add (this.b1);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.b1]));
		w21.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.b2 = new global::Gtk.Button ();
		this.b2.WidthRequest = 100;
		this.b2.CanFocus = true;
		this.b2.Name = "b2";
		this.b2.UseUnderline = true;
		this.b2.Label = global::Mono.Unix.Catalog.GetString ("2");
		this.hbox5.Add (this.b2);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.b2]));
		w22.Position = 1;
		this.hbox4.Add (this.hbox5);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.hbox5]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.b3 = new global::Gtk.Button ();
		this.b3.WidthRequest = 100;
		this.b3.CanFocus = true;
		this.b3.Name = "b3";
		this.b3.UseUnderline = true;
		this.b3.Label = global::Mono.Unix.Catalog.GetString ("3");
		this.hbox6.Add (this.b3);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.b3]));
		w24.Position = 0;
		// Container child hbox6.Gtk.Box+BoxChild
		this.bresta = new global::Gtk.Button ();
		this.bresta.WidthRequest = 65;
		this.bresta.CanFocus = true;
		this.bresta.Name = "bresta";
		this.bresta.UseUnderline = true;
		this.bresta.Label = global::Mono.Unix.Catalog.GetString ("-");
		this.hbox6.Add (this.bresta);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.bresta]));
		w25.Position = 1;
		this.hbox4.Add (this.hbox6);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.hbox6]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.bpunto = new global::Gtk.Button ();
		this.bpunto.WidthRequest = 75;
		this.bpunto.HeightRequest = 40;
		this.bpunto.CanFocus = true;
		this.bpunto.Name = "bpunto";
		this.bpunto.UseUnderline = true;
		this.bpunto.Label = global::Mono.Unix.Catalog.GetString (".");
		this.hbox3.Add (this.bpunto);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.bpunto]));
		w28.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.b = new global::Gtk.Button ();
		this.b.WidthRequest = 150;
		this.b.CanFocus = true;
		this.b.Name = "b";
		this.b.UseUnderline = true;
		this.b.Label = global::Mono.Unix.Catalog.GetString ("0");
		this.hbox3.Add (this.b);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.b]));
		w29.Position = 1;
		this.hbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox3]));
		w30.Position = 0;
		w30.Expand = false;
		w30.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.bigual = new global::Gtk.Button ();
		this.bigual.WidthRequest = 75;
		this.bigual.CanFocus = true;
		this.bigual.Name = "bigual";
		this.bigual.UseUnderline = true;
		this.bigual.Label = global::Mono.Unix.Catalog.GetString ("=");
		this.hbox2.Add (this.bigual);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.bigual]));
		w31.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.bsuma = new global::Gtk.Button ();
		this.bsuma.WidthRequest = 65;
		this.bsuma.CanFocus = true;
		this.bsuma.Name = "bsuma";
		this.bsuma.UseUnderline = true;
		this.bsuma.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.hbox2.Add (this.bsuma);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.bsuma]));
		w32.Position = 1;
		this.hbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox2]));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		this.vbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
		w34.Position = 2;
		w34.Expand = false;
		w34.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w35.Position = 2;
		w35.Expand = false;
		w35.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 401;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
