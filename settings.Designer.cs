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
            ((System.ComponentModel.ISupportInitialize)(this.BtnTerminate)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTerminate
            // 
            this.BtnTerminate.BackColor = System.Drawing.Color.Red;
            this.BtnTerminate.Location = new System.Drawing.Point(247, 0);
            this.BtnTerminate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTerminate.Name = "BtnTerminate";
            this.BtnTerminate.Size = new System.Drawing.Size(19, 20);
            this.BtnTerminate.TabIndex = 2;
            this.BtnTerminate.TabStop = false;
            this.BtnTerminate.Click += new System.EventHandler(this.BtnTerminate_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(266, 373);
            this.Controls.Add(this.BtnTerminate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.Text = "settings";
            ((System.ComponentModel.ISupportInitialize)(this.BtnTerminate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnTerminate;
    }
}