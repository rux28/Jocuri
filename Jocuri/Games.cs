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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            var HistoryForm = new History();
            HistoryForm.ShowDialog();
        }

        private void TicTacToeButton_Click(object sender, EventArgs e)
        {
            var TicTacToeForm = new TicTacToe();
            TicTacToeForm.ShowDialog();
        }

        private void HangmanButton_Click(object sender, EventArgs e)
        {
            var HangmanForm = new Hangman();
            HangmanForm.ShowDialog();
        }

        private void GuessTheNumberButton_Click(object sender, EventArgs e)
        {
            var GuessTheNumberForm = new GuessTheNumber();
            GuessTheNumberForm.ShowDialog();
        }
    }
}
