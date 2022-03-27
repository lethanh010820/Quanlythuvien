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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection cnn;
        private void ketnoi()
        {
            cnn = new SqlConnection(@"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True");
            cnn.Open();
        }
   
        private void HienThi()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("select * from TRASACH ", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dt = ds.Tables[0];
            dgvpn1.DataSource = dt;

        }
        private void Form7_Load(object sender, EventArgs e)
        {
            pnmasach.Enabled = false;
            pnmanv.Enabled = false;
            pnmaphieu.Enabled = false;
            ketnoi();
            HienThi();
            
            
        }
        private void update_TS()
        {
            string s = pnngaytra.Value.Year + "/" + pnngaytra.Value.Month + "/" + pnngaytra.Value.Day;
            SqlCommand cmd = new SqlCommand("update TRASACH set NgayTra=convert(smalldatetime,'" + s.ToString() + "'),PhatQuaHan='" + pnphat.Text + "' where MaPM='"+pnmaphieu.Text+"' and MaSach='"+pnmasach.Text+"' ", cnn);
            cmd.ExecuteNonQuery();
        }
        private void insert()
        {

            string s = pnngaytra.Value.Year + "/" + pnngaytra.Value.Month + "/" + pnngaytra.Value.Day;
            SqlCommand cmd=new SqlCommand("insert into TRASACH (MaPM,MaSach,MaNV,NgayTra,PhatQuaHan) values('"+pnmaphieu.Text+"','"+pnmasach.Text+"','"+pnmanv.Text+"',convert(smalldatetime,'"+s.ToString()+"'),'"+pnphat.Text+"')",cnn);
            cmd.ExecuteNonQuery();
        }
        private void delete()
        {
            SqlCommand cmd = new SqlCommand("delete from TRASACH where MaPM='" + pnmaphieu.Text + "' and MaSach='"+pnmasach.Text+"'",cnn);
            cmd.ExecuteNonQuery();
        }
        private void delete_mp()
        {
            SqlCommand cmd = new SqlCommand("delete from MAPHIEU where MaPM='" + pnmaphieu.Text + "'",cnn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("delete from QL_PHIEUMUON where MaPM='" + pnmaphieu.Text + "'", cnn);
            cmd1.ExecuteNonQuery();
        }
        private void combobox()
        {
            ketnoi();
            string maphieu = "select MaPM from PHIEUMUON";
            SqlCommand cmd = new SqlCommand(maphieu, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            cmd.ExecuteNonQuery();
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                pnmaphieu.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            string masach = "select MaSach from SACH";
            SqlCommand cmd1 = new SqlCommand(masach, cnn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            da1.Fill(ds1);
            dt1 = ds1.Tables[0];
            cmd1.ExecuteNonQuery();

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                pnmasach.Items.Add(ds1.Tables[0].Rows[i][0].ToString());

            string manv = "select MaNV from NHANVIEN";
            SqlCommand cmd2 = new SqlCommand(manv, cnn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            da2.Fill(ds2);
            dt2 = ds2.Tables[0];
            cmd2.ExecuteNonQuery();

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                pnmanv.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvpn1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                pnmaphieu.Text = dgvpn1.Rows[i].Cells[0].Value.ToString().Trim();
                pnmasach.Text = dgvpn1.Rows[i].Cells[1].Value.ToString().Trim();
                pnmanv.Text = dgvpn1.Rows[i].Cells[2].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgvpn1.Rows[i].Cells[3].Value.ToString());
                pnngaytra.Value = dt;
                pnphat.Text = dgvpn1.Rows[i].Cells[4].Value.ToString().Trim();
                
                DateTime y = DateTime.Now;
                if ((y.Month - pnngaytra.Value.Month > 0) || (y.Day - pnngaytra.Value.Day > 0) && pnphat.Text=="0")
                { MessageBox.Show("Phiếu mượn" + pnmaphieu.Text + " mượn sách " + pnmasach.Text + " quá hạn "); }
            }
            catch (Exception) { }
        }
        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update SACH set TinhTrang=0 where MaSach='" + pnmasach.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("delete from QL_PHIEUMUON where MaPM='" + pnmaphieu.Text + "' and MaSach='" + pnmasach.Text + "'", cnn);
            cmd1.ExecuteNonQuery();
            delete();
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_TS();
            HienThi();
        }


    }
}
