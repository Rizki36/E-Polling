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

using System.Threading;

namespace hopeproject
{
    public partial class UserControlPesertaLomba : UserControl
    {
        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|hope.accdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt = new DataTable();

        bool on_update;
        bool on_delete;

        public UserControlPesertaLomba()
        {
            InitializeComponent();
        }

        private void UserControlAddSchool_Load(object sender, EventArgs e)
        {
            tbSchool.Focus();
        }

        //untuk menambah data
        private void toAdd(int id,string school, string address, int points, string path)
        {

            //SQL STMT
            //const string sql = "INSERT INTO schools(school,address,points) VALUES(@school,@address,@points)";
            const string sql = "INSERT INTO schools(ID,school,address,points,path) VALUES(@id,@school,@address,@points,@path)";
            cmd = new OleDbCommand(sql, con);

            string strPoints = points.ToString();
            //ADD PARAMS
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@school", school);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@points", strPoints);
            cmd.Parameters.AddWithValue("@path", path);
            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTextboxs();
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
                toRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //untuk merefresh datagrid
        public void toRefresh()
        {
            dataGrid.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM schools ORDER BY ID";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),row[4].ToString());
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

        //untuk enable dan disable tb untuk delete
        private void toDelete(bool delete)
        {
            tbSchool.Enabled = !delete;
            tbAddress.Enabled = !delete;
            tbPoint.Enabled = !delete;
        }

        //untuk menghapus data by id
        private void toDelete(int id)
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
                    clearTextboxs();
                    MessageBox.Show(@"Successfully Delete");
                }
                con.Close();

                //REFRESH DATA
                toRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //untuk enable dan disable tb untuk delete
        private void toUpdate(bool update)
        {
            //tbId.Enabled = update;
        }

        //untuk mengupdate data dari textbox
        private void toUpdate(int id, string school, string address, int points)
        {
            string strId = id.ToString();
            string strPoints = points.ToString();
            //SQL STATEMENT
            string sql = "UPDATE schools SET ID='" + strId + "',school='" + school + "',address='" + address + "',points = '" + points + "',path = '" + filename + "' WHERE ID=" + strId + "";
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
                    clearTextboxs();
                    MessageBox.Show(@"Successfully Updated");
                }
                con.Close();

                //REFRESH DATA
                toRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //untuk mengaktifkan dan nonaktifkan btn
        private void control(bool active)
        {
            btnInsert.Enabled = active;
            btnRefresh.Enabled = active;
            btnDelete.Enabled = active;
            btnUpdate.Enabled = active;
            btnExport.Enabled = active;
            btnPrint.Enabled = active;
        }

        //untuk menambah row dalam datagrid
        private void populate(string ID, string schools, string address, string point,string path)
        {
            dataGrid.Rows.Add(ID, schools, address, point,path);
        }

        //untuk menghapus text dari textboxs
        private void clearTextboxs()
        {
            tbId.Text = "";
            tbSchool.Text = "";
            tbAddress.Text = "";
            tbPoint.Text = "";
            tbSearch.Text = "";
            pictureBox1.Image = _default_image;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            on_delete = true;
            toDelete(true);
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            control(false);
            tbId.Focus();
            toRefresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            on_update = true;
            toUpdate(true);
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
            control(false);
            tbPoint.Focus();
            toRefresh();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSchool.Enabled == false)
                    toDelete(Convert.ToInt32(tbId.Text));
                if (tbSchool.Enabled == true)
                    toUpdate((Convert.ToInt32(tbId.Text)), tbSchool.Text, tbAddress.Text, (Convert.ToInt32(tbPoint.Text)));
                on_delete = false;
                on_update = false;
                toDelete(false);
                toUpdate(false);
                clearTextboxs();
                btnConfirm.Visible = false;
                btnCancel.Visible = false;
                control(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toInsert()
        {
            try
            {
                int points = Convert.ToInt32(tbPoint.Text);
                int _id = Convert.ToInt32(tbId.Text);
                toAdd(_id,tbSchool.Text, tbAddress.Text, points,filename);
                points = 0;
                _id = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            toInsert();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            toRefresh();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dataGrid.Rows.Clear();
                //SQL STATEMENT
                String sql = "SELECT * FROM schools WHERE school LIKE '%" + tbSearch.Text + "%' ";
                cmd = new OleDbCommand(sql, con);
                try
                {
                    con.Open();
                    adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);
                    //LOOP THROUGH DATATABLE
                    foreach (DataRow row in dt.Rows)
                    {
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(),row[4].ToString());
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
                if (tbSearch.Text == "")
                    toRefresh();
            }
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
                        /*if (on_delete == true)
                        {
                            string id = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                            tbId.Text = id;
                        }*/
                        /*if (on_update == true)
                        {
                            string id = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                            string school = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                            string address = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
                            string points = dataGrid.SelectedRows[0].Cells[3].Value.ToString();

                            tbId.Text = id;
                            tbSchool.Text = school;
                            tbAddress.Text = address;
                            tbPoint.Text = points;

                        }*/

                        if (on_delete == true)
                        {
                            clearTextboxs();
                            string id = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                            tbId.Text = id;
                        }
                        else
                        {
                            string id = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                            string school = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                            string address = dataGrid.SelectedRows[0].Cells[2].Value.ToString();
                            string points = dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                            
                            tbId.Text = id;
                            tbSchool.Text = school;
                            tbAddress.Text = address;
                            tbPoint.Text = points;
                        }

                        //to show image picture
                        try
                        {
                            string imgPath = dataGrid.SelectedRows[0].Cells[4].Value.ToString();
                            pictureBox1.Image = Image.FromFile(imgPath);
                        }
                        catch
                        {
                            string imgPath = dataGrid.SelectedRows[0].Cells[4].Value.ToString();
                            pictureBox1.Image = _default_image;   
                        }
                    }

                }
                tbSchool.Focus();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //btnConfirm.Visible = false;
            //btnCancel.Visible = false;
            on_delete = false;
            on_update = false;
            toDelete(false);
            toUpdate(false);
            clearTextboxs();
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            control(true);
        }

        private void tbPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && on_delete == false && on_update == false)
            {
                toInsert();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //coming soon
        }



        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)app.ActiveSheet;
                app.Visible = false;
                int index = 1;
                int process = (dataGrid.Rows.Count - 1) * dataGrid.Columns.Count;
            try
            {
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        if (!backgroundWorker.CancellationPending)
                        {
                            backgroundWorker.ReportProgress(index++ * 100 / process);
                            ws.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value.ToString();
                        }

                        //MessageBox.Show(string.Format("{0} . {1} sukses", i, j));
                    }
                }
                //ws.SaveAs(namaFile, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing);
                ws.SaveAs(namaFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
            catch (Exception ex)
            {
                app.Quit();
                MessageBox.Show(ex.Message);
            } 
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                ProgressBar1.Value = e.ProgressPercentage;
                //lblProgress.Text = string.Format("Processing...{0}", e.ProgressPercentage);
                ProgressBar1.Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                this.Enabled = true;
                //lblProgress.Text = "your data has been successfully exported";
                timerReverse.Enabled = true;
            }
        }

        private string namaFile="";
        Bitmap _default_image = hopeproject.Properties.Resources.default_img;

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx;*.xlsm" })
            {
                if(sfd.ShowDialog()== DialogResult.OK)
                {
                    namaFile = sfd.FileName;
                    ProgressBar1.Value = 0;
                    backgroundWorker.RunWorkerAsync();
                    //lblProgress.Text = "Processing...0";
                    this.Enabled = false;
                }
            }
            
        }

        private void timerReverse_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value -= 1;
            if (ProgressBar1.Value <= 0) { timerReverse.Enabled = false; }
        }
        protected string filename = "";
        private void toOpenImage()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog { Filter = "Image File|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = fileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if(!on_delete == true) {
            //    toOpenImage();
            //}
            if(pictureBox1.Image == _default_image)
            {
                toOpenImage();
            }else if(on_update == true)
            {
                toOpenImage();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextboxs();
        }
    }
}
