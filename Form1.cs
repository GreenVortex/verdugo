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
        private void Main_MouseMove(object sender, MouseEventArgs e){if (e.Button == MouseButtons.Left){this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y;}}
        private void Main_MouseDown(object sender, MouseEventArgs e){lastPoint = new Point(e.X, e.Y);}

        //Launchers
        //L1
        private void Launcher01_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher1Path,"Launcher 1");
        }
        private void Launcher1Pic_Click(object sender, EventArgs e)
        {

        }
        //L2
        private void Launcher02_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher2Path, "Launcher 2");
        }
        private void Launcher2Pic_Click(object sender, EventArgs e)
        {

        }
        //L3
        private void Launcher03_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher3Path, "Launcher 3");
        }
        private void Launcher3Pic_Click(object sender, EventArgs e)
        {

        }
        //L4
        private void Launcher04_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher4Path, "Launcher 4");
        }
        private void Launcher4Pic_Click(object sender, EventArgs e)
        {

        }
        //L5
        private void Launcher05_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher5Path, "Launcher 5");
        }
        private void Launcher5Pic_Click(object sender, EventArgs e)
        {

        }
        //L6
        private void Launcher06_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher6Path, "Launcher 6");
        }
        private void Launcher6Pic_Click(object sender, EventArgs e)
        {

        }
        //L7
        private void Launcher07_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher7Path, "Launcher 7");
        }
        private void Launcher7Pic_Click(object sender, EventArgs e)
        {

        }
        //L8
        private void Launcher08_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher8Path, "Launcher 8");
        }
        private void Launcher8Pic_Click(object sender, EventArgs e)
        {

        }
        //L9
        private void Launcher09_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher9Path, "Launcher 9");
        }
        private void Launcher9Pic_Click(object sender, EventArgs e)
        {

        }
        //L10
        private void Launcher10_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher10Path, "Launcher 10");
        }
        private void Launcher10Pic_Click(object sender, EventArgs e)
        {

        }
        //L11
        private void Launcher11_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher11Path, "Launcher 11");
        }
        private void Launcher11Pic_Click(object sender, EventArgs e)
        {

        }
        //L12
        private void Launcher12_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher12Path, "Launcher 12");
        }
        private void Launcher12Pic_Click(object sender, EventArgs e)
        {

        }
        //L13
        private void Launcher13_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher13Path, "Launcher 13");
        }
        private void Launcher13Pic_Click(object sender, EventArgs e)
        {

        }
        //L14
        private void Launcher14_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher14Path, "Launcher 14");
        }
        private void Launcher14Pic_Click(object sender, EventArgs e)
        {

        }
        //L15
        private void Launcher15_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher15Path, "Launcher 15");
        }
        private void Launcher15Pic_Click(object sender, EventArgs e)
        {

        }
        //L16
        private void Launcher16_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher16Path, "Launcher 16");
        }
        private void Launcher16Pic_Click(object sender, EventArgs e)
        {

        }
        //L17
        private void Launcher17_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher17Path, "Launcher 17");
        }
        private void Launcher17Pic_Click(object sender, EventArgs e)
        {

        }
        //L18
        private void Launcher18_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher18Path, "Launcher 18");
        }
        private void Launcher18Pic_Click(object sender, EventArgs e)
        {

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
        //Launcher 
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

            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Attempt to launch without setting the exec @" + LaunchID);
                MessageBox.Show("It appears you don't have anything set for that launcher config it in the settings!", "Tell me what to do!");
            }

            catch
            {
                MessageBox.Show("You've somehow managed to break the software in ways we have not thought to be possible", "WOW!");
                Console.WriteLine("Unknown Error at " + LaunchID);
            }
        }
        //Loading settings
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            settings SettingsForm = new settings();
            SettingsForm.Show();
        }
    }
}
