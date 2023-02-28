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

namespace card_app
{
    public partial class obj_Tour : Form
    {
        private Connect con = new Connect();
        private SqlCommand com = new SqlCommand();
        private DataTable dt = new DataTable();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        int cnt;
        int s = 72;
        int n_t = 19;
        int c = 72;
        int p = 54;
        int k = 256;
        Label[] Name_Tour;
        Label[] summa;
        Label[] comment;
        Label[] currency;
        PictureBox[] pic;
        public obj_Tour()
        {
            
            InitializeComponent();
            string str = "Select * from Tour";
            com = new SqlCommand(str,con.getConnect());
            adapter.SelectCommand = com;
            adapter.Fill(dt);
            cnt = dt.Rows.Count;
            dt.Clear();
            Name_Tour = new Label[cnt];
            summa = new Label[cnt];
            comment = new Label[cnt];
            pic = new PictureBox[cnt];
            currency = new Label[cnt];
            for (int i = 0; i < cnt; i++)
            {
                
                summa[i] = new Label();
                summa[i].BackColor = Color.FromArgb(100, 65, 140);
                summa[i].ForeColor = Color.White;
                summa[i].AutoSize = true;
                summa[i].Font = new Font("Comic Sans MS", 11.25f, FontStyle.Bold);
                summa[i].Size = new Size(52, 21);
                summa[i].Location = new Point(550, s);
                summa[i].Text=$"summa{i}";
                //
                
                Name_Tour[i] = new Label();
                Name_Tour[i].BackColor = Color.FromArgb(100, 65, 140);
                Name_Tour[i].ForeColor = Color.White;
                Name_Tour[i].Font = new Font("Comic Sans MS", 12f, FontStyle.Italic);
                Name_Tour[i].AutoSize = true;
                Name_Tour[i].Text = $"Label{i}";
                Name_Tour[i].Size = new Size(52, 23);
                Name_Tour[i].Location = new Point(100,n_t);

                //
                
                comment[i] = new Label();
                comment[i].BackColor = Color.White;
                comment[i].Font = new Font("Times New Roman",9.75f,FontStyle.Italic);
                comment[i].Size = new Size(285, 83);
                comment[i].Location = new Point(250,c);
                comment[i].Text = $"Описание...{i}";
                //
               
                pic[i] = new PictureBox();
                pic[i].BackColor = Color.FromArgb(100,65,140);
                pic[i].Size = new Size(200,168);
                pic[i].Location = new Point(28,p);
                pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                //
                currency[i] = new Label();
                currency[i].BackColor = Color.FromArgb(100,65,140);
                currency[i].ForeColor = Color.White;
                currency[i].Text = "Рублей";
                currency[i].Font = new Font("Comic Sans MS", 11.25f, FontStyle.Italic);
                currency[i].Size = new Size(70, 30);
                currency[i].Location = new Point(610, s);
                //
                this.Controls.Add(Name_Tour[i]);
                this.Controls.Add(summa[i]);
                this.Controls.Add(comment[i]);
                this.Controls.Add(pic[i]);
                this.Controls.Add(currency[i]);
                s += 256;
                n_t += 256;
                c += 256;
                p += 256;
            }
            
            Show_all();
        }
    
        private void Show_all()
        {
            con.OpenCon();
            for (int i = 0; i < cnt; i++)
            {
                string query = "select * from Tour";
                com = new SqlCommand(query, con.getConnect());
                adapter.SelectCommand = com;
                adapter.Fill(dt);
                com.ExecuteNonQuery();
                Name_Tour[i].Text = dt.Rows[i][1].ToString();
                summa[i].Text = dt.Rows[i][2].ToString();
                pic[i].Image = Image.FromFile($@"C:\Users\kotia\source\repos\card_app\card_app\Resources\{Name_Tour[i].Text}\{Name_Tour[i].Text}.jpg");
                
            }





        }
    }
}
