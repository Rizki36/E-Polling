namespace hopeproject
{
    partial class frmAdmin2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdminForm = new System.Windows.Forms.Label();
            this.btnOption = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStatistika = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPesertaLomba = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.userControlStatistika1 = new hopeproject.UserControlStatistika();
            this.userControlOption1 = new hopeproject.UserControlOption();
            this.UserControlPesertaLomba1 = new hopeproject.UserControlPesertaLomba();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnOption);
            this.panel1.Controls.Add(this.btnStatistika);
            this.panel1.Controls.Add(this.btnPesertaLomba);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 496);
            this.panel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.panelLeft.Location = new System.Drawing.Point(32, 222);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(147, 5);
            this.panelLeft.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(58)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.lblAdminForm);
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 48);
            this.panel2.TabIndex = 5;
            // 
            // lblAdminForm
            // 
            this.lblAdminForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.lblAdminForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminForm.ForeColor = System.Drawing.Color.White;
            this.lblAdminForm.Location = new System.Drawing.Point(0, 0);
            this.lblAdminForm.Name = "lblAdminForm";
            this.lblAdminForm.Size = new System.Drawing.Size(214, 48);
            this.lblAdminForm.TabIndex = 0;
            this.lblAdminForm.Text = "ADMIN FORM";
            this.lblAdminForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOption
            // 
            this.btnOption.Activecolor = System.Drawing.Color.Transparent;
            this.btnOption.BackColor = System.Drawing.Color.Transparent;
            this.btnOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption.BorderRadius = 0;
            this.btnOption.ButtonText = "Option";
            this.btnOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOption.DisabledColor = System.Drawing.Color.Gray;
            this.btnOption.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOption.Iconimage = null;
            this.btnOption.Iconimage_right = null;
            this.btnOption.Iconimage_right_Selected = null;
            this.btnOption.Iconimage_Selected = null;
            this.btnOption.IconMarginLeft = 0;
            this.btnOption.IconMarginRight = 0;
            this.btnOption.IconRightVisible = true;
            this.btnOption.IconRightZoom = 0D;
            this.btnOption.IconVisible = true;
            this.btnOption.IconZoom = 90D;
            this.btnOption.IsTab = false;
            this.btnOption.Location = new System.Drawing.Point(62, 294);
            this.btnOption.Margin = new System.Windows.Forms.Padding(0);
            this.btnOption.Name = "btnOption";
            this.btnOption.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOption.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnOption.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOption.selected = false;
            this.btnOption.Size = new System.Drawing.Size(90, 48);
            this.btnOption.TabIndex = 4;
            this.btnOption.TabStop = false;
            this.btnOption.Text = "Option";
            this.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOption.Textcolor = System.Drawing.Color.White;
            this.btnOption.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Activecolor = System.Drawing.Color.Transparent;
            this.btnStatistika.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistika.BorderRadius = 0;
            this.btnStatistika.ButtonText = "Statistika";
            this.btnStatistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistika.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatistika.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatistika.Iconimage = null;
            this.btnStatistika.Iconimage_right = null;
            this.btnStatistika.Iconimage_right_Selected = null;
            this.btnStatistika.Iconimage_Selected = null;
            this.btnStatistika.IconMarginLeft = 0;
            this.btnStatistika.IconMarginRight = 0;
            this.btnStatistika.IconRightVisible = true;
            this.btnStatistika.IconRightZoom = 0D;
            this.btnStatistika.IconVisible = true;
            this.btnStatistika.IconZoom = 90D;
            this.btnStatistika.IsTab = false;
            this.btnStatistika.Location = new System.Drawing.Point(51, 239);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStatistika.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStatistika.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStatistika.selected = false;
            this.btnStatistika.Size = new System.Drawing.Size(112, 48);
            this.btnStatistika.TabIndex = 3;
            this.btnStatistika.TabStop = false;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistika.Textcolor = System.Drawing.Color.White;
            this.btnStatistika.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnPesertaLomba
            // 
            this.btnPesertaLomba.Activecolor = System.Drawing.Color.Transparent;
            this.btnPesertaLomba.BackColor = System.Drawing.Color.Transparent;
            this.btnPesertaLomba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesertaLomba.BorderRadius = 0;
            this.btnPesertaLomba.ButtonText = "Peserta Lomba";
            this.btnPesertaLomba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesertaLomba.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesertaLomba.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesertaLomba.Iconimage = null;
            this.btnPesertaLomba.Iconimage_right = null;
            this.btnPesertaLomba.Iconimage_right_Selected = null;
            this.btnPesertaLomba.Iconimage_Selected = null;
            this.btnPesertaLomba.IconMarginLeft = 0;
            this.btnPesertaLomba.IconMarginRight = 0;
            this.btnPesertaLomba.IconRightVisible = true;
            this.btnPesertaLomba.IconRightZoom = 0D;
            this.btnPesertaLomba.IconVisible = true;
            this.btnPesertaLomba.IconZoom = 90D;
            this.btnPesertaLomba.IsTab = false;
            this.btnPesertaLomba.Location = new System.Drawing.Point(23, 184);
            this.btnPesertaLomba.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesertaLomba.Name = "btnPesertaLomba";
            this.btnPesertaLomba.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPesertaLomba.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPesertaLomba.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesertaLomba.selected = false;
            this.btnPesertaLomba.Size = new System.Drawing.Size(168, 48);
            this.btnPesertaLomba.TabIndex = 1;
            this.btnPesertaLomba.TabStop = false;
            this.btnPesertaLomba.Text = "Peserta Lomba";
            this.btnPesertaLomba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesertaLomba.Textcolor = System.Drawing.Color.White;
            this.btnPesertaLomba.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesertaLomba.Click += new System.EventHandler(this.btnPesertaLomba_Click);
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.panelAtas.Controls.Add(this.pictureBox1);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1033, 37);
            this.panelAtas.TabIndex = 1;
            this.panelAtas.DoubleClick += new System.EventHandler(this.panelAtas_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::hopeproject.Properties.Resources.iconfinder_cross_4115230;
            this.pictureBox1.Location = new System.Drawing.Point(993, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::hopeproject.Properties.Resources.iconfinder_chevron_left_4115222;
            this.pictureBox2.Location = new System.Drawing.Point(14, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel_container
            // 
            this.panel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Controls.Add(this.userControlStatistika1);
            this.panel_container.Controls.Add(this.userControlOption1);
            this.panel_container.Controls.Add(this.pictureBox2);
            this.panel_container.Controls.Add(this.UserControlPesertaLomba1);
            this.panel_container.Location = new System.Drawing.Point(214, 36);
            this.panel_container.Margin = new System.Windows.Forms.Padding(0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(819, 486);
            this.panel_container.TabIndex = 2;
            // 
            // userControlStatistika1
            // 
            this.userControlStatistika1.BackColor = System.Drawing.Color.White;
            this.userControlStatistika1.Location = new System.Drawing.Point(112, 19);
            this.userControlStatistika1.Name = "userControlStatistika1";
            this.userControlStatistika1.Size = new System.Drawing.Size(576, 489);
            this.userControlStatistika1.TabIndex = 4;
            this.userControlStatistika1.TabStop = false;
            this.userControlStatistika1.Load += new System.EventHandler(this.userControlStatistika1_Load);
            // 
            // userControlOption1
            // 
            this.userControlOption1.BackColor = System.Drawing.Color.White;
            this.userControlOption1.ForeColor = System.Drawing.Color.Gray;
            this.userControlOption1.Location = new System.Drawing.Point(24, -6);
            this.userControlOption1.Name = "userControlOption1";
            this.userControlOption1.Size = new System.Drawing.Size(576, 489);
            this.userControlOption1.TabIndex = 5;
            this.userControlOption1.TabStop = false;
            // 
            // UserControlPesertaLomba1
            // 
            this.UserControlPesertaLomba1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.UserControlPesertaLomba1.Location = new System.Drawing.Point(14, 15);
            this.UserControlPesertaLomba1.Margin = new System.Windows.Forms.Padding(0);
            this.UserControlPesertaLomba1.Name = "UserControlPesertaLomba1";
            this.UserControlPesertaLomba1.Size = new System.Drawing.Size(819, 471);
            this.UserControlPesertaLomba1.TabIndex = 0;
            this.UserControlPesertaLomba1.Load += new System.EventHandler(this.userControlAddSchool1_Load);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelAtas;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this.panelLeft;
            // 
            // frmAdmin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 517);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin2_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnOption;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatistika;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesertaLomba;
        private System.Windows.Forms.Label lblAdminForm;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel_container;
        private UserControlPesertaLomba UserControlPesertaLomba1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private UserControlOption userControlOption1;
        private UserControlStatistika userControlStatistika1;
    }
}