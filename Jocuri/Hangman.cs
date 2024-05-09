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
        string word = "INFORMATICA";

        public Hangman()
        {
            InitializeComponent();
            label15.Text = "Litere greșite: ";
        }

        void verify(KeyEventArgs letter)
        {
            if (letter.KeyCode == Keys.I)
            {
                label25.Visible = true;
                label17.Visible = true;
            }
            else if (letter.KeyCode == Keys.N)
                label24.Visible = true;
            else if (letter.KeyCode == Keys.F)
                label23.Visible = true;
            else if (letter.KeyCode == Keys.O)
                label22.Visible = true;
            else if (letter.KeyCode == Keys.R)
                label21.Visible = true;
            else if (letter.KeyCode == Keys.M)
                label20.Visible = true;
            else if (letter.KeyCode == Keys.A)
            {
                label19.Visible = true;
                label1.Visible = true;
            }
            else if (letter.KeyCode == Keys.T)
                label18.Visible = true;
            else if (letter.KeyCode == Keys.C)
                label16.Visible = true;
            else
                label15.Text += letter.KeyCode.ToString() + " ";
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
