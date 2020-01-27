using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Random random = new Random();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBSaludarClicked(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(null, DialogFlags.NoSeparator, MessageType.Warning, ButtonsType.Ok, "Hola, te estoy saludando" + Texto1.Text);
        md.Run();
        md.Destroy();
    }

    protected void OnBSalirClicked(object sender, EventArgs e)
    {
        this.Destroy();
    }

    protected void OnAleatorioClicked(object sender, EventArgs e)
    {
        int maxvalue = int.Parse(aleatorio1.Text);
        int minvalue = int.Parse(aleatorio2.Text);
        int indexAleatorio = random.Next(minvalue, maxvalue);
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.Close, "Número aleatorio " + indexAleatorio);
        md.Run();
        md.Destroy();
    }
}
