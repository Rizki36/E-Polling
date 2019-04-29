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
    public partial class frmConfirm : Form
    {

        private const string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|hope.accdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;

        private int id_ = 0;
        public int point_ = 0;
        private string school_;
   
        public frmConfirm(int id,int point,string school)
        {
            InitializeComponent();
            id_ = id;
            point_ = point;
            school_ = school;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            point_ = point_ + (Convert.ToInt32(tbPoint.Text));
            string sql = "UPDATE schools SET points ='" + point_.ToString() + "' WHERE ID=" + id_.ToString() + "";
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
                    this.Close();
                }
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblSchool.Text = school_;
            this.KeyPreview = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            tbPoint.Focus(); // set the textbox focused.

            if (tbPoint.SelectionStart >= 0) //check if there is text to delete
            {
                int TxTindex = tbPoint.SelectionStart; // save the index position

                if (tbPoint.SelectedText.Length > 0)  //// check if there is selected text
                {
                    tbPoint.SelectedText = "";
                }
                else if (TxTindex > 0) // check if there is text in texbox
                {
                    tbPoint.Text = tbPoint.Text.Remove(TxTindex - 1, 1);
                    tbPoint.SelectionStart = TxTindex - 1; // to set the cursor position after the deleted number between the text.
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbPoint.Clear();
        }
        private void btnNumberX(object sender,EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            if (tbPoint.SelectionStart >= 0) //check if there is text to delete
            {
                int TxTindex = tbPoint.SelectionStart; // save the index position

                tbPoint.Text = tbPoint.Text.Insert(TxTindex, btn.Text.ToString());
                tbPoint.SelectionStart = TxTindex + 1; // to set the cursor position after the deleted number between the text.

            }
        }

        private void frmConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            bool active = btnNext.Visible;
            if (e.Control && e.KeyCode == Keys.E)
            {
                if (!active)
                    btnNext.Visible = true;
                else
                    btnNext.Visible = false;
                    
            }
        }
    }
}
