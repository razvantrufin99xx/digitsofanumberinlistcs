/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/31/2024
 * Time: 1:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sumaDeDigiti
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		public int [] x  = {1,2,3,4,5,6,7,8,9,0};
		public int sumaDigiti(ref int[] px)
		{
			int s = 0;
			
			for(int i=0;i<x.Length;i++)
			{
				
					s+=x[i];
				
			}
			return s;
		}
		public int produsDigiti(ref int[] px)
		{
			int p = 1;
			
			for(int i=0;i<x.Length;i++)
			{
				if(x[i]!=0)
				{
					p*=x[i];
				}
			}
			return p;
		}
		public int diferDigiti(ref int[] px)
		{
			int d = 0;
			
			for(int i=0;i<x.Length;i++)
			{
				
					d-=x[i];
				
			}
			return d;
		}
		public double dividDigiti(ref int[] px)
		{
			double d = x[0];
			
			for(int i=1;i<x.Length;i++)
			{
				if(x[i]!=0)
				{
					d/=x[i];
				}
			}
			return d;
		}
		public void run(ref TextBox xText)
		{
			xText.Text += "\r\n";
			int suma = sumaDigiti(ref x);
			xText.Text = suma.ToString();
			xText.Text += "\r\n";
			int produs = produsDigiti(ref x);
			xText.Text += produs.ToString();
			xText.Text += "\r\n";
			int dif = diferDigiti(ref x);
			xText.Text += dif.ToString();
			xText.Text += "\r\n";
			double div = dividDigiti(ref x);
			xText.Text += div.ToString();
			xText.Text += "\r\n";
		}
		void Button1Click(object sender, EventArgs e)
		{
			run(ref textBox1);
		}
	}
}
