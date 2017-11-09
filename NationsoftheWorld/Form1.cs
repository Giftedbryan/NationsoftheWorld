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
            String FileLocation = @"C:\Users\Giftedbryan\Downloads\loads\" + Counters.Nation.ToLower() + ".png";
            pictureBox1.Image = Image.FromFile(FileLocation);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Check();
            #region
            /*
            if (textBox1.Text == "The Netherlands")
            {
                Counters.Score++;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Giftedbryan\Downloads\loads\pt.png");
                //Counters.Nation = "";
            }

            if (textBox1.Text == "Portugal")
            {
                Counters.Score++;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Giftedbryan\Downloads\loads\be.png");
                //Counters.Nation = "";
            }

            if (textBox1.Text == "Belgium")
            {
                Counters.Score++;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Giftedbryan\Downloads\loads\de.png");
                //Counters.Nation = "";
            }

            if (textBox1.Text == "Germany")
            {
                Counters.Score++;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Giftedbryan\Downloads\loads\es.png");
                //Counters.Nation = "";
            }

            if (textBox1.Text == "Spain")
            {
                Counters.Score++;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Giftedbryan\Downloads\loads\gb.png");
                //Counters.Nation = "";
            }

            if (textBox1.Text == "Great Brittain")
            {
                Counters.Score++;
                pictureBox1.Image = Image.FromFile(@"C:\Users\Giftedbryan\Downloads\loads\pl.png");
                Counters.Nation = "";
            }

            if (textBox1.Text == "Poland")
            {
                Counters.Score++;
                textBox1.Text = "Good job, you finished the test";
            }
            */
            #endregion Legacy

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
                    String FileLocation = @"C:\Users\Giftedbryan\Downloads\loads\gj.png";
                    pictureBox1.Image = Image.FromFile(FileLocation);
                    textBox1.Text = "How did you do?";
                    Finished = true;
                    textBox1.ReadOnly = true;
                    pictureBox1.Focus();
                }

                if (!Program.CheckLastNation())
                {
                    Program.UpdateNation();
                    String FileLocation = @"C:\Users\Giftedbryan\Downloads\loads\" + Counters.Nation.ToLower() + ".png";
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
