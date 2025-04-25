namespace WinControlsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            MnuExit = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ChkItalic = new CheckBox();
            TxtResult = new TextBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            groupBox3 = new GroupBox();
            BtnCheck = new Button();
            LblUrl = new LinkLabel();
            DtpBirth = new DateTimePicker();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            CalSchedule = new MonthCalendar();
            toolTip1 = new ToolTip(components);
            groupBox4 = new GroupBox();
            PrgProcess = new ProgressBar();
            TrbProcess = new TrackBar();
            groupBox5 = new GroupBox();
            BtnMsg = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox6 = new GroupBox();
            BtnNode = new Button();
            BtnRoot = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            DlgOpenImage = new OpenFileDialog();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "상태 : 일반상태";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "일반컨트롤";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(293, 32);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 4;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(23, 69);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(333, 21);
            TxtResult.TabIndex = 3;
            TxtResult.Text = "Sample Text";
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(239, 32);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "볼드";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(45, 28);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(188, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 31);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnOpenImage);
            groupBox2.Controls.Add(PicImage);
            groupBox2.Location = new Point(403, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 509);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "픽쳐박스";
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(279, 473);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(100, 30);
            BtnOpenImage.TabIndex = 4;
            BtnOpenImage.Text = "이미지열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.ButtonShadow;
            PicImage.Location = new Point(0, 20);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(379, 447);
            PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnCheck);
            groupBox3.Controls.Add(LblUrl);
            groupBox3.Controls.Add(DtpBirth);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Controls.Add(CalSchedule);
            groupBox3.Location = new Point(791, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 503);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타컨트롤";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(255, 191);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 30);
            BtnCheck.TabIndex = 5;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // LblUrl
            // 
            LblUrl.AutoSize = true;
            LblUrl.Location = new Point(9, 241);
            LblUrl.Name = "LblUrl";
            LblUrl.Size = new Size(40, 14);
            LblUrl.TabIndex = 3;
            LblUrl.TabStop = true;
            LblUrl.Text = "네이버";
            LblUrl.LinkClicked += LblUrl_LinkClicked;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(9, 200);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(200, 21);
            DtpBirth.TabIndex = 2;
            DtpBirth.ValueChanged += DtpBirth_ValueChanged;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(255, 86);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 21);
            TxtDay.TabIndex = 1;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(255, 59);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 21);
            TxtMonth.TabIndex = 1;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(255, 32);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 21);
            TxtYear.TabIndex = 1;
            // 
            // CalSchedule
            // 
            CalSchedule.FirstDayOfWeek = Day.Sunday;
            CalSchedule.Location = new Point(9, 26);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PrgProcess);
            groupBox4.Controls.Add(TrbProcess);
            groupBox4.Location = new Point(15, 154);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(383, 108);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "트랙바";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(23, 71);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(329, 23);
            PrgProcess.TabIndex = 1;
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(19, 20);
            TrbProcess.Maximum = 100;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(333, 45);
            TrbProcess.TabIndex = 0;
            TrbProcess.TickFrequency = 10;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnMsg);
            groupBox5.Controls.Add(BtnModaless);
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Location = new Point(15, 268);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(383, 92);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스";
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(222, 35);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 0;
            BtnMsg.Text = "MessageBox";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(116, 35);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(100, 40);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(10, 35);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(100, 40);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnNode);
            groupBox6.Controls.Add(BtnRoot);
            groupBox6.Controls.Add(LsvDummy);
            groupBox6.Controls.Add(TrvDummy);
            groupBox6.Location = new Point(17, 366);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(383, 170);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "트리뷰, 리스트뷰";
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(277, 140);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(100, 30);
            BtnNode.TabIndex = 3;
            BtnNode.Text = "노드추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(171, 140);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(100, 30);
            BtnRoot.TabIndex = 2;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(200, 20);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(177, 115);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(8, 20);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(186, 115);
            TrvDummy.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("나눔고딕", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI컨트롤 예제 윈앱";
            TopMost = true;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox TxtResult;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private Label label1;
        private CheckBox ChkItalic;
        private ToolTip toolTip1;
        private GroupBox groupBox4;
        private ProgressBar PrgProcess;
        private TrackBar TrbProcess;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox5;
        private Button BtnMsg;
        private Button BtnModaless;
        private Button BtnModal;
        private GroupBox groupBox6;
        private Button BtnNode;
        private Button BtnRoot;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private ImageList imageList1;
        private Button BtnOpenImage;
        private PictureBox PicImage;
        private OpenFileDialog DlgOpenImage;
        private LinkLabel LblUrl;
        private DateTimePicker DtpBirth;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private MonthCalendar CalSchedule;
        private Button BtnCheck;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripMenuItem MnuExit;
    }
}
