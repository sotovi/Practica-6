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

	protected void OnBtnClearClicked (object sender, EventArgs e)
	{
		this.txtn1.Text ="";	
		this.txtn2.Text ="";
		this.txtn3.Text ="";
		this.txtSubtotal.Text ="";
		this.txtIVA.Text ="";
		this.txtTotal.Text ="";
	}

	protected void OnBtnFactClicked (object sender, EventArgs e)
	{
		double P1 = double.Parse(this.txtn1.Text);
		double P2 = double.Parse(this.txtn2.Text);
		double P3 = double.Parse(this.txtn3.Text);
		double Subtotal = P1+P2+P3;
		double IVA = Subtotal*.16;
		double Total = Subtotal+ IVA;
		this.txtSubtotal.Text = Subtotal.ToString();
		this.txtIVA.Text = IVA.ToString();
		this.txtTotal.Text = Total.ToString();



	}
}
