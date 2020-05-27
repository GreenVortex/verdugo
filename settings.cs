using System;
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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        private void settings_Load(object sender, EventArgs e)
        {
            //Sets the launcher selector to the first entree making sure the entree is not left blank
            LauncherSelect.SelectedIndex = 0;
        }

        //Border drag Functionality
        Point lastPoint;
        private void settings_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void settings_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; } }

        //Taskbar buttons
        private void BtnTerminate_Click(object sender, EventArgs e){this.Close();}

        //Feedback dialogue caller
        static void Feedback()
        {
            FeedBack Feedback = new FeedBack();
            Feedback.Show();
        }

        private void ApplySettings_Click(object sender, EventArgs e)
        {
            //Check if the execPath field is empty
            string IsFilled = ExecPath.Text;
            if (IsFilled.Length > 0)
            {
                //Pass index value to variable as int for switch statement
                int LauncherID = LauncherSelect.SelectedIndex;
                //Determine which launcher was selected and set coresponding settings
                switch (LauncherID)
                {
                    case 0: //Launcher1
                        Properties.Settings.Default.Launcher1Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 1: //Launcher2
                        Properties.Settings.Default.Launcher2Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 2: //Launcher3
                        Properties.Settings.Default.Launcher3Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 3: //Launcher4
                        Properties.Settings.Default.Launcher4Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 4: //Launcher5
                        Properties.Settings.Default.Launcher5Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 5: //Launcher6
                        Properties.Settings.Default.Launcher6Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 6: //Launcher7
                        Properties.Settings.Default.Launcher7Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 7: //Launcher8
                        Properties.Settings.Default.Launcher8Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 8: //Launcher9
                        Properties.Settings.Default.Launcher9Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 9: //Launcher10
                        Properties.Settings.Default.Launcher10Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 10: //Launcher11
                        Properties.Settings.Default.Launcher11Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 11: //Launcher12
                        Properties.Settings.Default.Launcher12Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 12: //Launcher13
                        Properties.Settings.Default.Launcher13Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 13: //Launcher14
                        Properties.Settings.Default.Launcher14Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 14: //Launcher15
                        Properties.Settings.Default.Launcher15Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 15: //Launcher16
                        Properties.Settings.Default.Launcher16Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 16: //Launcher17
                        Properties.Settings.Default.Launcher17Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    case 17: //Launcher18
                        Properties.Settings.Default.Launcher18Path = ExecPath.Text;
                        Properties.Settings.Default.FeedbackCode = "ConfigSuccess";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                    default: //Assigned to a launcher ID thats's out off bounds
                        Console.WriteLine("!WARNING!: An undefined launcherselector index was passed on");
                        Properties.Settings.Default.FeedbackCode = "ConfigFail";
                        Properties.Settings.Default.Save();
                        Feedback();
                        break;
                }
            }
            else
            {
                //Sends feedback code for empty exec field
                Properties.Settings.Default.FeedbackCode = "EmptyExec";
                Properties.Settings.Default.Save();
                Feedback();
            }


        }

        private void FindPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                ExecPath.Text = Open.FileName;
            }
        }
    }
}
