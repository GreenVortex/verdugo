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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Border
        Point lastPoint;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {if (e.Button == MouseButtons.Left){this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y;}}
        private void Main_MouseDown(object sender, MouseEventArgs e){lastPoint = new Point(e.X, e.Y);}

        //Launchers
        //L1
        private void Launcher01_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher1Path,"Launcher 1");
        }
        //L2
        private void Launcher02_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher2Path, "Launcher 2");
        }
        //L3
        private void Launcher03_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher3Path, "Launcher 3");
        }
        //L4
        private void Launcher04_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher4Path, "Launcher 4");
        }
        //L5
        private void Launcher05_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher5Path, "Launcher 5");
        }
        //L6
        private void Launcher06_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher6Path, "Launcher 6");
        }
        //L7
        private void Launcher07_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher7Path, "Launcher 7");
        }
        //L8
        private void Launcher08_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher8Path, "Launcher 8");
        }
        //L9
        private void Launcher09_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher9Path, "Launcher 9");
        }
        //L10
        private void Launcher10_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher10Path, "Launcher 10");
        }
        //L11
        private void Launcher11_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher11Path, "Launcher 11");
        }
        //L12
        private void Launcher12_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher12Path, "Launcher 12");
        }
        //L13
        private void Launcher13_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher13Path, "Launcher 13");
        }
        //L14
        private void Launcher14_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher14Path, "Launcher 14");
        }
        //L15
        private void Launcher15_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher15Path, "Launcher 15");
        }
        //L16
        private void Launcher16_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher16Path, "Launcher 16");
        }
        //L17
        private void Launcher17_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher17Path, "Launcher 17");
        }
        //L18
        private void Launcher18_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher18Path, "Launcher 18");
        }

        //TestingUnits
        static void TestUnitMsg(string msg,string testcode) 
        {
            MessageBox.Show("Testing Succeeded: " + msg, "TestMsg:" + testcode,MessageBoxButtons.OK,MessageBoxIcon.Information);
            Console.WriteLine("TestMsg:" + testcode + " Succeeded");
        }

        //Taskbar buttons
        private void BtnTerminate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static void RocketLauncher(string LaunchParam, string LaunchID)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = LaunchParam;
            try
            {
                proc.Start();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Error:Incorect path was attempted to execute, please correct path to file at " + LaunchID, "LaunchError");
                Console.WriteLine("Incorrect path at " + LaunchID);
            }

            catch
            {
                MessageBox.Show("You've somehow managed to break the software in ways we have not thought to be possible", "WOW!");
                Console.WriteLine("Unknown Error at " + LaunchID);
            }
        }
        //Setting Window Loader
        static void SettingLoader()
        {
            settings SettingsForm = new settings();
            SettingsForm.Show();
        }
    }
}
