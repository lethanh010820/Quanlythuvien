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
    public partial class Form5 : Form
    {
        SqlConnection cnn;
        public Form5()
        {
            InitializeComponent();
        }
        private void ketnoi()
        {
            string ketnoi = @"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(ketnoi);
            cnn.Open();
        }
       private void HienThi()
        {
           string sql = "select * from NXB";
           DataTable dt = new DataTable();
           DataSet ds = new DataSet();
           SqlCommand cmd = new SqlCommand(sql, cnn);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(ds);
           dt = ds.Tables[0];
           dgvnxb.DataSource = dt;

           //string sql = "select * from NHANVIEN";
           //DataTable dtnv = new DataTable();
           //DataSet dsnv = new DataSet();
           //SqlCommand cmd = new SqlCommand(sql, cnn);
           //SqlDataAdapter da = new SqlDataAdapter(cmd);
           //da.Fill(dsnv);
           //dtnv = dsnv.Tables[0];
           //dgvnvdanhsach.DataSource = dtnv;
        }


        private void insert()
       {
            string sql="insert into NXB values('"+txtma.Text+"',N'"+txtten.Text+"',N'"+txtdiachi.Text+"','"+txtsdt.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
       }
        private void delete()
        {
            string sql = "delete from NXB where MaNXB='" + txtma.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        private void update()
        {
            SqlCommand cmd = new SqlCommand("update NXB set TenNXB=N'" + txtten.Text + "',DiaChi=N'" + txtdiachi.Text + "',SDT='" + txtsdt.Text + "' where MaNXB='" + txtma.Text + "'",cnn);
            cmd.ExecuteNonQuery();
        }
        private void dgvnxb_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtma.Text = dgvnxb.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgvnxb.Rows[i].Cells[1].Value.ToString().Trim();
                txtdiachi.Text = dgvnxb.Rows[i].Cells[2].Value.ToString().Trim();
                txtsdt.Text = dgvnxb.Rows[i].Cells[3].Value.ToString().Trim();
            }
            catch (Exception a) { MessageBox.Show(a.Message); }
        }
        private void bttttcnluu_Click(object sender, EventArgs e)
        {
            if (bttthem.Text == "Thêm Mới")
            {
                txtma.Enabled = true;
                txtdiachi.Clear();
                txtma.Clear();
                txtsdt.Clear();
                txtten.Clear();
                button1.Enabled = false;
                bttqlnvxoa.Enabled = false;
                bttthem.Text = "Đồng Ý";
            }
            else
            {
                bttthem.Text = "Thêm Mới";
                button1.Enabled = true;
                bttqlnvxoa.Enabled = true;
                txtma.Enabled = false;
                insert();
                HienThi();
            }
        }

 
        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            delete();
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtma.Enabled = false;
            ketnoi();
            HienThi();
        }

        private void paneldg_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
