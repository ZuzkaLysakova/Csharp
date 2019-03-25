namespace LigaMistru
{
    partial class LigaMistru
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
            this.butnPřidej = new System.Windows.Forms.Button();
            this.butnVymaz = new System.Windows.Forms.Button();
            this.butnUprav = new System.Windows.Forms.Button();
            this.butnNejlepsi = new System.Windows.Forms.Button();
            this.butnRegistruj = new System.Windows.Forms.Button();
            this.butnZrusRegis = new System.Windows.Forms.Button();
            this.butnUkonci = new System.Windows.Forms.Button();
            this.dataGridViewHraci = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHraci)).BeginInit();
            this.SuspendLayout();
            // 
            // butnPřidej
            // 
            this.butnPřidej.Location = new System.Drawing.Point(592, 33);
            this.butnPřidej.Name = "butnPřidej";
            this.butnPřidej.Size = new System.Drawing.Size(118, 27);
            this.butnPřidej.TabIndex = 0;
            this.butnPřidej.Text = "Přidat";
            this.butnPřidej.UseVisualStyleBackColor = true;
            this.butnPřidej.Click += new System.EventHandler(this.butnPřidej_Click);
            // 
            // butnVymaz
            // 
            this.butnVymaz.Location = new System.Drawing.Point(592, 77);
            this.butnVymaz.Name = "butnVymaz";
            this.butnVymaz.Size = new System.Drawing.Size(118, 29);
            this.butnVymaz.TabIndex = 1;
            this.butnVymaz.Text = "Vymazat";
            this.butnVymaz.UseVisualStyleBackColor = true;
            this.butnVymaz.Click += new System.EventHandler(this.butnVymaz_Click);
            // 
            // butnUprav
            // 
            this.butnUprav.Location = new System.Drawing.Point(592, 126);
            this.butnUprav.Name = "butnUprav";
            this.butnUprav.Size = new System.Drawing.Size(118, 29);
            this.butnUprav.TabIndex = 2;
            this.butnUprav.Text = "Upravit";
            this.butnUprav.UseVisualStyleBackColor = true;
            this.butnUprav.Click += new System.EventHandler(this.butnUprav_Click);
            // 
            // butnNejlepsi
            // 
            this.butnNejlepsi.Location = new System.Drawing.Point(592, 173);
            this.butnNejlepsi.Name = "butnNejlepsi";
            this.butnNejlepsi.Size = new System.Drawing.Size(118, 29);
            this.butnNejlepsi.TabIndex = 3;
            this.butnNejlepsi.Text = "Nejlepší klub";
            this.butnNejlepsi.UseVisualStyleBackColor = true;
            this.butnNejlepsi.Click += new System.EventHandler(this.button3_Click);
            // 
            // butnRegistruj
            // 
            this.butnRegistruj.Location = new System.Drawing.Point(592, 222);
            this.butnRegistruj.Name = "butnRegistruj";
            this.butnRegistruj.Size = new System.Drawing.Size(118, 27);
            this.butnRegistruj.TabIndex = 4;
            this.butnRegistruj.Text = "Registrovat";
            this.butnRegistruj.UseVisualStyleBackColor = true;
            this.butnRegistruj.Click += new System.EventHandler(this.butnRegistruj_Click);
            // 
            // butnZrusRegis
            // 
            this.butnZrusRegis.Location = new System.Drawing.Point(592, 267);
            this.butnZrusRegis.Name = "butnZrusRegis";
            this.butnZrusRegis.Size = new System.Drawing.Size(118, 26);
            this.butnZrusRegis.TabIndex = 5;
            this.butnZrusRegis.Text = "Zrušit registraci";
            this.butnZrusRegis.UseVisualStyleBackColor = true;
            this.butnZrusRegis.Click += new System.EventHandler(this.butnZrusRegis_Click);
            // 
            // butnUkonci
            // 
            this.butnUkonci.Location = new System.Drawing.Point(592, 391);
            this.butnUkonci.Name = "butnUkonci";
            this.butnUkonci.Size = new System.Drawing.Size(118, 26);
            this.butnUkonci.TabIndex = 6;
            this.butnUkonci.Text = "Ukončit";
            this.butnUkonci.UseVisualStyleBackColor = true;
            this.butnUkonci.Click += new System.EventHandler(this.butnUkonci_Click);
            // 
            // dataGridViewHraci
            // 
            this.dataGridViewHraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHraci.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHraci.Name = "dataGridViewHraci";
            this.dataGridViewHraci.RowTemplate.Height = 24;
            this.dataGridViewHraci.Size = new System.Drawing.Size(548, 295);
            this.dataGridViewHraci.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 337);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 80);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LigaMistru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 429);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridViewHraci);
            this.Controls.Add(this.butnUkonci);
            this.Controls.Add(this.butnZrusRegis);
            this.Controls.Add(this.butnRegistruj);
            this.Controls.Add(this.butnNejlepsi);
            this.Controls.Add(this.butnUprav);
            this.Controls.Add(this.butnVymaz);
            this.Controls.Add(this.butnPřidej);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LigaMistru";
            this.Text = "Liga Mistrů";
            this.Load += new System.EventHandler(this.LigaMistru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHraci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butnPřidej;
        private System.Windows.Forms.Button butnVymaz;
        private System.Windows.Forms.Button butnUprav;
        private System.Windows.Forms.Button butnNejlepsi;
        private System.Windows.Forms.Button butnRegistruj;
        private System.Windows.Forms.Button butnZrusRegis;
        private System.Windows.Forms.Button butnUkonci;
        private System.Windows.Forms.DataGridView dataGridViewHraci;
        private System.Windows.Forms.ListView listView1;
    }
}

