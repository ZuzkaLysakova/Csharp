using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaMistru
{
    public partial class LigaMistru : Form
    {
        public LigaMistru()
        {
            InitializeComponent();
            dataGridViewHraci.ColumnCount = 4;
            dataGridViewHraci.ColumnHeadersVisible = true;
            dataGridViewHraci.Columns[0].Name = "Jméno";
            dataGridViewHraci.Columns[1].Name = "Klub";
            dataGridViewHraci.Columns[2].Name = "Góly";
            dataGridViewHraci.Columns[3].Name = "";
        }

        private void LigaMistru_Load(object sender, EventArgs e)
        {

        }

        private void butnVymaz_Click(object sender, EventArgs e)
        {

        }

        private void butnPřidej_Click(object sender, EventArgs e)
        {
            HracForm hrac = new HracForm();
            hrac.ShowDialog();
        }

        private void butnUprav_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NejlepsiKluby nejKluby = new NejlepsiKluby();
            nejKluby.ShowDialog();
        }

        private void butnRegistruj_Click(object sender, EventArgs e)
        {

        }

        private void butnZrusRegis_Click(object sender, EventArgs e)
        {

        }

        private void butnUkonci_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
