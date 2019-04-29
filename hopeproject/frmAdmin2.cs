using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace hopeproject
{
    public partial class frmAdmin2 : Form
    {
        Thread th;
        bool isMinimize;
        int distance_width_ofBtn = 30;
        int distance_top_ofBtn = 37;

        public frmAdmin2()
        {
            InitializeComponent();
        }

        private void frmAdmin2_Load(object sender, EventArgs e)
        {
            isMinimize = false;
            this.WindowState = FormWindowState.Maximized;
            UserControlPesertaLomba1.Dock = DockStyle.Fill;
            userControlStatistika1.Dock = DockStyle.Fill;
            userControlOption1.Dock = DockStyle.Fill;
            btnPesertaLomba_Click(new object(), new EventArgs());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesertaLomba_Click(object sender, EventArgs e)
        {   
            panelLeft.Location = new Point((distance_width_ofBtn + btnPesertaLomba.Left), (btnPesertaLomba.Top + distance_top_ofBtn));
            panelLeft.Width = btnPesertaLomba.Width - 2 * distance_width_ofBtn;
            UserControlPesertaLomba1.BringToFront();
            UserControlPesertaLomba1.toRefresh();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            panelLeft.Location = new Point((distance_width_ofBtn + btnStatistika.Left), (btnStatistika.Top + distance_top_ofBtn));
            panelLeft.Width = btnStatistika.Width - 2 * distance_width_ofBtn;
            userControlStatistika1.BringToFront();
            userControlStatistika1.toRefresh();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            panelLeft.Location = new Point((distance_width_ofBtn + btnOption.Left), (btnOption.Top + distance_top_ofBtn));
            panelLeft.Width = btnOption.Width - 2 * distance_width_ofBtn;
            userControlOption1.BringToFront();
        }

        private void userControlAddSchool1_Load(object sender, EventArgs e)
        {
            UserControlPesertaLomba1.toRefresh();
        }

        private void openFrmUser()
        {
            Application.Run(new frmLogin());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //untuk membuka form user
            th = new Thread(openFrmUser);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
            //frmView.Show();
            this.Close();
        }

        private void panelAtas_DoubleClick(object sender, EventArgs e)
        {
            if (isMinimize)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            isMinimize = !isMinimize;
        }

        private void frmAdmin2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void userControlStatistika1_Load(object sender, EventArgs e)
        {
            userControlStatistika1.toRefresh();
        }
    }
}
