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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void ketnoi()
        {
            string kenoi = @"Data Source=LAPTOP-HQA0J30P\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
            cnn = new SqlConnection(kenoi);
            cnn.Open();
        }
        private void HienThi_PM()
        {
            string sql = "select * from PHIEUMUON";
            DataTable dtpm = new DataTable();
            DataSet dspm = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter dapm = new SqlDataAdapter(cmd);
            dapm.Fill(dspm);
            dtpm = dspm.Tables[0];
            dgvpn1.DataSource = dtpm;
           
        }
        private void HienThi_QL()
        {
            DataTable dtql = new DataTable();
            DataSet dsql = new DataSet();
            SqlCommand cmd1 = new SqlCommand("select * from QL_PHIEUMUON", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dsql);
            dtql = dsql.Tables[0];
            dgvpn2.DataSource = dtql;
        }
        private void insert_PM()
        {
            string s1 = pn1ngaymuon.Value.Year + "/" + pn1ngaymuon.Value.Month + "/" + pn1ngaymuon.Value.Day;
            string sql = "insert into PHIEUMUON (MaPM,MaDG,NgayMuon,MaNV) values('" + pn1mapm.Text + "','" + pn1madg.Text + "',convert(smalldatetime,'" + s1.ToString() + "'),'" + pn1manv.Text + "') ";
            SqlCommand cmd1 = new SqlCommand(sql, cnn);
            cmd1.ExecuteNonQuery();

        }
        private void update_PM()
        {string s1 = pn1ngaymuon.Value.Year + "/" + pn1ngaymuon.Value.Month + "/" + pn1ngaymuon.Value.Day;
        SqlCommand cmd = new SqlCommand("update PHIEUMUON set MaDG='" + pn1madg.Text + "',NgayMuon=convert(smalldatetime,'" + s1.ToString() + "'),MaNV='" + pn1manv.Text + "' where MaPM='" + pn1mapm.Text + "'", cnn);
        cmd.ExecuteNonQuery();
        }
        private void update_QL()
        {
            string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            SqlCommand cmd = new SqlCommand("update QL_PHIEUMUON set MaSach='" + pn2masach.Text + "',HanTra=convert(smalldatetime,'" + s2.ToString() + "') where MaPM='" + pn2mapm.Text + "' and MaSach='"+pn2masach.Text+"'" , cnn);
            cmd.ExecuteNonQuery();
        }

        private void delete_PT()
        {string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            SqlCommand cmd = new SqlCommand("delete from TRASACH where MaPM='" + pn1mapm.Text + "'and MaSach='"+pn2masach.Text+"'",cnn);
            cmd.ExecuteNonQuery();
        }
        private void insert_PT()
        {
            string s1 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            string sql = "insert into TRASACH (MaPM,MaSach,MaNV,NgayTra,PhatQuaHan) values ('" + pn1mapm.Text + "','" + pn2masach.Text + "','" + pn1manv.Text + "',convert(smalldatetime,'"+s1.ToString()+"'),'0')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            pn1mapm.Enabled = false;
            pn2mapm.Enabled = false;
            ketnoi();
            HienThi_PM();
            HienThi_QL();

            string maphieu = "select MaDG from DOCGIA";
            SqlCommand cmd = new SqlCommand(maphieu, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            cmd.ExecuteNonQuery();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                pn1madg.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            /////////////////
            
   
            ///////////////
            string manv = "select MaNV from NHANVIEN";
            SqlCommand cmd2 = new SqlCommand(manv, cnn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            DataTable dt2 = new DataTable();
            da2.Fill(ds2);
            dt2 = ds2.Tables[0];
            cmd2.ExecuteNonQuery();

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                pn1manv.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
        }
        
        private void insert_QL()
        {

            string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            SqlCommand cmd = new SqlCommand("insert into QL_PHIEUMUON (MaPM,MaSach,HanTra) values('" + pn2mapm.Text + "','" + pn2masach.Text + "',convert(smalldatetime,'" + s2.ToString() + "'))", cnn);
            cmd.ExecuteNonQuery();
        }
        private void delete_PM()
        {
            SqlCommand cmd=new SqlCommand("delete from PHIEUMUON where MaPM='"+pn1mapm.Text+"'",cnn);
            cmd.ExecuteNonQuery();
            
        }
        private void delete_QL()
        {
            SqlCommand cmd1 = new SqlCommand("delete from QL_PHIEUMUON where MaPM='" + pn2mapm.Text + "' and MaSach='"+pn2masach.Text+"'", cnn);
            cmd1.ExecuteNonQuery();
        }
        private void bttthemmoi_Click(object sender, EventArgs e)
        {
            if (bttthemmoi.Text == "Thêm Mới")
            {
            
                pn2mapm.Enabled = false;
                pn1mapm.Enabled = true;
                pn1madg.Text = "";
                pn1manv.Text = "";
                pn1mapm.Clear();
                pn2mapm.Clear();
                pn2masach.Text = "";
                pn1mapm.Focus();
                button1.Enabled = false;
                bttthemmoi.Text = "Đồng Ý";
                return;
            }
            else
            {
                button1.Enabled = true;
                pn1mapm.Enabled = false;
                pn2mapm.Enabled = false;
                bttthemmoi.Text = "Thêm Mới";
                insert_PM();
                HienThi_PM();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
       private void button22_Click(object sender, EventArgs e)
        {
            if ((pn1mapm.Text == "") ||  (pn1madg.Text == "") || (pn1manv.Text == "") )
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin hoặc thông tin không chính xác");
            }
            else
            {
                insert_PM();
                HienThi_PM();
            }
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            delete_PM();
            HienThi_PM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_PM();
            HienThi_PM();
        }

        private void dgvpn1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                pn1mapm.Text = dgvpn1.Rows[i].Cells[0].Value.ToString().Trim();
                pn1madg.Text = dgvpn1.Rows[i].Cells[1].Value.ToString().Trim();

                DateTime dt=Convert.ToDateTime( dgvpn1.Rows[i].Cells[2].Value.ToString());
                pn1ngaymuon.Value = dt;
                pn1manv.Text = dgvpn1.Rows[i].Cells[3].Value.ToString().Trim();
                pn2masach.Items.Clear();

            }
            catch (Exception) { }
        }
        private void pn1maphieu_TextChanged(object sender, EventArgs e)
        {
            pn2mapm.Text = pn1mapm.Text.ToString();
        }
        private void dgvpn2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {

                pn2mapm.Text = dgvpn2.Rows[i].Cells[0].Value.ToString().Trim();
                pn2masach.Text = dgvpn2.Rows[i].Cells[1].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgvpn2.Rows[i].Cells[2].Value.ToString());
                pn2hantra.Value = dt;
                pn2mapm.Text = pn1mapm.Text.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update SACH set TinhTrang=1 where MaSach='" + pn2masach.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            
            insert_PT();
            insert_QL();
            HienThi_QL();
            pn2masach.Items.Clear();

        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            delete_QL();
            delete_PT();
            SqlCommand cmd = new SqlCommand("update SACH set TinhTrang=0 where MaSach='" + pn2masach.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            HienThi_QL();
            pn2masach.Items.Clear();
        }
        private void pn2masach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pn2masach_Enter(object sender, EventArgs e)
        {
            
            string masach = "select MaSach from SACH where TinhTrang= 0";
            SqlCommand cmd1 = new SqlCommand(masach, cnn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            da1.Fill(ds1);
            dt1 = ds1.Tables[0];
            cmd1.ExecuteNonQuery();

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                pn2masach.Items.Add(ds1.Tables[0].Rows[i][0].ToString().Trim());
            
        }
  
    }
}
