namespace FilthyMath
{
    partial class FilthyGame
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
            this.answerText = new MetroFramework.Controls.MetroTextBox();
            this.promptLabel = new MetroFramework.Controls.MetroLabel();
            this.questionLabel = new MetroFramework.Controls.MetroLabel();
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(250, 92);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(75, 23);
            this.answerText.TabIndex = 0;
            this.answerText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Answer);
            // 
            // promptLabel
            // 
            this.promptLabel.Location = new System.Drawing.Point(23, 60);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(243, 19);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "Prompt";
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(23, 92);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(221, 19);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "11 + 50 =";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // colorTimer
            // 
            this.colorTimer.Interval = 1000;
            this.colorTimer.Tick += new System.EventHandler(this.colorTimer_Tick);
            // 
            // FilthyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 128);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.answerText);
            this.MaximizeBox = false;
            this.Name = "FilthyGame";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Question 1";
            this.Shown += new System.EventHandler(this.FilthyGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Answer);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox answerText;
        private MetroFramework.Controls.MetroLabel promptLabel;
        private MetroFramework.Controls.MetroLabel questionLabel;
        private System.Windows.Forms.Timer colorTimer;
    }
}