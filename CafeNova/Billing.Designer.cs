namespace CafeNova
{
    partial class Billing
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcafe = new System.Windows.Forms.TextBox();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 48;
            this.listBox1.Location = new System.Drawing.Point(710, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotal.Location = new System.Drawing.Point(804, 477);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(174, 45);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: Rs 0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblcafe
            // 
            this.lblcafe.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblcafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcafe.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcafe.ForeColor = System.Drawing.Color.Ivory;
            this.lblcafe.Location = new System.Drawing.Point(0, 0);
            this.lblcafe.Margin = new System.Windows.Forms.Padding(1);
            this.lblcafe.Name = "lblcafe";
            this.lblcafe.Size = new System.Drawing.Size(1250, 77);
            this.lblcafe.TabIndex = 10;
            this.lblcafe.Text = "Cafe Nova ";
            this.lblcafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 615);
            this.pnlfooter.Margin = new System.Windows.Forms.Padding(1);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1250, 31);
            this.pnlfooter.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1139, 77);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 538);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(829, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "BILL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1250, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.lblcafe);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listBox1);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Billing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox lblcafe;
        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}