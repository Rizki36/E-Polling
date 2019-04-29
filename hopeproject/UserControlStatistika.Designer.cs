namespace hopeproject
{
    partial class UserControlStatistika
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listSchool21 = new hopeproject.listSchool2();
            this.listSchool22 = new hopeproject.listSchool2();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listSchool21);
            this.flowLayoutPanel1.Controls.Add(this.listSchool22);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 433);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listSchool21
            // 
            this.listSchool21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listSchool21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.listSchool21.Id = null;
            this.listSchool21.Location = new System.Drawing.Point(3, 3);
            this.listSchool21.Name = "listSchool21";
            this.listSchool21.Path = null;
            this.listSchool21.Point = null;
            this.listSchool21.School = null;
            this.listSchool21.Size = new System.Drawing.Size(283, 209);
            this.listSchool21.TabIndex = 0;
            // 
            // listSchool22
            // 
            this.listSchool22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listSchool22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.listSchool22.Id = null;
            this.listSchool22.Location = new System.Drawing.Point(292, 3);
            this.listSchool22.Name = "listSchool22";
            this.listSchool22.Path = null;
            this.listSchool22.Point = null;
            this.listSchool22.School = null;
            this.listSchool22.Size = new System.Drawing.Size(283, 209);
            this.listSchool22.TabIndex = 1;
            // 
            // UserControlStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserControlStatistika";
            this.Size = new System.Drawing.Size(859, 512);
            this.Load += new System.EventHandler(this.UserControlStatistika_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private listSchool2 listSchool21;
        private listSchool2 listSchool22;
    }
}
