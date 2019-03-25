namespace LigaMistru
{
    partial class NejlepsiKluby
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butnOkey = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet gólů";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kluby";
            // 
            // butnOkey
            // 
            this.butnOkey.Location = new System.Drawing.Point(356, 274);
            this.butnOkey.Name = "butnOkey";
            this.butnOkey.Size = new System.Drawing.Size(96, 29);
            this.butnOkey.TabIndex = 3;
            this.butnOkey.Text = "OK";
            this.butnOkey.UseVisualStyleBackColor = true;
            this.butnOkey.Click += new System.EventHandler(this.butnOkey_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(35, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 161);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // NejlepsiKluby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 315);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butnOkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NejlepsiKluby";
            this.Text = "Nejlepší kluby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butnOkey;
        private System.Windows.Forms.ListView listView1;
    }
}