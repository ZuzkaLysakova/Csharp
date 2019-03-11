namespace MessageLogger
{
    partial class MessageLoggerApplicationForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.LeftPanelCheckBox = new System.Windows.Forms.CheckBox();
            this.RighPanelCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InputMessageEditControl = new System.Windows.Forms.TextBox();
            this.lefttextBox2 = new System.Windows.Forms.TextBox();
            this.RighttextBox3 = new System.Windows.Forms.TextBox();
            this.LeftgroupBox1 = new System.Windows.Forms.GroupBox();
            this.RightgroupBox2 = new System.Windows.Forms.GroupBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.LeftgroupBox1.SuspendLayout();
            this.RightgroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(341, 119);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SenderClick);
            // 
            // LeftPanelCheckBox
            // 
            this.LeftPanelCheckBox.AutoSize = true;
            this.LeftPanelCheckBox.Location = new System.Drawing.Point(13, 51);
            this.LeftPanelCheckBox.Name = "LeftPanelCheckBox";
            this.LeftPanelCheckBox.Size = new System.Drawing.Size(90, 21);
            this.LeftPanelCheckBox.TabIndex = 1;
            this.LeftPanelCheckBox.Text = "LeftPanel";
            this.LeftPanelCheckBox.UseVisualStyleBackColor = true;
            this.LeftPanelCheckBox.CheckedChanged += new System.EventHandler(this.OutputEnabledCheckBox_CheckedChanged);
            // 
            // RighPanelCheckBox
            // 
            this.RighPanelCheckBox.AutoSize = true;
            this.RighPanelCheckBox.Location = new System.Drawing.Point(13, 12);
            this.RighPanelCheckBox.Name = "RighPanelCheckBox";
            this.RighPanelCheckBox.Size = new System.Drawing.Size(102, 21);
            this.RighPanelCheckBox.TabIndex = 0;
            this.RighPanelCheckBox.Text = "Right panel";
            this.RighPanelCheckBox.UseVisualStyleBackColor = true;
            // 
            // InputMessageEditControl
            // 
            this.InputMessageEditControl.Location = new System.Drawing.Point(12, 119);
            this.InputMessageEditControl.Multiline = true;
            this.InputMessageEditControl.Name = "InputMessageEditControl";
            this.InputMessageEditControl.Size = new System.Drawing.Size(314, 78);
            this.InputMessageEditControl.TabIndex = 3;
            // 
            // lefttextBox2
            // 
            this.lefttextBox2.Location = new System.Drawing.Point(6, 33);
            this.lefttextBox2.Multiline = true;
            this.lefttextBox2.Name = "lefttextBox2";
            this.lefttextBox2.Size = new System.Drawing.Size(263, 153);
            this.lefttextBox2.TabIndex = 0;
            // 
            // RighttextBox3
            // 
            this.RighttextBox3.Location = new System.Drawing.Point(6, 33);
            this.RighttextBox3.Multiline = true;
            this.RighttextBox3.Name = "RighttextBox3";
            this.RighttextBox3.Size = new System.Drawing.Size(257, 153);
            this.RighttextBox3.TabIndex = 0;
            // 
            // LeftgroupBox1
            // 
            this.LeftgroupBox1.Controls.Add(this.lefttextBox2);
            this.LeftgroupBox1.Enabled = false;
            this.LeftgroupBox1.Location = new System.Drawing.Point(16, 257);
            this.LeftgroupBox1.Name = "LeftgroupBox1";
            this.LeftgroupBox1.Size = new System.Drawing.Size(345, 206);
            this.LeftgroupBox1.TabIndex = 4;
            this.LeftgroupBox1.TabStop = false;
            this.LeftgroupBox1.Text = "Left output";
            // 
            // RightgroupBox2
            // 
            this.RightgroupBox2.Controls.Add(this.RighttextBox3);
            this.RightgroupBox2.Location = new System.Drawing.Point(402, 257);
            this.RightgroupBox2.Name = "RightgroupBox2";
            this.RightgroupBox2.Size = new System.Drawing.Size(288, 206);
            this.RightgroupBox2.TabIndex = 5;
            this.RightgroupBox2.TabStop = false;
            this.RightgroupBox2.Text = "Right output";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 96);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(43, 17);
            this.InputLabel.TabIndex = 6;
            this.InputLabel.Text = "Input:";
            // 
            // MessageLoggerApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 521);
            this.Controls.Add(this.LeftPanelCheckBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.RighPanelCheckBox);
            this.Controls.Add(this.RightgroupBox2);
            this.Controls.Add(this.LeftgroupBox1);
            this.Controls.Add(this.InputMessageEditControl);
            this.Controls.Add(this.SendButton);
            this.Name = "MessageLoggerApplicationForm";
            this.Text = "Message Logger Application";
            this.LeftgroupBox1.ResumeLayout(false);
            this.LeftgroupBox1.PerformLayout();
            this.RightgroupBox2.ResumeLayout(false);
            this.RightgroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox InputMessageEditControl;
        private System.Windows.Forms.CheckBox LeftPanelCheckBox;
        private System.Windows.Forms.CheckBox RighPanelCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox lefttextBox2;
        private System.Windows.Forms.TextBox RighttextBox3;
        private System.Windows.Forms.GroupBox LeftgroupBox1;
        private System.Windows.Forms.GroupBox RightgroupBox2;
        private System.Windows.Forms.Label InputLabel;
    }
}

