
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ActUtlTypeLib;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPlcMitsuMxCom;
using System.IO;



namespace MGR

{
	
	/// <summary>
	/// Description of Form2.
	/// </summary>
	/// 
	public partial class Form2 : Form
	{
		int ax1 = 0;
		
		string dosya = @"C:\Users\User\Desktop\C#\" + DateTime.Now.ToLongDateString() + ".txt";
		//StreamWriter Yaz = new StreamWriter(@"C:\Users\User\Desktop\C#\" + DateTime.Now.ToLongDateString() + ".txt");
		string[] yaz = new string[10000];
		public Form2()
		{
			
			

				//
				// The InitializeComponent() call is required for Windows Forms designer support.
				//
				InitializeComponent();
			
			//
			

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		ActUtlType plc = new ActUtlType();
		void Button1Click(object sender, EventArgs e)
		{
			MainForm f2 = new MainForm();
			f2.Show();
			Form3 f3 = new Form3();
			f3.Show();


		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{

		}
		
		private void Form2_Load(object sender, EventArgs e)
		{
			label3.ForeColor = Color.White;
			timer1.Enabled = true;
			timer1.Interval = 2000;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			plc.ActLogicalStationNumber = 1;
			plc.Open();
			if (button2.Text == "CONNECT")
			{
				label6.Text = "CONNECTED";
				label6.ForeColor = Color.Black;
				label6.BackColor = Color.Lime;
				button2.Text = "DISCONNECT";
				button2.BackColor = Color.Red;

			}
			else
			{
				label6.Text = "DISCONNECTED";
				label6.ForeColor = Color.Black;
				label6.BackColor = Color.Red;
				button2.Text = "CONNECT";
				button2.BackColor = Color.Lime;
				plc.Close();

			}
			//int a = plc.GetDevice("X0", out int X0);
			//string B = Convert.ToString(X0);
		}
		private void label7_Click(object sender, EventArgs e)
		{

		}
		private void label4_Click(object sender, EventArgs e)
		{

		}
		private void label6_Click(object sender, EventArgs e)
		{

		}
		private void button3_Click_1(object sender, EventArgs e)
		{
			int a1 = plc.GetDevice("X1", out int X1);
			string B1 = Convert.ToString(X1);
			if (B1 == "1") { button3.BackColor = Color.Lime; } else { button3.BackColor = Color.Red; }
		}
		private void button4_Click(object sender, EventArgs e)
		{
			int a2 = plc.GetDevice("X2", out int X2);
			string B2 = Convert.ToString(X2);
			if (B2 == "1") { button4.BackColor = Color.Lime; } else { button4.BackColor = Color.Red; }
		}
		private void button5_Click(object sender, EventArgs e)
		{
			int a3 = plc.GetDevice("X3", out int X3);
			string B3 = Convert.ToString(X3);
			if (B3 == "1") { button5.BackColor = Color.Lime; } else { button5.BackColor = Color.Red; }
		}
		private void button6_Click(object sender, EventArgs e)
		{
			int a4 = plc.GetDevice("X4", out int X4);
			string B4 = Convert.ToString(X4);
			if (B4 == "1") { button6.BackColor = Color.Lime; } else { button6.BackColor = Color.Red; }
		}
		private void button7_Click(object sender, EventArgs e)
		{
			int a5 = plc.GetDevice("X5", out int X5);
			string B5 = Convert.ToString(X5);
			if (B5 == "1") { button7.BackColor = Color.Lime; } else { button7.BackColor = Color.Red; }
		}
		private void button8_Click(object sender, EventArgs e)
		{
			int a6 = plc.GetDevice("X6", out int X6);
			string B6 = Convert.ToString(X6);
			if (B6 == "1") { button8.BackColor = Color.Lime; } else { button8.BackColor = Color.Red; }
		}
		private void button9_Click(object sender, EventArgs e)
		{
			int a7 = plc.GetDevice("X7", out int X7);
			string B7 = Convert.ToString(X7);
			if (B7 == "1") { button9.BackColor = Color.Lime; } else { button9.BackColor = Color.Red; }
		}
		private void button10_Click(object sender, EventArgs e)
		{
			int a8 = plc.GetDevice("X8", out int X8);
			string B8 = Convert.ToString(X8);
			if (B8 == "1") { button10.BackColor = Color.Lime; } else { button10.BackColor = Color.Red; }
		}
		private void button11_Click(object sender, EventArgs e)
		{
			int a9 = plc.GetDevice("X9", out int X9);
			string B9 = Convert.ToString(X9);
			if (B9 == "1") { button11.BackColor = Color.Lime; } else { button11.BackColor = Color.Red; }
		}
		private void button12_Click(object sender, EventArgs e)
		{
			int a10 = plc.GetDevice("X10", out int X10);
			string B10 = Convert.ToString(X10);
			if (B10 == "1") { button12.BackColor = Color.Lime; } else { button12.BackColor = Color.Red; }
		}
		private void button13_Click(object sender, EventArgs e)
		{
			int a11 = plc.GetDevice("X11", out int X11);
			string B11 = Convert.ToString(X11);
			if (B11 == "1") { button13.BackColor = Color.Lime; } else { button13.BackColor = Color.Red; }
		}
		private void button14_Click(object sender, EventArgs e)
		{
			int b = plc.GetDevice("Y0", out int Y0);
			string B12 = Convert.ToString(Y0);
			if (B12 == "1") { button14.BackColor = Color.Lime; } else { button14.BackColor = Color.Red; }
		}
		private void button15_Click(object sender, EventArgs e)
		{
			int b1 = plc.GetDevice("Y1", out int Y1);
			string B13 = Convert.ToString(Y1);
			if (B13 == "1") { button15.BackColor = Color.Lime; } else { button15.BackColor = Color.Red; }
		}
		private void button16_Click(object sender, EventArgs e)
		{
			int b2 = plc.GetDevice("Y2", out int Y2);
			string B14 = Convert.ToString(Y2);
			if (B14 == "1") { button16.BackColor = Color.Lime; } else { button16.BackColor = Color.Red; }
		}
		private void button17_Click(object sender, EventArgs e)
		{
			int b3 = plc.GetDevice("Y3", out int Y3);
			string B15 = Convert.ToString(Y3);
			if (B15 == "1") { button17.BackColor = Color.Lime; } else { button17.BackColor = Color.Red; }
		}
		private void button18_Click(object sender, EventArgs e)
		{
			int b4 = plc.GetDevice("Y4", out int Y4);
			string B16 = Convert.ToString(Y4);
			if (B16 == "1") { button18.BackColor = Color.Lime; } else { button18.BackColor = Color.Red; }
		}
		private void button19_Click(object sender, EventArgs e)
		{
			int b5 = plc.GetDevice("Y5", out int Y5);
			string B17 = Convert.ToString(Y5);
			if (B17 == "1") { button19.BackColor = Color.Lime; } else { button19.BackColor = Color.Red; }
		}
		private void button20_Click(object sender, EventArgs e)
		{
			int b6 = plc.GetDevice("Y6", out int Y6);
			string B18 = Convert.ToString(Y6);
			if (B18 == "1") { button20.BackColor = Color.Lime; } else { button20.BackColor = Color.Red; }
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			int a1 = plc.GetDevice("X1", out int X1);
			string B1 = Convert.ToString(X1);
			if (B1 == "1") { button3.BackColor = Color.Lime; }
			else{button3.BackColor = Color.Red;}
			int a2 = plc.GetDevice("X2", out int X2);
			string B2 = Convert.ToString(X2);
			if (B2 == "1") { button4.BackColor = Color.Lime; } else { button4.BackColor = Color.Red; }
			int a3 = plc.GetDevice("X3", out int X3);
			string B3 = Convert.ToString(X3);
			if (B3 == "1") { button5.BackColor = Color.Lime; } else { button5.BackColor = Color.Red; }
			int a4 = plc.GetDevice("X4", out int X4);
			string B4 = Convert.ToString(X4);
			if (B4 == "1") { button6.BackColor = Color.Lime; } else { button6.BackColor = Color.Red; }
			int a5 = plc.GetDevice("X5", out int X5);
			string B5 = Convert.ToString(X5);
			if (B5 == "1") { button7.BackColor = Color.Lime; } else { button7.BackColor = Color.Red; }
			int a6 = plc.GetDevice("X6", out int X6);
			string B6 = Convert.ToString(X6);
			if (B6 == "1") { button8.BackColor = Color.Lime; } else { button8.BackColor = Color.Red; }
			int a7 = plc.GetDevice("X7", out int X7);
			string B7 = Convert.ToString(X7);
			if (B7 == "1") { button9.BackColor = Color.Lime; } else { button9.BackColor = Color.Red; }
			int a8 = plc.GetDevice("X8", out int X8);
			string B8 = Convert.ToString(X8);
			if (B8 == "1") { button10.BackColor = Color.Lime; } else { button10.BackColor = Color.Red; }
			int a9 = plc.GetDevice("X9", out int X9);
			string B9 = Convert.ToString(X9);
			if (B9 == "1") { button11.BackColor = Color.Lime; } else { button11.BackColor = Color.Red; }
			int a10 = plc.GetDevice("X10", out int X10);
			string B10 = Convert.ToString(X10);
			if (B10 == "1") { button12.BackColor = Color.Lime; } else { button12.BackColor = Color.Red; }
			int a11 = plc.GetDevice("X11", out int X11);
			string B11 = Convert.ToString(X11);
			if (B11 == "1") { button13.BackColor = Color.Lime; } else { button13.BackColor = Color.Red; }
			int b = plc.GetDevice("Y0", out int Y0);
			string B12 = Convert.ToString(Y0);
			if (B12 == "1") { button14.BackColor = Color.Lime; } else { button14.BackColor = Color.Red; }
			int b1 = plc.GetDevice("Y1", out int Y1);
			string B13 = Convert.ToString(Y1);
			if (B13 == "1") { button15.BackColor = Color.Lime; } else { button15.BackColor = Color.Red; }
			int b2 = plc.GetDevice("Y2", out int Y2);
			string B14 = Convert.ToString(Y2);
			if (B14 == "1") { button16.BackColor = Color.Lime; } else { button16.BackColor = Color.Red; }
			int b3 = plc.GetDevice("Y3", out int Y3);
			string B15 = Convert.ToString(Y3);
			if (B15 == "1") { button17.BackColor = Color.Lime; } else { button17.BackColor = Color.Red; }
			int b4 = plc.GetDevice("Y4", out int Y4);
			string B16 = Convert.ToString(Y4);
			if (B16 == "1") { button18.BackColor = Color.Lime; } else { button18.BackColor = Color.Red; }
			int b5 = plc.GetDevice("Y5", out int Y5);
			string B17 = Convert.ToString(Y5);
			if (B17 == "1") { button19.BackColor = Color.Lime; } else { button19.BackColor = Color.Red; }
			int b6 = plc.GetDevice("Y6", out int Y6);
			string B18 = Convert.ToString(Y6);
			if (B18 == "1") { button20.BackColor = Color.Lime; } else { button20.BackColor = Color.Red; }
			yaz[ax1] = DateTime.Now.ToLongTimeString()+" ,"+label3.Text+" ,EMERGENCY STOP :" + B1 + " ,START SAW :" + B2 + " ,STOP SAW  :" + B3 + " ,LEFT HAND  :" + B4 + " ,RIGHT HAND  :" + B5 + " ,FORWARD SWITCH  :" + B6 + " ,BACK SWITCH  :" + B7 + " ,SECURITY DOOR  :" + B8 + " ,FAULT  :" + B9 + " ,PHASE CONTROL  :" + B10 + " ,TWO HAND SECURITY  :" + B11 + " ,FORWARD CUT  :"+B12+" ,BACK CUT  :"+B13+" ,COOLING  :"+B14+" ,4BAR  :"+B15+" ,6BAR  :"+B16+" ,START  :"+B17+" ,DOOR  :"+B18+ Environment.NewLine;
			ax1++;
			//System.IO.File.WriteAllLines(dosya, yaz);
			File.WriteAllLines(dosya, yaz);

		}
		}
	}

    
