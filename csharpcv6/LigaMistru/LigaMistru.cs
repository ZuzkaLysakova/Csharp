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
            dataGridViewHraci.Rows.Clear();
        }



        private void butnUprav_Click(object sender, EventArgs e)
        {
            HracForm hrac = new HracForm();

            hrac.textBoxJmeno.Text = dataGridViewHraci.CurrentRow.Cells[0].Value.ToString();
            hrac.comboBoxKluby.Text = dataGridViewHraci.CurrentRow.Cells[1].Value.ToString();
            hrac.textBoxGoly.Text = dataGridViewHraci.CurrentRow.Cells[2].Value.ToString();
            hrac.ShowDialog();
            
            //dataGridViewHraci.Rows.Add(HracForm.);
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

        private void butnPridej_Click(object sender, EventArgs e)
        {
            HracForm hrac = new HracForm();

            hrac.ShowDialog();
            dataGridViewHraci.Rows.Add(hrac.textBoxJmeno.Text, hrac.comboBoxKluby.SelectedItem, hrac.textBoxGoly.Text);
        }
    }
}
