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
    public partial class HracForm : Form
    {
        public HracForm()
        {
            InitializeComponent();
            comboBoxKluby.Items.Add("None");
            comboBoxKluby.Items.Add("FC_Porto");
            comboBoxKluby.Items.Add("Arsenal");
            comboBoxKluby.Items.Add("Real_Madrid");
            comboBoxKluby.Items.Add("Chelsea");
            comboBoxKluby.Items.Add("Barcelona");
        }

        private void butnOkey_Click(object sender, EventArgs e)
        {
            FotbalovyKlub fk;
            textBoxJmeno.Text = "";
            
            textBoxGoly.Text = "";
            butnOkey.DialogResult = DialogResult.OK;
        }

        private void butnStornuj_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
