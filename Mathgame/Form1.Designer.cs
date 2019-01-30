namespace Mathgame
{
    partial class Form1
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
            this.labelGameL = new System.Windows.Forms.Label();
            this.labelWhatIs = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGameL
            // 
            this.labelGameL.AutoSize = true;
            this.labelGameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelGameL.Location = new System.Drawing.Point(59, 40);
            this.labelGameL.Name = "labelGameL";
            this.labelGameL.Size = new System.Drawing.Size(186, 39);
            this.labelGameL.TabIndex = 0;
            this.labelGameL.Text = "Math game";
            // 
            // labelWhatIs
            // 
            this.labelWhatIs.AutoSize = true;
            this.labelWhatIs.Location = new System.Drawing.Point(108, 97);
            this.labelWhatIs.Name = "labelWhatIs";
            this.labelWhatIs.Size = new System.Drawing.Size(76, 13);
            this.labelWhatIs.TabIndex = 1;
            this.labelWhatIs.Text = "What is 2+2??";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 191);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 188);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Enabled = false;
            this.ButtonPlay.Location = new System.Drawing.Point(109, 232);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlay.TabIndex = 4;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(65, 133);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(0, 13);
            this.labelHighScore.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 322);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelWhatIs);
            this.Controls.Add(this.labelGameL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameL;
        private System.Windows.Forms.Label labelWhatIs;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Label labelHighScore;
    }
}

