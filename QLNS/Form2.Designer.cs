namespace QLNS
{
    partial class fmLichLam
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.txtMDN = new System.Windows.Forms.TextBox();
            this.txtCaLam = new System.Windows.Forms.TextBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.BangLichLam = new System.Windows.Forms.DataGridView();
            this.BangLichLamNV = new System.Windows.Forms.DataGridView();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.txtNL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BangLichLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangLichLamNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bảng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đăng Nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ca Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Nghỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(136, 25);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(168, 20);
            this.txtMB.TabIndex = 5;
            // 
            // txtMDN
            // 
            this.txtMDN.Location = new System.Drawing.Point(136, 63);
            this.txtMDN.Name = "txtMDN";
            this.txtMDN.Size = new System.Drawing.Size(168, 20);
            this.txtMDN.TabIndex = 6;
            // 
            // txtCaLam
            // 
            this.txtCaLam.Location = new System.Drawing.Point(136, 98);
            this.txtCaLam.Name = "txtCaLam";
            this.txtCaLam.Size = new System.Drawing.Size(168, 20);
            this.txtCaLam.TabIndex = 7;
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLuu.Location = new System.Drawing.Point(286, 142);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(72, 30);
            this.buttonLuu.TabIndex = 10;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSua.Location = new System.Drawing.Point(120, 138);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(72, 33);
            this.buttonSua.TabIndex = 11;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonXoa.Location = new System.Drawing.Point(449, 143);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(72, 28);
            this.buttonXoa.TabIndex = 12;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // BangLichLam
            // 
            this.BangLichLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangLichLam.Location = new System.Drawing.Point(12, 188);
            this.BangLichLam.Name = "BangLichLam";
            this.BangLichLam.Size = new System.Drawing.Size(421, 177);
            this.BangLichLam.TabIndex = 13;
            this.BangLichLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BangLichLam_CellClick);
            // 
            // BangLichLamNV
            // 
            this.BangLichLamNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangLichLamNV.Location = new System.Drawing.Point(458, 188);
            this.BangLichLamNV.Name = "BangLichLamNV";
            this.BangLichLamNV.Size = new System.Drawing.Size(174, 177);
            this.BangLichLamNV.TabIndex = 14;
            // 
            // txtNN
            // 
            this.txtNN.Location = new System.Drawing.Point(435, 43);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(159, 20);
            this.txtNN.TabIndex = 15;
            // 
            // txtNL
            // 
            this.txtNL.Location = new System.Drawing.Point(435, 95);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(158, 20);
            this.txtNL.TabIndex = 16;
            // 
            // fmLichLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 368);
            this.Controls.Add(this.txtNL);
            this.Controls.Add(this.txtNN);
            this.Controls.Add(this.BangLichLamNV);
            this.Controls.Add(this.BangLichLam);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.txtCaLam);
            this.Controls.Add(this.txtMDN);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmLichLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch làm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangLichLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangLichLamNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMB;
        private System.Windows.Forms.TextBox txtMDN;
        private System.Windows.Forms.TextBox txtCaLam;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DataGridView BangLichLam;
        private System.Windows.Forms.DataGridView BangLichLamNV;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.TextBox txtNL;
    }
}