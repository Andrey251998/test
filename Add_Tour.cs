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
using System.IO;

namespace card_app
{
    
    public partial class Add_Tour : Form
    {
       private  Connect con = new Connect();
       private  string query;
       private string pyth;
        private string folder_Tour;
       private  SqlCommand com = new SqlCommand();
       private  DataTable dt = new DataTable();
       private  SqlDataAdapter adapter = new SqlDataAdapter();
       
        public Add_Tour()
        {
            InitializeComponent();
            add_photo.Show();
            
        }
        private void create_folder(TextBox _Name_Tour)
        {
            folder_Tour = $@"C:\Users\kotia\source\repos\card_app\card_app\Resources\{_Name_Tour.Text}";
             DirectoryInfo dir = new DirectoryInfo(folder_Tour);
            if (!dir.Exists)
            {
                dir.Create();
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
                openphoto.ShowDialog();
                picture1.Image = Image.FromFile(openphoto.FileName);
                picture1.SizeMode = PictureBoxSizeMode.Zoom;
                picture1.Show();
                add_photo.Hide();
                add_photo.Enabled = false;
            check_photo.Hide();
            
            FileInfo file = new FileInfo(openphoto.FileName);
            pyth = file.FullName;
            
            
            
        }

         private void add_Click(object sender, EventArgs e)
        {
            create_folder(Name_Tour);
            con.OpenCon();
            File.Copy(openphoto.FileName,$@"{folder_Tour}\{Name_Tour.Text}.jpg");

            query = @"SELECT 'true' FROM sys.Tables WHERE  Name = 'Tour'";
            com = new SqlCommand(query, con.getConnect());
            adapter.SelectCommand = com;
            adapter.Fill(dt);

            query = $@"insert into Tour values 
            ('{Name_Tour.Text}',{price.Text})";
            com = new SqlCommand(query, con.getConnect());
            com.ExecuteNonQuery();
            MessageBox.Show("Добавлена ");
            Close();
            _default def = new _default();
            def.ChildForm(new Add_Tour(), sender);
            
        }
            
        
    }
}
