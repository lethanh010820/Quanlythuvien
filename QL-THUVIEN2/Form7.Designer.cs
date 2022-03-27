namespace QL_THUVIEN2
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnngaytra = new System.Windows.Forms.DateTimePicker();
            this.pnmanv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bttqlnvxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnphat = new System.Windows.Forms.TextBox();
            this.pnmasach = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvpn1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnmaphieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pnngaytra);
            this.panel3.Controls.Add(this.pnmanv);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.bttqlnvxoa);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pnphat);
            this.panel3.Controls.Add(this.pnmasach);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dgvpn1);
            this.panel3.Controls.Add(this.pnmaphieu);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(-3, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 521);
            this.panel3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "PHIẾU TRẢ";
            // 
            // pnngaytra
            // 
            this.pnngaytra.CalendarForeColor = System.Drawing.Color.White;
            this.pnngaytra.CalendarTitleForeColor = System.Drawing.Color.White;
            this.pnngaytra.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.pnngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pnngaytra.Location = new System.Drawing.Point(583, 64);
            this.pnngaytra.Margin = new System.Windows.Forms.Padding(4);
            this.pnngaytra.Name = "pnngaytra";
            this.pnngaytra.Size = new System.Drawing.Size(163, 26);
            this.pnngaytra.TabIndex = 40;
            // 
            // pnmanv
            // 
            this.pnmanv.FormattingEnabled = true;
            this.pnmanv.Location = new System.Drawing.Point(161, 156);
            this.pnmanv.Margin = new System.Windows.Forms.Padding(4);
            this.pnmanv.Name = "pnmanv";
            this.pnmanv.Size = new System.Drawing.Size(179, 27);
            this.pnmanv.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Image = global::QL_THUVIEN2.Properties.Resources.rewind;
            this.button2.Location = new System.Drawing.Point(659, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 59);
            this.button2.TabIndex = 37;
            this.button2.Text = "Thoát";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttqlnvxoa
            // 
            this.bttqlnvxoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttqlnvxoa.Image = global::QL_THUVIEN2.Properties.Resources.page_remove1;
            this.bttqlnvxoa.Location = new System.Drawing.Point(354, 456);
            this.bttqlnvxoa.Name = "bttqlnvxoa";
            this.bttqlnvxoa.Size = new System.Drawing.Size(122, 59);
            this.bttqlnvxoa.TabIndex = 36;
            this.bttqlnvxoa.Text = "Xóa";
            this.bttqlnvxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttqlnvxoa.UseVisualStyleBackColor = true;
            this.bttqlnvxoa.Click += new System.EventHandler(this.bttqlnvxoa_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Image = global::QL_THUVIEN2.Properties.Resources.page_accept;
            this.button1.Location = new System.Drawing.Point(44, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 59);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cập Nhật";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnphat
            // 
            this.pnphat.Location = new System.Drawing.Point(583, 110);
            this.pnphat.Margin = new System.Windows.Forms.Padding(4);
            this.pnphat.Name = "pnphat";
            this.pnphat.Size = new System.Drawing.Size(163, 26);
            this.pnphat.TabIndex = 15;
            // 
            // pnmasach
            // 
            this.pnmasach.FormattingEnabled = true;
            this.pnmasach.Location = new System.Drawing.Point(161, 109);
            this.pnmasach.Margin = new System.Windows.Forms.Padding(4);
            this.pnmasach.Name = "pnmasach";
            this.pnmasach.Size = new System.Drawing.Size(179, 27);
            this.pnmasach.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(455, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Phạt Quá Hạn";
            // 
            // dgvpn1
            // 
            this.dgvpn1.AllowUserToAddRows = false;
            this.dgvpn1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpn1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpn1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column7,
            this.Column1});
            this.dgvpn1.Location = new System.Drawing.Point(4, 214);
            this.dgvpn1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpn1.Name = "dgvpn1";
            this.dgvpn1.Size = new System.Drawing.Size(804, 229);
            this.dgvpn1.TabIndex = 10;
            this.dgvpn1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpn1_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu Mượn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Sách";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayTra";
            this.Column7.HeaderText = "Ngày Trả";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PhatQuaHan";
            this.Column1.HeaderText = "Phạt Quá Hạn";
            this.Column1.Name = "Column1";
            // 
            // pnmaphieu
            // 
            this.pnmaphieu.FormattingEnabled = true;
            this.pnmaphieu.Location = new System.Drawing.Point(161, 62);
            this.pnmaphieu.Margin = new System.Windows.Forms.Padding(4);
            this.pnmaphieu.Name = "pnmaphieu";
            this.pnmaphieu.Size = new System.Drawing.Size(179, 27);
            this.pnmaphieu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(455, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã Sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã Phiếu Mượn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 521);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "PHIẾU TRẢ";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox pnmasach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvpn1;
        private System.Windows.Forms.ComboBox pnmaphieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttqlnvxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker pnngaytra;
        private System.Windows.Forms.ComboBox pnmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pnphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
    }
}