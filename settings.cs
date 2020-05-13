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
    }
}
