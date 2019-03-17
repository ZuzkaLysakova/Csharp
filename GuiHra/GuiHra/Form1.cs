using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiHra
{
    public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public event UpdatedStatsEventHandler UpdateStats;



        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Stats
    {
        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public int Accuracy { get; private set; }

        public event UpdatedStatsEventHandler UpdatedStats;
        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        private void Update(bool correctKey)
        {
            if(correctKey == true)
            {
                Correct++;
            }
            else
            {
                Missed++;
            }
            Accuracy = Correct / Missed * 100;
            OnUpdatedStats();
        }
    }
}
