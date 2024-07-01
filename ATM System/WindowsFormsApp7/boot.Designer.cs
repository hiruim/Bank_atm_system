namespace WindowsFormsApp7
{
    partial class boot
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
            this.components = new System.ComponentModel.Container();
            this.LoadPanel = new System.Windows.Forms.Panel();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.LoadTime = new System.Windows.Forms.Timer(this.components);
            this.BasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadPanel
            // 
            this.LoadPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LoadPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new System.Drawing.Size(184, 14);
            this.LoadPanel.TabIndex = 0;
            this.LoadPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadPanel_Paint);
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.Transparent;
            this.BasePanel.Controls.Add(this.LoadPanel);
            this.BasePanel.Location = new System.Drawing.Point(1, 535);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(1004, 14);
            this.BasePanel.TabIndex = 1;
            // 
            // LoadTime
            // 
            this.LoadTime.Enabled = true;
            this.LoadTime.Interval = 15;
            this.LoadTime.Tick += new System.EventHandler(this.LoadTime_Tick);
            // 
            // boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.Screenshot__271_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 550);
            this.Controls.Add(this.BasePanel);
            this.DoubleBuffered = true;
            this.Name = "boot";
            this.Text = "boot";
            this.Load += new System.EventHandler(this.boot_Load);
            this.BasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadPanel;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Timer LoadTime;
    }
}