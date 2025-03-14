namespace QLNS
{
    partial class fmGiaoDienChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLịchLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýLịchLàmToolStripMenuItem,
            this.quảnLýChấmCôngToolStripMenuItem,
            this.quảnLýLươngToolStripMenuItem,
            this.quảnLýThôngBáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý thông tin nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýLịchLàmToolStripMenuItem
            // 
            this.quảnLýLịchLàmToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýLịchLàmToolStripMenuItem.Name = "quảnLýLịchLàmToolStripMenuItem";
            this.quảnLýLịchLàmToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.quảnLýLịchLàmToolStripMenuItem.Text = "Quản lý lịch làm";
            this.quảnLýLịchLàmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLịchLàmToolStripMenuItem_Click);
            // 
            // quảnLýChấmCôngToolStripMenuItem
            // 
            this.quảnLýChấmCôngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýChấmCôngToolStripMenuItem.Name = "quảnLýChấmCôngToolStripMenuItem";
            this.quảnLýChấmCôngToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.quảnLýChấmCôngToolStripMenuItem.Text = "Quản lý chấm công";
            // 
            // quảnLýLươngToolStripMenuItem
            // 
            this.quảnLýLươngToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýLươngToolStripMenuItem.Name = "quảnLýLươngToolStripMenuItem";
            this.quảnLýLươngToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.quảnLýLươngToolStripMenuItem.Text = "Quản lý lương";
            // 
            // quảnLýThôngBáoToolStripMenuItem
            // 
            this.quảnLýThôngBáoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quảnLýThôngBáoToolStripMenuItem.Name = "quảnLýThôngBáoToolStripMenuItem";
            this.quảnLýThôngBáoToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quảnLýThôngBáoToolStripMenuItem.Text = "Quản lý thông báo";
            // 
            // fmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::QLNS.Properties.Resources.Screenshot_2024_11_24_224657;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 417);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmGiaoDienChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chính";
            this.Load += new System.EventHandler(this.fmGiaoDienChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngBáoToolStripMenuItem;
    }
}