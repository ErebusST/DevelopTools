namespace DataBaseApp
{
    partial class CreateCodeAndView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.btnOpenSelectPath = new System.Windows.Forms.Button();
            this.tbx_CodePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_gongNengMiaoShu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConnStr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbDataBaseType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbDbConnState = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_creater = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_boxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_baoGuDingBuFen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_leiMingCheng = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_tableName = new System.Windows.Forms.TextBox();
            this.tbx_ziDuan = new System.Windows.Forms.TextBox();
            this.tbx_msg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_templateUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbx_templateUrl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbx_tableName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbx_leiMingCheng);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_baoGuDingBuFen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbx_boxName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbx_creater);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnOpenFolder);
            this.panel1.Controls.Add(this.btnExportAll);
            this.panel1.Controls.Add(this.btnOpenSelectPath);
            this.panel1.Controls.Add(this.tbx_CodePath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbx_gongNengMiaoShu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 215);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(331, 153);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(128, 23);
            this.btnOpenFolder.TabIndex = 22;
            this.btnOpenFolder.Text = "打开保存路径文件夹";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(174, 154);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(138, 23);
            this.btnExportAll.TabIndex = 21;
            this.btnExportAll.Text = "生成代码";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnOpenSelectPath
            // 
            this.btnOpenSelectPath.Location = new System.Drawing.Point(394, 118);
            this.btnOpenSelectPath.Name = "btnOpenSelectPath";
            this.btnOpenSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSelectPath.TabIndex = 20;
            this.btnOpenSelectPath.Text = "选择路径";
            this.btnOpenSelectPath.UseVisualStyleBackColor = true;
            this.btnOpenSelectPath.Click += new System.EventHandler(this.btnOpenSelectPath_Click);
            // 
            // tbx_CodePath
            // 
            this.tbx_CodePath.Location = new System.Drawing.Point(72, 118);
            this.tbx_CodePath.Name = "tbx_CodePath";
            this.tbx_CodePath.Size = new System.Drawing.Size(307, 21);
            this.tbx_CodePath.TabIndex = 19;
            this.tbx_CodePath.Text = "F:\\imagesServer\\test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "文件路径";
            // 
            // tbx_gongNengMiaoShu
            // 
            this.tbx_gongNengMiaoShu.Location = new System.Drawing.Point(71, 12);
            this.tbx_gongNengMiaoShu.Name = "tbx_gongNengMiaoShu";
            this.tbx_gongNengMiaoShu.Size = new System.Drawing.Size(172, 21);
            this.tbx_gongNengMiaoShu.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "功能描述";
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbMain.Location = new System.Drawing.Point(0, 320);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(714, 23);
            this.pbMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbx_msg);
            this.panel2.Controls.Add(this.pbMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 343);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbx_ziDuan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 558);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 5;
            // 
            // lbState
            // 
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(131, 17);
            this.lbState.Text = "toolStripStatusLabel6";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // lbConnStr
            // 
            this.lbConnStr.Name = "lbConnStr";
            this.lbConnStr.Size = new System.Drawing.Size(131, 17);
            this.lbConnStr.Text = "toolStripStatusLabel5";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel4.Text = "链接字符串";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lbDataBaseType
            // 
            this.lbDataBaseType.Name = "lbDataBaseType";
            this.lbDataBaseType.Size = new System.Drawing.Size(131, 17);
            this.lbDataBaseType.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "数据库类型";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lbDbConnState
            // 
            this.lbDbConnState.Name = "lbDbConnState";
            this.lbDbConnState.Size = new System.Drawing.Size(131, 17);
            this.lbDbConnState.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDbConnState,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lbDataBaseType,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lbConnStr,
            this.toolStripStatusLabel5,
            this.lbState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1005, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "创建人";
            // 
            // tbx_creater
            // 
            this.tbx_creater.Location = new System.Drawing.Point(295, 12);
            this.tbx_creater.Name = "tbx_creater";
            this.tbx_creater.Size = new System.Drawing.Size(84, 21);
            this.tbx_creater.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "子包名称";
            // 
            // tbx_boxName
            // 
            this.tbx_boxName.Location = new System.Drawing.Point(445, 12);
            this.tbx_boxName.Name = "tbx_boxName";
            this.tbx_boxName.Size = new System.Drawing.Size(96, 21);
            this.tbx_boxName.TabIndex = 31;
            this.tbx_boxName.Text = "background.order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "包固定部分";
            // 
            // tbx_baoGuDingBuFen
            // 
            this.tbx_baoGuDingBuFen.Location = new System.Drawing.Point(615, 12);
            this.tbx_baoGuDingBuFen.Name = "tbx_baoGuDingBuFen";
            this.tbx_baoGuDingBuFen.Size = new System.Drawing.Size(96, 21);
            this.tbx_baoGuDingBuFen.TabIndex = 33;
            this.tbx_baoGuDingBuFen.Text = "com.ndm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "后台类名称";
            // 
            // tbx_leiMingCheng
            // 
            this.tbx_leiMingCheng.Location = new System.Drawing.Point(84, 49);
            this.tbx_leiMingCheng.Name = "tbx_leiMingCheng";
            this.tbx_leiMingCheng.Size = new System.Drawing.Size(172, 21);
            this.tbx_leiMingCheng.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "表名称";
            // 
            // tbx_tableName
            // 
            this.tbx_tableName.Location = new System.Drawing.Point(339, 46);
            this.tbx_tableName.Name = "tbx_tableName";
            this.tbx_tableName.Size = new System.Drawing.Size(172, 21);
            this.tbx_tableName.TabIndex = 37;
            // 
            // tbx_ziDuan
            // 
            this.tbx_ziDuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_ziDuan.Location = new System.Drawing.Point(0, 0);
            this.tbx_ziDuan.Multiline = true;
            this.tbx_ziDuan.Name = "tbx_ziDuan";
            this.tbx_ziDuan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_ziDuan.Size = new System.Drawing.Size(287, 558);
            this.tbx_ziDuan.TabIndex = 2;
            this.tbx_ziDuan.Text = "请把model全部粘贴到这里";
            // 
            // tbx_msg
            // 
            this.tbx_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_msg.Location = new System.Drawing.Point(0, 0);
            this.tbx_msg.Multiline = true;
            this.tbx_msg.Name = "tbx_msg";
            this.tbx_msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_msg.Size = new System.Drawing.Size(714, 320);
            this.tbx_msg.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "清空字段";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_templateUrl
            // 
            this.tbx_templateUrl.Location = new System.Drawing.Point(104, 79);
            this.tbx_templateUrl.Name = "tbx_templateUrl";
            this.tbx_templateUrl.Size = new System.Drawing.Size(172, 21);
            this.tbx_templateUrl.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "前台文件夹名";
            // 
            // CreateCodeAndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 580);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CreateCodeAndView";
            this.Text = "CreateCodeAndView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateBeanForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel lbState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lbConnStr;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbDataBaseType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbDbConnState;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Button btnOpenSelectPath;
        private System.Windows.Forms.TextBox tbx_CodePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_gongNengMiaoShu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_creater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_boxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_baoGuDingBuFen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_leiMingCheng;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_tableName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_ziDuan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_msg;
        private System.Windows.Forms.TextBox tbx_templateUrl;
        private System.Windows.Forms.Label label2;
    }
}