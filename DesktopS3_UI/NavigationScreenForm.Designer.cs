namespace DesktopS3_UI
{
    partial class NavigationScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationScreenForm));
            this.Asset_Button = new System.Windows.Forms.Button();
            this.Transportation_Button = new System.Windows.Forms.Button();
            this.Part_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Asset_Button
            // 
            this.Asset_Button.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Asset_Button.Location = new System.Drawing.Point(273, 41);
            this.Asset_Button.Name = "Asset_Button";
            this.Asset_Button.Size = new System.Drawing.Size(226, 50);
            this.Asset_Button.TabIndex = 0;
            this.Asset_Button.Text = "Asset Statistics";
            this.Asset_Button.UseVisualStyleBackColor = true;
            this.Asset_Button.Click += new System.EventHandler(this.Navigation_Click);
            // 
            // Transportation_Button
            // 
            this.Transportation_Button.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Transportation_Button.Location = new System.Drawing.Point(273, 97);
            this.Transportation_Button.Name = "Transportation_Button";
            this.Transportation_Button.Size = new System.Drawing.Size(226, 50);
            this.Transportation_Button.TabIndex = 0;
            this.Transportation_Button.Text = "Transportation Statistics";
            this.Transportation_Button.UseVisualStyleBackColor = true;
            this.Transportation_Button.Click += new System.EventHandler(this.Navigation_Click);
            // 
            // Part_Button
            // 
            this.Part_Button.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Part_Button.Location = new System.Drawing.Point(273, 153);
            this.Part_Button.Name = "Part_Button";
            this.Part_Button.Size = new System.Drawing.Size(226, 50);
            this.Part_Button.TabIndex = 0;
            this.Part_Button.Text = "Part Statistics";
            this.Part_Button.UseVisualStyleBackColor = true;
            this.Part_Button.Click += new System.EventHandler(this.Navigation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NavigationScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(545, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Part_Button);
            this.Controls.Add(this.Transportation_Button);
            this.Controls.Add(this.Asset_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NavigationScreenForm";
            this.Text = "NavigationScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Asset_Button;
        private Button Transportation_Button;
        private Button Part_Button;
        private PictureBox pictureBox1;
    }
}