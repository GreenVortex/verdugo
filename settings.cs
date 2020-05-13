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
            LauncherSelect.SelectedIndex = 0;
        }

        //Border drag Functionality
        Point lastPoint;
        private void settings_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void settings_MouseMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; } }

        //Taskbar buttons
        private void BtnTerminate_Click(object sender, EventArgs e){this.Close();}

        private void ApplySettings_Click(object sender, EventArgs e)
        {
            int LauncherID = LauncherSelect.SelectedIndex;
            switch (LauncherID)
            {
                case 0:
                    Properties.Settings.Default.Launcher1Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 1:
                    Properties.Settings.Default.Launcher2Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 2:
                    Properties.Settings.Default.Launcher3Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 3:
                    Properties.Settings.Default.Launcher4Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 4:
                    Properties.Settings.Default.Launcher5Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 5:
                    Properties.Settings.Default.Launcher6Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 6:
                    Properties.Settings.Default.Launcher7Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 7:
                    Properties.Settings.Default.Launcher8Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 8:
                    Properties.Settings.Default.Launcher9Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 9:
                    Properties.Settings.Default.Launcher10Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 10:
                    Properties.Settings.Default.Launcher11Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 11:
                    Properties.Settings.Default.Launcher12Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 12:
                    Properties.Settings.Default.Launcher13Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 13:
                    Properties.Settings.Default.Launcher14Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 14:
                    Properties.Settings.Default.Launcher15Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 15:
                    Properties.Settings.Default.Launcher16Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 16:
                    Properties.Settings.Default.Launcher17Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                case 17:
                    Properties.Settings.Default.Launcher18Path = ExecPath.Text;
                    Properties.Settings.Default.Save();
                    break;
                default:
                    Console.WriteLine("!WARNING!: An undefined launcherselector index was passed on");
                    break;
            }
        }
    }
}
