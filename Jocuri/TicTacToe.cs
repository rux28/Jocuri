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
    public partial class TicTacToe : Form
    {
        public static int cine = 1;

        int[] line1;
        int[] line2;
        int[] line3;
        int[] column1;
        int[] column2;
        int[] column3;

        public TicTacToe()
        {
            InitializeComponent();
            line1 = new int[3];
            line2 = new int[3];
            line3 = new int[3];
            column1 = new int[3];
            column2 = new int[3];
            column3 = new int[3];
            line1[0] = line1[1] = line1[2] = column1[0] = column1[1] = column1[2] = 0;
            line2[0] = line2[1] = line2[2] = column2[0] = column2[1] = column2[2] = 0;
            line3[0] = line3[1] = line3[2] = column3[0] = column3[1] = column3[2] = 0;
        }

        int verify()
        {
            if ((line1[0] == 1 && line1[1] == 1 && line1[2] == 1) &&
               (line2[0] == 1 && line2[1] == 1 && line2[2] == 1) &&
               (line3[0] == 1 && line3[1] == 1 && line3[2] == 1) &&
               (column1[0] == 1 && column1[1] == 1 && column1[2] == 1) &&
               (column2[0] == 1 && column2[1] == 1 && column2[2] == 1) &&
               (column3[0] == 1 && column3[1] == 1 && column3[2] == 1) &&
               (line1[0] == 1 && line2[1] == 1 && line3[2] == 1) &&
               (line1[2] == 1 && line2[1] == 1 && line3[0] == 1))
                return 2;
            else if ((line1[0] == 1 && line1[1] == 1 && line1[2] == 1) ||
               (line2[0] == 1 && line2[1] == 1 && line2[2] == 1) ||
               (line3[0] == 1 && line3[1] == 1 && line3[2] == 1) ||
               (column1[0] == 1 && column1[1] == 1 && column1[2] == 1) ||
               (column2[0] == 1 && column2[1] == 1 && column2[2] == 1) ||
               (column3[0] == 1 && column3[1] == 1 && column3[2] == 1) ||
               (line1[0] == 1 && line2[1] == 1 && line3[2] == 1) ||
               (line1[2] == 1 && line2[1] == 1 && line3[0] == 1))
                return 1;
            return 3;
        }
        int player()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
                return 1;
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
                return 2;
            return 3;
        }
        void reset()
        {
            line1[0] = line1[1] = line1[2] = column1[0] = column1[1] = column1[2] = 0;
            line2[0] = line2[1] = line2[2] = column2[0] = column2[1] = column2[2] = 0;
            line3[0] = line3[1] = line3[2] = column3[0] = column3[1] = column3[2] = 0;
            button1.Text = button2.Text = button3.Text = "";
            button4.Text = button5.Text = button6.Text = "";
            button7.Text = button8.Text = button9.Text = "";
            cine = 1;
        }
        void put()
        {
            if (cine % 2 == 0)
            {
                cine++;
                label1.Text = "Pune X";
            }
            else
            {
                cine++;
                label1.Text = "Pune O";
            }
        }
        void win()
        {
            if (verify() == 1 && player() == 1)
            {
                MessageBox.Show("X a câștigat jocul!");
                reset();
            }
            else if (verify() == 1 && player() == 2)
            {
                MessageBox.Show("O a câștigat jocul!");
                reset();
            }
            else if (verify() == 2 && player() == 3)
            {
                MessageBox.Show("Remiză.");
                reset();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button1.Text = "X";
            else
                button1.Text = "O";
            put();
            line1[0] = 1;
            column1[0] = 1;
            win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button2.Text = "X";
            else
                button2.Text = "O";
            put();
            line1[1] = 1;
            column2[0] = 1;
            win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button3.Text = "X";
            else
                button3.Text = "O";
            put();
            line1[2] = 1;
            column3[0] = 1;
            win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button4.Text = "X";
            else
                button4.Text = "O";
            put();
            line2[0] = 1;
            column1[1] = 1;
            win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button5.Text = "X";
            else
                button5.Text = "O";
            put();
            line2[1] = 1;
            column2[1] = 1;
            win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button6.Text = "X";
            else
                button6.Text = "O";
            put();
            line2[2] = 1;
            column3[1] = 1;
            win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button7.Text = "X";
            else
                button7.Text = "O";
            put();
            line3[0] = 1;
            column1[2] = 1;
            win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button8.Text = "X";
            else
                button8.Text = "O";
            put();
            line3[1] = 1;
            column2[2] = 1;
            win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cine % 2 == 1)
                button9.Text = "X";
            else
                button9.Text = "O";
            put();
            line3[2] = 1;
            column3[2] = 1;
            win();
        }
    }
}
