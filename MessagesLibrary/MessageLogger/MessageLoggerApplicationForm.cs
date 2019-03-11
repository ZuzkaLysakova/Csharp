using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageLogger
{
    public partial class MessageLoggerApplicationForm : Form
    {

        EventHandler sendTextOtoLeftOutputEventHandler;
        EventHandler sendTextOtoRightOutputEventHandler;
        public MessageLoggerApplicationForm()
        {
            InitializeComponent();
            sendTextOtoLeftOutputEventHandler = new EventHandler(SendTextToLeftOutput);
            sendTextOtoRightOutputEventHandler = new EventHandler(SendTextToRightOutput);
        }

        

        private void SenderClick(object sender, EventArgs e)
        {
            if (LeftPanelCheckBox.Checked)
            {
                this.lefttextBox2.Text += InputMessageEditControl.Text + "\r\n";
            }
            if (RighPanelCheckBox.Checked)
            {
                this.RighttextBox3.Text += InputMessageEditControl.Text + "\r\n";
            }
        }
        private void SendTextToLeftOutput(object sender, EventArgs e)
        {
            lefttextBox2.Text += InputMessageEditControl.Text + "\r\n";
        }

        private void SendTextToRightOutput(object sender, EventArgs e)
        {
            RighttextBox3.Text += InputMessageEditControl.Text + "\r\n";
        }

        private void OutputEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler checkedChangedEventHandler = null;
            if(sender == LeftPanelCheckBox)
            {
                checkedChangedEventHandler = sendTextOtoLeftOutputEventHandler;
            }else if(sender == RighPanelCheckBox)
            {
                checkedChangedEventHandler = sendTextOtoRightOutputEventHandler;
            }
            
            if ((sender as CheckBox).Checked)
            {
                SendButton.Click += sendTextOtoLeftOutputEventHandler;
            }
            else
            {
                SendButton.Click -= sendTextOtoLeftOutputEventHandler;
            }
        }
    }
}
