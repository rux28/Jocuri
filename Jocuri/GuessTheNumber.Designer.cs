
namespace Jocuri
{
    partial class GuessTheNumber
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
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculatorul se va gândi la un număr de la 1 la 100, iar tu va trebui să îl ghice" +
    "ști!";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(86, 60);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(160, 80);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generează un număr";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introdu numărul la care te gândești:\r\n";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(539, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(82, 41);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // guessButton
            // 
            this.guessButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.guessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guessButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(671, 211);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(144, 41);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "Ghicește";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numere ghicite: ";
            // 
            // GuessTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jocuri.Properties.Resources.GuessTheNumberBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Name = "GuessTheNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessTheNumber";
            this.Load += new System.EventHandler(this.GuessTheNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label3;
    }
}