using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_THUVIEN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        string tk;
       
        public void KetNoi()
        {

                string ketnoi = @"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
                cnn = new SqlConnection(ketnoi);
                cnn.Open();
        }

        private void HienThi()
        {
            string sql = "select MaNV,TenNV,GioiTinh,DiaChi,SDT,NgaySinh,TaiKhoan from NHANVIEN";
            DataTable dtnv = new DataTable();
            DataSet dsnv = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsnv);
            dtnv = dsnv.Tables[0];
            dgvnvdanhsach.DataSource = dtnv;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Enabled = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelqlnhanvien.Enabled = false;
            KetNoi();
            ttcnma.Enabled = false;
            
        }
        private void update()
        {           
            string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
            SqlCommand cmd = new SqlCommand("update NHANVIEN set TenNV=N'" + ttcnten.Text + "',GioiTinh=N'" + ttcngioitinh.Text + "',DiaChi=N'" + ttcndiachi.Text + "',SDT='" + ttcnsdt.Text + "',NgaySinh=convert(smalldatetime,'" + s.ToString() + "') where MaNV='"+ttcnma.Text+"'", cnn);
            cmd.ExecuteNonQuery();

        }
        private void delete()
        {
            string sql = "delete from NHANVIEN where MaNV='" + ttcnma.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        private void insert()
        {
            try
            {
                string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
                string sql =
                    "insert into NHANVIEN(MaNV,TenNV,GioiTinh,DiaChi,SDT,NgaySinh) values('" + ttcnma.Text + "',N'" + ttcnten.Text + "',N'" + ttcngioitinh.Text + "',N'" + ttcndiachi.Text + "','" + ttcnsdt.Text + "',convert(smalldatetime,'" + s.ToString() + "'))";
               
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.Add(new SqlParameter("@tr", ttcnngaysinh.Value.Date));
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { MessageBox.Show("Không được trùng Mã Nhân Viên"); }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Visible = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelqlnhanvien.Enabled = false;
            bttdangnhap.Enabled = true;
            panel6.Visible=true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            frm3.ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            
            Form2 frm= new Form2();
            frm.Message = txtdntaikhoan.Text;
            frm.MK = txtdnmatkhau.Text;
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();

            frm4.ShowDialog();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            KetNoi();       
            string sql=@"select * from NHANVIEN where TaiKhoan='"+txtdntaikhoan.Text+"' and MatKhau = '"+txtdnmatkhau.Text+"' ";
            DataTable dt=new DataTable();
            DataSet ds=new DataSet();
            SqlCommand cmd=new SqlCommand(sql,cnn);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt=ds.Tables[0];
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công !");
                bttdangnhap.Enabled = false;
                paneldsnv.Enabled = true;
                panelqlphieu.Enabled = true;
                panelqldocgia.Enabled = true;
                panelqlnhanvien.Enabled = true;
                paneldangnhap.Hide();
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Mật khẩu\n không chính xác!");
                txtdntaikhoan.Focus();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdnmatkhau.Clear();
            txtdntaikhoan.Clear();
            paneldangnhap.Visible = true;
            txtdntaikhoan.Focus();
        }

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    paneldsnv.Visible = true;
        //    HienThi();

        //}

        private void button7_Click(object sender, EventArgs e)
        {
            KetNoi();
            paneldsnv.Visible = true;
            HienThi();

        }

        private void dgvnvdanhsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            bttqltk.Visible = true;
            try
            {
                ttcnma.Text = dgvnvdanhsach.Rows[i].Cells[0].Value.ToString().Trim();
                ttcnten.Text = dgvnvdanhsach.Rows[i].Cells[1].Value.ToString().Trim();
                ttcngioitinh.Text=dgvnvdanhsach.Rows[i].Cells[2].Value.ToString().Trim();
                ttcndiachi.Text = dgvnvdanhsach.Rows[i].Cells[3].Value.ToString().Trim();
                ttcnsdt.Text = dgvnvdanhsach.Rows[i].Cells[4].Value.ToString().Trim();
                DateTime dt =Convert.ToDateTime( dgvnvdanhsach.Rows[i].Cells[5].Value.ToString());
                ttcnngaysinh.Value = dt;
                tk = dgvnvdanhsach.Rows[i].Cells[6].Value.ToString();
            
            }
            catch (Exception ) {  }
        }

        private void bttttcnluu_Click(object sender, EventArgs e)
        {

            if (bttttcnluu.Text == "Thêm Mới")
            {
                bttttcnluu.Text = "Đồng Ý";
                bttqltk.Hide();
                ttcnsdt.Clear();
                ttcnten.Clear();
                ttcngioitinh.Clear();
                ttcndiachi.Clear();
                ttcnma.Clear();
                ttcnngaysinh.Text = "";
                ttcnma.Focus();
                ttcnma.Enabled = true;
                button1.Enabled = false;
                bttqlnvxoa.Enabled = false;
                return;
            }
            else
            {
     
                bttttcnluu.Text = "Thêm Mới";
 
                button1.Enabled = true;
                bttqlnvxoa.Enabled = true;
                bttqltk.Hide();
                insert();
                HienThi();
                ttcnma.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
            update();
            HienThi();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            bttqltk.Hide();
            delete();
            HienThi();
        }

        private void bttqltk_Click(object sender, EventArgs e)
        {
            
            if (tk.ToString() =="")
            {
                Form2 frm = new Form2();
                frm.MaNV = ttcnma.Text;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nhân viên này đã có tài khoản");
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            new Form7().ShowDialog();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form9().ShowDialog();
        }

        private void paneldsnv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdntaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvnvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvnvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
