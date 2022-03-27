namespace QL_THUVIEN2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.paneldg = new System.Windows.Forms.Panel();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bttqlnvxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttthem = new System.Windows.Forms.Button();
            this.dgvnxb = new System.Windows.Forms.DataGridView();
            this.dgvmanxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtttcnten = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paneldg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnxb)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldg
            // 
            this.paneldg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldg.BackColor = System.Drawing.Color.Transparent;
            this.paneldg.Controls.Add(this.txtsdt);
            this.paneldg.Controls.Add(this.txtdiachi);
            this.paneldg.Controls.Add(this.txtten);
            this.paneldg.Controls.Add(this.txtma);
            this.paneldg.Controls.Add(this.button2);
            this.paneldg.Controls.Add(this.bttqlnvxoa);
            this.paneldg.Controls.Add(this.button1);
            this.paneldg.Controls.Add(this.bttthem);
            this.paneldg.Controls.Add(this.dgvnxb);
            this.paneldg.Controls.Add(this.label19);
            this.paneldg.Controls.Add(this.label14);
            this.paneldg.Controls.Add(this.label13);
            this.paneldg.Controls.Add(this.txtttcnten);
            this.paneldg.Controls.Add(this.label11);
            this.paneldg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldg.Location = new System.Drawing.Point(1, 1);
            this.paneldg.Name = "paneldg";
            this.paneldg.Size = new System.Drawing.Size(774, 501);
            this.paneldg.TabIndex = 5;
            this.paneldg.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldg_Paint);
            // 
            // txtsdt
            // 
            this.txtsdt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsdt.Location = new System.Drawing.Point(533, 129);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(178, 26);
            this.txtsdt.TabIndex = 30;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdiachi.Location = new System.Drawing.Point(533, 67);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(178, 26);
            this.txtdiachi.TabIndex = 29;
            // 
            // txtten
            // 
            this.txtten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtten.Location = new System.Drawing.Point(134, 129);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(178, 26);
            this.txtten.TabIndex = 28;
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtma.Location = new System.Drawing.Point(134, 71);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(178, 26);
            this.txtma.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Image = global::QL_THUVIEN2.Properties.Resources.rewind2;
            this.button2.Location = new System.Drawing.Point(609, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 56);
            this.button2.TabIndex = 26;
            this.button2.Text = "Thoát";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttqlnvxoa
            // 
            this.bttqlnvxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttqlnvxoa.Image = global::QL_THUVIEN2.Properties.Resources.remove2;
            this.bttqlnvxoa.Location = new System.Drawing.Point(441, 430);
            this.bttqlnvxoa.Name = "bttqlnvxoa";
            this.bttqlnvxoa.Size = new System.Drawing.Size(106, 56);
            this.bttqlnvxoa.TabIndex = 22;
            this.bttqlnvxoa.Text = "Xóa";
            this.bttqlnvxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttqlnvxoa.UseVisualStyleBackColor = true;
            this.bttqlnvxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Image = global::QL_THUVIEN2.Properties.Resources.comment_edit;
            this.button1.Location = new System.Drawing.Point(241, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sửa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttthem
            // 
            this.bttthem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttthem.Image = global::QL_THUVIEN2.Properties.Resources.add2;
            this.bttthem.Location = new System.Drawing.Point(43, 430);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(135, 56);
            this.bttthem.TabIndex = 19;
            this.bttthem.Text = "Thêm Mới";
            this.bttthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttthem.UseVisualStyleBackColor = true;
            this.bttthem.Click += new System.EventHandler(this.bttttcnluu_Click);
            // 
            // dgvnxb
            // 
            this.dgvnxb.AllowUserToAddRows = false;
            this.dgvnxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvnxb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnxb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmanxb,
            this.dgvtennxb,
            this.dgvdiachi,
            this.dgvsdt});
            this.dgvnxb.Location = new System.Drawing.Point(2, 190);
            this.dgvnxb.Name = "dgvnxb";
            this.dgvnxb.Size = new System.Drawing.Size(769, 226);
            this.dgvnxb.TabIndex = 3;
            this.dgvnxb.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnxb_RowEnter);
            // 
            // dgvmanxb
            // 
            this.dgvmanxb.DataPropertyName = "MaNXB";
            this.dgvmanxb.HeaderText = "Mã NXB";
            this.dgvmanxb.Name = "dgvmanxb";
            // 
            // dgvtennxb
            // 
            this.dgvtennxb.DataPropertyName = "TenNXB";
            this.dgvtennxb.HeaderText = "Tên NXB";
            this.dgvtennxb.Name = "dgvtennxb";
            // 
            // dgvdiachi
            // 
            this.dgvdiachi.DataPropertyName = "DiaChi";
            this.dgvdiachi.HeaderText = "Địa Chỉ";
            this.dgvdiachi.Name = "dgvdiachi";
            // 
            // dgvsdt
            // 
            this.dgvsdt.DataPropertyName = "SDT";
            this.dgvsdt.HeaderText = "Số ĐT";
            this.dgvsdt.Name = "dgvsdt";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(271, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(223, 19);
            this.label19.TabIndex = 8;
            this.label19.Text = "THÔNG TIN NHÀ XUẤT BẢN\r\n";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(408, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "SDT";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(404, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Địa Chỉ";
            // 
            // txtttcnten
            // 
            this.txtttcnten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtttcnten.AutoSize = true;
            this.txtttcnten.ForeColor = System.Drawing.Color.White;
            this.txtttcnten.Location = new System.Drawing.Point(24, 136);
            this.txtttcnten.Name = "txtttcnten";
            this.txtttcnten.Size = new System.Drawing.Size(69, 19);
            this.txtttcnten.TabIndex = 1;
            this.txtttcnten.Text = "Tên NXB";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã NXB";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 499);
            this.Controls.Add(this.paneldg);
            this.Name = "Form5";
            this.Text = "THÔNG TIN NHÀ XUẤT BẢN";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.paneldg.ResumeLayout(false);
            this.paneldg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldg;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttqlnvxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.DataGridView dgvnxb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtttcnten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmanxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsdt;
    }
}