namespace WindowsFormsApp7
{
    partial class login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_CARD_NO = new System.Windows.Forms.TextBox();
            this.TXT_PIN = new System.Windows.Forms.TextBox();
            this.BTN_SIGN_IN = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.BTN_SIGN_UP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lanka Pay ATM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Card No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "PIN :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.inserting_credit_card_into_atm_stock_illustration_gg60985487;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(767, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 159);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_CARD_NO
            // 
            this.TXT_CARD_NO.BackColor = System.Drawing.Color.SkyBlue;
            this.TXT_CARD_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CARD_NO.Location = new System.Drawing.Point(252, 151);
            this.TXT_CARD_NO.MaxLength = 11;
            this.TXT_CARD_NO.Name = "TXT_CARD_NO";
            this.TXT_CARD_NO.Size = new System.Drawing.Size(410, 45);
            this.TXT_CARD_NO.TabIndex = 7;
            // 
            // TXT_PIN
            // 
            this.TXT_PIN.BackColor = System.Drawing.Color.SkyBlue;
            this.TXT_PIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PIN.Location = new System.Drawing.Point(252, 199);
            this.TXT_PIN.MaxLength = 5;
            this.TXT_PIN.Name = "TXT_PIN";
            this.TXT_PIN.Size = new System.Drawing.Size(410, 45);
            this.TXT_PIN.TabIndex = 7;
            // 
            // BTN_SIGN_IN
            // 
            this.BTN_SIGN_IN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_SIGN_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SIGN_IN.Location = new System.Drawing.Point(252, 308);
            this.BTN_SIGN_IN.Name = "BTN_SIGN_IN";
            this.BTN_SIGN_IN.Size = new System.Drawing.Size(196, 50);
            this.BTN_SIGN_IN.TabIndex = 8;
            this.BTN_SIGN_IN.Text = "SIGN IN";
            this.BTN_SIGN_IN.UseVisualStyleBackColor = false;
            this.BTN_SIGN_IN.Click += new System.EventHandler(this.BTN_SIGN_IN_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR.Location = new System.Drawing.Point(478, 308);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(184, 50);
            this.BTN_CLEAR.TabIndex = 8;
            this.BTN_CLEAR.Text = "CLEAR";
            this.BTN_CLEAR.UseVisualStyleBackColor = false;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // BTN_SIGN_UP
            // 
            this.BTN_SIGN_UP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_SIGN_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SIGN_UP.Location = new System.Drawing.Point(252, 379);
            this.BTN_SIGN_UP.Name = "BTN_SIGN_UP";
            this.BTN_SIGN_UP.Size = new System.Drawing.Size(410, 50);
            this.BTN_SIGN_UP.TabIndex = 8;
            this.BTN_SIGN_UP.Text = "SIGN UP";
            this.BTN_SIGN_UP.UseVisualStyleBackColor = false;
            this.BTN_SIGN_UP.Click += new System.EventHandler(this.BTN_SIGN_UP_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::WindowsFormsApp7.Properties.Resources.Earth1_Abstract_News_Motion_Background_Video_Loop_Sample2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 550);
            this.Controls.Add(this.BTN_SIGN_UP);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.BTN_SIGN_IN);
            this.Controls.Add(this.TXT_PIN);
            this.Controls.Add(this.TXT_CARD_NO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_CARD_NO;
        private System.Windows.Forms.TextBox TXT_PIN;
        private System.Windows.Forms.Button BTN_SIGN_IN;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.Button BTN_SIGN_UP;
    }
}