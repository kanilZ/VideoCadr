namespace VideoAudio
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonSaveTxt = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboCameras = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInterval = new System.Windows.Forms.Label();
            this.buttonStartInterval = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStopInterval = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.uploadPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageAudio = new System.Windows.Forms.TabPage();
            this.buttonMakeTxt = new System.Windows.Forms.Button();
            this.textWav = new System.Windows.Forms.TextBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonResumePlay = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRepRec = new System.Windows.Forms.Button();
            this.buttonStopRec = new System.Windows.Forms.Button();
            this.buttonStartRec = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadwavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileWavDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileTxtDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageVideo.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPageAudio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStart.Location = new System.Drawing.Point(8, 376);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 34);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStop.Location = new System.Drawing.Point(374, 376);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(116, 34);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 463);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // buttonSaveTxt
            // 
            this.buttonSaveTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSaveTxt.Location = new System.Drawing.Point(130, 376);
            this.buttonSaveTxt.Name = "buttonSaveTxt";
            this.buttonSaveTxt.Size = new System.Drawing.Size(116, 34);
            this.buttonSaveTxt.TabIndex = 4;
            this.buttonSaveTxt.Text = "Save txt";
            this.buttonSaveTxt.UseVisualStyleBackColor = true;
            this.buttonSaveTxt.Click += new System.EventHandler(this.buttonScr_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(5, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(609, 326);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // comboCameras
            // 
            this.comboCameras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCameras.FormattingEnabled = true;
            this.comboCameras.Location = new System.Drawing.Point(701, 50);
            this.comboCameras.Name = "comboCameras";
            this.comboCameras.Size = new System.Drawing.Size(121, 24);
            this.comboCameras.TabIndex = 6;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown.Location = new System.Drawing.Point(701, 123);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Камери";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(252, 376);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 34);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Screen";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelInterval
            // 
            this.labelInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(699, 90);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(110, 17);
            this.labelInterval.TabIndex = 10;
            this.labelInterval.Text = "Інтервал кадрів";
            // 
            // buttonStartInterval
            // 
            this.buttonStartInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartInterval.Location = new System.Drawing.Point(701, 169);
            this.buttonStartInterval.Name = "buttonStartInterval";
            this.buttonStartInterval.Size = new System.Drawing.Size(55, 34);
            this.buttonStartInterval.TabIndex = 11;
            this.buttonStartInterval.Text = "Start";
            this.buttonStartInterval.UseVisualStyleBackColor = true;
            this.buttonStartInterval.Click += new System.EventHandler(this.buttonStartInterval_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageVideo);
            this.tabControl.Controls.Add(this.tabPageAudio);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(891, 463);
            this.tabControl.TabIndex = 12;
            // 
            // tabPageVideo
            // 
            this.tabPageVideo.Controls.Add(this.buttonClear);
            this.tabPageVideo.Controls.Add(this.buttonStopInterval);
            this.tabPageVideo.Controls.Add(this.buttonSaveTxt);
            this.tabPageVideo.Controls.Add(this.buttonStart);
            this.tabPageVideo.Controls.Add(this.buttonSave);
            this.tabPageVideo.Controls.Add(this.buttonStartInterval);
            this.tabPageVideo.Controls.Add(this.numericUpDown);
            this.tabPageVideo.Controls.Add(this.comboCameras);
            this.tabPageVideo.Controls.Add(this.buttonStop);
            this.tabPageVideo.Controls.Add(this.labelInterval);
            this.tabPageVideo.Controls.Add(this.label1);
            this.tabPageVideo.Controls.Add(this.pictureBox);
            this.tabPageVideo.Controls.Add(this.menuStrip2);
            this.tabPageVideo.Location = new System.Drawing.Point(4, 25);
            this.tabPageVideo.Name = "tabPageVideo";
            this.tabPageVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVideo.Size = new System.Drawing.Size(883, 434);
            this.tabPageVideo.TabIndex = 0;
            this.tabPageVideo.Text = "Відео потік";
            this.tabPageVideo.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClear.Location = new System.Drawing.Point(496, 376);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 34);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStopInterval
            // 
            this.buttonStopInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopInterval.Location = new System.Drawing.Point(767, 169);
            this.buttonStopInterval.Name = "buttonStopInterval";
            this.buttonStopInterval.Size = new System.Drawing.Size(55, 34);
            this.buttonStopInterval.TabIndex = 12;
            this.buttonStopInterval.Text = "Stop";
            this.buttonStopInterval.UseVisualStyleBackColor = true;
            this.buttonStopInterval.Click += new System.EventHandler(this.buttonStopInterval_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadPhotoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(877, 28);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // uploadPhotoToolStripMenuItem
            // 
            this.uploadPhotoToolStripMenuItem.Name = "uploadPhotoToolStripMenuItem";
            this.uploadPhotoToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.uploadPhotoToolStripMenuItem.Text = "Завантажити фото з txt";
            this.uploadPhotoToolStripMenuItem.Click += new System.EventHandler(this.uploadPhotoToolStripMenuItem_Click);
            // 
            // tabPageAudio
            // 
            this.tabPageAudio.Controls.Add(this.buttonMakeTxt);
            this.tabPageAudio.Controls.Add(this.textWav);
            this.tabPageAudio.Controls.Add(this.buttonPause);
            this.tabPageAudio.Controls.Add(this.buttonResumePlay);
            this.tabPageAudio.Controls.Add(this.buttonPlay);
            this.tabPageAudio.Controls.Add(this.buttonRepRec);
            this.tabPageAudio.Controls.Add(this.buttonStopRec);
            this.tabPageAudio.Controls.Add(this.buttonStartRec);
            this.tabPageAudio.Controls.Add(this.menuStrip1);
            this.tabPageAudio.Location = new System.Drawing.Point(4, 25);
            this.tabPageAudio.Name = "tabPageAudio";
            this.tabPageAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAudio.Size = new System.Drawing.Size(883, 434);
            this.tabPageAudio.TabIndex = 1;
            this.tabPageAudio.Text = "Аудіо потік";
            this.tabPageAudio.UseVisualStyleBackColor = true;
            // 
            // buttonMakeTxt
            // 
            this.buttonMakeTxt.Location = new System.Drawing.Point(25, 263);
            this.buttonMakeTxt.Name = "buttonMakeTxt";
            this.buttonMakeTxt.Size = new System.Drawing.Size(94, 49);
            this.buttonMakeTxt.TabIndex = 9;
            this.buttonMakeTxt.Text = "Make txt";
            this.buttonMakeTxt.UseVisualStyleBackColor = true;
            this.buttonMakeTxt.Click += new System.EventHandler(this.buttonMakeTxt_Click);
            // 
            // textWav
            // 
            this.textWav.Location = new System.Drawing.Point(25, 367);
            this.textWav.Multiline = true;
            this.textWav.Name = "textWav";
            this.textWav.Size = new System.Drawing.Size(169, 29);
            this.textWav.TabIndex = 8;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(651, 367);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 29);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonResumePlay
            // 
            this.buttonResumePlay.Location = new System.Drawing.Point(529, 367);
            this.buttonResumePlay.Name = "buttonResumePlay";
            this.buttonResumePlay.Size = new System.Drawing.Size(75, 29);
            this.buttonResumePlay.TabIndex = 6;
            this.buttonResumePlay.Text = "Resume";
            this.buttonResumePlay.UseVisualStyleBackColor = true;
            this.buttonResumePlay.Click += new System.EventHandler(this.buttonResumePlay_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(408, 367);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 29);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRepRec
            // 
            this.buttonRepRec.Location = new System.Drawing.Point(25, 192);
            this.buttonRepRec.Name = "buttonRepRec";
            this.buttonRepRec.Size = new System.Drawing.Size(94, 49);
            this.buttonRepRec.TabIndex = 4;
            this.buttonRepRec.Text = "Repeat Recording";
            this.buttonRepRec.UseVisualStyleBackColor = true;
            // 
            // buttonStopRec
            // 
            this.buttonStopRec.Location = new System.Drawing.Point(25, 120);
            this.buttonStopRec.Name = "buttonStopRec";
            this.buttonStopRec.Size = new System.Drawing.Size(94, 49);
            this.buttonStopRec.TabIndex = 3;
            this.buttonStopRec.Text = "Stop Recording";
            this.buttonStopRec.UseVisualStyleBackColor = true;
            this.buttonStopRec.Click += new System.EventHandler(this.buttonStopRec_Click);
            // 
            // buttonStartRec
            // 
            this.buttonStartRec.Location = new System.Drawing.Point(25, 48);
            this.buttonStartRec.Name = "buttonStartRec";
            this.buttonStartRec.Size = new System.Drawing.Size(94, 49);
            this.buttonStartRec.TabIndex = 2;
            this.buttonStartRec.Text = "Start Recording";
            this.buttonStartRec.UseVisualStyleBackColor = true;
            this.buttonStartRec.Click += new System.EventHandler(this.buttonStartRec_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadwavToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadwavToolStripMenuItem
            // 
            this.loadwavToolStripMenuItem.Name = "loadwavToolStripMenuItem";
            this.loadwavToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.loadwavToolStripMenuItem.Text = "Завантажити аудіо файл";
            this.loadwavToolStripMenuItem.Click += new System.EventHandler(this.loadwavToolStripMenuItem_Click);
            // 
            // openFileWavDialog
            // 
            this.openFileWavDialog.Filter = " (*.mp3)|*.mp3|(*.wav)|*.wav";
            this.openFileWavDialog.InitialDirectory = "D:\\IT\\repos\\VideoCadr\\Audio";
            // 
            // openFileTxtDialog
            // 
            this.openFileTxtDialog.Filter = " (*.txt)|*.txt";
            this.openFileTxtDialog.InitialDirectory = "D:\\IT\\repos\\VideoCadr\\Frames";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 463);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "VideoAudio Thread";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageVideo.ResumeLayout(false);
            this.tabPageVideo.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPageAudio.ResumeLayout(false);
            this.tabPageAudio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonSaveTxt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboCameras;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Button buttonStartInterval;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAudio;
        private System.Windows.Forms.TabPage tabPageVideo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadwavToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileWavDialog;
        private System.Windows.Forms.Button buttonStopInterval;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem uploadPhotoToolStripMenuItem;
        private System.Windows.Forms.Button buttonRepRec;
        private System.Windows.Forms.Button buttonStopRec;
        private System.Windows.Forms.Button buttonStartRec;
        private System.Windows.Forms.OpenFileDialog openFileTxtDialog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonResumePlay;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TextBox textWav;
        private System.Windows.Forms.Button buttonMakeTxt;
    }
}

