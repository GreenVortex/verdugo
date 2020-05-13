namespace Verdugo
{
    partial class ConfigSetMessage
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
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkayButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.Color.DarkGray;
            this.DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionText.ForeColor = System.Drawing.Color.LightGray;
            this.DescriptionText.Location = new System.Drawing.Point(3, 3);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(193, 53);
            this.DescriptionText.TabIndex = 1;
            this.DescriptionText.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.OkayButton);
            this.panel1.Controls.Add(this.DescriptionText);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 88);
            this.panel1.TabIndex = 2;
            // 
            // OkayButton
            // 
            this.OkayButton.BackColor = System.Drawing.Color.DarkGray;
            this.OkayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkayButton.ForeColor = System.Drawing.Color.LightGray;
            this.OkayButton.Location = new System.Drawing.Point(61, 62);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 2;
            this.OkayButton.TabStop = false;
            this.OkayButton.UseVisualStyleBackColor = false;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // ConfigSetMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(223, 133);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigSetMessage";
            this.Text = "ConfigSetMessage";
            this.Load += new System.EventHandler(this.ConfigSetMessage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigSetMessage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigSetMessage_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkayButton;
    }
}