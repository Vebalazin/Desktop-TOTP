namespace DesktopTOTPGenerator
{
    partial class frmMain
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
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.lblOtp = new System.Windows.Forms.Label();
            this.txtTOTP = new System.Windows.Forms.TextBox();
            this.lblUnos = new System.Windows.Forms.Label();
            this.txtKljuc = new System.Windows.Forms.TextBox();
            this.btnStani = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(93, 175);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(75, 23);
            this.btnGeneriraj.TabIndex = 0;
            this.btnGeneriraj.Text = "Generiraj";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // lblOtp
            // 
            this.lblOtp.AutoSize = true;
            this.lblOtp.Location = new System.Drawing.Point(13, 110);
            this.lblOtp.Name = "lblOtp";
            this.lblOtp.Size = new System.Drawing.Size(108, 13);
            this.lblOtp.TabIndex = 1;
            this.lblOtp.Text = "Vaš TOTP password:";
            // 
            // txtTOTP
            // 
            this.txtTOTP.Location = new System.Drawing.Point(133, 107);
            this.txtTOTP.Name = "txtTOTP";
            this.txtTOTP.Size = new System.Drawing.Size(100, 20);
            this.txtTOTP.TabIndex = 2;
            // 
            // lblUnos
            // 
            this.lblUnos.AutoSize = true;
            this.lblUnos.Location = new System.Drawing.Point(13, 50);
            this.lblUnos.Name = "lblUnos";
            this.lblUnos.Size = new System.Drawing.Size(93, 13);
            this.lblUnos.TabIndex = 3;
            this.lblUnos.Text = "Unesite tajni ključ:";
            // 
            // txtKljuc
            // 
            this.txtKljuc.Location = new System.Drawing.Point(133, 47);
            this.txtKljuc.Name = "txtKljuc";
            this.txtKljuc.Size = new System.Drawing.Size(163, 20);
            this.txtKljuc.TabIndex = 4;
            this.txtKljuc.TextChanged += new System.EventHandler(this.txtKljuc_TextChanged);
            // 
            // btnStani
            // 
            this.btnStani.Location = new System.Drawing.Point(205, 175);
            this.btnStani.Name = "btnStani";
            this.btnStani.Size = new System.Drawing.Size(75, 23);
            this.btnStani.TabIndex = 5;
            this.btnStani.Text = "Stani";
            this.btnStani.UseVisualStyleBackColor = true;
            this.btnStani.Click += new System.EventHandler(this.btnStani_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 236);
            this.Controls.Add(this.btnStani);
            this.Controls.Add(this.txtKljuc);
            this.Controls.Add(this.lblUnos);
            this.Controls.Add(this.txtTOTP);
            this.Controls.Add(this.lblOtp);
            this.Controls.Add(this.btnGeneriraj);
            this.Name = "frmMain";
            this.Text = "Desktop TOTP Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.Label lblOtp;
        private System.Windows.Forms.TextBox txtTOTP;
        private System.Windows.Forms.Label lblUnos;
        private System.Windows.Forms.TextBox txtKljuc;
        private System.Windows.Forms.Button btnStani;
        private System.Windows.Forms.Timer timer1;
    }
}

