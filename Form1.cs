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
        //Loader for launcher thumbnails on formload
        private void Main_Load(object sender, EventArgs e)
        {
            Launcher01.ImageLocation = Properties.Settings.Default.Launcher1Pic;
            Launcher02.ImageLocation = Properties.Settings.Default.Launcher2Pic;
            Launcher03.ImageLocation = Properties.Settings.Default.Launcher3Pic;
            Launcher04.ImageLocation = Properties.Settings.Default.Launcher4Pic;
            Launcher05.ImageLocation = Properties.Settings.Default.Launcher5Pic;
            Launcher06.ImageLocation = Properties.Settings.Default.Launcher6Pic;
            Launcher07.ImageLocation = Properties.Settings.Default.Launcher7Pic;
            Launcher08.ImageLocation = Properties.Settings.Default.Launcher8Pic;
            Launcher09.ImageLocation = Properties.Settings.Default.Launcher9Pic;
            Launcher10.ImageLocation = Properties.Settings.Default.Launcher10Pic;
            Launcher11.ImageLocation = Properties.Settings.Default.Launcher11Pic;
            Launcher12.ImageLocation = Properties.Settings.Default.Launcher12Pic;
            Launcher13.ImageLocation = Properties.Settings.Default.Launcher13Pic;
            Launcher14.ImageLocation = Properties.Settings.Default.Launcher14Pic;
            Launcher15.ImageLocation = Properties.Settings.Default.Launcher15Pic;
            Launcher16.ImageLocation = Properties.Settings.Default.Launcher16Pic;
            Launcher17.ImageLocation = Properties.Settings.Default.Launcher17Pic;
            Launcher18.ImageLocation = Properties.Settings.Default.Launcher18Pic;
        }
        //Feedback dialogue caller
        static void Feedback()
        {
            FeedBack Feedback = new FeedBack();
            Feedback.Show();
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
        //Sets and saves the launcher thumbnail
        private void Launcher1Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if(Open.ShowDialog()==DialogResult.OK)
            {
                Launcher01.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher1Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L2
        private void Launcher02_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher2Path, "Launcher 2");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher2Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher02.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher2Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L3
        private void Launcher03_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher3Path, "Launcher 3");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher3Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher03.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher3Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L4
        private void Launcher04_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher4Path, "Launcher 4");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher4Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher04.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher4Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L5
        private void Launcher05_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher5Path, "Launcher 5");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher5Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher05.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher5Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L6
        private void Launcher06_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher6Path, "Launcher 6");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher6Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher06.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher6Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L7
        private void Launcher07_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher7Path, "Launcher 7");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher7Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher07.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher7Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L8
        private void Launcher08_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher8Path, "Launcher 8");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher8Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher08.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher8Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L9
        private void Launcher09_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher9Path, "Launcher 9");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher9Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher09.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher9Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L10
        private void Launcher10_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher10Path, "Launcher 10");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher10Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher10.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher10Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L11
        private void Launcher11_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher11Path, "Launcher 11");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher11Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher11.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher11Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L12
        private void Launcher12_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher12Path, "Launcher 12");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher12Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher12.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher12Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L13
        private void Launcher13_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher13Path, "Launcher 13");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher13Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher13.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher13Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L14
        private void Launcher14_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher14Path, "Launcher 14");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher14Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher14.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher14Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L15
        private void Launcher15_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher15Path, "Launcher 15");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher15Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher15.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher15Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L16
        private void Launcher16_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher16Path, "Launcher 16");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher16Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher16.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher16Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L17
        private void Launcher17_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher17Path, "Launcher 17");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher17Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher17.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher17Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
        }
        //L18
        private void Launcher18_Click(object sender, EventArgs e)
        {
            RocketLauncher(Properties.Settings.Default.Launcher18Path, "Launcher 18");
        }
        //Sets and saves the launcher thumbnail
        private void Launcher18Pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if (Open.ShowDialog() == DialogResult.OK)
            {
                Launcher18.ImageLocation = Open.FileName;
                Properties.Settings.Default.Launcher18Pic = Open.FileName;
                Properties.Settings.Default.Save();
            }
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
        //Launcher code execution
        static void RocketLauncher(string LaunchParam, string LaunchID)
        {
            //Launching parameters
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = LaunchParam;
            try
            {
                proc.Start();
            }
            //Error handler for incorrect file path in ececuter parameters
            catch (System.ComponentModel.Win32Exception) 
            {
                MessageBox.Show("Error:Incorect path was attempted to execute, please correct path to file at " + LaunchID, "LaunchError");
                Console.WriteLine("Incorrect path at " + LaunchID);
            }
            //Error handler for launching with empty parameters
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Attempt to launch without setting the exec @" + LaunchID);
                MessageBox.Show("It appears you don't have anything set for that launcher config it in the settings!", "Tell me what to do!");
            }
            //Error handler for unknown error
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
