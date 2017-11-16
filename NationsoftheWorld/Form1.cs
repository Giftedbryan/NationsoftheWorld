using System;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace NationsoftheWorld
{
    public partial class Form1 : Form
    {
        bool Finished = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.Select();
            pictureBox1.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(Counters.Nation);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();
            textBox1.Select();
        }
        private void Check()
        {
            if (Finished == false)
            {

                if (Program.Checkanswer(textBox1.Text))
                {
                    Counters.Score++;
                }

                else
                {
                    MessageBox.Show("The correct name was: " + Counters.Nation, "Sorry!" );                    
                }

                if (Program.CheckLastNation())
                {
                    pictureBox1.Image = (System.Drawing.Image)Properties.Resources.gj;
                    textBox1.Text = "How did you do?";
                    Finished = true;
                    textBox1.ReadOnly = true;
                    pictureBox1.Focus();
                    Program.Index++;
                }

                else
                {
                    Program.UpdateNation();
                    pictureBox1.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(Counters.Nation);
                    textBox1.Text = "";
                }

                textBox2.Text = Counters.Score + " out of " + Program.Index;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Check();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Check();
            }
        }
    }
}
