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
    public partial class Form2 : Form
    {
        private string _message;
        private string _manv;
        private string _mk;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnn;

        public void KetNoi()
        {
            string ketnoi = @"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(ketnoi);
            cnn.Open();
        }
        public string MK
        {
            get { return _mk; }
            set { _mk = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            lbltaikhoan.Text = _message;
  
            KetNoi();
            if (_message != null)
            {
                panel1.Visible=true;
                panel2.Hide();
            }
            if (_manv != null)
            {
                panel1.Hide();
                panel2.Visible = true;
            }
        }    
   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = @"select TaiKhoan  from NHANVIEN where MaNV='" + _manv.ToString() + "' and TaiKhoan='"+null+"' ";
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dt = ds.Tables[0];
                if (dt.Rows.Count>0)
                { MessageBox.Show("Tài Khoản đã tồn tại"); }
                else
                {
                    string insert = "update NHANVIEN set TaiKhoan='" + txttk.Text + "',MatKhau='" + txtmk.Text + "' where MaNV='" + _manv.ToString() + "' ";
                    MessageBox.Show("Tạo Thành Công!");
                    SqlCommand cmd1 = new SqlCommand(insert, cnn);
                    cmd1.ExecuteNonQuery();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
                
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtmkcu.PasswordChar = '\0';
                txtmklai.PasswordChar = '\0';
                txtmkmoi.PasswordChar = '\0';
            }
            if (checkBox1.Checked == false)
            {
                txtmkcu.PasswordChar = '*';
                txtmkmoi.PasswordChar = '*';
                txtmklai.PasswordChar = '*';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtmkcu.Text == _mk)
            {
                if (txtmkmoi.Text == txtmklai.Text)
                {
                    try
                    {
                        string sql = "update NHANVIEN set MatKhau='" + txtmkmoi.Text + "' where TaiKhoan='" + lbltaikhoan.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi thành công !");
                    }
                    catch (Exception ) { MessageBox.Show("Lỗi !"); }
                }
                else { MessageBox.Show("Mật khẩu mới không khớp!");
                txtmkmoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác !");
                txtmkcu.Focus(); 
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbltaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
