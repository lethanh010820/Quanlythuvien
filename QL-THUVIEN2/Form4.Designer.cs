namespace QL_THUVIEN2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.paneldg = new System.Windows.Forms.Panel();
            this.txttinhtrang = new System.Windows.Forms.CheckBox();
            this.txttheloai = new System.Windows.Forms.ComboBox();
            this.txtnxb = new System.Windows.Forms.ComboBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bttqlnvxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bttttcnluu = new System.Windows.Forms.Button();
            this.dgvsach = new System.Windows.Forms.DataGridView();
            this.dgvms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvmanxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtttcnten = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paneldg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldg
            // 
            this.paneldg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldg.BackColor = System.Drawing.Color.Transparent;
            this.paneldg.Controls.Add(this.txttinhtrang);
            this.paneldg.Controls.Add(this.txttheloai);
            this.paneldg.Controls.Add(this.txtnxb);
            this.paneldg.Controls.Add(this.txtgia);
            this.paneldg.Controls.Add(this.txtten);
            this.paneldg.Controls.Add(this.txtma);
            this.paneldg.Controls.Add(this.label2);
            this.paneldg.Controls.Add(this.label1);
            this.paneldg.Controls.Add(this.button2);
            this.paneldg.Controls.Add(this.bttqlnvxoa);
            this.paneldg.Controls.Add(this.button1);
            this.paneldg.Controls.Add(this.bttttcnluu);
            this.paneldg.Controls.Add(this.dgvsach);
            this.paneldg.Controls.Add(this.label19);
            this.paneldg.Controls.Add(this.label16);
            this.paneldg.Controls.Add(this.label13);
            this.paneldg.Controls.Add(this.txtttcnten);
            this.paneldg.Controls.Add(this.label11);
            this.paneldg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldg.Location = new System.Drawing.Point(0, 0);
            this.paneldg.Name = "paneldg";
            this.paneldg.Size = new System.Drawing.Size(908, 501);
            this.paneldg.TabIndex = 4;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.AutoSize = true;
            this.txttinhtrang.ForeColor = System.Drawing.Color.White;
            this.txttinhtrang.Location = new System.Drawing.Point(636, 155);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(88, 23);
            this.txttinhtrang.TabIndex = 37;
            this.txttinhtrang.Text = "Đã Mượn";
            this.txttinhtrang.UseVisualStyleBackColor = true;
            // 
            // txttheloai
            // 
            this.txttheloai.FormattingEnabled = true;
            this.txttheloai.Location = new System.Drawing.Point(636, 104);
            this.txttheloai.Name = "txttheloai";
            this.txttheloai.Size = new System.Drawing.Size(178, 27);
            this.txttheloai.TabIndex = 36;
            this.txttheloai.SelectedIndexChanged += new System.EventHandler(this.txttheloai_SelectedIndexChanged);
            // 
            // txtnxb
            // 
            this.txtnxb.FormattingEnabled = true;
            this.txtnxb.Location = new System.Drawing.Point(636, 63);
            this.txtnxb.Name = "txtnxb";
            this.txtnxb.Size = new System.Drawing.Size(178, 27);
            this.txtnxb.TabIndex = 35;
            this.txtnxb.SelectedIndexChanged += new System.EventHandler(this.txtnxb_SelectedIndexChanged);
            // 
            // txtgia
            // 
            this.txtgia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtgia.Location = new System.Drawing.Point(163, 152);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(178, 26);
            this.txtgia.TabIndex = 34;
            // 
            // txtten
            // 
            this.txtten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtten.Location = new System.Drawing.Point(163, 107);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(178, 26);
            this.txtten.TabIndex = 33;
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtma.Location = new System.Drawing.Point(163, 66);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(178, 26);
            this.txtma.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tình Trạng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thể Loại";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Image = global::QL_THUVIEN2.Properties.Resources.rewind1;
            this.button2.Location = new System.Drawing.Point(761, 432);
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
            this.bttqlnvxoa.Image = global::QL_THUVIEN2.Properties.Resources.folder_delete;
            this.bttqlnvxoa.Location = new System.Drawing.Point(522, 432);
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
            this.button1.Image = global::QL_THUVIEN2.Properties.Resources.folder_edit;
            this.button1.Location = new System.Drawing.Point(260, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sửa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttttcnluu
            // 
            this.bttttcnluu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttttcnluu.Image = global::QL_THUVIEN2.Properties.Resources.folder_add;
            this.bttttcnluu.Location = new System.Drawing.Point(33, 432);
            this.bttttcnluu.Name = "bttttcnluu";
            this.bttttcnluu.Size = new System.Drawing.Size(130, 56);
            this.bttttcnluu.TabIndex = 19;
            this.bttttcnluu.Text = "Thêm Mới";
            this.bttttcnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttttcnluu.UseVisualStyleBackColor = true;
            this.bttttcnluu.Click += new System.EventHandler(this.bttttcnluu_Click);
            // 
            // dgvsach
            // 
            this.dgvsach.AllowUserToAddRows = false;
            this.dgvsach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvms,
            this.dgvts,
            this.dgvgia,
            this.dgvmanxb,
            this.Column1,
            this.Column2});
            this.dgvsach.Location = new System.Drawing.Point(2, 214);
            this.dgvsach.Name = "dgvsach";
            this.dgvsach.Size = new System.Drawing.Size(903, 213);
            this.dgvsach.TabIndex = 3;
            this.dgvsach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsach_RowEnter);
            // 
            // dgvms
            // 
            this.dgvms.DataPropertyName = "MaSach";
            this.dgvms.HeaderText = "Mã Sách";
            this.dgvms.Name = "dgvms";
            // 
            // dgvts
            // 
            this.dgvts.DataPropertyName = "TenSach";
            this.dgvts.HeaderText = "Tên Sách";
            this.dgvts.Name = "dgvts";
            // 
            // dgvgia
            // 
            this.dgvgia.DataPropertyName = "Gia";
            this.dgvgia.HeaderText = "Giá";
            this.dgvgia.Name = "dgvgia";
            // 
            // dgvmanxb
            // 
            this.dgvmanxb.DataPropertyName = "MaNXB";
            this.dgvmanxb.HeaderText = "Mã NXB";
            this.dgvmanxb.Name = "dgvmanxb";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTL";
            this.Column1.HeaderText = "Mã Thể Loại";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TinhTrang";
            this.Column2.HeaderText = "Tình Trạng";
            this.Column2.Name = "Column2";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(370, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 19);
            this.label19.TabIndex = 8;
            this.label19.Text = "THÔNG TIN SÁCH\r\n";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(495, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nhà Xuất Bản";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giá";
            // 
            // txtttcnten
            // 
            this.txtttcnten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtttcnten.AutoSize = true;
            this.txtttcnten.ForeColor = System.Drawing.Color.White;
            this.txtttcnten.Location = new System.Drawing.Point(57, 119);
            this.txtttcnten.Name = "txtttcnten";
            this.txtttcnten.Size = new System.Drawing.Size(66, 19);
            this.txtttcnten.TabIndex = 1;
            this.txtttcnten.Text = "Tên Sách";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(57, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Sách";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 500);
            this.Controls.Add(this.paneldg);
            this.Name = "Form4";
            this.Text = "THÔNG TIN SÁCH";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.paneldg.ResumeLayout(false);
            this.paneldg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttqlnvxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttttcnluu;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtttcnten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmanxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox txttinhtrang;
        private System.Windows.Forms.ComboBox txttheloai;
        private System.Windows.Forms.ComboBox txtnxb;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
    }
}