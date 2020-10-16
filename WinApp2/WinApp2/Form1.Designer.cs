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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTest12 = new System.Windows.Forms.RadioButton();
            this.rbTest11 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTest11 = new System.Windows.Forms.TextBox();
            this.btnTest11 = new System.Windows.Forms.Button();
            this.cbTest11 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTest12 = new System.Windows.Forms.TextBox();
            this.btnTest12 = new System.Windows.Forms.Button();
            this.tbTest13 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("궁서", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 490);
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
            this.tabPage1.Size = new System.Drawing.Size(717, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "문자열 테스트";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbTest12);
            this.groupBox1.Controls.Add(this.rbTest11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTest11);
            this.groupBox1.Controls.Add(this.btnTest11);
            this.groupBox1.Location = new System.Drawing.Point(18, 25);
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
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Text";
            // 
            // rbTest12
            // 
            this.rbTest12.AutoSize = true;
            this.rbTest12.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbTest12.Location = new System.Drawing.Point(193, 27);
            this.rbTest12.Name = "rbTest12";
            this.rbTest12.Size = new System.Drawing.Size(81, 20);
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
            this.rbTest11.Size = new System.Drawing.Size(81, 20);
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
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // tbTest11
            // 
            this.tbTest11.Location = new System.Drawing.Point(99, 71);
            this.tbTest11.Name = "tbTest11";
            this.tbTest11.Size = new System.Drawing.Size(160, 26);
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
            // cbTest11
            // 
            this.cbTest11.FormattingEnabled = true;
            this.cbTest11.Location = new System.Drawing.Point(100, 86);
            this.cbTest11.Name = "cbTest11";
            this.cbTest11.Size = new System.Drawing.Size(160, 24);
            this.cbTest11.TabIndex = 2;
            this.cbTest11.SelectedIndexChanged += new System.EventHandler(this.cbTest11_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input Text";
            // 
            // tbTest12
            // 
            this.tbTest12.Location = new System.Drawing.Point(100, 45);
            this.tbTest12.Name = "tbTest12";
            this.tbTest12.Size = new System.Drawing.Size(160, 26);
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
            // tbTest13
            // 
            this.tbTest13.Enabled = false;
            this.tbTest13.Location = new System.Drawing.Point(100, 126);
            this.tbTest13.Name = "tbTest13";
            this.tbTest13.Size = new System.Drawing.Size(160, 26);
            this.tbTest13.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTest12;
        private System.Windows.Forms.Button btnTest12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTest13;
    }
}

