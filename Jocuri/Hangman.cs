using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri
{
    public partial class Hangman : Form
    {
        string usedLetters = "";
        int mistake = 0, correct = 0;

        public Hangman()
        {
            InitializeComponent();
            label15.Text = "Litere greșite: ";
        }

        void reset()
        {
            label1.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label15.Text = "Litere greșite: ";
            mistake = 0;
            correct = 0;
            usedLetters = "";
            Refresh();
        }


        void draw()
        {
            Graphics e;
            e = this.CreateGraphics();
            if (mistake == 1)
            {
                e.DrawLine(new Pen(Color.White, 3), 50, 375, 300, 375);
                e.DrawLine(new Pen(Color.White, 3), 175, 375, 175, 100);
                e.DrawLine(new Pen(Color.White, 3), 175, 100, 300, 100);
                e.DrawLine(new Pen(Color.White, 3), 300, 100, 300, 150);
            }
            else if (mistake == 2)
                e.DrawEllipse(new Pen(Color.White, 3), 275, 150, 50, 50);
            else if (mistake == 3)
                e.DrawLine(new Pen(Color.White, 3), 300, 200, 300, 275);
            else if (mistake == 4)
                e.DrawLine(new Pen(Color.White, 3), 300, 210, 250, 240);
            else if (mistake == 5)
                e.DrawLine(new Pen(Color.White, 3), 300, 210, 350, 240);
            else if (mistake == 6)
                e.DrawLine(new Pen(Color.White, 3), 300, 275, 250, 305);
            else if (mistake == 7)
            {
                e.DrawLine(new Pen(Color.White, 3), 300, 275, 350, 305);
                MessageBox.Show("Ai pierdut!");
                reset();
            }
        }

        void verify(KeyEventArgs letter)
        {
            if(65 <= (char)letter.KeyCode && (char)letter.KeyCode <= 97)
            {
                if (usedLetters.IndexOf((char)letter.KeyCode) != -1)
                    MessageBox.Show("Ai folosit deja litera!");
                else
                {
                    if (letter.KeyCode == Keys.I)
                    {
                        label25.Visible = true;
                        label17.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.N)
                    {
                        label24.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.F)
                    {
                        label23.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.O)
                    {
                        label22.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.R)
                    {
                        label21.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.M)
                    {
                        label20.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.A)
                    {
                        label19.Visible = true;
                        label1.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.T)
                    {
                        label18.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else if (letter.KeyCode == Keys.C)
                    {
                        label16.Visible = true;
                        correct++;
                        usedLetters += letter.KeyCode.ToString();
                    }
                    else
                    {
                        label15.Text += letter.KeyCode.ToString() + " ";
                        mistake++;
                        usedLetters += letter.KeyCode.ToString();
                        draw();
                    }
                }
                if (correct == 9)
                {
                    MessageBox.Show("Ai câștigat!");
                    reset();
                }
            }
        }

        private void Hangman_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hangman_KeyDown(object sender, KeyEventArgs e)
        {
            verify(e);
        }
    }
}
