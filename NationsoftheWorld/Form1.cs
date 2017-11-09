using System;
using System.Drawing;
using System.Windows.Forms;

namespace NationsoftheWorld
{
    public partial class Form1 : Form
    {
        bool Finished = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.Select();
            String FileLocation = "resources/" + Counters.Nation.ToLower() + ".png";
            pictureBox1.Image = Image.FromFile(FileLocation);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }
        private void Check()
        {
            if (Finished == false)
            {

                if (Program.Checkanswer(textBox1.Text) && !Program.CheckLastNation())
                {
                    Counters.Score++;
                }

                else if (Program.CheckLastNation())
                {
                    String FileLocation = "resources/gj.png";
                    pictureBox1.Image = Image.FromFile(FileLocation);
                    textBox1.Text = "How did you do?";
                    Finished = true;
                    textBox1.ReadOnly = true;
                    pictureBox1.Focus();
                }

                if (!Program.CheckLastNation())
                {
                    Program.UpdateNation();
                    String FileLocation = "resources/" + Counters.Nation.ToLower() + ".png";
                    pictureBox1.Image = Image.FromFile(FileLocation);
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
