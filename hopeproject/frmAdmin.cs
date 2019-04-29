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
    public partial class frmInput : MetroForm
    {

        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|hope.accdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        private static string strKonfirmasi;

        public frmInput()
        {
            InitializeComponent();
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            tbId.Enabled = false;

            retrieve();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tbSchool.Focus(); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try { 
            int points = Convert.ToInt32(tbPoints.Text);
            add(tbSchool.Text, tbAddress.Text,points);
            points = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add(string school, string address, int points)
        {

            //SQL STMT
            const string sql = "INSERT INTO schools(school,address,points) VALUES(@school,@address,@points)";
            cmd = new OleDbCommand(sql, con);

            string strPoints = points.ToString();
            //ADD PARAMS
            cmd.Parameters.AddWithValue("@school", school);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@points", strPoints);

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

      
        private void retrieve()
        {
            dataGrid.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM schools ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

                con.Close();
                //CLEAR DATATABLE
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        /*
         * FILL DATAGRIDVIEW
         */
        private void populate(string ID, string schools , string address, string point)
        {
            dataGrid.Rows.Add(ID, schools, address, point);
        }


        
        private void clearTxts()
        {
            tbId.Text = "";
            tbSchool.Text = "";
            tbAddress.Text = "";
            tbPoints.Text = "";
            tbSearch.Text = "";
        }

        private void delete(int id)
        {
            string strId = id.ToString();
            string sql = "DELETE FROM schools WHERE ID=" + strId + "";
            cmd = new OleDbCommand(sql, con);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Delete");
                }
                con.Close();

                //REFRESH DATA
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }


        private void update(int id, string school, string address, int points)
        {
            string strId = id.ToString();
            string strPoints = points.ToString();
            //SQL STATEMENT
            string sql = "UPDATE schools SET school='" + school + "',address='" + address + "',points ='" + strPoints + "' WHERE ID=" + strId + "";
            cmd = new OleDbCommand(sql, con);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Updated");
                }
                con.Close();

                //REFRESH DATA
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            btn(false);
            strKonfirmasi = "update";
            tbId.Focus();
        }

        private void btn(bool aktif)
        {
            if (aktif)
            {
                btnInsert.Enabled = true;
                btnRefresh.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnConfirm.Visible = false;
                btnCancel.Visible = false;

                tbId.Enabled = false;
            }else
                {
                btnInsert.Enabled = false;
                btnRefresh.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnConfirm.Visible = true;
                btnCancel.Visible = true;

                tbId.Enabled = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            konfirmasi(strKonfirmasi);
            strKonfirmasi = "";
            clearTxts();
            btn(true);
        }

        private void konfirmasi(string btnCmd)
        {
            try {
                
                switch (btnCmd)
                {
                    case "update":
                        int id = Convert.ToInt32(tbId.Text);
                        int points = Convert.ToInt32(tbPoints.Text);
                        update(id, tbSchool.Text, tbAddress.Text, points);
                        break;
                    case "delete":
                        int ID = Convert.ToInt32(tbId.Text);
                        delete(ID);
                        tbSchool.Enabled = Enabled;
                        tbAddress.Enabled = Enabled;
                        tbPoints.Enabled = Enabled;
                        tbSearch.Enabled = Enabled;
                        break;
                }
  
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btn(true);
            tbSchool.Enabled = Enabled;
            tbAddress.Enabled = Enabled;
            tbPoints.Enabled = Enabled;
            clearTxts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btn(false);
            tbSchool.Enabled = false;
            tbAddress.Enabled = false;
            tbPoints.Enabled = false;
            tbSearch.Enabled = false;
            strKonfirmasi = "delete";
    
        }
        
        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                int selectedIndex = dataGrid.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGrid.SelectedRows[0].Cells[0].Value != null)
                    {
                        if(strKonfirmasi=="delete" || strKonfirmasi == "update")
                        {
                            string id = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                            tbId.Text = id;
                        }
                        if (strKonfirmasi == "update")
                        {

                            string school = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                            string address = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
                            string points = dataGrid.SelectedRows[0].Cells[3].Value.ToString();


                            tbSchool.Text = school;
                            tbAddress.Text = address;
                            tbPoints.Text = points;

                        }
                                
                                
                             
                          
                        

                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearTxts();
            retrieve();
            tbSchool.Focus();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)13)
            {

                dataGrid.Rows.Clear();
                //SQL STATEMENT
                String sql = "SELECT * FROM schools WHERE school='" + tbSearch.Text + "' ";
                cmd = new OleDbCommand(sql, con);
                try
                {
                    con.Open();
                    adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);
                    //LOOP THROUGH DATATABLE
                    foreach (DataRow row in dt.Rows)
                    {
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                    }

                    con.Close();
                    //CLEAR DATATABLE
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }





    }
}
