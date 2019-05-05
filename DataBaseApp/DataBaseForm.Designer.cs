namespace DataBaseApp
{
    partial class DataBaseForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbDbConnState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConnStr = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip12 = new System.Windows.Forms.MenuStrip();
            this.miConnectionDB = new System.Windows.Forms.ToolStripMenuItem();
            this.cboDataBase = new System.Windows.Forms.ToolStripComboBox();
            this.btnExcludedField = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtInsert = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUpdate = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.radHibernate = new System.Windows.Forms.RadioButton();
            this.radMybatis = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDbConnState,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.lbConnStr,
            this.toolStripStatusLabel3,
            this.lbState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1094);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2028, 38);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbDbConnState
            // 
            this.lbDbConnState.ForeColor = System.Drawing.Color.Lime;
            this.lbDbConnState.Name = "lbDbConnState";
            this.lbDbConnState.Size = new System.Drawing.Size(257, 33);
            this.lbDbConnState.Text = "toolStripStatusLabel5";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(20, 33);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(134, 33);
            this.toolStripStatusLabel2.Text = "链接字符串";
            // 
            // lbConnStr
            // 
            this.lbConnStr.Name = "lbConnStr";
            this.lbConnStr.Size = new System.Drawing.Size(257, 33);
            this.lbConnStr.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(20, 33);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lbState
            // 
            this.lbState.ForeColor = System.Drawing.Color.Red;
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(257, 33);
            this.lbState.Text = "toolStripStatusLabel4";
            // 
            // menuStrip12
            // 
            this.menuStrip12.AllowMerge = false;
            this.menuStrip12.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip12.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConnectionDB,
            this.cboDataBase,
            this.btnExcludedField});
            this.menuStrip12.Location = new System.Drawing.Point(0, 0);
            this.menuStrip12.Name = "menuStrip12";
            this.menuStrip12.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip12.Size = new System.Drawing.Size(2028, 47);
            this.menuStrip12.TabIndex = 1;
            this.menuStrip12.Text = "menuStrip1";
            // 
            // miConnectionDB
            // 
            this.miConnectionDB.Name = "miConnectionDB";
            this.miConnectionDB.Size = new System.Drawing.Size(178, 39);
            this.miConnectionDB.Text = "连接数据库(&C)";
            this.miConnectionDB.Click += new System.EventHandler(this.miConnectionDB_Click);
            // 
            // cboDataBase
            // 
            this.cboDataBase.Name = "cboDataBase";
            this.cboDataBase.Size = new System.Drawing.Size(238, 39);
            this.cboDataBase.SelectedIndexChanged += new System.EventHandler(this.cboDataBase_SelectedIndexChanged);
            this.cboDataBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDataBase_KeyPress);
            // 
            // btnExcludedField
            // 
            this.btnExcludedField.Name = "btnExcludedField";
            this.btnExcludedField.Size = new System.Drawing.Size(170, 39);
            this.btnExcludedField.Text = "设置排除字段";
            this.btnExcludedField.Click += new System.EventHandler(this.btnExcludedField_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
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
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(2028, 1047);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Location = new System.Drawing.Point(0, 35);
            this.tvMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tvMain.Name = "tvMain";
            this.tvMain.Size = new System.Drawing.Size(466, 1012);
            this.tvMain.TabIndex = 3;
            this.tvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMain_AfterSelect);
            // 
            // txtSelect
            // 
            this.txtSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSelect.Location = new System.Drawing.Point(0, 0);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(466, 35);
            this.txtSelect.TabIndex = 2;
            this.txtSelect.TextChanged += new System.EventHandler(this.txtSelect_TextChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1554, 973);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtInsert);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1538, 926);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert方法";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtInsert
            // 
            this.txtInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInsert.Location = new System.Drawing.Point(6, 6);
            this.txtInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInsert.Size = new System.Drawing.Size(1526, 914);
            this.txtInsert.TabIndex = 3;
            this.txtInsert.Text = "";
            this.txtInsert.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInsert_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUpdate);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1538, 907);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update方法";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdate.Location = new System.Drawing.Point(6, 6);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtUpdate.Size = new System.Drawing.Size(1526, 895);
            this.txtUpdate.TabIndex = 5;
            this.txtUpdate.Text = "";
            this.txtUpdate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUpdate_KeyUp);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtJson);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Size = new System.Drawing.Size(1538, 907);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JSON";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(6, 6);
            this.txtJson.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(1526, 895);
            this.txtJson.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 973);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1160, 10);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(310, 46);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "复制全部Insert语句(&C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // radHibernate
            // 
            this.radHibernate.AutoSize = true;
            this.radHibernate.Checked = true;
            this.radHibernate.Location = new System.Drawing.Point(640, 14);
            this.radHibernate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radHibernate.Name = "radHibernate";
            this.radHibernate.Size = new System.Drawing.Size(149, 28);
            this.radHibernate.TabIndex = 3;
            this.radHibernate.TabStop = true;
            this.radHibernate.Text = "Hibernate";
            this.radHibernate.UseVisualStyleBackColor = true;
            this.radHibernate.CheckedChanged += new System.EventHandler(this.radHibernate_CheckedChanged);
            // 
            // radMybatis
            // 
            this.radMybatis.AutoSize = true;
            this.radMybatis.Location = new System.Drawing.Point(842, 14);
            this.radMybatis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radMybatis.Name = "radMybatis";
            this.radMybatis.Size = new System.Drawing.Size(125, 28);
            this.radMybatis.TabIndex = 4;
            this.radMybatis.TabStop = true;
            this.radMybatis.Text = "MyBatis";
            this.radMybatis.UseVisualStyleBackColor = true;
            this.radMybatis.CheckedChanged += new System.EventHandler(this.radMybatis_CheckedChanged);
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2028, 1132);
            this.Controls.Add(this.radMybatis);
            this.Controls.Add(this.radHibernate);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip12;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "DataBaseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成Insert&Update工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataBaseForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip12.ResumeLayout(false);
            this.menuStrip12.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip12;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolStripComboBox cboDataBase;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbConnStr;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.RichTextBox txtInsert;
        private System.Windows.Forms.RichTextBox txtUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbState;
        private System.Windows.Forms.ToolStripMenuItem miConnectionDB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbDbConnState;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.ToolStripMenuItem btnExcludedField;
        private System.Windows.Forms.RadioButton radHibernate;
        private System.Windows.Forms.RadioButton radMybatis;
    }
}