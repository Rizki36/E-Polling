using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace hopeproject
{
    public partial class frmUser2 : Form
    {
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|hope.accdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbCommand cmdForCount;
        OleDbCommand cmdDatagrid;
        OleDbDataAdapter adapter;

        //for list schools
        DataTable dt = new DataTable();
        //for count schools
        DataTable dc = new DataTable();
        //for top school datagrid
        DataTable dtGrid = new DataTable();

        protected int totalSchools;

        bool isMinimize;
        //untuk memastikan di refresh
        bool mustRefresh;

        public frmUser2()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmUser2_Load(object sender, EventArgs e)
        {
            isMinimize = false;
            this.WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.Controls.Clear();
            loadList("Points");
            tampilkanList();
            
            loadTopSchool();
            tampilkanTopSchool();
            
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tampilkanList()
        {
            listSchool2[] list = new listSchool2[totalSchools];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new listSchool2();
                list[i].Id = dt.Rows[i][0].ToString();
                list[i].School = dt.Rows[i][1].ToString();
                list[i].Point = dt.Rows[i][3].ToString();
                list[i].Path = dt.Rows[i][4].ToString();
                list[i].lblSchool.Click += listClicked;
                flowLayoutPanel1.Controls.Add(list[i]);
            }
            
            dt.Rows.Clear();
            totalSchools = 0;
            //string data = dt.Rows[0][1].ToString();
            //MessageBox.Show(data);
        }

        private void FrmUser2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tampilkanTopSchool()
        {
            datagridTopScore.Rows.Clear();
            int no = 0;
            foreach (DataRow row in dtGrid.Rows)
            {
                no += 1;
                populate(no.ToString(), row[0].ToString(), row[1].ToString());
            }

            dtGrid.Rows.Clear();
        }

        private void populate(string ID, string schools,string point)
        {
            datagridTopScore.Rows.Add(ID, schools,point);
        }

        private void loadSearch()
        {
            string sqlForCount = "SELECT  COUNT(ID) FROM schools WHERE school LIKE '%" + tbSearch.Text + "%' ";
            string sql = "SELECT * FROM schools WHERE school LIKE '%" + tbSearch.Text + "%'";
            cmdForCount = new OleDbCommand(sqlForCount, con);
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmdForCount);
                adapter.Fill(dc);

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                //copy id(string) to message
                //membaca data dari dataTable
                totalSchools = dc.Rows[0].Field<int>(0);

                con.Close();
                //CLEAR DATATABLE
                dc.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void loadTopSchool()
        {
            string sqlDatagrid = "SELECT school,points FROM schools ORDER BY points DESC";
            cmdDatagrid = new OleDbCommand(sqlDatagrid, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmdDatagrid);
                adapter.Fill(dtGrid);

                con.Close();
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
        }
        private void loadList(String sortBy = "ID",string sort ="DESC")
        {
            /*
             *ketika btnAddPoint diklik
             * mencari semua kolom didatabase dengan id tbId.text
             * 
             */

            //SQL STATEMENT
            string sqlForCount = "SELECT  COUNT(ID) FROM schools ";
            string sql = "SELECT * FROM schools ORDER BY " + sortBy + " "+ sort;
            
            cmdForCount = new OleDbCommand(sqlForCount, con);
            cmd = new OleDbCommand(sql, con);
            
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmdForCount);
                adapter.Fill(dc);

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                //copy id(string) to message
                //membaca data dari dataTable
                totalSchools = dc.Rows[0].Field<int>(0);
                
                con.Close();
                //CLEAR DATATABLE
                dc.Rows.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadList("ID","ASC");
            tampilkanList();
            loadTopSchool();
            tampilkanTopSchool();
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadList("school","ASC");
            tampilkanList();
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadList("points");
            tampilkanList();
        }

        private void toRefreh()
        {
            flowLayoutPanel1.Controls.Clear();
            loadList("points");
            tampilkanList();
            loadTopSchool();
            tampilkanTopSchool();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                flowLayoutPanel1.Controls.Clear();
                loadSearch();
                tampilkanList();
                if (tbSearch.Text == "")
                {
                    toRefreh();
                }
                    
            }    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toRefreh();
        }

        //int _point = 0;
        //public int Id
        //{
        //    get { return _point; }
        //}

        private void frmUser2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void frmUser2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                toRefreh();
            }
        }


        private void listClicked(object sender, EventArgs e)
        {
            toRefreh();
        }
    }
}
