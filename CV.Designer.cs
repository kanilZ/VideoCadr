namespace VideoAudio
{
    partial class CV
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
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.buttonBin = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uploadPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиФотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonEdgeFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInput.InitialImage = null;
            this.pictureBoxInput.Location = new System.Drawing.Point(23, 39);
            this.pictureBoxInput.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(410, 345);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOutput.Location = new System.Drawing.Point(522, 39);
            this.pictureBoxOutput.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(410, 345);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.TabStop = false;
            // 
            // buttonBin
            // 
            this.buttonBin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBin.Location = new System.Drawing.Point(23, 447);
            this.buttonBin.Name = "buttonBin";
            this.buttonBin.Size = new System.Drawing.Size(160, 41);
            this.buttonBin.TabIndex = 3;
            this.buttonBin.Text = "Бінарізація";
            this.buttonBin.UseVisualStyleBackColor = true;
            this.buttonBin.Click += new System.EventHandler(this.buttonBin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadPhotoToolStripMenuItem,
            this.зберегтиФотоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uploadPhotoToolStripMenuItem
            // 
            this.uploadPhotoToolStripMenuItem.Name = "uploadPhotoToolStripMenuItem";
            this.uploadPhotoToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.uploadPhotoToolStripMenuItem.Text = "Завантажити фото";
            this.uploadPhotoToolStripMenuItem.Click += new System.EventHandler(this.uploadPhotoToolStripMenuItem_Click);
            // 
            // зберегтиФотоToolStripMenuItem
            // 
            this.зберегтиФотоToolStripMenuItem.Name = "зберегтиФотоToolStripMenuItem";
            this.зберегтиФотоToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.зберегтиФотоToolStripMenuItem.Text = "Зберегти фото";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(273, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Медіана\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonMedian_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonResult.Location = new System.Drawing.Point(768, 447);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(160, 41);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "Визначити об\'єкти";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonEdgeFilter
            // 
            this.buttonEdgeFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEdgeFilter.Location = new System.Drawing.Point(522, 447);
            this.buttonEdgeFilter.Name = "buttonEdgeFilter";
            this.buttonEdgeFilter.Size = new System.Drawing.Size(160, 41);
            this.buttonEdgeFilter.TabIndex = 7;
            this.buttonEdgeFilter.Text = "Фільтрація країв";
            this.buttonEdgeFilter.UseVisualStyleBackColor = true;
            this.buttonEdgeFilter.Click += new System.EventHandler(this.buttonEdgeFilter_Click);
            // 
            // CV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 524);
            this.Controls.Add(this.buttonEdgeFilter);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBin);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CV";
            this.Text = "CV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Button buttonBin;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uploadPhotoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonEdgeFilter;
        private System.Windows.Forms.ToolStripMenuItem зберегтиФотоToolStripMenuItem;
    }
}