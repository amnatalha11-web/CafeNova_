namespace CafeNova
{
    partial class Login
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
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblcafe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 567);
            this.pnlfooter.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1779, 31);
            this.pnlfooter.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblUser.Location = new System.Drawing.Point(681, 191);
            this.lblUser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(158, 41);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblpass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblpass.Location = new System.Drawing.Point(681, 285);
            this.lblpass.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(150, 41);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Password";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(841, 183);
            this.txtUser.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(252, 74);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(841, 274);
            this.txtPass.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(252, 74);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Peru;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(784, 383);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(222, 79);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblcafe
            // 
            this.lblcafe.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblcafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcafe.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcafe.ForeColor = System.Drawing.Color.Ivory;
            this.lblcafe.Location = new System.Drawing.Point(0, 0);
            this.lblcafe.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblcafe.Name = "lblcafe";
            this.lblcafe.Size = new System.Drawing.Size(1779, 77);
            this.lblcafe.TabIndex = 9;
            this.lblcafe.Text = "Cafe Nova ";
            this.lblcafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblcafe.TextChanged += new System.EventHandler(this.lblcafe_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1779, 598);
            this.Controls.Add(this.lblcafe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlfooter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox lblcafe;
    }
}