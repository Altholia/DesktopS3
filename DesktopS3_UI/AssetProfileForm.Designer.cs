namespace DesktopS3_UI
{
    partial class AssetProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetProfileForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Asset_PictureBox = new System.Windows.Forms.PictureBox();
            this.RightClick_PictureBox = new System.Windows.Forms.PictureBox();
            this.LeftClick_PictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceDate_Label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.AssetNumber_Label = new System.Windows.Forms.Label();
            this.AssetName_Label = new System.Windows.Forms.Label();
            this.AssetCategory_Label = new System.Windows.Forms.Label();
            this.Department_Label = new System.Windows.Forms.Label();
            this.ManufactureDate_Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RegistrationTime_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Transfer_DataGridView = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Upkeep_DataGridView = new System.Windows.Forms.DataGridView();
            this.UpkeepRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpkeepDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information_Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Asset_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightClick_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftClick_PictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upkeep_DataGridView)).BeginInit();
            this.Information_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.Asset_PictureBox);
            this.panel1.Location = new System.Drawing.Point(91, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 235);
            this.panel1.TabIndex = 2;
            // 
            // Asset_PictureBox
            // 
            this.Asset_PictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Asset_PictureBox.ErrorImage")));
            this.Asset_PictureBox.Location = new System.Drawing.Point(10, 10);
            this.Asset_PictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.Asset_PictureBox.Name = "Asset_PictureBox";
            this.Asset_PictureBox.Size = new System.Drawing.Size(141, 215);
            this.Asset_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Asset_PictureBox.TabIndex = 0;
            this.Asset_PictureBox.TabStop = false;
            // 
            // RightClick_PictureBox
            // 
            this.RightClick_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RightClick_PictureBox.Image")));
            this.RightClick_PictureBox.Location = new System.Drawing.Point(258, 152);
            this.RightClick_PictureBox.Name = "RightClick_PictureBox";
            this.RightClick_PictureBox.Size = new System.Drawing.Size(65, 69);
            this.RightClick_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightClick_PictureBox.TabIndex = 3;
            this.RightClick_PictureBox.TabStop = false;
            this.RightClick_PictureBox.Click += new System.EventHandler(this.RightClick_PictureBox_Click);
            // 
            // LeftClick_PictureBox
            // 
            this.LeftClick_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LeftClick_PictureBox.Image")));
            this.LeftClick_PictureBox.Location = new System.Drawing.Point(20, 152);
            this.LeftClick_PictureBox.Name = "LeftClick_PictureBox";
            this.LeftClick_PictureBox.Size = new System.Drawing.Size(65, 69);
            this.LeftClick_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftClick_PictureBox.TabIndex = 3;
            this.LeftClick_PictureBox.TabStop = false;
            this.LeftClick_PictureBox.Click += new System.EventHandler(this.LeftClick_PictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asset Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asset Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Asset Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Manufacture Date:";
            // 
            // ServiceDate_Label
            // 
            this.ServiceDate_Label.AutoSize = true;
            this.ServiceDate_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServiceDate_Label.Location = new System.Drawing.Point(3, 183);
            this.ServiceDate_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ServiceDate_Label.Name = "ServiceDate_Label";
            this.ServiceDate_Label.Size = new System.Drawing.Size(131, 25);
            this.ServiceDate_Label.TabIndex = 12;
            this.ServiceDate_Label.Text = "Service Date:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(3, 218);
            this.label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(178, 25);
            this.label.TabIndex = 13;
            this.label.Text = "Registration Time:";
            // 
            // AssetNumber_Label
            // 
            this.AssetNumber_Label.AutoSize = true;
            this.AssetNumber_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AssetNumber_Label.Location = new System.Drawing.Point(156, 8);
            this.AssetNumber_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.AssetNumber_Label.Name = "AssetNumber_Label";
            this.AssetNumber_Label.Size = new System.Drawing.Size(46, 25);
            this.AssetNumber_Label.TabIndex = 0;
            this.AssetNumber_Label.Text = "null";
            // 
            // AssetName_Label
            // 
            this.AssetName_Label.AutoSize = true;
            this.AssetName_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AssetName_Label.Location = new System.Drawing.Point(135, 43);
            this.AssetName_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.AssetName_Label.Name = "AssetName_Label";
            this.AssetName_Label.Size = new System.Drawing.Size(46, 25);
            this.AssetName_Label.TabIndex = 1;
            this.AssetName_Label.Text = "null";
            // 
            // AssetCategory_Label
            // 
            this.AssetCategory_Label.AutoSize = true;
            this.AssetCategory_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AssetCategory_Label.Location = new System.Drawing.Point(164, 78);
            this.AssetCategory_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.AssetCategory_Label.Name = "AssetCategory_Label";
            this.AssetCategory_Label.Size = new System.Drawing.Size(46, 25);
            this.AssetCategory_Label.TabIndex = 2;
            this.AssetCategory_Label.Text = "null";
            // 
            // Department_Label
            // 
            this.Department_Label.AutoSize = true;
            this.Department_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Department_Label.Location = new System.Drawing.Point(136, 113);
            this.Department_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.Department_Label.Name = "Department_Label";
            this.Department_Label.Size = new System.Drawing.Size(46, 25);
            this.Department_Label.TabIndex = 3;
            this.Department_Label.Text = "null";
            // 
            // ManufactureDate_Label
            // 
            this.ManufactureDate_Label.AutoSize = true;
            this.ManufactureDate_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManufactureDate_Label.Location = new System.Drawing.Point(194, 148);
            this.ManufactureDate_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ManufactureDate_Label.Name = "ManufactureDate_Label";
            this.ManufactureDate_Label.Size = new System.Drawing.Size(46, 25);
            this.ManufactureDate_Label.TabIndex = 4;
            this.ManufactureDate_Label.Text = "null";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(140, 183);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "null";
            // 
            // RegistrationTime_Label
            // 
            this.RegistrationTime_Label.AutoSize = true;
            this.RegistrationTime_Label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationTime_Label.Location = new System.Drawing.Point(187, 218);
            this.RegistrationTime_Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RegistrationTime_Label.Name = "RegistrationTime_Label";
            this.RegistrationTime_Label.Size = new System.Drawing.Size(46, 25);
            this.RegistrationTime_Label.TabIndex = 6;
            this.RegistrationTime_Label.Text = "null";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Transfer_DataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Upkeep_DataGridView, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 330);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 499);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 39);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Transfer History";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 39);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(393, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 39);
            this.panel4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Upkeep History";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 39);
            this.panel5.TabIndex = 0;
            // 
            // Transfer_DataGridView
            // 
            this.Transfer_DataGridView.AllowUserToAddRows = false;
            this.Transfer_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transfer_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Transfer_DataGridView.ColumnHeadersHeight = 40;
            this.Transfer_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Start,
            this.Destination,
            this.TransferTime});
            this.Transfer_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Transfer_DataGridView.Location = new System.Drawing.Point(3, 48);
            this.Transfer_DataGridView.Name = "Transfer_DataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transfer_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Transfer_DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Transfer_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Transfer_DataGridView.RowTemplate.Height = 45;
            this.Transfer_DataGridView.Size = new System.Drawing.Size(384, 448);
            this.Transfer_DataGridView.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            this.Destination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TransferTime
            // 
            this.TransferTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransferTime.HeaderText = "TransferTime";
            this.TransferTime.Name = "TransferTime";
            this.TransferTime.ReadOnly = true;
            // 
            // Upkeep_DataGridView
            // 
            this.Upkeep_DataGridView.AllowUserToAddRows = false;
            this.Upkeep_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Upkeep_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Upkeep_DataGridView.ColumnHeadersHeight = 40;
            this.Upkeep_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpkeepRemark,
            this.UpkeepDate});
            this.Upkeep_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upkeep_DataGridView.Location = new System.Drawing.Point(393, 48);
            this.Upkeep_DataGridView.Name = "Upkeep_DataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Upkeep_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Upkeep_DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Upkeep_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Upkeep_DataGridView.RowTemplate.Height = 45;
            this.Upkeep_DataGridView.Size = new System.Drawing.Size(384, 448);
            this.Upkeep_DataGridView.TabIndex = 3;
            // 
            // UpkeepRemark
            // 
            this.UpkeepRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpkeepRemark.HeaderText = "UpkeepRemark";
            this.UpkeepRemark.Name = "UpkeepRemark";
            this.UpkeepRemark.ReadOnly = true;
            this.UpkeepRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UpkeepDate
            // 
            this.UpkeepDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpkeepDate.HeaderText = "UpkeepDate";
            this.UpkeepDate.Name = "UpkeepDate";
            this.UpkeepDate.ReadOnly = true;
            // 
            // Information_Panel
            // 
            this.Information_Panel.Controls.Add(this.label2);
            this.Information_Panel.Controls.Add(this.label);
            this.Information_Panel.Controls.Add(this.AssetNumber_Label);
            this.Information_Panel.Controls.Add(this.ServiceDate_Label);
            this.Information_Panel.Controls.Add(this.AssetName_Label);
            this.Information_Panel.Controls.Add(this.label6);
            this.Information_Panel.Controls.Add(this.AssetCategory_Label);
            this.Information_Panel.Controls.Add(this.label5);
            this.Information_Panel.Controls.Add(this.Department_Label);
            this.Information_Panel.Controls.Add(this.label4);
            this.Information_Panel.Controls.Add(this.ManufactureDate_Label);
            this.Information_Panel.Controls.Add(this.label3);
            this.Information_Panel.Controls.Add(this.label14);
            this.Information_Panel.Controls.Add(this.RegistrationTime_Label);
            this.Information_Panel.Location = new System.Drawing.Point(341, 74);
            this.Information_Panel.Name = "Information_Panel";
            this.Information_Panel.Size = new System.Drawing.Size(468, 250);
            this.Information_Panel.TabIndex = 6;
            // 
            // AssetProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(812, 841);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.LeftClick_PictureBox);
            this.Controls.Add(this.RightClick_PictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Information_Panel);
            this.Name = "AssetProfileForm";
            this.Text = "AssetProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssetProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.AssetProfileForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Asset_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightClick_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftClick_PictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upkeep_DataGridView)).EndInit();
            this.Information_Panel.ResumeLayout(false);
            this.Information_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox Asset_PictureBox;
        private PictureBox RightClick_PictureBox;
        private PictureBox LeftClick_PictureBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label ServiceDate_Label;
        private Label label;
        private Label AssetNumber_Label;
        private Label AssetName_Label;
        private Label AssetCategory_Label;
        private Label Department_Label;
        private Label ManufactureDate_Label;
        private Label label14;
        private Label RegistrationTime_Label;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private Panel panel4;
        private Label label8;
        private Panel panel5;
        private DataGridView Transfer_DataGridView;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn Destination;
        private DataGridViewTextBoxColumn TransferTime;
        private DataGridView Upkeep_DataGridView;
        private DataGridViewTextBoxColumn UpkeepRemark;
        private DataGridViewTextBoxColumn UpkeepDate;
        private Panel Information_Panel;
    }
}