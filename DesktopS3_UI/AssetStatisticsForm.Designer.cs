namespace DesktopS3_UI
{
    partial class AssetStatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpkeepType_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Upkeep_DataGridView = new System.Windows.Forms.DataGridView();
            this.AssetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastupkeepDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpkeepCircle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFromTheNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Category_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_Combox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Asset_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufactureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Upkeep_DataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Asset_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.270156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.46054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.269303F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 43);
            this.panel1.TabIndex = 1;
            this.panel1.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asset Upkeeped Statistics";
            this.label2.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 43);
            this.panel2.TabIndex = 0;
            this.panel2.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.UpkeepType_ComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1258, 60);
            this.panel3.TabIndex = 2;
            this.panel3.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // UpkeepType_ComboBox
            // 
            this.UpkeepType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpkeepType_ComboBox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpkeepType_ComboBox.FormattingEnabled = true;
            this.UpkeepType_ComboBox.Location = new System.Drawing.Point(154, 15);
            this.UpkeepType_ComboBox.Name = "UpkeepType_ComboBox";
            this.UpkeepType_ComboBox.Size = new System.Drawing.Size(184, 35);
            this.UpkeepType_ComboBox.Sorted = true;
            this.UpkeepType_ComboBox.TabIndex = 1;
            this.UpkeepType_ComboBox.TextChanged += new System.EventHandler(this.UpkeepType_ComboBox_TextChanged);
            this.UpkeepType_ComboBox.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.UpkeepType_ComboBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Upkeep Type:";
            this.label3.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // Upkeep_DataGridView
            // 
            this.Upkeep_DataGridView.AllowUserToAddRows = false;
            this.Upkeep_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Upkeep_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Upkeep_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Upkeep_DataGridView.ColumnHeadersHeight = 40;
            this.Upkeep_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetNumber,
            this.AssetName,
            this.Department,
            this.LastupkeepDate,
            this.UpkeepCircle,
            this.TimeFromTheNext});
            this.Upkeep_DataGridView.Location = new System.Drawing.Point(12, 165);
            this.Upkeep_DataGridView.Name = "Upkeep_DataGridView";
            this.Upkeep_DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Upkeep_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Upkeep_DataGridView.RowTemplate.Height = 45;
            this.Upkeep_DataGridView.Size = new System.Drawing.Size(1258, 273);
            this.Upkeep_DataGridView.TabIndex = 1;
            this.Upkeep_DataGridView.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.Upkeep_DataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // AssetNumber
            // 
            this.AssetNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetNumber.HeaderText = "AssetNumber";
            this.AssetNumber.Name = "AssetNumber";
            this.AssetNumber.ReadOnly = true;
            this.AssetNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssetName
            // 
            this.AssetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetName.HeaderText = "AssetName";
            this.AssetName.Name = "AssetName";
            this.AssetName.ReadOnly = true;
            this.AssetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastupkeepDate
            // 
            this.LastupkeepDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastupkeepDate.HeaderText = "LastupkeepDate";
            this.LastupkeepDate.Name = "LastupkeepDate";
            this.LastupkeepDate.ReadOnly = true;
            this.LastupkeepDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UpkeepCircle
            // 
            this.UpkeepCircle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpkeepCircle.HeaderText = "UpkeepCircle";
            this.UpkeepCircle.Name = "UpkeepCircle";
            this.UpkeepCircle.ReadOnly = true;
            this.UpkeepCircle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimeFromTheNext
            // 
            this.TimeFromTheNext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeFromTheNext.HeaderText = "TimeFromTheNext";
            this.TimeFromTheNext.Name = "TimeFromTheNext";
            this.TimeFromTheNext.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 459);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1258, 43);
            this.panel4.TabIndex = 1;
            this.panel4.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "All Assets";
            this.label4.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 43);
            this.panel5.TabIndex = 0;
            this.panel5.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Search_Button);
            this.panel6.Controls.Add(this.Category_ComboBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.Name_Combox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 508);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1258, 60);
            this.panel6.TabIndex = 2;
            this.panel6.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search_Button.Location = new System.Drawing.Point(976, 14);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(110, 32);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            this.Search_Button.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.Search_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // Category_ComboBox
            // 
            this.Category_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_ComboBox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category_ComboBox.FormattingEnabled = true;
            this.Category_ComboBox.Location = new System.Drawing.Point(611, 15);
            this.Category_ComboBox.Name = "Category_ComboBox";
            this.Category_ComboBox.Size = new System.Drawing.Size(248, 35);
            this.Category_ComboBox.Sorted = true;
            this.Category_ComboBox.TabIndex = 1;
            this.Category_ComboBox.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.Category_ComboBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(453, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Asset Category:";
            this.label6.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // Name_Combox
            // 
            this.Name_Combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Name_Combox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Combox.FormattingEnabled = true;
            this.Name_Combox.Location = new System.Drawing.Point(144, 15);
            this.Name_Combox.Name = "Name_Combox";
            this.Name_Combox.Size = new System.Drawing.Size(248, 35);
            this.Name_Combox.Sorted = true;
            this.Name_Combox.TabIndex = 1;
            this.Name_Combox.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.Name_Combox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Asset Name:";
            this.label5.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // Asset_DataGridView
            // 
            this.Asset_DataGridView.AllowUserToAddRows = false;
            this.Asset_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Asset_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Asset_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Asset_DataGridView.ColumnHeadersHeight = 45;
            this.Asset_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.AssetCategory,
            this.dataGridViewTextBoxColumn3,
            this.ManufactureDate,
            this.ServiceDate,
            this.RegistrationTime,
            this.AssetProfile});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Asset_DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.Asset_DataGridView.Location = new System.Drawing.Point(12, 574);
            this.Asset_DataGridView.Name = "Asset_DataGridView";
            this.Asset_DataGridView.RowHeadersVisible = false;
            this.Asset_DataGridView.RowTemplate.Height = 45;
            this.Asset_DataGridView.Size = new System.Drawing.Size(1258, 273);
            this.Asset_DataGridView.TabIndex = 3;
            this.Asset_DataGridView.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.Asset_DataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "AssetNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "AssetName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssetCategory
            // 
            this.AssetCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetCategory.HeaderText = "AssetCategory";
            this.AssetCategory.Name = "AssetCategory";
            this.AssetCategory.ReadOnly = true;
            this.AssetCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ManufactureDate
            // 
            this.ManufactureDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufactureDate.HeaderText = "ManufactureDate";
            this.ManufactureDate.Name = "ManufactureDate";
            this.ManufactureDate.ReadOnly = true;
            this.ManufactureDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServiceDate
            // 
            this.ServiceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceDate.HeaderText = "ServiceDate";
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.ReadOnly = true;
            this.ServiceDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RegistrationTime
            // 
            this.RegistrationTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegistrationTime.HeaderText = "RegistrationTime";
            this.RegistrationTime.Name = "RegistrationTime";
            this.RegistrationTime.ReadOnly = true;
            this.RegistrationTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssetProfile
            // 
            this.AssetProfile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetProfile.HeaderText = "AssetProfile";
            this.AssetProfile.Name = "AssetProfile";
            this.AssetProfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssetStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1282, 863);
            this.Controls.Add(this.Asset_DataGridView);
            this.Controls.Add(this.Upkeep_DataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Name = "AssetStatisticsForm";
            this.Text = "AssetStatisticsForm";
            this.Deactivate += new System.EventHandler(this.AssetStatisticsForm_Deactivate);
            this.Load += new System.EventHandler(this.AssetStatisticsForm_Load);
            this.MouseHover += new System.EventHandler(this.AssetStatisticsForm_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AssetStatisticsForm_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Upkeep_DataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Asset_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private ComboBox UpkeepType_ComboBox;
        private Label label3;
        private DataGridView Upkeep_DataGridView;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private ComboBox Name_Combox;
        private Label label5;
        private ComboBox Category_ComboBox;
        private Label label6;
        private Button Search_Button;
        private DataGridView Asset_DataGridView;
        private DataGridViewTextBoxColumn AssetNumber;
        private DataGridViewTextBoxColumn AssetName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn LastupkeepDate;
        private DataGridViewTextBoxColumn UpkeepCircle;
        private DataGridViewTextBoxColumn TimeFromTheNext;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn AssetCategory;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ManufactureDate;
        private DataGridViewTextBoxColumn ServiceDate;
        private DataGridViewTextBoxColumn RegistrationTime;
        private DataGridViewTextBoxColumn AssetProfile;
    }
}