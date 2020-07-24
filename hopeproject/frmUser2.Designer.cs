namespace hopeproject
{
    partial class frmUser2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.datagridTopScore = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clmnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerTopScore = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.containerLblTopSchool = new System.Windows.Forms.Panel();
            this.lblTopSchool = new System.Windows.Forms.Label();
            this.containerController = new System.Windows.Forms.Panel();
            this.btnPoints = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSchool = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnId = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contentContainer = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTopScore)).BeginInit();
            this.containerTopScore.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.containerLblTopSchool.SuspendLayout();
            this.containerController.SuspendLayout();
            this.contentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.navPanel.Controls.Add(this.pictureBox2);
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1033, 37);
            this.navPanel.TabIndex = 0;
            this.navPanel.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 333);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // datagridTopScore
            // 
            this.datagridTopScore.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.datagridTopScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.datagridTopScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.datagridTopScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridTopScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.datagridTopScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTopScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.datagridTopScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTopScore.ColumnHeadersVisible = false;
            this.datagridTopScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnNo,
            this.clmnSchool,
            this.clmnPoints});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridTopScore.DefaultCellStyle = dataGridViewCellStyle15;
            this.datagridTopScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridTopScore.DoubleBuffered = true;
            this.datagridTopScore.EnableHeadersVisualStyles = false;
            this.datagridTopScore.GridColor = System.Drawing.Color.Gray;
            this.datagridTopScore.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.datagridTopScore.HeaderForeColor = System.Drawing.Color.White;
            this.datagridTopScore.Location = new System.Drawing.Point(0, 35);
            this.datagridTopScore.Margin = new System.Windows.Forms.Padding(0);
            this.datagridTopScore.MultiSelect = false;
            this.datagridTopScore.Name = "datagridTopScore";
            this.datagridTopScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridTopScore.RowHeadersVisible = false;
            this.datagridTopScore.RowHeadersWidth = 4;
            this.datagridTopScore.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.datagridTopScore.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.datagridTopScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTopScore.Size = new System.Drawing.Size(309, 298);
            this.datagridTopScore.TabIndex = 2;
            // 
            // clmnNo
            // 
            this.clmnNo.HeaderText = "No";
            this.clmnNo.Name = "clmnNo";
            this.clmnNo.Width = 50;
            // 
            // clmnSchool
            // 
            this.clmnSchool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnSchool.HeaderText = "School";
            this.clmnSchool.Name = "clmnSchool";
            // 
            // clmnPoints
            // 
            this.clmnPoints.HeaderText = "Points";
            this.clmnPoints.Name = "clmnPoints";
            this.clmnPoints.Width = 50;
            // 
            // containerTopScore
            // 
            this.containerTopScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerTopScore.Controls.Add(this.tableLayoutPanel1);
            this.containerTopScore.Location = new System.Drawing.Point(642, 0);
            this.containerTopScore.Margin = new System.Windows.Forms.Padding(0);
            this.containerTopScore.Name = "containerTopScore";
            this.containerTopScore.Size = new System.Drawing.Size(309, 333);
            this.containerTopScore.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.datagridTopScore, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.containerLblTopSchool, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 333);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // containerLblTopSchool
            // 
            this.containerLblTopSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.containerLblTopSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.containerLblTopSchool.Controls.Add(this.lblTopSchool);
            this.containerLblTopSchool.Location = new System.Drawing.Point(0, 0);
            this.containerLblTopSchool.Margin = new System.Windows.Forms.Padding(0);
            this.containerLblTopSchool.Name = "containerLblTopSchool";
            this.containerLblTopSchool.Size = new System.Drawing.Size(309, 35);
            this.containerLblTopSchool.TabIndex = 3;
            // 
            // lblTopSchool
            // 
            this.lblTopSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopSchool.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSchool.ForeColor = System.Drawing.Color.White;
            this.lblTopSchool.Location = new System.Drawing.Point(0, 0);
            this.lblTopSchool.Name = "lblTopSchool";
            this.lblTopSchool.Size = new System.Drawing.Size(309, 35);
            this.lblTopSchool.TabIndex = 0;
            this.lblTopSchool.Text = "Top School";
            this.lblTopSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerController
            // 
            this.containerController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerController.Controls.Add(this.btnPoints);
            this.containerController.Controls.Add(this.btnSchool);
            this.containerController.Controls.Add(this.btnId);
            this.containerController.Controls.Add(this.lblOrder);
            this.containerController.Controls.Add(this.lblSearch);
            this.containerController.Controls.Add(this.tbSearch);
            this.containerController.Location = new System.Drawing.Point(41, 102);
            this.containerController.Margin = new System.Windows.Forms.Padding(0);
            this.containerController.Name = "containerController";
            this.containerController.Size = new System.Drawing.Size(596, 41);
            this.containerController.TabIndex = 0;
            // 
            // btnPoints
            // 
            this.btnPoints.ActiveBorderThickness = 1;
            this.btnPoints.ActiveCornerRadius = 30;
            this.btnPoints.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnPoints.ActiveForecolor = System.Drawing.Color.White;
            this.btnPoints.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.btnPoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPoints.BackgroundImage")));
            this.btnPoints.ButtonText = "Points";
            this.btnPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoints.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoints.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPoints.IdleBorderThickness = 1;
            this.btnPoints.IdleCornerRadius = 30;
            this.btnPoints.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnPoints.IdleForecolor = System.Drawing.Color.White;
            this.btnPoints.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnPoints.Location = new System.Drawing.Point(255, 0);
            this.btnPoints.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(91, 41);
            this.btnPoints.TabIndex = 5;
            this.btnPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // btnSchool
            // 
            this.btnSchool.ActiveBorderThickness = 1;
            this.btnSchool.ActiveCornerRadius = 30;
            this.btnSchool.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnSchool.ActiveForecolor = System.Drawing.Color.White;
            this.btnSchool.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.btnSchool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchool.BackgroundImage")));
            this.btnSchool.ButtonText = "School";
            this.btnSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchool.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchool.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSchool.IdleBorderThickness = 1;
            this.btnSchool.IdleCornerRadius = 30;
            this.btnSchool.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnSchool.IdleForecolor = System.Drawing.Color.White;
            this.btnSchool.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnSchool.Location = new System.Drawing.Point(160, 0);
            this.btnSchool.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnSchool.Name = "btnSchool";
            this.btnSchool.Size = new System.Drawing.Size(93, 41);
            this.btnSchool.TabIndex = 4;
            this.btnSchool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSchool.Click += new System.EventHandler(this.btnSchool_Click);
            // 
            // btnId
            // 
            this.btnId.ActiveBorderThickness = 1;
            this.btnId.ActiveCornerRadius = 30;
            this.btnId.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnId.ActiveForecolor = System.Drawing.Color.White;
            this.btnId.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.btnId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnId.BackgroundImage")));
            this.btnId.ButtonText = "No";
            this.btnId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnId.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnId.IdleBorderThickness = 1;
            this.btnId.IdleCornerRadius = 30;
            this.btnId.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnId.IdleForecolor = System.Drawing.Color.White;
            this.btnId.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.btnId.Location = new System.Drawing.Point(93, 0);
            this.btnId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(65, 41);
            this.btnId.TabIndex = 3;
            this.btnId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(160)))));
            this.lblOrder.Location = new System.Drawing.Point(3, 8);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(91, 25);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Order By";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(488, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(101, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search By School";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderColorFocused = System.Drawing.Color.Gray;
            this.tbSearch.BorderColorIdle = System.Drawing.Color.Gray;
            this.tbSearch.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.tbSearch.BorderThickness = 1;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.Gray;
            this.tbSearch.isPassword = false;
            this.tbSearch.Location = new System.Drawing.Point(357, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(235, 28);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // contentContainer
            // 
            this.contentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentContainer.Controls.Add(this.flowLayoutPanel1);
            this.contentContainer.Controls.Add(this.containerTopScore);
            this.contentContainer.Location = new System.Drawing.Point(41, 143);
            this.contentContainer.Margin = new System.Windows.Forms.Padding(0);
            this.contentContainer.Name = "contentContainer";
            this.contentContainer.Size = new System.Drawing.Size(951, 333);
            this.contentContainer.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.navPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmUser2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(216)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1033, 517);
            this.Controls.Add(this.contentContainer);
            this.Controls.Add(this.containerController);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser2_FormClosing);
            this.Load += new System.EventHandler(this.frmUser2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUser2_KeyDown);
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTopScore)).EndInit();
            this.containerTopScore.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.containerLblTopSchool.ResumeLayout(false);
            this.containerController.ResumeLayout(false);
            this.containerController.PerformLayout();
            this.contentContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridTopScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPoints;
        private System.Windows.Forms.Panel containerTopScore;
        private System.Windows.Forms.Panel containerController;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblOrder;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPoints;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSchool;
        private Bunifu.Framework.UI.BunifuThinButton2 btnId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel containerLblTopSchool;
        private System.Windows.Forms.Panel contentContainer;
        private System.Windows.Forms.Label lblTopSchool;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}