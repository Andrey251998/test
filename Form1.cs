using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card_app
{
    public partial class _default : Form
    {

        private Form ActiveForm;

        public _default()
        {
            InitializeComponent();
            Big_Font();
            create_new_Tour.Hide();
        }
        private void Big_Font()
        {
            Tour.MouseEnter +=(s,a) => { Tour.Font = new Font(Tour.Font.Name,16); };
            Tour.MouseLeave += (s, a) => { Tour.Font = new Font(Tour.Font.Name, 12); };

            Clients.MouseEnter += (s, a) => { Clients.Font = new Font(Clients.Font.Name, 16); };
            Clients.MouseLeave += (s, a) => { Clients.Font = new Font(Clients.Font.Name, 12); };

            staff.MouseEnter += (s, a) => { staff.Font = new Font(staff.Font.Name, 16); };
            staff.MouseLeave += (s, a) => { staff.Font = new Font(staff.Font.Name, 12); };

            Archives.MouseEnter += (s, a) => { Archives.Font = new Font(Archives.Font.Name, 16); };
            Archives.MouseLeave += (s, a) => { Archives.Font = new Font(Archives.Font.Name, 12); };
        }

        private void _default_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travel_companyDataSet2.staff". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travel_companyDataSet1.Tours". При необходимости она может быть перемещена или удалена.


        }
        public  void ChildForm(Form childFormm,object sender=default)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childFormm;
            childFormm.TopLevel = false;
            childFormm.FormBorderStyle = FormBorderStyle.None;
            childFormm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childFormm);
            this.panelDesktopPanel.Tag = childFormm;
            childFormm.BringToFront();
            childFormm.Show();
        }

        private void Tour_Click(object sender, EventArgs e)
        {
            create_new_Tour.Show();
            ChildForm(new obj_Tour(),sender);
            
        }

        private void staff_Click(object sender, EventArgs e)
        {
            
           
        }

        private void create_new_Tour_Click(object sender, EventArgs e)
        {
            ChildForm(new Add_Tour(), sender);
        }
    }
}

