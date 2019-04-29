using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace hopeproject
{
    public partial class UserControlStatistika : UserControl
    {
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|hope.accdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbCommand cmdForCount;
        OleDbDataAdapter adapter;

        //for list schools
        DataTable dt = new DataTable();
        //for count schools
        DataTable dc = new DataTable();

        protected int totalSchools;

        public UserControlStatistika()
        {
            InitializeComponent();
        }

        private void UserControlStatistika_Load(object sender, EventArgs e)
        {
            toRefresh();
        }
        private void loadList()
        {
            /*
             *ketika btnAddPoint diklik
             * mencari semua kolom didatabase dengan id tbId.text
             * 
             */

            //SQL STATEMENT
            string sqlForCount = "SELECT  COUNT(ID) FROM schools ";
            string sql = "SELECT * FROM schools ORDER BY points DESC";

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
        private void tampilkanList()
        {
            listSchool2[] list = new listSchool2[totalSchools];
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new listSchool2();
                list[i].lblSchool.Enabled = false;
                list[i].Id = dt.Rows[i][0].ToString();
                list[i].School = dt.Rows[i][1].ToString();
                list[i].Point = dt.Rows[i][3].ToString();
                list[i].Path = dt.Rows[i][4].ToString();
                flowLayoutPanel1.Controls.Add(list[i]);
            }
            
            dt.Rows.Clear();
            totalSchools = 0;
            //string data = dt.Rows[0][1].ToString();
            //MessageBox.Show(data);
        }

        public void toRefresh()
        {
            loadList();
            tampilkanList();
        }

    }
}
