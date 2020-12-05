namespace VideoAudio
{
    partial class Main
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileWavDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileTxtDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileBitDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogMoreOne = new System.Windows.Forms.OpenFileDialog();
            this.tabPageAffine = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonMirror = new System.Windows.Forms.Button();
            this.buttonSaveAffine = new System.Windows.Forms.Button();
            this.trackBarHalf = new System.Windows.Forms.TrackBar();
            this.pictureBoxAffineOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxAffineIn = new System.Windows.Forms.PictureBox();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.uploadAffineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.афинниПеретворенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageFilters = new System.Windows.Forms.TabPage();
            this.buttonSaveFiltered = new System.Windows.Forms.Button();
            this.buttonFiltering = new System.Windows.Forms.Button();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вибірФільтраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFIlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageAudio = new System.Windows.Forms.TabPage();
            this.buttonStopPlay = new System.Windows.Forms.Button();
            this.waveViewer = new NAudio.Gui.WaveViewer();
            this.buttonMakeTxt = new System.Windows.Forms.Button();
            this.textWav = new System.Windows.Forms.TextBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonResumePlay = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStopRec = new System.Windows.Forms.Button();
            this.buttonStartRec = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadwavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStopInterval = new System.Windows.Forms.Button();
            this.buttonSaveTxt = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonStartInterval = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboCameras = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.uploadBitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadPhotoTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCV = new System.Windows.Forms.TabPage();
            this.buttonCV = new System.Windows.Forms.Button();
            this.tabPageAffine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHalf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAffineOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAffineIn)).BeginInit();
            this.menuStrip4.SuspendLayout();
            this.tabPageFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.tabPageAudio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 463);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // openFileWavDialog
            // 
            this.openFileWavDialog.Filter = "(*.wav)|*.wav";
            this.openFileWavDialog.InitialDirectory = "D:\\IT\\repos\\VideoCadr\\Audio";
            // 
            // openFileTxtDialog
            // 
            this.openFileTxtDialog.Filter = " (*.txt)|*.txt";
            this.openFileTxtDialog.InitialDirectory = "D:\\IT\\repos\\VideoCadr\\Txt";
            // 
            // openFileBitDialog
            // 
            this.openFileBitDialog.Filter = " (*.bitmap)|*.bmp";
            this.openFileBitDialog.InitialDirectory = "D:\\IT\\repos\\VideoCadr\\Frames";
            // 
            // openFileDialogMoreOne
            // 
            this.openFileDialogMoreOne.Multiselect = true;
            // 
            // tabPageAffine
            // 
            this.tabPageAffine.Controls.Add(this.label3);
            this.tabPageAffine.Controls.Add(this.trackBarWidth);
            this.tabPageAffine.Controls.Add(this.label2);
            this.tabPageAffine.Controls.Add(this.buttonScale);
            this.tabPageAffine.Controls.Add(this.buttonMirror);
            this.tabPageAffine.Controls.Add(this.buttonSaveAffine);
            this.tabPageAffine.Controls.Add(this.trackBarHalf);
            this.tabPageAffine.Controls.Add(this.pictureBoxAffineOut);
            this.tabPageAffine.Controls.Add(this.pictureBoxAffineIn);
            this.tabPageAffine.Controls.Add(this.menuStrip4);
            this.tabPageAffine.Location = new System.Drawing.Point(4, 25);
            this.tabPageAffine.Name = "tabPageAffine";
            this.tabPageAffine.Size = new System.Drawing.Size(883, 434);
            this.tabPageAffine.TabIndex = 3;
            this.tabPageAffine.Text = "Афінні перетворення";
            this.tabPageAffine.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(464, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Width";
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.Enabled = false;
            this.trackBarWidth.Location = new System.Drawing.Point(454, 63);
            this.trackBarWidth.Maximum = 2000;
            this.trackBarWidth.Minimum = 100;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarWidth.Size = new System.Drawing.Size(56, 317);
            this.trackBarWidth.TabIndex = 16;
            this.trackBarWidth.TickFrequency = 10;
            this.trackBarWidth.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(367, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Height";
            // 
            // buttonScale
            // 
            this.buttonScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonScale.Location = new System.Drawing.Point(174, 386);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(88, 27);
            this.buttonScale.TabIndex = 14;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonMirror
            // 
            this.buttonMirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMirror.Location = new System.Drawing.Point(34, 386);
            this.buttonMirror.Name = "buttonMirror";
            this.buttonMirror.Size = new System.Drawing.Size(88, 27);
            this.buttonMirror.TabIndex = 13;
            this.buttonMirror.Text = "Mirror";
            this.buttonMirror.UseVisualStyleBackColor = true;
            this.buttonMirror.Click += new System.EventHandler(this.buttonMirror_Click);
            // 
            // buttonSaveAffine
            // 
            this.buttonSaveAffine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAffine.Location = new System.Drawing.Point(732, 386);
            this.buttonSaveAffine.Name = "buttonSaveAffine";
            this.buttonSaveAffine.Size = new System.Drawing.Size(113, 27);
            this.buttonSaveAffine.TabIndex = 12;
            this.buttonSaveAffine.Text = "Save";
            this.buttonSaveAffine.UseVisualStyleBackColor = true;
            this.buttonSaveAffine.Click += new System.EventHandler(this.buttonSaveAffine_Click);
            // 
            // trackBarHalf
            // 
            this.trackBarHalf.Enabled = false;
            this.trackBarHalf.Location = new System.Drawing.Point(370, 63);
            this.trackBarHalf.Maximum = 360;
            this.trackBarHalf.Name = "trackBarHalf";
            this.trackBarHalf.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHalf.Size = new System.Drawing.Size(56, 317);
            this.trackBarHalf.TabIndex = 3;
            this.trackBarHalf.TickFrequency = 10;
            this.trackBarHalf.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarHalf.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // pictureBoxAffineOut
            // 
            this.pictureBoxAffineOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAffineOut.Location = new System.Drawing.Point(516, 63);
            this.pictureBoxAffineOut.Name = "pictureBoxAffineOut";
            this.pictureBoxAffineOut.Size = new System.Drawing.Size(329, 317);
            this.pictureBoxAffineOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAffineOut.TabIndex = 2;
            this.pictureBoxAffineOut.TabStop = false;
            // 
            // pictureBoxAffineIn
            // 
            this.pictureBoxAffineIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAffineIn.Location = new System.Drawing.Point(34, 63);
            this.pictureBoxAffineIn.Name = "pictureBoxAffineIn";
            this.pictureBoxAffineIn.Size = new System.Drawing.Size(329, 317);
            this.pictureBoxAffineIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAffineIn.TabIndex = 1;
            this.pictureBoxAffineIn.TabStop = false;
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadAffineToolStripMenuItem,
            this.афинниПеретворенняToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(883, 28);
            this.menuStrip4.TabIndex = 4;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // uploadAffineToolStripMenuItem
            // 
            this.uploadAffineToolStripMenuItem.Name = "uploadAffineToolStripMenuItem";
            this.uploadAffineToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.uploadAffineToolStripMenuItem.Text = "Завантажити фото";
            this.uploadAffineToolStripMenuItem.Click += new System.EventHandler(this.uploadAffineToolStripMenuItem_Click);
            // 
            // афинниПеретворенняToolStripMenuItem
            // 
            this.афинниПеретворенняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateToolStripMenuItem,
            this.scaleToolStripMenuItem});
            this.афинниПеретворенняToolStripMenuItem.Name = "афинниПеретворенняToolStripMenuItem";
            this.афинниПеретворенняToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.афинниПеретворенняToolStripMenuItem.Text = "Афинни перетворення";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.rotateToolStripMenuItem.Text = "Поворот";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.scaleToolStripMenuItem.Text = "Масштабування";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Controls.Add(this.buttonSaveFiltered);
            this.tabPageFilters.Controls.Add(this.buttonFiltering);
            this.tabPageFilters.Controls.Add(this.pictureBoxOutput);
            this.tabPageFilters.Controls.Add(this.pictureBoxInput);
            this.tabPageFilters.Controls.Add(this.menuStrip3);
            this.tabPageFilters.Location = new System.Drawing.Point(4, 25);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Size = new System.Drawing.Size(883, 434);
            this.tabPageFilters.TabIndex = 2;
            this.tabPageFilters.Text = "Фільтри";
            this.tabPageFilters.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFiltered
            // 
            this.buttonSaveFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFiltered.Location = new System.Drawing.Point(739, 388);
            this.buttonSaveFiltered.Name = "buttonSaveFiltered";
            this.buttonSaveFiltered.Size = new System.Drawing.Size(113, 27);
            this.buttonSaveFiltered.TabIndex = 11;
            this.buttonSaveFiltered.Text = "Save";
            this.buttonSaveFiltered.UseVisualStyleBackColor = true;
            this.buttonSaveFiltered.Click += new System.EventHandler(this.buttonSaveFiltered_Click);
            // 
            // buttonFiltering
            // 
            this.buttonFiltering.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFiltering.Location = new System.Drawing.Point(386, 388);
            this.buttonFiltering.Name = "buttonFiltering";
            this.buttonFiltering.Size = new System.Drawing.Size(113, 27);
            this.buttonFiltering.TabIndex = 7;
            this.buttonFiltering.Text = "Transform";
            this.buttonFiltering.UseVisualStyleBackColor = true;
            this.buttonFiltering.Click += new System.EventHandler(this.buttonFiltering_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOutput.Location = new System.Drawing.Point(523, 56);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(329, 317);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxInput.Location = new System.Drawing.Point(25, 56);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(329, 317);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem,
            this.вибірФільтраToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(883, 28);
            this.menuStrip3.TabIndex = 10;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.uploadToolStripMenuItem.Text = "Завантажити фото";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // вибірФільтраToolStripMenuItem
            // 
            this.вибірФільтраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastToolStripMenuItem,
            this.medianaToolStripMenuItem,
            this.timeToolStripMenuItem});
            this.вибірФільтраToolStripMenuItem.Name = "вибірФільтраToolStripMenuItem";
            this.вибірФільтраToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.вибірФільтраToolStripMenuItem.Text = "Вибір фільтра";
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.contrastToolStripMenuItem.Text = "Лінійне контрастування";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // medianaToolStripMenuItem
            // 
            this.medianaToolStripMenuItem.Name = "medianaToolStripMenuItem";
            this.medianaToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.medianaToolStripMenuItem.Text = "Медіанний фільтр";
            this.medianaToolStripMenuItem.Click += new System.EventHandler(this.medianaToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFIlesToolStripMenuItem});
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.timeToolStripMenuItem.Text = "Часовий ряд";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // selectFIlesToolStripMenuItem
            // 
            this.selectFIlesToolStripMenuItem.Name = "selectFIlesToolStripMenuItem";
            this.selectFIlesToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.selectFIlesToolStripMenuItem.Text = "Виберіть файли";
            this.selectFIlesToolStripMenuItem.Click += new System.EventHandler(this.selectFIlesToolStripMenuItem_Click);
            // 
            // tabPageAudio
            // 
            this.tabPageAudio.Controls.Add(this.buttonStopPlay);
            this.tabPageAudio.Controls.Add(this.waveViewer);
            this.tabPageAudio.Controls.Add(this.buttonMakeTxt);
            this.tabPageAudio.Controls.Add(this.textWav);
            this.tabPageAudio.Controls.Add(this.buttonPause);
            this.tabPageAudio.Controls.Add(this.buttonResumePlay);
            this.tabPageAudio.Controls.Add(this.buttonPlay);
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
            // buttonStopPlay
            // 
            this.buttonStopPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopPlay.Location = new System.Drawing.Point(732, 364);
            this.buttonStopPlay.Name = "buttonStopPlay";
            this.buttonStopPlay.Size = new System.Drawing.Size(75, 29);
            this.buttonStopPlay.TabIndex = 11;
            this.buttonStopPlay.Text = "Stop";
            this.buttonStopPlay.UseVisualStyleBackColor = true;
            this.buttonStopPlay.Click += new System.EventHandler(this.buttonStopPlay_Click);
            // 
            // waveViewer
            // 
            this.waveViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.waveViewer.Location = new System.Drawing.Point(200, 34);
            this.waveViewer.Name = "waveViewer";
            this.waveViewer.SamplesPerPixel = 128;
            this.waveViewer.Size = new System.Drawing.Size(671, 309);
            this.waveViewer.StartPosition = ((long)(0));
            this.waveViewer.TabIndex = 10;
            this.waveViewer.WaveStream = null;
            // 
            // buttonMakeTxt
            // 
            this.buttonMakeTxt.Location = new System.Drawing.Point(25, 197);
            this.buttonMakeTxt.Name = "buttonMakeTxt";
            this.buttonMakeTxt.Size = new System.Drawing.Size(94, 49);
            this.buttonMakeTxt.TabIndex = 9;
            this.buttonMakeTxt.Text = "Make txt";
            this.buttonMakeTxt.UseVisualStyleBackColor = true;
            this.buttonMakeTxt.Click += new System.EventHandler(this.buttonMakeTxt_Click);
            // 
            // textWav
            // 
            this.textWav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textWav.Location = new System.Drawing.Point(25, 364);
            this.textWav.Multiline = true;
            this.textWav.Name = "textWav";
            this.textWav.Size = new System.Drawing.Size(301, 29);
            this.textWav.TabIndex = 8;
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPause.Location = new System.Drawing.Point(628, 364);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 29);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonResumePlay
            // 
            this.buttonResumePlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResumePlay.Location = new System.Drawing.Point(511, 364);
            this.buttonResumePlay.Name = "buttonResumePlay";
            this.buttonResumePlay.Size = new System.Drawing.Size(75, 29);
            this.buttonResumePlay.TabIndex = 6;
            this.buttonResumePlay.Text = "Resume";
            this.buttonResumePlay.UseVisualStyleBackColor = true;
            this.buttonResumePlay.Click += new System.EventHandler(this.buttonResumePlay_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Location = new System.Drawing.Point(399, 364);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 29);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
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
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadBitToolStripMenuItem,
            this.uploadPhotoTxtToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(877, 28);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // uploadBitToolStripMenuItem
            // 
            this.uploadBitToolStripMenuItem.Name = "uploadBitToolStripMenuItem";
            this.uploadBitToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.uploadBitToolStripMenuItem.Text = "Завантажити фото";
            this.uploadBitToolStripMenuItem.Click += new System.EventHandler(this.uploadBitToolStripMenuItem_Click);
            // 
            // uploadPhotoTxtToolStripMenuItem
            // 
            this.uploadPhotoTxtToolStripMenuItem.Name = "uploadPhotoTxtToolStripMenuItem";
            this.uploadPhotoTxtToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.uploadPhotoTxtToolStripMenuItem.Text = "Завантажити фото з txt";
            this.uploadPhotoTxtToolStripMenuItem.Click += new System.EventHandler(this.uploadPhotoToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageVideo);
            this.tabControl.Controls.Add(this.tabPageAudio);
            this.tabControl.Controls.Add(this.tabPageFilters);
            this.tabControl.Controls.Add(this.tabPageAffine);
            this.tabControl.Controls.Add(this.tabPageCV);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(891, 463);
            this.tabControl.TabIndex = 12;
            // 
            // tabPageCV
            // 
            this.tabPageCV.Controls.Add(this.buttonCV);
            this.tabPageCV.Location = new System.Drawing.Point(4, 25);
            this.tabPageCV.Name = "tabPageCV";
            this.tabPageCV.Size = new System.Drawing.Size(883, 434);
            this.tabPageCV.TabIndex = 4;
            this.tabPageCV.Text = "Комп\'ютерний зір";
            this.tabPageCV.UseVisualStyleBackColor = true;
            // 
            // buttonCV
            // 
            this.buttonCV.Location = new System.Drawing.Point(281, 145);
            this.buttonCV.Name = "buttonCV";
            this.buttonCV.Size = new System.Drawing.Size(302, 121);
            this.buttonCV.TabIndex = 0;
            this.buttonCV.Text = "Перейти";
            this.buttonCV.UseVisualStyleBackColor = true;
            this.buttonCV.Click += new System.EventHandler(this.buttonCV_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 463);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Main";
            this.Text = "VideoAudio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabPageAffine.ResumeLayout(false);
            this.tabPageAffine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHalf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAffineOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAffineIn)).EndInit();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.tabPageFilters.ResumeLayout(false);
            this.tabPageFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPageAudio.ResumeLayout(false);
            this.tabPageAudio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageVideo.ResumeLayout(false);
            this.tabPageVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileWavDialog;
        private System.Windows.Forms.OpenFileDialog openFileTxtDialog;
        private System.Windows.Forms.OpenFileDialog openFileBitDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogMoreOne;
        private System.Windows.Forms.TabPage tabPageAffine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Button buttonMirror;
        private System.Windows.Forms.Button buttonSaveAffine;
        private System.Windows.Forms.TrackBar trackBarHalf;
        private System.Windows.Forms.PictureBox pictureBoxAffineOut;
        private System.Windows.Forms.PictureBox pictureBoxAffineIn;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem uploadAffineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem афинниПеретворенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageFilters;
        private System.Windows.Forms.Button buttonSaveFiltered;
        private System.Windows.Forms.Button buttonFiltering;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вибірФільтраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFIlesToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageAudio;
        private System.Windows.Forms.Button buttonStopPlay;
        private NAudio.Gui.WaveViewer waveViewer;
        private System.Windows.Forms.Button buttonMakeTxt;
        private System.Windows.Forms.TextBox textWav;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonResumePlay;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStopRec;
        private System.Windows.Forms.Button buttonStartRec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadwavToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageVideo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStopInterval;
        private System.Windows.Forms.Button buttonSaveTxt;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonStartInterval;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ComboBox comboCameras;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem uploadBitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadPhotoTxtToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCV;
        private System.Windows.Forms.Button buttonCV;
    }
}

