using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verdugo
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        //Border
        Point lastPoint;
        private void ConfigSetMessage_MouseDown(object sender, MouseEventArgs e){ lastPoint = new Point(e.X, e.Y);}
        private void ConfigSetMessage_MouseMove(object sender, MouseEventArgs e){if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }}

        private void ConfigSetMessage_Load(object sender, EventArgs e)
        {
            /*
            if (Properties.Settings.Default.SetLauncherSuccess == true)
            {
                DescriptionText.Text = "Settings applied successfully";
                OkayButton.Text = "Perfect";
            }

            else
            {
                DescriptionText.Text = "Unfortunately the settings were not applied";
                OkayButton.Text = "oh";
            }
            */

            switch (Properties.Settings.Default.FeedbackCode)
            {
                case "ConfigSuccess":
                    DescriptionText.Text = "Settings applied successfully";
                    OkayButton.Text = "Perfect";
                    break;
                case "ConfigFail":
                    DescriptionText.Text = "Unfortunately the settings were not applied";
                    OkayButton.Text = "oh";
                    break;
                case "EmptyExec":
                    DescriptionText.Text = "Please enter text into the Executable path field";
                    OkayButton.Text = "oh";
                    break;
                default:
                    DescriptionText.Text = "Unknown Feedback";
                    OkayButton.Text = "Zoinks";
                    break;
            }
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
