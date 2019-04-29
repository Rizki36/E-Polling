using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework;
using System.Data.OleDb;

namespace hopeproject
{
    public partial class frmView : MetroForm
    {

        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|hope.accdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        //public void uji()
        //{
        //    String sql = "SELECT * FROM schools ";
        //    cmd = new OleDbCommand(sql, con);
        //    try
        //    {
        //        con.Open();
        //        adapter = new OleDbDataAdapter(cmd);
        //        adapter.Fill(dt);
        //        //LOOP THROUGH DATATABLE
        //        string field = dt.Rows[0].Field<string>(2);
        //        MessageBox.Show(field);
        //        con.Close();
        //        //CLEAR DATATABLE
        //        dt.Rows.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        con.Close();
        //    }
        //}


    }
}
