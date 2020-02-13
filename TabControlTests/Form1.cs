using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			tabControl1.Click += TabControl1_Click;
			tabControl1.Deselected += TabControl1_Deselected;
			tabControl1.GotFocus += TabControl1_GotFocus;
			tabControl1.LostFocus += TabControl1_LostFocus;
			tabControl1.MouseClick += TabControl1_MouseClick;
			tabControl1.TabIndexChanged += TabControl1_TabIndexChanged;

			tabPage1.GotFocus += TabPage1_GotFocus;
			tabPage1.Leave += TabPage1_Leave;
			tabPage1.LostFocus += TabPage1_LostFocus;
			tabPage1.Enter += TabPage1_Enter;
			
			tabPage2.GotFocus += TabPage2_GotFocus;
			tabPage2.Leave += TabPage2_Leave;
			tabPage2.LostFocus += TabPage2_LostFocus;
		}

		private void TabControl1_TabIndexChanged(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void TabControl1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void TabControl1_LostFocus(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void TabControl1_GotFocus(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void TabControl1_Deselected(object sender, TabControlEventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void TabControl1_Click(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void TabPage1_Enter(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void TabPage2_LostFocus(object sender, System.EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void TabPage2_Leave(object sender, System.EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void TabPage2_GotFocus(object sender, System.EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void TabPage1_LostFocus(object sender, System.EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void TabPage1_Leave(object sender, System.EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		void TabPage1_GotFocus(object sender, System.EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void textBox2_Enter(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}

		private void textBox2_Leave(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text + $"\r\n{DateTime.Now.TimeOfDay} {new StackTrace().GetFrame(0).GetMethod().Name}";
		}
	}
}
