namespace wf03_property
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GbxMain = new System.Windows.Forms.GroupBox();
            this.NudFontsize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cbofontFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrbDummy = new System.Windows.Forms.TrackBar();
            this.PgbDummy = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnModal = new System.Windows.Forms.Button();
            this.BtnModalless = new System.Windows.Forms.Button();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TrvDummy = new System.Windows.Forms.TreeView();
            this.LsvDummy = new System.Windows.Forms.ListView();
            this.BtnAddRoot = new System.Windows.Forms.Button();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.RdoNormal = new System.Windows.Forms.RadioButton();
            this.RdoIndent = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PcbDummy = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.GbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontsize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxMain
            // 
            this.GbxMain.BackColor = System.Drawing.Color.Transparent;
            this.GbxMain.Controls.Add(this.RdoIndent);
            this.GbxMain.Controls.Add(this.RdoNormal);
            this.GbxMain.Controls.Add(this.NudFontsize);
            this.GbxMain.Controls.Add(this.label2);
            this.GbxMain.Controls.Add(this.txtResult);
            this.GbxMain.Controls.Add(this.chkItalic);
            this.GbxMain.Controls.Add(this.chkBold);
            this.GbxMain.Controls.Add(this.cbofontFamily);
            this.GbxMain.Controls.Add(this.label1);
            this.GbxMain.Location = new System.Drawing.Point(12, 12);
            this.GbxMain.Name = "GbxMain";
            this.GbxMain.Size = new System.Drawing.Size(476, 154);
            this.GbxMain.TabIndex = 0;
            this.GbxMain.TabStop = false;
            this.GbxMain.Text = "컨트롤 학습";
            // 
            // NudFontsize
            // 
            this.NudFontsize.BackColor = System.Drawing.SystemColors.Window;
            this.NudFontsize.Location = new System.Drawing.Point(90, 56);
            this.NudFontsize.Name = "NudFontsize";
            this.NudFontsize.Size = new System.Drawing.Size(120, 23);
            this.NudFontsize.TabIndex = 4;
            this.NudFontsize.ValueChanged += new System.EventHandler(this.NudFontsize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "글자크기";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(21, 85);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(417, 63);
            this.txtResult.TabIndex = 5;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.BackColor = System.Drawing.SystemColors.Control;
            this.chkItalic.Location = new System.Drawing.Point(318, 27);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(62, 20);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = false;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.BackColor = System.Drawing.SystemColors.Control;
            this.chkBold.Location = new System.Drawing.Point(242, 27);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 20);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "볼드";
            this.chkBold.UseVisualStyleBackColor = false;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // cbofontFamily
            // 
            this.cbofontFamily.BackColor = System.Drawing.SystemColors.Window;
            this.cbofontFamily.FormattingEnabled = true;
            this.cbofontFamily.Location = new System.Drawing.Point(89, 23);
            this.cbofontFamily.Name = "cbofontFamily";
            this.cbofontFamily.Size = new System.Drawing.Size(121, 24);
            this.cbofontFamily.TabIndex = 1;
            this.cbofontFamily.SelectedIndexChanged += new System.EventHandler(this.cbofontFamily_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "글자체";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PgbDummy);
            this.groupBox1.Controls.Add(this.TrbDummy);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트랙바 및 진행바";
            // 
            // TrbDummy
            // 
            this.TrbDummy.Location = new System.Drawing.Point(6, 22);
            this.TrbDummy.Maximum = 20;
            this.TrbDummy.Name = "TrbDummy";
            this.TrbDummy.Size = new System.Drawing.Size(464, 45);
            this.TrbDummy.TabIndex = 6;
            this.TrbDummy.Scroll += new System.EventHandler(this.TrbDummy_Scroll);
            // 
            // PgbDummy
            // 
            this.PgbDummy.Location = new System.Drawing.Point(21, 73);
            this.PgbDummy.Maximum = 20;
            this.PgbDummy.Name = "PgbDummy";
            this.PgbDummy.Size = new System.Drawing.Size(440, 22);
            this.PgbDummy.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMsgBox);
            this.groupBox2.Controls.Add(this.BtnModalless);
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모달/ 리스 와 메세지창";
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(21, 27);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(126, 34);
            this.BtnModal.TabIndex = 8;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // BtnModalless
            // 
            this.BtnModalless.Location = new System.Drawing.Point(153, 27);
            this.BtnModalless.Name = "BtnModalless";
            this.BtnModalless.Size = new System.Drawing.Size(139, 34);
            this.BtnModalless.TabIndex = 9;
            this.BtnModalless.Text = "Modalless";
            this.BtnModalless.UseVisualStyleBackColor = true;
            this.BtnModalless.Click += new System.EventHandler(this.BtnModalless_Click);
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(298, 27);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(163, 34);
            this.BtnMsgBox.TabIndex = 10;
            this.BtnMsgBox.Text = "Message box";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddChild);
            this.groupBox3.Controls.Add(this.BtnAddRoot);
            this.groupBox3.Controls.Add(this.LsvDummy);
            this.groupBox3.Controls.Add(this.TrvDummy);
            this.groupBox3.Location = new System.Drawing.Point(494, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 208);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "트리뷰 / 리스트뷰 ";
            // 
            // TrvDummy
            // 
            this.TrvDummy.Location = new System.Drawing.Point(6, 22);
            this.TrvDummy.Name = "TrvDummy";
            this.TrvDummy.Size = new System.Drawing.Size(185, 148);
            this.TrvDummy.TabIndex = 11;
            // 
            // LsvDummy
            // 
            this.LsvDummy.HideSelection = false;
            this.LsvDummy.Location = new System.Drawing.Point(197, 22);
            this.LsvDummy.Name = "LsvDummy";
            this.LsvDummy.Size = new System.Drawing.Size(185, 148);
            this.LsvDummy.TabIndex = 12;
            this.LsvDummy.UseCompatibleStateImageBehavior = false;
            // 
            // BtnAddRoot
            // 
            this.BtnAddRoot.Location = new System.Drawing.Point(35, 176);
            this.BtnAddRoot.Name = "BtnAddRoot";
            this.BtnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRoot.TabIndex = 13;
            this.BtnAddRoot.Text = "루트 추가";
            this.BtnAddRoot.UseVisualStyleBackColor = true;
            this.BtnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(116, 176);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChild.TabIndex = 14;
            this.BtnAddChild.Text = "자식 추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // RdoNormal
            // 
            this.RdoNormal.AutoSize = true;
            this.RdoNormal.Checked = true;
            this.RdoNormal.Location = new System.Drawing.Point(242, 56);
            this.RdoNormal.Name = "RdoNormal";
            this.RdoNormal.Size = new System.Drawing.Size(49, 20);
            this.RdoNormal.TabIndex = 6;
            this.RdoNormal.TabStop = true;
            this.RdoNormal.Text = "일반";
            this.RdoNormal.UseVisualStyleBackColor = true;
            this.RdoNormal.CheckedChanged += new System.EventHandler(this.RdoNormal_CheckedChanged);
            // 
            // RdoIndent
            // 
            this.RdoIndent.AutoSize = true;
            this.RdoIndent.Location = new System.Drawing.Point(318, 58);
            this.RdoIndent.Name = "RdoIndent";
            this.RdoIndent.Size = new System.Drawing.Size(73, 20);
            this.RdoIndent.TabIndex = 6;
            this.RdoIndent.Text = "들여쓰기";
            this.RdoIndent.UseVisualStyleBackColor = true;
            this.RdoIndent.CheckedChanged += new System.EventHandler(this.RdoIndent_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnLoad);
            this.groupBox4.Controls.Add(this.PcbDummy);
            this.groupBox4.Location = new System.Drawing.Point(494, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 137);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "픽쳐박스";
            // 
            // PcbDummy
            // 
            this.PcbDummy.Location = new System.Drawing.Point(7, 23);
            this.PcbDummy.Name = "PcbDummy";
            this.PcbDummy.Size = new System.Drawing.Size(276, 108);
            this.PcbDummy.TabIndex = 0;
            this.PcbDummy.TabStop = false;
            this.PcbDummy.Click += new System.EventHandler(this.PcbDummy_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(307, 19);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "로드";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 384);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxMain);
            this.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "속성 확인";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GbxMain.ResumeLayout(false);
            this.GbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontsize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxMain;
        private System.Windows.Forms.NumericUpDown NudFontsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cbofontFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar PgbDummy;
        private System.Windows.Forms.TrackBar TrbDummy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.Button BtnModalless;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.Button BtnAddRoot;
        private System.Windows.Forms.ListView LsvDummy;
        private System.Windows.Forms.TreeView TrvDummy;
        private System.Windows.Forms.RadioButton RdoIndent;
        private System.Windows.Forms.RadioButton RdoNormal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.PictureBox PcbDummy;
    }
}

