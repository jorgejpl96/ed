
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox3;

	private global::Gtk.Label Titulo1;

	private global::Gtk.HButtonBox hbuttonbox1;

	private global::Gtk.VBox vbox5;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry Texto1;

	private global::Gtk.Button BSaludar;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Entry Pantalla;

	private global::Gtk.Button Aleatorio;

	private global::Gtk.Button BSalir;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Entry aleatorio1;

	private global::Gtk.Entry aleatorio2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.Titulo1 = new global::Gtk.Label();
		this.Titulo1.Name = "Titulo1";
		this.Titulo1.LabelProp = global::Mono.Unix.Catalog.GetString("primeros programas c#");
		this.vbox3.Add(this.Titulo1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.Titulo1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.vbox3.Add(this.hbuttonbox1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbuttonbox1]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.Texto1 = new global::Gtk.Entry();
		this.Texto1.CanFocus = true;
		this.Texto1.Name = "Texto1";
		this.Texto1.IsEditable = true;
		this.Texto1.InvisibleChar = '•';
		this.hbox2.Add(this.Texto1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.Texto1]));
		w3.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.BSaludar = new global::Gtk.Button();
		this.BSaludar.CanFocus = true;
		this.BSaludar.Name = "BSaludar";
		this.BSaludar.UseUnderline = true;
		this.BSaludar.Label = global::Mono.Unix.Catalog.GetString("Saludar");
		this.hbox2.Add(this.BSaludar);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.BSaludar]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox5.Add(this.hbox2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.Pantalla = new global::Gtk.Entry();
		this.Pantalla.CanFocus = true;
		this.Pantalla.Name = "Pantalla";
		this.Pantalla.IsEditable = false;
		this.Pantalla.InvisibleChar = '•';
		this.hbox3.Add(this.Pantalla);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.Pantalla]));
		w6.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.Aleatorio = new global::Gtk.Button();
		this.Aleatorio.CanFocus = true;
		this.Aleatorio.Name = "Aleatorio";
		this.Aleatorio.UseUnderline = true;
		this.Aleatorio.Label = global::Mono.Unix.Catalog.GetString("Aleatorio");
		this.hbox3.Add(this.Aleatorio);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.Aleatorio]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.BSalir = new global::Gtk.Button();
		this.BSalir.CanFocus = true;
		this.BSalir.Name = "BSalir";
		this.BSalir.UseUnderline = true;
		this.BSalir.Label = global::Mono.Unix.Catalog.GetString("SALIR");
		this.hbox3.Add(this.BSalir);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BSalir]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox5.Add(this.hbox3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox3]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox3.Add(this.vbox5);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vbox5]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.aleatorio1 = new global::Gtk.Entry();
		this.aleatorio1.CanFocus = true;
		this.aleatorio1.Name = "aleatorio1";
		this.aleatorio1.IsEditable = true;
		this.aleatorio1.InvisibleChar = '•';
		this.hbox1.Add(this.aleatorio1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.aleatorio1]));
		w11.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.aleatorio2 = new global::Gtk.Entry();
		this.aleatorio2.CanFocus = true;
		this.aleatorio2.Name = "aleatorio2";
		this.aleatorio2.IsEditable = true;
		this.aleatorio2.InvisibleChar = '•';
		this.hbox1.Add(this.aleatorio2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.aleatorio2]));
		w12.Position = 1;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox3.Add(this.vbox2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vbox2]));
		w14.Position = 3;
		w14.Expand = false;
		w14.Fill = false;
		this.Add(this.vbox3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 397;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.BSaludar.Clicked += new global::System.EventHandler(this.OnBSaludarClicked);
		this.Aleatorio.Clicked += new global::System.EventHandler(this.OnAleatorioClicked);
		this.BSalir.Clicked += new global::System.EventHandler(this.OnBSalirClicked);
	}
}
