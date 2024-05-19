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
    public partial class GuessTheNumber : Form
    {
        int randomNumber, guessedNumber;
        public GuessTheNumber()
        {
            InitializeComponent();
            randomNumber = -1;
        }

        void binarySearch()
        {
            if (randomNumber == guessedNumber)
            {
                MessageBox.Show("Ai ghicit! Numărul era " + randomNumber.ToString() + "!");
                label3.Text = "Numere ghicite: ";
                randomNumber = -1;
            }
            else if(randomNumber < guessedNumber)
            {
                MessageBox.Show("Numărul e mai mic!");
                label3.Text += guessedNumber.ToString() + " ";
            }
            else
            {
                MessageBox.Show("Numărul e mai mare!");
                label3.Text += guessedNumber.ToString() + " ";
            }    
        }


        private void GuessTheNumber_Load(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 101);
            MessageBox.Show("Calculatorul a generat un număr.");
            label3.Text = "Numere ghicite: ";
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (randomNumber == -1)
            {
                MessageBox.Show("Nu ai generat un număr!");
                richTextBox1.Text = "";
            }
            else
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                    if (!"0123456789".Contains(richTextBox1.Text[i].ToString()))
                        ok = false;
                if (ok == true)
                {
                    guessedNumber = Int32.Parse(richTextBox1.Text);
                    richTextBox1.Text = "";
                    if (guessedNumber < 1 || guessedNumber > 100)
                        MessageBox.Show("Nu ai introdus un număr de la 1 la 100!");
                    else
                        binarySearch();
                }
                else
                {
                    MessageBox.Show("Nu ai introdus un număr!");
                    richTextBox1.Text = "";
                }
            }
        }
    }
}
