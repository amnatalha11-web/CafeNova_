namespace CafeNova
{
    partial class Admin
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
            this.lblcafe = new System.Windows.Forms.TextBox();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblcafe
            // 
            this.lblcafe.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblcafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcafe.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcafe.ForeColor = System.Drawing.Color.White;
            this.lblcafe.Location = new System.Drawing.Point(-18, 1);
            this.lblcafe.Name = "lblcafe";
            this.lblcafe.Size = new System.Drawing.Size(1853, 77);
            this.lblcafe.TabIndex = 9;
            this.lblcafe.Text = "Cafe Nova ";
            this.lblcafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 651);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1769, 47);
            this.pnlfooter.TabIndex = 10;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Tan;
            this.btnView.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Maroon;
            this.btnView.Location = new System.Drawing.Point(630, 160);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(499, 101);
            this.btnView.TabIndex = 11;
            this.btnView.Text = " View Orders";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 580);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "label1";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Peru;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(12, 84);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(326, 76);
            this.btnAdmin.TabIndex = 15;
            this.btnAdmin.Text = "Admin Login";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1521, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 58);
            this.button1.TabIndex = 24;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.BackColor = System.Drawing.Color.Chocolate;
            this.listBoxOrders.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOrders.ForeColor = System.Drawing.Color.White;
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 30;
            this.listBoxOrders.Location = new System.Drawing.Point(758, 299);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(258, 244);
            this.listBoxOrders.TabIndex = 25;
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1769, 698);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.lblcafe);
            this.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblcafe;
        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxOrders;
    }
}