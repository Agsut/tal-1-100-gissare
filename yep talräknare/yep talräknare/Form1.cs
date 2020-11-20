using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yep_talräknare
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Random slump = new Random();
			slump33 = slump.Next(0, 101);
		}
		int gissning = 0;
		int antalgissningar = 0;
		int slump33 = 0;

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			gissning = int.Parse(textBox1.Text);
			antalgissningar++;
			label3.Text = "Du har gissat " + antalgissningar + " gånger!";

			if (gissning < slump33)
				label2.Text = "Ditt tal är för lågt";
			else if (gissning > slump33)
				label2.Text = "Ditt tal var för högt";
			else
			{
				label2.Text = "Du hade rätt!";
			}
		}
	}
}
