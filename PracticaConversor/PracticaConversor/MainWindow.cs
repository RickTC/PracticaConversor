using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnCambiaClicked (object sender, System.EventArgs e)
	{
		double dineropesos,cambiarpesos;
		
		if (!Double.TryParse(peso.Text, out dineropesos)|| !Double.TryParse(cambio.Text,out cambiarpesos) || dineropesos==0 || cambiarpesos==0)
		{
			MessageDialog md = new MessageDialog(
				
				null,
				DialogFlags.Modal,
				MessageType.Info,
				ButtonsType.None,
					"El caracter ingresado no es correcto\n y/o cero en espacio"
				);
			md.Show();
		}
		else
		{
			double respuesta= dineropesos/cambiarpesos;
			dolar.Text = respuesta.ToString();
		}
		
		
	}

	protected void OnLimpiaClicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}
}
