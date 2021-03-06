
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label label1;
	private global::Gtk.Entry nombre;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;
	private global::Gtk.ComboBox Grupo;
	private global::Gtk.Entry codigo;
	private global::Gtk.VScrollbar vscrollbar1;
	private global::Gtk.Label label4;
	private global::Gtk.RadioButton radA;
	private global::Gtk.Label label5;
	private global::Gtk.Label label8;
	private global::Gtk.SpinButton resultado;
	private global::Gtk.Label label9;
	private global::Gtk.CheckButton germBtn;
	private global::Gtk.CheckButton coreaBtn;
	private global::Gtk.CheckButton brasilBtn;
	private global::Gtk.CheckButton nethBtn;
	private global::Gtk.Label label10;
	private global::Gtk.Calendar fecha;
	private global::Gtk.Entry total;
	private global::Gtk.Button btnAceptar;
	private global::Gtk.RadioButton radc;
	private global::Gtk.Label label7;
	private global::Gtk.RadioButton radB;
	private global::Gtk.Label label6;
	private global::Gtk.CheckButton thaiBtn;
	private global::Gtk.Label label11;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Encuesta");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w1.X = 46;
		w1.Y = 34;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.nombre = new global::Gtk.Entry ();
		this.nombre.CanFocus = true;
		this.nombre.Name = "nombre";
		this.nombre.IsEditable = true;
		this.nombre.InvisibleChar = '●';
		this.fixed1.Add (this.nombre);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.nombre]));
		w2.X = 142;
		w2.Y = 24;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w3.X = 48;
		w3.Y = 93;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Grupo");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w4.X = 374;
		w4.Y = 24;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Grupo = global::Gtk.ComboBox.NewText ();
		this.Grupo.AppendText (global::Mono.Unix.Catalog.GetString ("a"));
		this.Grupo.AppendText (global::Mono.Unix.Catalog.GetString ("b"));
		this.Grupo.AppendText (global::Mono.Unix.Catalog.GetString ("c"));
		this.Grupo.Name = "Grupo";
		this.Grupo.Active = 0;
		this.fixed1.Add (this.Grupo);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Grupo]));
		w5.X = 470;
		w5.Y = 18;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.codigo = new global::Gtk.Entry ();
		this.codigo.CanFocus = true;
		this.codigo.Name = "codigo";
		this.codigo.IsEditable = true;
		this.codigo.InvisibleChar = '●';
		this.fixed1.Add (this.codigo);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.codigo]));
		w6.X = 140;
		w6.Y = 83;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.vscrollbar1 = new global::Gtk.VScrollbar (null);
		this.vscrollbar1.Name = "vscrollbar1";
		this.vscrollbar1.Adjustment.Upper = 100D;
		this.vscrollbar1.Adjustment.PageIncrement = 10D;
		this.vscrollbar1.Adjustment.PageSize = 10D;
		this.vscrollbar1.Adjustment.StepIncrement = 1D;
		this.fixed1.Add (this.vscrollbar1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.vscrollbar1]));
		w7.X = 672;
		w7.Y = 284;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = "Acuanto equivale [(9+(12*13))/6]";
		this.fixed1.Add (this.label4);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
		w8.X = 33;
		w8.Y = 137;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radA = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("19"));
		this.radA.CanFocus = true;
		this.radA.Name = "radA";
		this.radA.DrawIndicator = true;
		this.radA.UseUnderline = true;
		this.radA.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed1.Add (this.radA);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radA]));
		w9.X = 74;
		w9.Y = 180;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w10.X = 53;
		w10.Y = 182;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Cuanto es 2+2?");
		this.fixed1.Add (this.label8);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label8]));
		w11.X = 62;
		w11.Y = 231;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.resultado = new global::Gtk.SpinButton (0D, 100D, 1D);
		this.resultado.CanFocus = true;
		this.resultado.Name = "resultado";
		this.resultado.Adjustment.PageIncrement = 10D;
		this.resultado.ClimbRate = 1D;
		this.resultado.Numeric = true;
		this.fixed1.Add (this.resultado);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.resultado]));
		w12.X = 63;
		w12.Y = 250;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Cuales paises pertenecen a asia?");
		this.fixed1.Add (this.label9);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label9]));
		w13.X = 43;
		w13.Y = 288;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.germBtn = new global::Gtk.CheckButton ();
		this.germBtn.CanFocus = true;
		this.germBtn.Name = "germBtn";
		this.germBtn.Label = global::Mono.Unix.Catalog.GetString ("Germania");
		this.germBtn.DrawIndicator = true;
		this.germBtn.UseUnderline = true;
		this.fixed1.Add (this.germBtn);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.germBtn]));
		w14.X = 36;
		w14.Y = 326;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.coreaBtn = new global::Gtk.CheckButton ();
		this.coreaBtn.CanFocus = true;
		this.coreaBtn.Name = "coreaBtn";
		this.coreaBtn.Label = global::Mono.Unix.Catalog.GetString ("NorthCorea");
		this.coreaBtn.Active = true;
		this.coreaBtn.DrawIndicator = true;
		this.coreaBtn.UseUnderline = true;
		this.fixed1.Add (this.coreaBtn);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.coreaBtn]));
		w15.X = 126;
		w15.Y = 324;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.brasilBtn = new global::Gtk.CheckButton ();
		this.brasilBtn.CanFocus = true;
		this.brasilBtn.Name = "brasilBtn";
		this.brasilBtn.Label = global::Mono.Unix.Catalog.GetString ("Brasil");
		this.brasilBtn.DrawIndicator = true;
		this.brasilBtn.UseUnderline = true;
		this.fixed1.Add (this.brasilBtn);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.brasilBtn]));
		w16.X = 237;
		w16.Y = 327;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.nethBtn = new global::Gtk.CheckButton ();
		this.nethBtn.CanFocus = true;
		this.nethBtn.Name = "nethBtn";
		this.nethBtn.Label = global::Mono.Unix.Catalog.GetString ("Netherlands");
		this.nethBtn.DrawIndicator = true;
		this.nethBtn.UseUnderline = true;
		this.fixed1.Add (this.nethBtn);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.nethBtn]));
		w17.X = 411;
		w17.Y = 331;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("fecha de la seguna guerra mundial");
		this.fixed1.Add (this.label10);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label10]));
		w18.X = 33;
		w18.Y = 381;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.fecha = new global::Gtk.Calendar ();
		this.fecha.CanFocus = true;
		this.fecha.Name = "fecha";
		this.fecha.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.fixed1.Add (this.fecha);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.fecha]));
		w19.X = 30;
		w19.Y = 429;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.total = new global::Gtk.Entry ();
		this.total.CanFocus = true;
		this.total.Name = "total";
		this.total.IsEditable = true;
		this.total.InvisibleChar = '●';
		this.fixed1.Add (this.total);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.total]));
		w20.X = 376;
		w20.Y = 441;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnAceptar = new global::Gtk.Button ();
		this.btnAceptar.CanFocus = true;
		this.btnAceptar.Name = "btnAceptar";
		this.btnAceptar.UseUnderline = true;
		this.btnAceptar.Label = global::Mono.Unix.Catalog.GetString ("ACEPTAR");
		this.fixed1.Add (this.btnAceptar);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnAceptar]));
		w21.X = 278;
		w21.Y = 559;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radc = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("5.3"));
		this.radc.CanFocus = true;
		this.radc.Name = "radc";
		this.radc.DrawIndicator = true;
		this.radc.UseUnderline = true;
		this.radc.Group = this.radA.Group;
		this.fixed1.Add (this.radc);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radc]));
		w22.X = 256;
		w22.Y = 183;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.label7);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label7]));
		w23.X = 235;
		w23.Y = 184;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radB = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("7.5"));
		this.radB.CanFocus = true;
		this.radB.Name = "radB";
		this.radB.DrawIndicator = true;
		this.radB.UseUnderline = true;
		this.radB.Group = this.radA.Group;
		this.fixed1.Add (this.radB);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radB]));
		w24.X = 158;
		w24.Y = 182;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.label6);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label6]));
		w25.X = 138;
		w25.Y = 183;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.thaiBtn = new global::Gtk.CheckButton ();
		this.thaiBtn.CanFocus = true;
		this.thaiBtn.Name = "thaiBtn";
		this.thaiBtn.Label = global::Mono.Unix.Catalog.GetString ("Thailand");
		this.thaiBtn.DrawIndicator = true;
		this.thaiBtn.UseUnderline = true;
		this.fixed1.Add (this.thaiBtn);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.thaiBtn]));
		w26.X = 318;
		w26.Y = 324;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Total de puntos:");
		this.fixed1.Add (this.label11);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label11]));
		w27.X = 259;
		w27.Y = 444;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 706;
		this.DefaultHeight = 916;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.Grupo.Changed += new global::System.EventHandler (this.OnCombobox1Changed);
		this.btnAceptar.Clicked += new global::System.EventHandler (this.OnBtnAceptarClicked);
	}
}
