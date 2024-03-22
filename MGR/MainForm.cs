/*
 * Created by SharpDevelop.
 * User: adily
 * Date: 29.11.2021
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
using System.Speech.Recognition;
using System.Speech.Recognition.SrgsGrammar;
using SpeechLib;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;

namespace MGR
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form


	{
		public Form2 frm2;

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
		SpeechSynthesizer sr = new SpeechSynthesizer();
		PromptBuilder promptBuilder = new PromptBuilder();
		SpeechRecognitionEngine ses = new SpeechRecognitionEngine();
		ActUtlType plc = new ActUtlType();
		void Button1Click(object sender, EventArgs e)
		{

			textBox2.BackColor = Color.Green;
			textBox2.Text = "CLAMP ACTIVE";
			textBox2.ForeColor = Color.White;
			plc.SetDevice("X4", 1);
			plc.SetDevice("X3", 0);

		}

		void Button3Click(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.Green;
			textBox1.Text = "ENGINE ACTIVE";
			textBox1.ForeColor = Color.White;
			plc.SetDevice("X1", 1);
			plc.SetDevice("X2", 1);



		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.Red;
			textBox1.Text = "ENGINE PASSIVE";
			textBox1.ForeColor = Color.White;
			plc.SetDevice("X2", 0);
			plc.SetDevice("X1", 0);


		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox2.BackColor = Color.Red;
			textBox2.Text = "CLAMP PASSIVE";
			textBox2.ForeColor = Color.White;
			plc.SetDevice("X3", 0);
			plc.SetDevice("X4", 1);

		}
		void Label5Click(object sender, EventArgs e)
		{

		}

		void MainFormLoad(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			//DateTime today= DateTime.Now;
			//textBox6.Text=today.ToString("");	
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;

		}

		void Button5Click(object sender, EventArgs e)
		{
			SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
			Grammar g = new DictationGrammar();
			sr.LoadGrammar(g);
			Choices list = new Choices();
			list.Add(new string[] { "Hello", "start","start engine","calis","hope","hop","testere","destere","hadi","atesle","motoru durdur","motoru baslat", "stop engine","dur","stop", "clamp open", "clamp close", "process open", "process close" ,"basla","motoru baslat","yavasla"});
			Grammar grammar = new Grammar(new GrammarBuilder(list));
			try
			{
				plc.ActLogicalStationNumber = 1;
				plc.Open();
				plc.SetDevice("X0", 1);
				button5.Text = "Speak English please";
				ses.RequestRecognizerUpdate();
				ses.LoadGrammar(grammar);
				sr.SetInputToDefaultAudioDevice();

				ses.SpeechRecognized += ses_SpeechRecognized;
				ses.SetInputToDefaultAudioDevice();
				ses.RecognizeAsync(RecognizeMode.Multiple);
			}
			catch
			{
				return;
			}
			/*	try
				{
					button5.Text = "talk please";
					sr.SetInputToDefaultAudioDevice();
					RecognitionResult res=sr.Recognize();
					button5.Text = res.Text;
				}
				catch (Exception)
				{
					button5.Text="Error";
				}*/

			if (textBox5.Text =="")
			{
				MessageBox.Show("Please, write your name.");
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button6.Enabled = false; button7.Enabled = false;
				button8.Enabled = false;

			}
			else
			{
				MessageBox.Show("Welcome " + textBox5.Text);
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;
				button4.Enabled = true;
				button6.Enabled = true;
				button7.Enabled = true;
				button8.Enabled = true;

			}


		
		}
		void ses_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			richTextBox1.Text = e.Result.Text;
			if (e.Result.Text== "basla"|| e.Result.Text == "start"|| e.Result.Text == "destere"|| e.Result.Text == "testere" ||e.Result.Text =="start engine"|| e.Result.Text == "motoru baslat"|| e.Result.Text == "atesle"|| e.Result.Text == "calis"|| e.Result.Text == "hadi") 
			{
				promptBuilder.ClearContent();
				promptBuilder.AppendText("okey engine is started");
				sr.Speak(promptBuilder);
				plc.SetDevice("X1", 1);
			}

			if (e.Result.Text == "dur" || e.Result.Text == "stop" || e.Result.Text == "stop engine" || e.Result.Text == "motoru durdur" || e.Result.Text == "yavasla" || e.Result.Text == "hope" || e.Result.Text == "hop")
			{
				promptBuilder.ClearContent();
				promptBuilder.AppendText("tamam stopped");
				sr.Speak(promptBuilder);
				plc.SetDevice("X2", 1);
			}











			/*
			switch (e.Result.Text)
			{
				case "basla":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("hello");
					sr.Speak(promptBuilder);

					break;
				case "motoru baslat":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("basladi");
					sr.Speak(promptBuilder);
					plc.SetDevice("X1", 1);

					break;
				case "yavasla":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("durdu");
					sr.Speak(promptBuilder);
					plc.SetDevice("X1", 0);
					plc.SetDevice("X2", 1);
					break;
				case "start":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("started");
					sr.Speak(promptBuilder);
					plc.SetDevice("X1", 1);
				
					break;
				case "stop engine":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("okey stopped engine");
					sr.Speak(promptBuilder);
					plc.SetDevice("X2", 1);
					break;
				case "clamp open":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("clampi acdim");
					sr.Speak(promptBuilder);
					plc.SetDevice("X4", 1);
					plc.SetDevice("X3", 0);
					break;
				case "clamp close":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("okey closed clamp");
					sr.Speak(promptBuilder);
					plc.SetDevice("X3", 1);
					plc.SetDevice("X4", 0);
					break;
				case "process open":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("OK PROCESS OPENED");
					sr.Speak(promptBuilder);
					break;
				case "process close":
					promptBuilder.ClearContent();
					promptBuilder.AppendText("OK PROCESS CLOSED");
					sr.Speak(promptBuilder);
					break;*/

		}
		void Label6Click(object sender, EventArgs e)
		{

		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{

		}
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{

		}
		void Timer1Tick(object sender, EventArgs e)
		{
			textBox7.Text = DateTime.Now.ToLongTimeString();
			textBox6.Text = DateTime.Now.ToLongDateString();

		}
		void Button6Click(object sender, EventArgs e)
		{
			textBox3.Text = "CUTTING IS ACTIVE";
			textBox3.BackColor = Color.Green;
			textBox3.ForeColor = Color.White;
		}
		void Button7Click(object sender, EventArgs e)
		{
			Form2 F2 = new Form2();
			F2.label3.Text = textBox5.Text;
			F2.Show();
			this.Hide();


		}
		void Button8Click(object sender, EventArgs e)
		{
			textBox3.Text = "CUTTING IS PASSIVE";
			textBox3.BackColor = Color.Red;
			textBox3.ForeColor = Color.White;
		}
		void PictureBox1Click(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
