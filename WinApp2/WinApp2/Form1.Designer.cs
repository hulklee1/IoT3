using System.Windows.Forms;

namespace WinApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTest13 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTest12 = new System.Windows.Forms.TextBox();
            this.btnTest12 = new System.Windows.Forms.Button();
            this.cbTest11 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTest12 = new System.Windows.Forms.RadioButton();
            this.rbTest11 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTest11 = new System.Windows.Forms.TextBox();
            this.btnTest11 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbText22 = new System.Windows.Forms.RadioButton();
            this.rbText21 = new System.Windows.Forms.RadioButton();
            this.chkViewHexa = new System.Windows.Forms.CheckBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnForm2Test = new System.Windows.Forms.Button();
            this.tbTest22 = new System.Windows.Forms.TextBox();
            this.PopupMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.현재창을출력창으로2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTest21 = new System.Windows.Forms.TextBox();
            this.PopupMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.현재창을출력창으로1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.btnExecSql = new System.Windows.Forms.Button();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopupMenu3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucellUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGridCmd = new System.Windows.Forms.Button();
            this.tbGridCmd = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.form2CallTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.배열TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출력창설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTbSet21 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTbSet22 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudBFileSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDBOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuDBClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCSVImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PopupMenu2.SuspendLayout();
            this.PopupMenu1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PopupMenu3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(1, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("궁서", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "문자열 테스트";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTest13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTest12);
            this.groupBox2.Controls.Add(this.btnTest12);
            this.groupBox2.Controls.Add(this.cbTest11);
            this.groupBox2.Location = new System.Drawing.Point(18, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "콤보박스 테스트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Text";
            // 
            // tbTest13
            // 
            this.tbTest13.Enabled = false;
            this.tbTest13.Location = new System.Drawing.Point(100, 126);
            this.tbTest13.Name = "tbTest13";
            this.tbTest13.Size = new System.Drawing.Size(160, 23);
            this.tbTest13.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input Text";
            // 
            // tbTest12
            // 
            this.tbTest12.Location = new System.Drawing.Point(100, 45);
            this.tbTest12.Name = "tbTest12";
            this.tbTest12.Size = new System.Drawing.Size(160, 23);
            this.tbTest12.TabIndex = 1;
            // 
            // btnTest12
            // 
            this.btnTest12.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTest12.Location = new System.Drawing.Point(265, 42);
            this.btnTest12.Name = "btnTest12";
            this.btnTest12.Size = new System.Drawing.Size(75, 28);
            this.btnTest12.TabIndex = 0;
            this.btnTest12.Text = "추가";
            this.btnTest12.UseVisualStyleBackColor = true;
            this.btnTest12.Click += new System.EventHandler(this.btnTest12_Click);
            // 
            // cbTest11
            // 
            this.cbTest11.FormattingEnabled = true;
            this.cbTest11.Location = new System.Drawing.Point(100, 86);
            this.cbTest11.Name = "cbTest11";
            this.cbTest11.Size = new System.Drawing.Size(160, 21);
            this.cbTest11.TabIndex = 2;
            this.cbTest11.SelectedIndexChanged += new System.EventHandler(this.cbTest11_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbTest12);
            this.groupBox1.Controls.Add(this.rbTest11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTest11);
            this.groupBox1.Controls.Add(this.btnTest11);
            this.groupBox1.Location = new System.Drawing.Point(18, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대소문자 변환 테스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Text";
            // 
            // rbTest12
            // 
            this.rbTest12.AutoSize = true;
            this.rbTest12.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbTest12.Location = new System.Drawing.Point(193, 27);
            this.rbTest12.Name = "rbTest12";
            this.rbTest12.Size = new System.Drawing.Size(70, 18);
            this.rbTest12.TabIndex = 4;
            this.rbTest12.Text = "대문자";
            this.rbTest12.UseVisualStyleBackColor = true;
            // 
            // rbTest11
            // 
            this.rbTest11.AutoSize = true;
            this.rbTest11.Checked = true;
            this.rbTest11.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbTest11.Location = new System.Drawing.Point(100, 27);
            this.rbTest11.Name = "rbTest11";
            this.rbTest11.Size = new System.Drawing.Size(70, 18);
            this.rbTest11.TabIndex = 4;
            this.rbTest11.TabStop = true;
            this.rbTest11.Text = "소문자";
            this.rbTest11.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("궁서", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // tbTest11
            // 
            this.tbTest11.Location = new System.Drawing.Point(99, 71);
            this.tbTest11.Name = "tbTest11";
            this.tbTest11.Size = new System.Drawing.Size(160, 23);
            this.tbTest11.TabIndex = 1;
            // 
            // btnTest11
            // 
            this.btnTest11.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTest11.Location = new System.Drawing.Point(265, 71);
            this.btnTest11.Name = "btnTest11";
            this.btnTest11.Size = new System.Drawing.Size(75, 28);
            this.btnTest11.TabIndex = 0;
            this.btnTest11.Text = "변환";
            this.btnTest11.UseVisualStyleBackColor = true;
            this.btnTest11.Click += new System.EventHandler(this.btnTest11_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rbText22);
            this.tabPage2.Controls.Add(this.rbText21);
            this.tabPage2.Controls.Add(this.chkViewHexa);
            this.tabPage2.Controls.Add(this.btnTemp);
            this.tabPage2.Controls.Add(this.btnFileOpen);
            this.tabPage2.Controls.Add(this.btnForm2Test);
            this.tabPage2.Controls.Add(this.tbTest22);
            this.tabPage2.Controls.Add(this.tbTest21);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "배열테스트";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbText22
            // 
            this.rbText22.AutoSize = true;
            this.rbText22.Checked = true;
            this.rbText22.Location = new System.Drawing.Point(456, 70);
            this.rbText22.Name = "rbText22";
            this.rbText22.Size = new System.Drawing.Size(140, 23);
            this.rbText22.TabIndex = 6;
            this.rbText22.TabStop = true;
            this.rbText22.Text = "Current Window2";
            this.rbText22.UseVisualStyleBackColor = true;
            this.rbText22.Click += new System.EventHandler(this.rbText2_Click);
            // 
            // rbText21
            // 
            this.rbText21.AutoSize = true;
            this.rbText21.Location = new System.Drawing.Point(7, 70);
            this.rbText21.Name = "rbText21";
            this.rbText21.Size = new System.Drawing.Size(140, 23);
            this.rbText21.TabIndex = 6;
            this.rbText21.Text = "Current Window1";
            this.rbText21.UseVisualStyleBackColor = true;
            this.rbText21.Click += new System.EventHandler(this.rbText2_Click);
            // 
            // chkViewHexa
            // 
            this.chkViewHexa.AutoSize = true;
            this.chkViewHexa.Checked = true;
            this.chkViewHexa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkViewHexa.Location = new System.Drawing.Point(232, 25);
            this.chkViewHexa.Name = "chkViewHexa";
            this.chkViewHexa.Size = new System.Drawing.Size(112, 23);
            this.chkViewHexa.TabIndex = 5;
            this.chkViewHexa.Text = "View in Hexa";
            this.chkViewHexa.UseVisualStyleBackColor = true;
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(128, 20);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(84, 31);
            this.btnTemp.TabIndex = 4;
            this.btnTemp.Text = "Test#1";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(7, 20);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(115, 31);
            this.btnFileOpen.TabIndex = 4;
            this.btnFileOpen.Text = "File Open";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // btnForm2Test
            // 
            this.btnForm2Test.Location = new System.Drawing.Point(456, 20);
            this.btnForm2Test.Name = "btnForm2Test";
            this.btnForm2Test.Size = new System.Drawing.Size(128, 31);
            this.btnForm2Test.TabIndex = 4;
            this.btnForm2Test.Text = "Call Form2";
            this.btnForm2Test.UseVisualStyleBackColor = true;
            this.btnForm2Test.Click += new System.EventHandler(this.btnForm2Test_Click);
            // 
            // tbTest22
            // 
            this.tbTest22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTest22.ContextMenuStrip = this.PopupMenu2;
            this.tbTest22.Location = new System.Drawing.Point(230, 98);
            this.tbTest22.Multiline = true;
            this.tbTest22.Name = "tbTest22";
            this.tbTest22.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTest22.Size = new System.Drawing.Size(386, 308);
            this.tbTest22.TabIndex = 3;
            // 
            // PopupMenu2
            // 
            this.PopupMenu2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PopupMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재창을출력창으로2ToolStripMenuItem});
            this.PopupMenu2.Name = "PopupMenu2";
            this.PopupMenu2.Size = new System.Drawing.Size(237, 28);
            // 
            // 현재창을출력창으로2ToolStripMenuItem
            // 
            this.현재창을출력창으로2ToolStripMenuItem.Name = "현재창을출력창으로2ToolStripMenuItem";
            this.현재창을출력창으로2ToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.현재창을출력창으로2ToolStripMenuItem.Text = "현재 창을 출력창으로 2";
            this.현재창을출력창으로2ToolStripMenuItem.Click += new System.EventHandler(this.mnuSelect2_Click);
            // 
            // tbTest21
            // 
            this.tbTest21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTest21.ContextMenuStrip = this.PopupMenu1;
            this.tbTest21.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTest21.Location = new System.Drawing.Point(7, 98);
            this.tbTest21.Multiline = true;
            this.tbTest21.Name = "tbTest21";
            this.tbTest21.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTest21.Size = new System.Drawing.Size(373, 308);
            this.tbTest21.TabIndex = 2;
            // 
            // PopupMenu1
            // 
            this.PopupMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PopupMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재창을출력창으로1ToolStripMenuItem});
            this.PopupMenu1.Name = "PopupMenu1";
            this.PopupMenu1.Size = new System.Drawing.Size(232, 28);
            // 
            // 현재창을출력창으로1ToolStripMenuItem
            // 
            this.현재창을출력창으로1ToolStripMenuItem.Name = "현재창을출력창으로1ToolStripMenuItem";
            this.현재창을출력창으로1ToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.현재창을출력창으로1ToolStripMenuItem.Text = "현재창을 출력창으로 1";
            this.현재창을출력창으로1ToolStripMenuItem.Click += new System.EventHandler(this.mnuSelect1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Controls.Add(this.btnGridCmd);
            this.tabPage3.Controls.Add(this.tbGridCmd);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(625, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data Grid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbTable);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbDatabase);
            this.splitContainer1.Panel1.Controls.Add(this.btnExecSql);
            this.splitContainer1.Panel1.Controls.Add(this.tbSql);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(625, 408);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 5;
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(295, 2);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(150, 25);
            this.cbTable.TabIndex = 7;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Database";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDatabase.Location = new System.Drawing.Point(81, 2);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(208, 25);
            this.tbDatabase.TabIndex = 5;
            // 
            // btnExecSql
            // 
            this.btnExecSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecSql.Location = new System.Drawing.Point(477, 2);
            this.btnExecSql.Name = "btnExecSql";
            this.btnExecSql.Size = new System.Drawing.Size(142, 25);
            this.btnExecSql.TabIndex = 4;
            this.btnExecSql.Text = "Go";
            this.btnExecSql.UseVisualStyleBackColor = true;
            this.btnExecSql.Click += new System.EventHandler(this.btnExecSql_Click);
            // 
            // tbSql
            // 
            this.tbSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSql.Font = new System.Drawing.Font("Consolas", 8F);
            this.tbSql.Location = new System.Drawing.Point(3, 28);
            this.tbSql.Multiline = true;
            this.tbSql.Name = "tbSql";
            this.tbSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSql.Size = new System.Drawing.Size(619, 139);
            this.tbSql.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.ContextMenuStrip = this.PopupMenu3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(619, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // PopupMenu3
            // 
            this.PopupMenu3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PopupMenu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddRow,
            this.mnucellUpdate});
            this.PopupMenu3.Name = "PopupMenu3";
            this.PopupMenu3.Size = new System.Drawing.Size(158, 52);
            // 
            // mnuAddRow
            // 
            this.mnuAddRow.Name = "mnuAddRow";
            this.mnuAddRow.Size = new System.Drawing.Size(157, 24);
            this.mnuAddRow.Text = "행 추가";
            this.mnuAddRow.Click += new System.EventHandler(this.mnuAddRow_Click);
            // 
            // mnucellUpdate
            // 
            this.mnucellUpdate.Name = "mnucellUpdate";
            this.mnucellUpdate.Size = new System.Drawing.Size(157, 24);
            this.mnucellUpdate.Text = "Cell update";
            this.mnucellUpdate.Click += new System.EventHandler(this.mnucellUpdate_Click);
            // 
            // btnGridCmd
            // 
            this.btnGridCmd.Enabled = false;
            this.btnGridCmd.Location = new System.Drawing.Point(7, 39);
            this.btnGridCmd.Name = "btnGridCmd";
            this.btnGridCmd.Size = new System.Drawing.Size(54, 29);
            this.btnGridCmd.TabIndex = 2;
            this.btnGridCmd.Text = "Grid Control";
            this.btnGridCmd.UseVisualStyleBackColor = true;
            this.btnGridCmd.Visible = false;
            this.btnGridCmd.Click += new System.EventHandler(this.btnGridCmd_Click);
            // 
            // tbGridCmd
            // 
            this.tbGridCmd.Enabled = false;
            this.tbGridCmd.Location = new System.Drawing.Point(7, 4);
            this.tbGridCmd.Name = "tbGridCmd";
            this.tbGridCmd.Size = new System.Drawing.Size(54, 25);
            this.tbGridCmd.TabIndex = 1;
            this.tbGridCmd.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.mnuImportCSV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text파일열기ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.form2CallTestToolStripMenuItem,
            this.toolStripMenuItem2,
            this.배열TestToolStripMenuItem,
            this.종료ToolStripMenuItem,
            this.출력창설정ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // text파일열기ToolStripMenuItem
            // 
            this.text파일열기ToolStripMenuItem.Name = "text파일열기ToolStripMenuItem";
            this.text파일열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.text파일열기ToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.text파일열기ToolStripMenuItem.Text = "Text 파일 열기(O)";
            this.text파일열기ToolStripMenuItem.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // form2CallTestToolStripMenuItem
            // 
            this.form2CallTestToolStripMenuItem.Name = "form2CallTestToolStripMenuItem";
            this.form2CallTestToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.form2CallTestToolStripMenuItem.Text = "Form2 Call test";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 6);
            // 
            // 배열TestToolStripMenuItem
            // 
            this.배열TestToolStripMenuItem.Name = "배열TestToolStripMenuItem";
            this.배열TestToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.배열TestToolStripMenuItem.Text = "배열 test";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 출력창설정ToolStripMenuItem
            // 
            this.출력창설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTbSet21,
            this.mnuTbSet22});
            this.출력창설정ToolStripMenuItem.Name = "출력창설정ToolStripMenuItem";
            this.출력창설정ToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.출력창설정ToolStripMenuItem.Text = "출력창 설정";
            // 
            // mnuTbSet21
            // 
            this.mnuTbSet21.Name = "mnuTbSet21";
            this.mnuTbSet21.Size = new System.Drawing.Size(162, 26);
            this.mnuTbSet21.Text = "Text 창 #1";
            this.mnuTbSet21.Click += new System.EventHandler(this.mnuTbSet21_Click);
            // 
            // mnuTbSet22
            // 
            this.mnuTbSet22.Checked = true;
            this.mnuTbSet22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuTbSet22.Name = "mnuTbSet22";
            this.mnuTbSet22.Size = new System.Drawing.Size(162, 26);
            this.mnuTbSet22.Text = "Text 창 #2";
            this.mnuTbSet22.Click += new System.EventHandler(this.mnuTbSet22_Click);
            // 
            // mnuImportCSV
            // 
            this.mnuImportCSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudBFileSelect,
            this.mnuDBOpen,
            this.mnuDBClose,
            this.mnuCSVImport});
            this.mnuImportCSV.Name = "mnuImportCSV";
            this.mnuImportCSV.Size = new System.Drawing.Size(86, 24);
            this.mnuImportCSV.Text = "Database";
            // 
            // mnudBFileSelect
            // 
            this.mnudBFileSelect.Name = "mnudBFileSelect";
            this.mnudBFileSelect.Size = new System.Drawing.Size(282, 26);
            this.mnudBFileSelect.Text = "DB File Select";
            this.mnudBFileSelect.Click += new System.EventHandler(this.mnudBFileSelect_Click);
            // 
            // mnuDBOpen
            // 
            this.mnuDBOpen.Name = "mnuDBOpen";
            this.mnuDBOpen.Size = new System.Drawing.Size(282, 26);
            this.mnuDBOpen.Text = "DB Open";
            this.mnuDBOpen.Click += new System.EventHandler(this.mnuDBOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2,
            this.StatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(152, 20);
            this.StatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // StatusLabel3
            // 
            this.StatusLabel3.Name = "StatusLabel3";
            this.StatusLabel3.Size = new System.Drawing.Size(15, 20);
            this.StatusLabel3.Text = "-";
            // 
            // mnuDBClose
            // 
            this.mnuDBClose.Name = "mnuDBClose";
            this.mnuDBClose.Size = new System.Drawing.Size(282, 26);
            this.mnuDBClose.Text = "DB Close";
            this.mnuDBClose.Click += new System.EventHandler(this.mnuDBClose_Click);
            // 
            // mnuCSVImport
            // 
            this.mnuCSVImport.Name = "mnuCSVImport";
            this.mnuCSVImport.Size = new System.Drawing.Size(282, 26);
            this.mnuCSVImport.Text = "Migration - Import xls (csv) ";
            this.mnuCSVImport.Click += new System.EventHandler(this.mnuCSVImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "C# Programming Test Ver.2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PopupMenu2.ResumeLayout(false);
            this.PopupMenu1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PopupMenu3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTest11;
        private System.Windows.Forms.Button btnTest11;
        private System.Windows.Forms.RadioButton rbTest11;
        private System.Windows.Forms.ComboBox cbTest11;
        private System.Windows.Forms.RadioButton rbTest12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTest12;
        private System.Windows.Forms.Button btnTest12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTest13;
        private System.Windows.Forms.TextBox tbTest22;
        private System.Windows.Forms.TextBox tbTest21;
        private System.Windows.Forms.Button btnForm2Test;
        private System.Windows.Forms.CheckBox chkViewHexa;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.RadioButton rbText22;
        private System.Windows.Forms.RadioButton rbText21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text파일열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem form2CallTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 배열TestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출력창설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTbSet21;
        private System.Windows.Forms.ToolStripMenuItem mnuTbSet22;
        private System.Windows.Forms.ContextMenuStrip PopupMenu1;
        private System.Windows.Forms.ToolStripMenuItem 현재창을출력창으로1ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip PopupMenu2;
        private System.Windows.Forms.ToolStripMenuItem 현재창을출력창으로2ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGridCmd;
        private System.Windows.Forms.TextBox tbGridCmd;
        private System.Windows.Forms.ContextMenuStrip PopupMenu3;
        private System.Windows.Forms.ToolStripMenuItem mnuAddRow;
        private System.Windows.Forms.Button btnExecSql;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.ToolStripMenuItem mnuImportCSV;
        private System.Windows.Forms.ToolStripMenuItem mnudBFileSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuDBOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private DataGridViewTextBoxColumn Column1;
        private ToolStripMenuItem mnucellUpdate;
        private ToolStripStatusLabel StatusLabel3;
        private SplitContainer splitContainer1;
        private ComboBox cbTable;
        private Label label5;
        private TextBox tbDatabase;
        private ToolStripMenuItem mnuDBClose;
        private ToolStripMenuItem mnuCSVImport;
    }
}

