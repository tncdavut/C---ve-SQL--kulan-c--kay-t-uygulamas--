using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kisiler
{
    public partial class KAYIT : Form
    {
        
        public KAYIT()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db2;
        DataClasses1DataContext db;
        private void KAYIT_Load(object sender, EventArgs e)
        {
            db2 = new DataClasses1DataContext();
            İLCOMBOX.ValueMember = "İLİD";
            İLCOMBOX.DisplayMember = "İLLER";
            İLCOMBOX.DataSource = db2.İL;

            // TODO: Bu kod satırı 'kisilerDataSet.GOREVLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gOREVLERTableAdapter.Fill(this.kisilerDataSet.GOREVLER);
            // TODO: Bu kod satırı 'kisilerDataSet.İLCE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İLCETableAdapter.Fill(this.kisilerDataSet.İLCE);
            // TODO: Bu kod satırı 'kisilerDataSet.İL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İLTableAdapter.Fill(this.kisilerDataSet.İL);

            SqlCommand komut = new SqlCommand("Select *From GOREVLER", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GOREVCOMBOX.ValueMember = "GOREVİD";
            GOREVCOMBOX.DisplayMember = "GOREVADI";
            GOREVCOMBOX.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select *From İL", baglan);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            İLCOMBOX.ValueMember = "İLİD";
            İLCOMBOX.DisplayMember = "İLLER";
            İLCOMBOX.DataSource = dt2;

            SqlCommand komut3 = new SqlCommand("Select *From İLCE", baglan);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            İLCECOMBOX.ValueMember = "İLCEİD";
            İLCECOMBOX.DisplayMember = "İLCELER";
            İLCECOMBOX.DataSource =  dt3;


        }
        private void LİSTELEME_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=kisiler;Integrated Security=True");
            DataTable dt = new DataTable();
            string sql = "SELECT KİSİİD, KİSİADI ,KİSİSOYADI, İLLER,İLCELER, GOREVADI ,GOREVMAASI FROM KİSİLER\r\nJOIN İL ON KİSİLER.İLİD =İL.İLİD\r\nJOIN İLCE ON KİSİLER.İLCEİD = İLCE.İLCEİD\r\nJOIN GOREVLER ON KİSİLER.GOREVİD = GOREVLER.GOREVİD;";
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void İLCOMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (İLCOMBOX.SelectedIndex != -1)
            {
               
                var sehirilceler = from i in db2.İLCE where i.İLİD == Convert.ToInt32(İLCOMBOX.SelectedValue) select i;
                İLCECOMBOX.ValueMember = "İLCEİD";
                İLCECOMBOX.DisplayMember = "İLCELER";
                İLCECOMBOX.DataSource = sehirilceler;
            }
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=kisiler;Integrated Security=True");

        private void KAYDETBUTON_Click(object sender, EventArgs e)
        {

            if (ADITEXBOX.Text.ToString() == "" || SOYADITEXBOX.Text.ToString() == "" || İLCOMBOX.Text.ToString() == "" || GOREVCOMBOX.Text.ToString() == "")
            {
 
                MessageBox.Show("alanları boş geçemeyiniz lütfen", "uyarı");
            }
            else
            {

                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into kisiler (KİSİADI,KİSİSOYADI,İLİD,İLCEİD,GOREVİD) values(@p1,@p2,@p3,@p4,@p5)", baglan);
                komut.Parameters.AddWithValue("@p1", ADITEXBOX.Text);
                komut.Parameters.AddWithValue("@p2", SOYADITEXBOX.Text);
                komut.Parameters.AddWithValue("@p3", İLCOMBOX.SelectedValue);
                komut.Parameters.AddWithValue("@p4", İLCECOMBOX.SelectedValue);
                komut.Parameters.AddWithValue("@p5", GOREVCOMBOX.SelectedValue);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("başarılı şekilde kaydedilmiştir");
                IDTXTBOX.Clear();
                ADITEXBOX.Clear();
                SOYADITEXBOX.Clear();
            }




        }
       
        private void button1_Click(object sender, EventArgs e) // SİLME BUTONU
        {

          
            if (IDTXTBOX.Text.ToString() != "")
            {

                baglan.Open();
                SqlCommand komut = new SqlCommand("Delete from kisiler where  KİSİİD = '" + IDTXTBOX.Text.ToString() + "'", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                IDTXTBOX.Clear();
                ADITEXBOX.Clear();
                SOYADITEXBOX.Clear();
                MessageBox.Show("BAŞARILI ŞEKİLDE SİLİNDİ", "uyarı");
            }
            else
            {

                MessageBox.Show("lütfen silmek istedğiniz kişinin ID yazınız", "uyarı");
            }
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            
            if (ADITEXBOX.Text.ToString() == "" || SOYADITEXBOX.Text.ToString() == "" || İLCOMBOX.Text.ToString() == "" || GOREVCOMBOX.Text.ToString() == "")
            {
                MessageBox.Show("alanları boş geçemeyiniz lütfen", "uyarı");
            }
            else
            {

                baglan.Open();
                SqlCommand komut2 = new SqlCommand("update kisiler set KİSİADI='" + ADITEXBOX.Text + "',KİSİSOYADI='" + SOYADITEXBOX.Text + "',İLİD='" + İLCOMBOX.SelectedValue + "',İLCEİD='" + İLCECOMBOX.SelectedValue + "', GOREVİD='" + GOREVCOMBOX.SelectedValue + "' where KİSİİD=" + IDTXTBOX.Text + "", baglan);
                komut2.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("BAŞARIYLA GÜNCELENDİ", "uyarı");
                IDTXTBOX.Clear();
                ADITEXBOX.Clear();
                SOYADITEXBOX.Clear();
                
            }

        }

        private void GOREVCOMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void İLCECOMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
