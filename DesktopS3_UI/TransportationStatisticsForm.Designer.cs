namespace DesktopS3_UI
{
    partial class TransportationStatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.ToDate_DateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FromDate_DateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lines_DataGridView = new System.Windows.Forms.DataGridView();
            this.StartCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTaskAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicles_DataGridView = new System.Windows.Forms.DataGridView();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Tasks_DataGridView = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleTeamAdministrator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredCompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualCompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllocatedVehicles = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lines_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehicles_DataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_DataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1297, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1291, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transportation Statistics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Search_Button);
            this.panel1.Controls.Add(this.ToDate_DateTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FromDate_DateTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 68);
            this.panel1.TabIndex = 1;
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search_Button.Location = new System.Drawing.Point(656, 15);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(93, 33);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // ToDate_DateTime
            // 
            this.ToDate_DateTime.CustomFormat = "yyyy/MM/dd";
            this.ToDate_DateTime.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToDate_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate_DateTime.Location = new System.Drawing.Point(402, 16);
            this.ToDate_DateTime.MinDate = new System.DateTime(2022, 9, 5, 0, 0, 0, 0);
            this.ToDate_DateTime.Name = "ToDate_DateTime";
            this.ToDate_DateTime.Size = new System.Drawing.Size(122, 30);
            this.ToDate_DateTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(359, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "to:";
            // 
            // FromDate_DateTime
            // 
            this.FromDate_DateTime.CustomFormat = "yyyy/MM/dd";
            this.FromDate_DateTime.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromDate_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate_DateTime.Location = new System.Drawing.Point(109, 18);
            this.FromDate_DateTime.MinDate = new System.DateTime(2022, 9, 5, 0, 0, 0, 0);
            this.FromDate_DateTime.Name = "FromDate_DateTime";
            this.FromDate_DateTime.Size = new System.Drawing.Size(122, 30);
            this.FromDate_DateTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.25051F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.502053F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.24744F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lines_DataGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Vehicles_DataGridView, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1273, 333);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 39);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "The Busiest Transportation Lines";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 39);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(661, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(609, 39);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "The Busiest Transportation Vehicles";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 39);
            this.panel5.TabIndex = 1;
            // 
            // Lines_DataGridView
            // 
            this.Lines_DataGridView.AllowUserToAddRows = false;
            this.Lines_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lines_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Lines_DataGridView.ColumnHeadersHeight = 45;
            this.Lines_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartCity,
            this.DestinationCity,
            this.TaskAmount,
            this.TotalTaskAmount});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Lines_DataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.Lines_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lines_DataGridView.Location = new System.Drawing.Point(3, 48);
            this.Lines_DataGridView.Name = "Lines_DataGridView";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lines_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Lines_DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lines_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.Lines_DataGridView.RowTemplate.Height = 45;
            this.Lines_DataGridView.Size = new System.Drawing.Size(608, 282);
            this.Lines_DataGridView.TabIndex = 2;
            // 
            // StartCity
            // 
            this.StartCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartCity.HeaderText = "StartCity";
            this.StartCity.Name = "StartCity";
            this.StartCity.ReadOnly = true;
            this.StartCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DestinationCity
            // 
            this.DestinationCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DestinationCity.HeaderText = "DestinationCity";
            this.DestinationCity.Name = "DestinationCity";
            this.DestinationCity.ReadOnly = true;
            this.DestinationCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TaskAmount
            // 
            this.TaskAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskAmount.HeaderText = "TaskAmount";
            this.TaskAmount.Name = "TaskAmount";
            this.TaskAmount.ReadOnly = true;
            this.TaskAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalTaskAmount
            // 
            this.TotalTaskAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalTaskAmount.HeaderText = "TotalTaskAmount";
            this.TotalTaskAmount.Name = "TotalTaskAmount";
            this.TotalTaskAmount.ReadOnly = true;
            this.TotalTaskAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vehicles_DataGridView
            // 
            this.Vehicles_DataGridView.AllowUserToAddRows = false;
            this.Vehicles_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Vehicles_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.Vehicles_DataGridView.ColumnHeadersHeight = 40;
            this.Vehicles_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlateNumber,
            this.Driver,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Vehicles_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vehicles_DataGridView.Location = new System.Drawing.Point(661, 48);
            this.Vehicles_DataGridView.Name = "Vehicles_DataGridView";
            this.Vehicles_DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vehicles_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.Vehicles_DataGridView.RowTemplate.Height = 45;
            this.Vehicles_DataGridView.Size = new System.Drawing.Size(609, 282);
            this.Vehicles_DataGridView.TabIndex = 3;
            // 
            // PlateNumber
            // 
            this.PlateNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlateNumber.HeaderText = "PlateNumber";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            this.PlateNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Driver
            // 
            this.Driver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Driver.HeaderText = "Driver";
            this.Driver.Name = "Driver";
            this.Driver.ReadOnly = true;
            this.Driver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "TaskAmount";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "TotalTaskAmount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Tasks_DataGridView, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 548);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1273, 290);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1267, 36);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Transportation Tasks";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 36);
            this.panel7.TabIndex = 0;
            // 
            // Tasks_DataGridView
            // 
            this.Tasks_DataGridView.AllowUserToAddRows = false;
            this.Tasks_DataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tasks_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.Tasks_DataGridView.ColumnHeadersHeight = 40;
            this.Tasks_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Start,
            this.Destination,
            this.VehicleTeamAdministrator,
            this.RequiredCompletionDate,
            this.ActualCompletionDate,
            this.AllocatedVehicles});
            this.Tasks_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tasks_DataGridView.Location = new System.Drawing.Point(3, 45);
            this.Tasks_DataGridView.Name = "Tasks_DataGridView";
            this.Tasks_DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tasks_DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.Tasks_DataGridView.RowTemplate.Height = 45;
            this.Tasks_DataGridView.Size = new System.Drawing.Size(1267, 242);
            this.Tasks_DataGridView.TabIndex = 1;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.HeaderText = "TaskName";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // VehicleTeamAdministrator
            // 
            this.VehicleTeamAdministrator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VehicleTeamAdministrator.HeaderText = "VehicleTeamAdministrator";
            this.VehicleTeamAdministrator.Name = "VehicleTeamAdministrator";
            this.VehicleTeamAdministrator.ReadOnly = true;
            // 
            // RequiredCompletionDate
            // 
            this.RequiredCompletionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RequiredCompletionDate.HeaderText = "RequiredCompletionDate";
            this.RequiredCompletionDate.Name = "RequiredCompletionDate";
            this.RequiredCompletionDate.ReadOnly = true;
            // 
            // ActualCompletionDate
            // 
            this.ActualCompletionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActualCompletionDate.HeaderText = "ActualCompletionDate";
            this.ActualCompletionDate.Name = "ActualCompletionDate";
            this.ActualCompletionDate.ReadOnly = true;
            // 
            // AllocatedVehicles
            // 
            this.AllocatedVehicles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AllocatedVehicles.HeaderText = "AllocatedVehicles";
            this.AllocatedVehicles.Name = "AllocatedVehicles";
            this.AllocatedVehicles.ReadOnly = true;
            // 
            // TransportationStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1297, 850);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TransportationStatisticsForm";
            this.Text = "TransportationStatisticsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lines_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehicles_DataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Button Search_Button;
        private DateTimePicker ToDate_DateTime;
        private Label label3;
        private DateTimePicker FromDate_DateTime;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private DataGridView Lines_DataGridView;
        private DataGridViewTextBoxColumn StartCity;
        private DataGridViewTextBoxColumn DestinationCity;
        private DataGridViewTextBoxColumn TaskAmount;
        private DataGridViewTextBoxColumn TotalTaskAmount;
        private DataGridView Vehicles_DataGridView;
        private DataGridViewTextBoxColumn PlateNumber;
        private DataGridViewTextBoxColumn Driver;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private DataGridView Tasks_DataGridView;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn Destination;
        private DataGridViewTextBoxColumn VehicleTeamAdministrator;
        private DataGridViewTextBoxColumn RequiredCompletionDate;
        private DataGridViewTextBoxColumn ActualCompletionDate;
        private DataGridViewLinkColumn AllocatedVehicles;
    }
}