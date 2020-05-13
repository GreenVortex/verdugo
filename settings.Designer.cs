namespace Verdugo
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnTerminate = new System.Windows.Forms.PictureBox();
            this.LauncherSelect = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTerminate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTerminate
            // 
            this.BtnTerminate.BackColor = System.Drawing.Color.Red;
            this.BtnTerminate.Location = new System.Drawing.Point(212, 0);
            this.BtnTerminate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTerminate.Name = "BtnTerminate";
            this.BtnTerminate.Size = new System.Drawing.Size(19, 20);
            this.BtnTerminate.TabIndex = 2;
            this.BtnTerminate.TabStop = false;
            this.BtnTerminate.Click += new System.EventHandler(this.BtnTerminate_Click);
            // 
            // LauncherSelect
            // 
            this.LauncherSelect.BackColor = System.Drawing.Color.DimGray;
            this.LauncherSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LauncherSelect.ForeColor = System.Drawing.Color.LightGray;
            this.LauncherSelect.FormattingEnabled = true;
            this.LauncherSelect.Items.AddRange(new object[] {
            "Launcher 01",
            "Launcher 02",
            "Launcher 03",
            "Launcher 04",
            "Launcher 05",
            "Launcher 06",
            "Launcher 07",
            "Launcher 08",
            "Launcher 09",
            "Launcher 10",
            "Launcher 11",
            "Launcher 12",
            "Launcher 13",
            "Launcher 14",
            "Launcher 15",
            "Launcher 16",
            "Launcher 17",
            "Launcher 18"});
            this.LauncherSelect.Location = new System.Drawing.Point(3, 27);
            this.LauncherSelect.Name = "LauncherSelect";
            this.LauncherSelect.Size = new System.Drawing.Size(201, 21);
            this.LauncherSelect.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.LauncherSelect);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 176);
            this.panel1.TabIndex = 4;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(231, 236);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTerminate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settings_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BtnTerminate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnTerminate;
        private System.Windows.Forms.ComboBox LauncherSelect;
        private System.Windows.Forms.Panel panel1;
    }
}