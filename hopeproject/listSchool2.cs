using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace hopeproject
{
    public partial class listSchool2 : UserControl
    {
        /*
         * public bool aktiv 
         * if aktiv 
        */    
    public listSchool2()
        {
            InitializeComponent();
        }

        private void listSchool2_Load(object sender, EventArgs e)
        {

        }

        #region Properties
        private string _id;
        private string _school;
        private string _point;
        private string _path;
        
        [Category("custom props")]
        public string Id
        {
            get { return _id; }
            set { _id = value;}
        }

        [Category("custom props")]
        public string School
        {
            get { return _school; }
            set { _school = value; lblSchool.Text = value; }
        }

        [Category("custom props")]
        public string Point
        {
            get { return _point; }
            set { _point = value; lblPoint.Text = value; }
        }

        [Category("custom props")]
        public string Path
        {
            get { return _path; }
            set {
                _path = value;
                try
                {
                    pictureBox1.Image = Image.FromFile(value);
                }
                catch
                {
                    pictureBox1.Image = hopeproject.Properties.Resources.default_img;
                }
            }
        }
        #endregion

        private void lblSchool_Click(object sender, EventArgs e)
        {
            int __id = Convert.ToInt32(_id);
            int __point = Convert.ToInt32(_point);
            //string __school = _school;
            frmConfirm confirm = new frmConfirm(__id,__point,_school);
            
            confirm.ShowDialog();
            frmConfirmAdmin confirmAdmin = new frmConfirmAdmin(_school, confirm.point_);
            confirmAdmin.ShowDialog();
        }

    }
}
