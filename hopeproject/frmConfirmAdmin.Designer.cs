namespace hopeproject
{
    partial class frmConfirmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmAdmin));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btn0 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(345, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(166, 65);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "label1";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(103, 236);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(166, 65);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "label2";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(547, 236);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(166, 65);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "label3";
            // 
            // btn0
            // 
            this.btn0.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.BorderRadius = 5;
            this.btn0.ButtonText = "Finish";
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.DisabledColor = System.Drawing.Color.Gray;
            this.btn0.Iconcolor = System.Drawing.Color.Transparent;
            this.btn0.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn0.Iconimage")));
            this.btn0.Iconimage_right = null;
            this.btn0.Iconimage_right_Selected = null;
            this.btn0.Iconimage_Selected = null;
            this.btn0.IconMarginLeft = 0;
            this.btn0.IconMarginRight = 0;
            this.btn0.IconRightVisible = true;
            this.btn0.IconRightZoom = 0D;
            this.btn0.IconVisible = false;
            this.btn0.IconZoom = 90D;
            this.btn0.IsTab = false;
            this.btn0.Location = new System.Drawing.Point(360, 400);
            this.btn0.Margin = new System.Windows.Forms.Padding(6);
            this.btn0.Name = "btn0";
            this.btn0.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btn0.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btn0.OnHoverTextColor = System.Drawing.Color.White;
            this.btn0.selected = false;
            this.btn0.Size = new System.Drawing.Size(122, 45);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "Finish";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn0.Textcolor = System.Drawing.Color.White;
            this.btn0.TextFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // frmConfirmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 559);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmAdmin";
            this.Load += new System.EventHandler(this.frmConfirmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblPoint;
        private Bunifu.Framework.UI.BunifuFlatButton btn0;
    }
}