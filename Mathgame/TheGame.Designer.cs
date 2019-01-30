namespace Mathgame
{
    partial class TheGame
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
            this.components = new System.ComponentModel.Container();
            this.labelQustion = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.textBoxAnswe = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelYourScore = new System.Windows.Forms.Label();
            this.labelWrongLable = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQustion
            // 
            this.labelQustion.AutoSize = true;
            this.labelQustion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelQustion.Location = new System.Drawing.Point(20, 19);
            this.labelQustion.Name = "labelQustion";
            this.labelQustion.Size = new System.Drawing.Size(252, 20);
            this.labelQustion.TabIndex = 1;
            this.labelQustion.Text = "Solv the math within the given time";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFormula.Location = new System.Drawing.Point(20, 118);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(0, 20);
            this.labelFormula.TabIndex = 2;
            // 
            // textBoxAnswe
            // 
            this.textBoxAnswe.Location = new System.Drawing.Point(159, 118);
            this.textBoxAnswe.Name = "textBoxAnswe";
            this.textBoxAnswe.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnswe.TabIndex = 3;
            this.textBoxAnswe.TextChanged += new System.EventHandler(this.textBoxAnswe_TextChanged);
            this.textBoxAnswe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswe_KeyDown);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(160, 166);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 4;
            // 
            // labelYourScore
            // 
            this.labelYourScore.AutoSize = true;
            this.labelYourScore.Location = new System.Drawing.Point(60, 165);
            this.labelYourScore.Name = "labelYourScore";
            this.labelYourScore.Size = new System.Drawing.Size(58, 13);
            this.labelYourScore.TabIndex = 5;
            this.labelYourScore.Text = "Your score";
            // 
            // labelWrongLable
            // 
            this.labelWrongLable.AutoSize = true;
            this.labelWrongLable.Location = new System.Drawing.Point(60, 195);
            this.labelWrongLable.Name = "labelWrongLable";
            this.labelWrongLable.Size = new System.Drawing.Size(39, 13);
            this.labelWrongLable.TabIndex = 6;
            this.labelWrongLable.Text = "Wrong";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Location = new System.Drawing.Point(159, 194);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(0, 13);
            this.labelWrong.TabIndex = 7;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(219, 75);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(39, 20);
            this.textBoxTime.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "High Score:";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(144, 236);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(0, 13);
            this.labelHighScore.TabIndex = 10;
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 276);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelWrongLable);
            this.Controls.Add(this.labelYourScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxAnswe);
            this.Controls.Add(this.labelFormula);
            this.Controls.Add(this.labelQustion);
            this.Name = "TheGame";
            this.Text = "TheGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQustion;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.TextBox textBoxAnswe;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelYourScore;
        private System.Windows.Forms.Label labelWrongLable;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHighScore;
    }
}