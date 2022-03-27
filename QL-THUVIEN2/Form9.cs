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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void ketnoi()
        {
            string ketnoi = @"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(ketnoi);
            cnn.Open();
        }
        private void HienThi()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("select *from THELOAI", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            dgv.DataSource = dt;
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            ma.Enabled = false;
            ketnoi();
            HienThi();
        }

        private void bttthemmoi_Click(object sender, EventArgs e)
        {
            bttqlnvxoa.Enabled = false;
            button1.Enabled = false;
            if(bttthemmoi.Text=="Thêm Mới")
            {
                ma.Clear();
                ten.Clear();
                bttthemmoi.Text = "Đồng Ý";
                ma.Focus();
                ma.Enabled = true;
                
                return;
            }
            if (bttthemmoi.Text=="Đồng Ý")
            {
                try
                {
                    string sql = "insert into THELOAI values('" + ma.Text + "',N'" + ten.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, cnn);
                    cmd.ExecuteNonQuery();
                    HienThi();
                    
                    ma.Enabled = false;
                    bttthemmoi.Text = "Thêm Mới";
                    bttqlnvxoa.Enabled = true;
                    button1.Enabled = true;
                    return;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); };

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from THELOAI where MaTL='" + ma.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                ma.Text = dgv.Rows[i].Cells[0].Value.ToString().Trim();
                ten.Text = dgv.Rows[i].Cells[1].Value.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update THELOAI set  TenTL=N'" + ten.Text + "' where MaTL='" + ma.Text + "' ", cnn);
            cmd.ExecuteNonQuery();
            HienThi();
        }


    }
}
