using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected virtual void exit (object sender, System.EventArgs e)
	{
		Environment.Exit(0);
	}
	
	protected virtual void @new (object sender, System.EventArgs e)
	{
		Environment.Exit(0);
	}
	
	
	
}

