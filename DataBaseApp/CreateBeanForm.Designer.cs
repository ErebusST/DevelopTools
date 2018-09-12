namespace DataBaseApp
{
    partial class CreateBeanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBeanForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbDbConnState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConnStr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConnectionDB = new System.Windows.Forms.ToolStripButton();
            this.cboDataBase = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.raMybatis = new System.Windows.Forms.RadioButton();
            this.raHibernate = new System.Windows.Forms.RadioButton();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOpenFieldSetting = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.btnOpenSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDbConnState,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.lbConnStr,
            this.toolStripStatusLabel5,
            this.lbState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1076);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2084, 38);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbDbConnState
            // 
            this.lbDbConnState.Name = "lbDbConnState";
            this.lbDbConnState.Size = new System.Drawing.Size(257, 33);
            this.lbDbConnState.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 33);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(134, 33);
            this.toolStripStatusLabel4.Text = "链接字符串";
            // 
            // lbConnStr
            // 
            this.lbConnStr.Name = "lbConnStr";
            this.lbConnStr.Size = new System.Drawing.Size(257, 33);
            this.lbConnStr.Text = "toolStripStatusLabel5";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(20, 33);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // lbState
            // 
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(257, 33);
            this.lbState.Text = "toolStripStatusLabel6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnectionDB,
            this.cboDataBase,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2084, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConnectionDB
            // 
            this.btnConnectionDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnectionDB.Image = ((System.Drawing.Image)(resources.GetObject("btnConnectionDB.Image")));
            this.btnConnectionDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnectionDB.Name = "btnConnectionDB";
            this.btnConnectionDB.Size = new System.Drawing.Size(138, 36);
            this.btnConnectionDB.Text = "连接数据库";
            this.btnConnectionDB.Click += new System.EventHandler(this.btnConnectionDB_Click);
            // 
            // cboDataBase
            // 
            this.cboDataBase.Name = "cboDataBase";
            this.cboDataBase.Size = new System.Drawing.Size(238, 39);
            this.cboDataBase.SelectedIndexChanged += new System.EventHandler(this.cboDataBase_SelectedIndexChanged);
            this.cboDataBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDataBase_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvMain);
            this.splitContainer1.Panel1.Controls.Add(this.txtSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(2084, 1037);
            this.splitContainer1.SplitterDistance = 596;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvMain
            // 
            this.tvMain.CheckBoxes = true;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Location = new System.Drawing.Point(0, 35);
            this.tvMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvMain.Name = "tvMain";
            this.tvMain.Size = new System.Drawing.Size(596, 1002);
            this.tvMain.TabIndex = 4;
            this.tvMain.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterCheck);
            // 
            // txtSelect
            // 
            this.txtSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSelect.Location = new System.Drawing.Point(0, 0);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(596, 35);
            this.txtSelect.TabIndex = 3;
            this.txtSelect.TextChanged += new System.EventHandler(this.txtSelect_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Controls.Add(this.pbMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1480, 877);
            this.panel2.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1480, 831);
            this.txtLog.TabIndex = 1;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbMain.Location = new System.Drawing.Point(0, 831);
            this.pbMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1480, 46);
            this.pbMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.raMybatis);
            this.panel1.Controls.Add(this.raHibernate);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnOpenFieldSetting);
            this.panel1.Controls.Add(this.btnOpenFolder);
            this.panel1.Controls.Add(this.btnExportAll);
            this.panel1.Controls.Add(this.btnOpenSelectPath);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSuffix);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrefix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 160);
            this.panel1.TabIndex = 0;
            // 
            // raMybatis
            // 
            this.raMybatis.AutoSize = true;
            this.raMybatis.Location = new System.Drawing.Point(42, 116);
            this.raMybatis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.raMybatis.Name = "raMybatis";
            this.raMybatis.Size = new System.Drawing.Size(173, 28);
            this.raMybatis.TabIndex = 14;
            this.raMybatis.Text = "For Mybatis";
            this.raMybatis.UseVisualStyleBackColor = true;
            this.raMybatis.CheckedChanged += new System.EventHandler(this.raMybatis_CheckedChanged);
            // 
            // raHibernate
            // 
            this.raHibernate.AutoSize = true;
            this.raHibernate.Checked = true;
            this.raHibernate.Location = new System.Drawing.Point(42, 74);
            this.raHibernate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.raHibernate.Name = "raHibernate";
            this.raHibernate.Size = new System.Drawing.Size(197, 28);
            this.raHibernate.TabIndex = 13;
            this.raHibernate.TabStop = true;
            this.raHibernate.Text = "For Hibernate";
            this.raHibernate.UseVisualStyleBackColor = true;
            this.raHibernate.CheckedChanged += new System.EventHandler(this.raHibernate_CheckedChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1198, 90);
            this.btnReload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(256, 46);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "重新加载配置文件";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOpenFieldSetting
            // 
            this.btnOpenFieldSetting.Location = new System.Drawing.Point(800, 90);
            this.btnOpenFieldSetting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenFieldSetting.Name = "btnOpenFieldSetting";
            this.btnOpenFieldSetting.Size = new System.Drawing.Size(386, 46);
            this.btnOpenFieldSetting.TabIndex = 11;
            this.btnOpenFieldSetting.Text = "打开数据库类型映射配置文件";
            this.btnOpenFieldSetting.UseVisualStyleBackColor = true;
            this.btnOpenFieldSetting.Click += new System.EventHandler(this.btnOpenFieldSetting_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(532, 90);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(256, 46);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "打开保存路径文件夹";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(244, 90);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(276, 46);
            this.btnExportAll.TabIndex = 9;
            this.btnExportAll.Text = "生成JavaBean";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnOpenSelectPath
            // 
            this.btnOpenSelectPath.Location = new System.Drawing.Point(1262, 16);
            this.btnOpenSelectPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenSelectPath.Name = "btnOpenSelectPath";
            this.btnOpenSelectPath.Size = new System.Drawing.Size(150, 46);
            this.btnOpenSelectPath.TabIndex = 6;
            this.btnOpenSelectPath.Text = "选择路径";
            this.btnOpenSelectPath.UseVisualStyleBackColor = true;
            this.btnOpenSelectPath.Click += new System.EventHandler(this.btnOpenSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(636, 20);
            this.txtPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(610, 35);
            this.txtPath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "保存路径";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(338, 20);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(164, 35);
            this.txtSuffix.TabIndex = 3;
            this.txtSuffix.Text = "Entity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "后缀";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(88, 20);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(164, 35);
            this.txtPrefix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "前缀";
            // 
            // CreateBeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2084, 1114);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "CreateBeanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成JavaBean";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateBeanForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateBeanForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnConnectionDB;
        private System.Windows.Forms.ToolStripComboBox cboDataBase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lbDbConnState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbConnStr;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lbState;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnOpenFieldSetting;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.RadioButton raMybatis;
        private System.Windows.Forms.RadioButton raHibernate;
    }
}