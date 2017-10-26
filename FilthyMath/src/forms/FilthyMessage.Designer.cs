namespace FilthyMath.src.forms
{
    partial class FilthyMessage
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
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.messageLabel = new MetroFramework.Controls.MetroLabel();
            this.smallMessageLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Highlight = true;
            this.okButton.Location = new System.Drawing.Point(198, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.messageLabel.Location = new System.Drawing.Point(23, 30);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(278, 25);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Woah! Something is wrong, amigo.";
            // 
            // smallMessageLabel
            // 
            this.smallMessageLabel.AutoSize = true;
            this.smallMessageLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.smallMessageLabel.Location = new System.Drawing.Point(23, 55);
            this.smallMessageLabel.Name = "smallMessageLabel";
            this.smallMessageLabel.Size = new System.Drawing.Size(89, 15);
            this.smallMessageLabel.TabIndex = 2;
            this.smallMessageLabel.Text = "Definitely wrong.";
            // 
            // FilthyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 136);
            this.Controls.Add(this.smallMessageLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.okButton);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilthyMessage";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Shown += new System.EventHandler(this.FilthyMessage_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroLabel messageLabel;
        private MetroFramework.Controls.MetroLabel smallMessageLabel;
    }
}