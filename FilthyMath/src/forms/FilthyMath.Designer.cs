namespace FilthyMath
{
    partial class FilthyMath
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
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.yourNameTitle = new MetroFramework.Controls.MetroLabel();
            this.usernameText = new MetroFramework.Controls.MetroTextBox();
            this.factorsGroupBox = new System.Windows.Forms.GroupBox();
            this.questionsLabel = new MetroFramework.Controls.MetroLabel();
            this.askMeLabel = new MetroFramework.Controls.MetroLabel();
            this.questionsNumeric = new System.Windows.Forms.NumericUpDown();
            this.questionsTitle = new MetroFramework.Controls.MetroLabel();
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.helpButton = new MetroFramework.Controls.MetroButton();
            this.operationsGroupBox = new System.Windows.Forms.GroupBox();
            this.operationsOptionsButton = new MetroFramework.Controls.MetroButton();
            this.divisionOptionsButton = new MetroFramework.Controls.MetroButton();
            this.multiplicationOptionsButton = new MetroFramework.Controls.MetroButton();
            this.subtractionOptionsButton = new MetroFramework.Controls.MetroButton();
            this.additionOptionsButton = new MetroFramework.Controls.MetroButton();
            this.divisionToggle = new MetroFramework.Controls.MetroToggle();
            this.divisionLabel = new MetroFramework.Controls.MetroLabel();
            this.multiplicationToggle = new MetroFramework.Controls.MetroToggle();
            this.multiplicationLabel = new MetroFramework.Controls.MetroLabel();
            this.subtractionToggle = new MetroFramework.Controls.MetroToggle();
            this.subtractionLabel = new MetroFramework.Controls.MetroLabel();
            this.additionToggle = new MetroFramework.Controls.MetroToggle();
            this.additionLabel = new MetroFramework.Controls.MetroLabel();
            this.operationsTitle = new MetroFramework.Controls.MetroLabel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.nameGroupBox.SuspendLayout();
            this.factorsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsNumeric)).BeginInit();
            this.operationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.yourNameTitle);
            this.nameGroupBox.Location = new System.Drawing.Point(23, 63);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(181, 49);
            this.nameGroupBox.TabIndex = 0;
            this.nameGroupBox.TabStop = false;
            // 
            // yourNameTitle
            // 
            this.yourNameTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.yourNameTitle.Location = new System.Drawing.Point(6, 0);
            this.yourNameTitle.Name = "yourNameTitle";
            this.yourNameTitle.Size = new System.Drawing.Size(175, 26);
            this.yourNameTitle.TabIndex = 0;
            this.yourNameTitle.Text = "Your Name";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(30, 92);
            this.usernameText.Name = "usernameText";
            this.usernameText.PromptText = "Type your name here";
            this.usernameText.Size = new System.Drawing.Size(174, 23);
            this.usernameText.TabIndex = 1;
            this.usernameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            // 
            // factorsGroupBox
            // 
            this.factorsGroupBox.Controls.Add(this.questionsLabel);
            this.factorsGroupBox.Controls.Add(this.askMeLabel);
            this.factorsGroupBox.Controls.Add(this.questionsNumeric);
            this.factorsGroupBox.Controls.Add(this.questionsTitle);
            this.factorsGroupBox.Location = new System.Drawing.Point(23, 125);
            this.factorsGroupBox.Name = "factorsGroupBox";
            this.factorsGroupBox.Size = new System.Drawing.Size(252, 53);
            this.factorsGroupBox.TabIndex = 2;
            this.factorsGroupBox.TabStop = false;
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Location = new System.Drawing.Point(102, 30);
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(63, 19);
            this.questionsLabel.TabIndex = 3;
            this.questionsLabel.Text = "questions";
            // 
            // askMeLabel
            // 
            this.askMeLabel.AutoSize = true;
            this.askMeLabel.Location = new System.Drawing.Point(7, 30);
            this.askMeLabel.Name = "askMeLabel";
            this.askMeLabel.Size = new System.Drawing.Size(52, 19);
            this.askMeLabel.TabIndex = 2;
            this.askMeLabel.Text = "Ask me";
            // 
            // questionsNumeric
            // 
            this.questionsNumeric.Location = new System.Drawing.Point(61, 30);
            this.questionsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.questionsNumeric.Name = "questionsNumeric";
            this.questionsNumeric.Size = new System.Drawing.Size(40, 20);
            this.questionsNumeric.TabIndex = 1;
            this.questionsNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.questionsNumeric.ValueChanged += new System.EventHandler(this.questionsNumeric_ValueChanged);
            this.questionsNumeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            // 
            // questionsTitle
            // 
            this.questionsTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.questionsTitle.Location = new System.Drawing.Point(6, 0);
            this.questionsTitle.Name = "questionsTitle";
            this.questionsTitle.Size = new System.Drawing.Size(175, 27);
            this.questionsTitle.TabIndex = 0;
            this.questionsTitle.Text = "Questions";
            // 
            // startButton
            // 
            this.startButton.Highlight = true;
            this.startButton.Location = new System.Drawing.Point(405, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.Style = MetroFramework.MetroColorStyle.Green;
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start!";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(324, 218);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            // 
            // operationsGroupBox
            // 
            this.operationsGroupBox.Controls.Add(this.operationsOptionsButton);
            this.operationsGroupBox.Controls.Add(this.divisionOptionsButton);
            this.operationsGroupBox.Controls.Add(this.multiplicationOptionsButton);
            this.operationsGroupBox.Controls.Add(this.subtractionOptionsButton);
            this.operationsGroupBox.Controls.Add(this.additionOptionsButton);
            this.operationsGroupBox.Controls.Add(this.divisionToggle);
            this.operationsGroupBox.Controls.Add(this.divisionLabel);
            this.operationsGroupBox.Controls.Add(this.multiplicationToggle);
            this.operationsGroupBox.Controls.Add(this.multiplicationLabel);
            this.operationsGroupBox.Controls.Add(this.subtractionToggle);
            this.operationsGroupBox.Controls.Add(this.subtractionLabel);
            this.operationsGroupBox.Controls.Add(this.additionToggle);
            this.operationsGroupBox.Controls.Add(this.additionLabel);
            this.operationsGroupBox.Controls.Add(this.operationsTitle);
            this.operationsGroupBox.Location = new System.Drawing.Point(281, 63);
            this.operationsGroupBox.Name = "operationsGroupBox";
            this.operationsGroupBox.Size = new System.Drawing.Size(199, 121);
            this.operationsGroupBox.TabIndex = 1;
            this.operationsGroupBox.TabStop = false;
            // 
            // operationsOptionsButton
            // 
            this.operationsOptionsButton.Location = new System.Drawing.Point(160, 0);
            this.operationsOptionsButton.Name = "operationsOptionsButton";
            this.operationsOptionsButton.Size = new System.Drawing.Size(23, 23);
            this.operationsOptionsButton.TabIndex = 16;
            this.operationsOptionsButton.Text = "..";
            this.operationsOptionsButton.Click += new System.EventHandler(this.operationsOptionsButton_Click);
            // 
            // divisionOptionsButton
            // 
            this.divisionOptionsButton.Location = new System.Drawing.Point(160, 95);
            this.divisionOptionsButton.Name = "divisionOptionsButton";
            this.divisionOptionsButton.Size = new System.Drawing.Size(23, 23);
            this.divisionOptionsButton.TabIndex = 15;
            this.divisionOptionsButton.Text = "..";
            this.divisionOptionsButton.Click += new System.EventHandler(this.divisionOptionsButton_Click);
            // 
            // multiplicationOptionsButton
            // 
            this.multiplicationOptionsButton.Location = new System.Drawing.Point(160, 72);
            this.multiplicationOptionsButton.Name = "multiplicationOptionsButton";
            this.multiplicationOptionsButton.Size = new System.Drawing.Size(23, 23);
            this.multiplicationOptionsButton.TabIndex = 14;
            this.multiplicationOptionsButton.Text = "..";
            this.multiplicationOptionsButton.Click += new System.EventHandler(this.multiplicationOptionsButton_Click);
            // 
            // subtractionOptionsButton
            // 
            this.subtractionOptionsButton.Location = new System.Drawing.Point(160, 49);
            this.subtractionOptionsButton.Name = "subtractionOptionsButton";
            this.subtractionOptionsButton.Size = new System.Drawing.Size(23, 23);
            this.subtractionOptionsButton.TabIndex = 13;
            this.subtractionOptionsButton.Text = "..";
            this.subtractionOptionsButton.Click += new System.EventHandler(this.subtractionOptionsButton_Click);
            // 
            // additionOptionsButton
            // 
            this.additionOptionsButton.Location = new System.Drawing.Point(160, 26);
            this.additionOptionsButton.Name = "additionOptionsButton";
            this.additionOptionsButton.Size = new System.Drawing.Size(23, 23);
            this.additionOptionsButton.TabIndex = 12;
            this.additionOptionsButton.Text = "..";
            this.additionOptionsButton.Click += new System.EventHandler(this.additionOptionsButton_Click);
            // 
            // divisionToggle
            // 
            this.divisionToggle.AutoSize = true;
            this.divisionToggle.DisplayStatus = false;
            this.divisionToggle.Location = new System.Drawing.Point(104, 98);
            this.divisionToggle.Name = "divisionToggle";
            this.divisionToggle.Size = new System.Drawing.Size(50, 17);
            this.divisionToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.divisionToggle.TabIndex = 11;
            this.divisionToggle.Text = "Off";
            this.divisionToggle.UseStyleColors = true;
            this.divisionToggle.UseVisualStyleBackColor = true;
            this.divisionToggle.CheckedChanged += new System.EventHandler(this.operationCheckedChanged);
            this.divisionToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            this.divisionToggle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.operationsMouseUp);
            // 
            // divisionLabel
            // 
            this.divisionLabel.Location = new System.Drawing.Point(-14, 95);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(112, 19);
            this.divisionLabel.TabIndex = 10;
            this.divisionLabel.Text = "Division";
            this.divisionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // multiplicationToggle
            // 
            this.multiplicationToggle.AutoSize = true;
            this.multiplicationToggle.DisplayStatus = false;
            this.multiplicationToggle.Location = new System.Drawing.Point(104, 75);
            this.multiplicationToggle.Name = "multiplicationToggle";
            this.multiplicationToggle.Size = new System.Drawing.Size(50, 17);
            this.multiplicationToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.multiplicationToggle.TabIndex = 9;
            this.multiplicationToggle.Text = "Off";
            this.multiplicationToggle.UseStyleColors = true;
            this.multiplicationToggle.UseVisualStyleBackColor = true;
            this.multiplicationToggle.CheckedChanged += new System.EventHandler(this.operationCheckedChanged);
            this.multiplicationToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            this.multiplicationToggle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.operationsMouseUp);
            // 
            // multiplicationLabel
            // 
            this.multiplicationLabel.Location = new System.Drawing.Point(-14, 72);
            this.multiplicationLabel.Name = "multiplicationLabel";
            this.multiplicationLabel.Size = new System.Drawing.Size(112, 19);
            this.multiplicationLabel.TabIndex = 8;
            this.multiplicationLabel.Text = "Multiplication";
            this.multiplicationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // subtractionToggle
            // 
            this.subtractionToggle.AutoSize = true;
            this.subtractionToggle.DisplayStatus = false;
            this.subtractionToggle.Location = new System.Drawing.Point(104, 52);
            this.subtractionToggle.Name = "subtractionToggle";
            this.subtractionToggle.Size = new System.Drawing.Size(50, 17);
            this.subtractionToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.subtractionToggle.TabIndex = 7;
            this.subtractionToggle.Text = "Off";
            this.subtractionToggle.UseStyleColors = true;
            this.subtractionToggle.UseVisualStyleBackColor = true;
            this.subtractionToggle.CheckedChanged += new System.EventHandler(this.operationCheckedChanged);
            this.subtractionToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            this.subtractionToggle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.operationsMouseUp);
            // 
            // subtractionLabel
            // 
            this.subtractionLabel.Location = new System.Drawing.Point(-14, 49);
            this.subtractionLabel.Name = "subtractionLabel";
            this.subtractionLabel.Size = new System.Drawing.Size(112, 19);
            this.subtractionLabel.TabIndex = 6;
            this.subtractionLabel.Text = "Subtraction";
            this.subtractionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // additionToggle
            // 
            this.additionToggle.AutoSize = true;
            this.additionToggle.Checked = true;
            this.additionToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.additionToggle.DisplayStatus = false;
            this.additionToggle.Location = new System.Drawing.Point(104, 29);
            this.additionToggle.Name = "additionToggle";
            this.additionToggle.Size = new System.Drawing.Size(50, 17);
            this.additionToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.additionToggle.TabIndex = 5;
            this.additionToggle.Text = "On";
            this.additionToggle.UseStyleColors = true;
            this.additionToggle.UseVisualStyleBackColor = true;
            this.additionToggle.CheckedChanged += new System.EventHandler(this.operationCheckedChanged);
            this.additionToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            this.additionToggle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.operationsMouseUp);
            // 
            // additionLabel
            // 
            this.additionLabel.Location = new System.Drawing.Point(-14, 26);
            this.additionLabel.Name = "additionLabel";
            this.additionLabel.Size = new System.Drawing.Size(112, 19);
            this.additionLabel.TabIndex = 4;
            this.additionLabel.Text = "Addition";
            this.additionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // operationsTitle
            // 
            this.operationsTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.operationsTitle.Location = new System.Drawing.Point(6, -3);
            this.operationsTitle.Name = "operationsTitle";
            this.operationsTitle.Size = new System.Drawing.Size(193, 26);
            this.operationsTitle.TabIndex = 0;
            this.operationsTitle.Text = "Operations";
            this.operationsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(23, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FilthyMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 264);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.operationsGroupBox);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.factorsGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.MaximizeBox = false;
            this.Name = "FilthyMath";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Welcome to FilthyMath!";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Shown += new System.EventHandler(this.FilthyMath_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilthyMath_KeyDown);
            this.nameGroupBox.ResumeLayout(false);
            this.factorsGroupBox.ResumeLayout(false);
            this.factorsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsNumeric)).EndInit();
            this.operationsGroupBox.ResumeLayout(false);
            this.operationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox nameGroupBox;
        private MetroFramework.Controls.MetroLabel yourNameTitle;
        private MetroFramework.Controls.MetroTextBox usernameText;
        private System.Windows.Forms.GroupBox factorsGroupBox;
        private MetroFramework.Controls.MetroLabel questionsLabel;
        private MetroFramework.Controls.MetroLabel askMeLabel;
        private System.Windows.Forms.NumericUpDown questionsNumeric;
        private MetroFramework.Controls.MetroLabel questionsTitle;
        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroButton helpButton;
        private System.Windows.Forms.GroupBox operationsGroupBox;
        private MetroFramework.Controls.MetroToggle divisionToggle;
        private MetroFramework.Controls.MetroLabel divisionLabel;
        private MetroFramework.Controls.MetroToggle multiplicationToggle;
        private MetroFramework.Controls.MetroLabel multiplicationLabel;
        private MetroFramework.Controls.MetroToggle subtractionToggle;
        private MetroFramework.Controls.MetroLabel subtractionLabel;
        private MetroFramework.Controls.MetroToggle additionToggle;
        private MetroFramework.Controls.MetroLabel additionLabel;
        private MetroFramework.Controls.MetroLabel operationsTitle;
        private MetroFramework.Controls.MetroButton operationsOptionsButton;
        private MetroFramework.Controls.MetroButton divisionOptionsButton;
        private MetroFramework.Controls.MetroButton multiplicationOptionsButton;
        private MetroFramework.Controls.MetroButton subtractionOptionsButton;
        private MetroFramework.Controls.MetroButton additionOptionsButton;
        private MetroFramework.Controls.MetroButton exitButton;
    }
}