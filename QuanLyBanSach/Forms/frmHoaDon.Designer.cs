namespace QuanLyBanSach.Forms
{
    partial class frmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabHoaDon = new System.Windows.Forms.TabControl();
            this.tbpHoaDonBan = new System.Windows.Forms.TabPage();
            this.tbpHoaDonNhap = new System.Windows.Forms.TabPage();
            this.tabHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 43);
            this.panel1.TabIndex = 0;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.tbpHoaDonBan);
            this.tabHoaDon.Controls.Add(this.tbpHoaDonNhap);
            this.tabHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHoaDon.Location = new System.Drawing.Point(0, 0);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.SelectedIndex = 0;
            this.tabHoaDon.Size = new System.Drawing.Size(684, 518);
            this.tabHoaDon.TabIndex = 1;
            // 
            // tbpHoaDonBan
            // 
            this.tbpHoaDonBan.Location = new System.Drawing.Point(4, 22);
            this.tbpHoaDonBan.Name = "tbpHoaDonBan";
            this.tbpHoaDonBan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHoaDonBan.Size = new System.Drawing.Size(676, 492);
            this.tbpHoaDonBan.TabIndex = 0;
            this.tbpHoaDonBan.Text = "Hóa đơn bán";
            this.tbpHoaDonBan.UseVisualStyleBackColor = true;
            // 
            // tbpHoaDonNhap
            // 
            this.tbpHoaDonNhap.Location = new System.Drawing.Point(4, 22);
            this.tbpHoaDonNhap.Name = "tbpHoaDonNhap";
            this.tbpHoaDonNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHoaDonNhap.Size = new System.Drawing.Size(676, 492);
            this.tbpHoaDonNhap.TabIndex = 1;
            this.tbpHoaDonNhap.Text = "Hóa đơn nhập";
            this.tbpHoaDonNhap.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tabHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDon";
            this.Text = "Hóa đơn";
            this.tabHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabHoaDon;
        private System.Windows.Forms.TabPage tbpHoaDonBan;
        private System.Windows.Forms.TabPage tbpHoaDonNhap;
    }
}