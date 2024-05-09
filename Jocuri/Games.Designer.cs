
namespace Jocuri
{
    partial class Games
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.TicTacToeButton = new System.Windows.Forms.Button();
            this.HangmanButton = new System.Windows.Forms.Button();
            this.GuessTheNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jocuri";
            // 
            // HistoryButton
            // 
            this.HistoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.Location = new System.Drawing.Point(674, 260);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(200, 150);
            this.HistoryButton.TabIndex = 1;
            this.HistoryButton.Text = "Istoria Jocurilor";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // TicTacToeButton
            // 
            this.TicTacToeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TicTacToeButton.BackgroundImage = global::Jocuri.Properties.Resources.Tic_tac_toe_svg;
            this.TicTacToeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TicTacToeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicTacToeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToeButton.Location = new System.Drawing.Point(250, 584);
            this.TicTacToeButton.Name = "TicTacToeButton";
            this.TicTacToeButton.Size = new System.Drawing.Size(200, 150);
            this.TicTacToeButton.TabIndex = 2;
            this.TicTacToeButton.UseVisualStyleBackColor = true;
            this.TicTacToeButton.Click += new System.EventHandler(this.TicTacToeButton_Click);
            // 
            // HangmanButton
            // 
            this.HangmanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HangmanButton.BackgroundImage = global::Jocuri.Properties.Resources.hangman;
            this.HangmanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HangmanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HangmanButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangmanButton.Location = new System.Drawing.Point(674, 584);
            this.HangmanButton.Name = "HangmanButton";
            this.HangmanButton.Size = new System.Drawing.Size(200, 150);
            this.HangmanButton.TabIndex = 3;
            this.HangmanButton.UseVisualStyleBackColor = true;
            this.HangmanButton.Click += new System.EventHandler(this.HangmanButton_Click);
            // 
            // GuessTheNumberButton
            // 
            this.GuessTheNumberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuessTheNumberButton.BackgroundImage = global::Jocuri.Properties.Resources.GuessTheNumber;
            this.GuessTheNumberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuessTheNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuessTheNumberButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessTheNumberButton.Location = new System.Drawing.Point(1099, 584);
            this.GuessTheNumberButton.Name = "GuessTheNumberButton";
            this.GuessTheNumberButton.Size = new System.Drawing.Size(200, 150);
            this.GuessTheNumberButton.TabIndex = 4;
            this.GuessTheNumberButton.UseVisualStyleBackColor = true;
            this.GuessTheNumberButton.Click += new System.EventHandler(this.GuessTheNumberButton_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jocuri.Properties.Resources.games;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.GuessTheNumberButton);
            this.Controls.Add(this.HangmanButton);
            this.Controls.Add(this.TicTacToeButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.label1);
            this.Name = "Games";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button TicTacToeButton;
        private System.Windows.Forms.Button HangmanButton;
        private System.Windows.Forms.Button GuessTheNumberButton;
    }
}

