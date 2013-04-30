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

	protected void OnCombobox1Changed (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	}

	protected void OnEstadoChangeValue (object o, ChangeValueArgs args)
	{
		//throw new NotImplementedException ();
	}

	protected void OnEstadoInput (object o, InputArgs args)
	{
		//throw new NotImplementedException ();
	}

	protected void OnEstadoValueChanged (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	}

	protected void OnEstadoOutput (object o, OutputArgs args)
	{
		//throw new NotImplementedException ();
	}

	protected void OnBtnAceptarClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	    
		int puntos=0;

		if(this.radB.Active){ puntos ++;       }
	    
		if(this.resultado.Text=="4"){ puntos ++;         }
	
		if(this.coreaBtn.Active  ){puntos ++;}
		if(this.thaiBtn.Active ){puntos ++;}


		DateTime Fecha = this.fecha.GetDate();
		string fechaselec=Fecha.ToLongDateString();

	if(fechaselec ==" 1/Septiembre/1932" ){  puntos ++;}

		this.total.Text=puntos.ToString();
		}
}
