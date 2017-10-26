namespace FilthyMath.src.forms
{
    partial class FilthyOperation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.andLabel = new MetroFramework.Controls.MetroLabel();
            this.factorRange2Numeric = new System.Windows.Forms.NumericUpDown();
            this.numbersBetweenLabel = new MetroFramework.Controls.MetroLabel();
            this.factorRange1Numeric = new System.Windows.Forms.NumericUpDown();
            this.factorRangeTitle = new MetroFramework.Controls.MetroLabel();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.applyButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorRange2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorRange1Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.andLabel);
            this.groupBox1.Controls.Add(this.factorRange2Numeric);
            this.groupBox1.Controls.Add(this.numbersBetweenLabel);
            this.groupBox1.Controls.Add(this.factorRange1Numeric);
            this.groupBox1.Controls.Add(this.factorRangeTitle);
            this.groupBox1.Location = new System.Drawing.Point(24, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(166, 30);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(31, 19);
            this.andLabel.TabIndex = 3;
            this.andLabel.Text = "and";
            // 
            // factorRange2Numeric
            // 
            this.factorRange2Numeric.Location = new System.Drawing.Point(200, 30);
            this.factorRange2Numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.factorRange2Numeric.Name = "factorRange2Numeric";
            this.factorRange2Numeric.Size = new System.Drawing.Size(40, 20);
            this.factorRange2Numeric.TabIndex = 3;
            this.factorRange2Numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numbersBetweenLabel
            // 
            this.numbersBetweenLabel.AutoSize = true;
            this.numbersBetweenLabel.Location = new System.Drawing.Point(7, 30);
            this.numbersBetweenLabel.Name = "numbersBetweenLabel";
            this.numbersBetweenLabel.Size = new System.Drawing.Size(116, 19);
            this.numbersBetweenLabel.TabIndex = 2;
            this.numbersBetweenLabel.Text = "Numbers between";
            // 
            // factorRange1Numeric
            // 
            this.factorRange1Numeric.Location = new System.Drawing.Point(125, 30);
            this.factorRange1Numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.factorRange1Numeric.Name = "factorRange1Numeric";
            this.factorRange1Numeric.Size = new System.Drawing.Size(40, 20);
            this.factorRange1Numeric.TabIndex = 1;
            // 
            // factorRangeTitle
            // 
            this.factorRangeTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.factorRangeTitle.Location = new System.Drawing.Point(6, 0);
            this.factorRangeTitle.Name = "factorRangeTitle";
            this.factorRangeTitle.Size = new System.Drawing.Size(175, 27);
            this.factorRangeTitle.TabIndex = 0;
            this.factorRangeTitle.Text = "Factor Range";
            // 
            // okButton
            // 
            this.okButton.Highlight = true;
            this.okButton.Location = new System.Drawing.Point(202, 122);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = MetroFramework.MetroColorStyle.Green;
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(121, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(40, 122);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // FilthyOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 168);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilthyOperation";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Operation Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factorRange2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorRange1Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel andLabel;
        private MetroFramework.Controls.MetroLabel numbersBetweenLabel;
        private MetroFramework.Controls.MetroLabel factorRangeTitle;
        private MetroFramework.Controls.MetroButton okButton;
        internal System.Windows.Forms.NumericUpDown factorRange1Numeric;
        internal System.Windows.Forms.NumericUpDown factorRange2Numeric;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton applyButton;
    }
}