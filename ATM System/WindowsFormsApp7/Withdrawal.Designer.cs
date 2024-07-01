namespace WindowsFormsApp7
{
    partial class Withdrawal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_WITH_AMOU = new System.Windows.Forms.TextBox();
            this.BTN_WITHDR = new System.Windows.Forms.Button();
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAXIMUM DAILY WITHDRAWAL ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "IS RS 500,000.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please Enter Your Amount";
            // 
            // TXT_WITH_AMOU
            // 
            this.TXT_WITH_AMOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_WITH_AMOU.Location = new System.Drawing.Point(304, 252);
            this.TXT_WITH_AMOU.Name = "TXT_WITH_AMOU";
            this.TXT_WITH_AMOU.Size = new System.Drawing.Size(367, 45);
            this.TXT_WITH_AMOU.TabIndex = 2;
            // 
            // BTN_WITHDR
            // 
            this.BTN_WITHDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_WITHDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_WITHDR.ForeColor = System.Drawing.Color.Black;
            this.BTN_WITHDR.Location = new System.Drawing.Point(239, 351);
            this.BTN_WITHDR.Name = "BTN_WITHDR";
            this.BTN_WITHDR.Size = new System.Drawing.Size(250, 58);
            this.BTN_WITHDR.TabIndex = 3;
            this.BTN_WITHDR.Text = "WITHDRAW";
            this.BTN_WITHDR.UseVisualStyleBackColor = false;
            // 
            // BTN_BACK
            // 
            this.BTN_BACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BACK.ForeColor = System.Drawing.Color.Black;
            this.BTN_BACK.Location = new System.Drawing.Point(495, 351);
            this.BTN_BACK.Name = "BTN_BACK";
            this.BTN_BACK.Size = new System.Drawing.Size(250, 58);
            this.BTN_BACK.TabIndex = 3;
            this.BTN_BACK.Text = "BACK";
            this.BTN_BACK.UseVisualStyleBackColor = false;
            this.BTN_BACK.Click += new System.EventHandler(this.BTN_BACK_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(389, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1005, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_BACK);
            this.Controls.Add(this.BTN_WITHDR);
            this.Controls.Add(this.TXT_WITH_AMOU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_WITH_AMOU;
        private System.Windows.Forms.Button BTN_WITHDR;
        private System.Windows.Forms.Button BTN_BACK;
        private System.Windows.Forms.Button button3;
    }
}