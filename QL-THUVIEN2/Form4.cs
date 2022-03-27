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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        string matl,manxb;
        private void HienThi()
        {
            string sql = "select * from SACH";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            dgvsach.DataSource = dt;
        }
      
        private void loadmanxb()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("select * from NXB", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            txtnxb.DataSource = dt;
            txtnxb.DisplayMember = "TenNXB";
            txtnxb.ValueMember = "MaNXB";
        }
        private void loadtl()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("select * from theloai", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            txttheloai.DataSource = dt;
            txttheloai.DisplayMember = "TenTL";
            txttheloai.ValueMember = "MaTL";
            
            
        }
        private void ketnoi()
        {
            string ketnoi = @"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(ketnoi);
            cnn.Open();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            ketnoi();
            HienThi();
            loadmanxb();
            loadtl();
            txtma.Enabled = false;
            txtnxb_SelectedIndexChanged(sender, e);
            txttheloai_SelectedIndexChanged(sender, e);
        }
        private void update()
        {


            SqlCommand cmd = new SqlCommand("update SACH set TenSach=N'" + txtten.Text + "',Gia=" + txtgia.Text + ",MaNXB='" + manxb + "',MaTL=N'" + matl + "',TinhTrang='" + Convert.ToByte(txttinhtrang.Checked) + "' where MaSach='" + txtma.Text + "'", cnn);
            cmd.ExecuteNonQuery();
        }
        private void insert()
        {
         try
            {
                string sql = "insert into SACH values('" + txtma.Text + "',N'" + txtten.Text + "','" + txtgia.Text + "','" + manxb + "','"+matl+"','"+Convert.ToByte(txttinhtrang.Checked)+"')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {MessageBox.Show("Lỗi");
            }
        }
        private void delete()
        {
           
            string sql = "delete from SACH where MaSach='" + txtma.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }

        private void bttttcnluu_Click(object sender, EventArgs e)
        {

            if (bttttcnluu.Text == "Thêm Mới")
            {
                txttheloai.Text = "";
                txtgia.Clear();
                txtma.Clear();
                txtnxb.Text = "";
                txtten.Clear();
                txtma.Focus();
                txtma.Enabled = true;
                bttttcnluu.Text = "Đồng Ý";
           
            }
            else
            {
                txtma.Enabled = false;
                insert();
                HienThi();
                bttttcnluu.Text = "Thêm Mới";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            update();
            HienThi();
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            delete();
            HienThi();
        }

        private void dgvsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = e.RowIndex;
            try {

                txtma.Text = dgvsach.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgvsach.Rows[i].Cells[1].Value.ToString().Trim();
                txtgia.Text = dgvsach.Rows[i].Cells[2].Value.ToString().Trim();
                txtnxb.SelectedValue = dgvsach.Rows[i].Cells[3].Value.ToString().Trim();
                txttheloai.SelectedValue = dgvsach.Rows[i].Cells[4].Value.ToString().Trim();
                string tl = dgvsach.Rows[i].Cells[5].Value.ToString();
                if (tl.ToString() == "True")
                    txttinhtrang.Checked = true;
                else txttinhtrang.Checked = false;
                
            }
            catch (Exception ) {  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            manxb = txtnxb.SelectedValue.ToString();
            
        }

        private void txttheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            matl = txttheloai.SelectedValue.ToString();
          
        }

    }
}
