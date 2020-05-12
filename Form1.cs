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
            RocketLauncher("notepad","Launcher 1");
        }
        //L2
        private void Launcher02_Click(object sender, EventArgs e)
        {
            
        }
        //L3
        private void Launcher03_Click(object sender, EventArgs e)
        {

        }
        //L4
        private void Launcher04_Click(object sender, EventArgs e)
        {
            
        }
        //L5
        private void Launcher05_Click(object sender, EventArgs e)
        {
            
        }
        //L6
        private void Launcher06_Click(object sender, EventArgs e)
        {
            
        }
        //L7
        private void Launcher07_Click(object sender, EventArgs e)
        {
            
        }
        //L8
        private void Launcher08_Click(object sender, EventArgs e)
        {
            
        }
        //L9
        private void Launcher09_Click(object sender, EventArgs e)
        {
            
        }
        //L10
        private void Launcher10_Click(object sender, EventArgs e)
        {
            
        }
        //L11
        private void Launcher11_Click(object sender, EventArgs e)
        {
            
        }
        //L12
        private void Launcher12_Click(object sender, EventArgs e)
        {
            
        }
        //L13
        private void Launcher13_Click(object sender, EventArgs e)
        {
            
        }
        //L14
        private void Launcher14_Click(object sender, EventArgs e)
        {
            
        }
        //L15
        private void Launcher15_Click(object sender, EventArgs e)
        {
            
        }
        //L16
        private void Launcher16_Click(object sender, EventArgs e)
        {
            
        }
        //L17
        private void Launcher17_Click(object sender, EventArgs e)
        {
            
        }
        //L18
        private void Launcher18_Click(object sender, EventArgs e)
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
    }
}
