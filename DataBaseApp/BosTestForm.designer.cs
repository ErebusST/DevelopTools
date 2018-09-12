namespace CreateProject
{
    partial class BosTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BosTestForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.ObjName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btbBack = new System.Windows.Forms.ToolStripButton();
            this.txtRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btn_Cut = new System.Windows.Forms.ToolStripButton();
            this.txtCutPath = new System.Windows.Forms.ToolStripTextBox();
            this.btnCreateFolder = new System.Windows.Forms.ToolStripButton();
            this.txtFolderName = new System.Windows.Forms.ToolStripTextBox();
            this.btnDownload = new System.Windows.Forms.ToolStripButton();
            this.ddSelectBucket = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbSelectedBucket = new System.Windows.Forms.ToolStripLabel();
            this.btnDownload1 = new System.Windows.Forms.ToolStripButton();
            this.btn_ClearMuPartsInfo = new System.Windows.Forms.ToolStripButton();
            this.btnOpenText = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvData);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            this.gvData.AllowUserToOrderColumns = true;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjName,
            this.Size,
            this.Date,
            this.ObjType,
            this.KEY,
            this.s2});
            this.gvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvData.Location = new System.Drawing.Point(3, 42);
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.RowHeadersVisible = false;
            this.gvData.RowTemplate.Height = 23;
            this.gvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(1042, 451);
            this.gvData.TabIndex = 3;
            this.gvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellContentDoubleClick);
            this.gvData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvData_RowsAdded);
            // 
            // ObjName
            // 
            this.ObjName.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ObjName.DataPropertyName = "ObjName";
            this.ObjName.HeaderText = "文件名";
            this.ObjName.Name = "ObjName";
            this.ObjName.ReadOnly = true;
            this.ObjName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ObjName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ObjName.Width = 200;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "大小";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "时间";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ObjType
            // 
            this.ObjType.DataPropertyName = "ObjType";
            this.ObjType.HeaderText = "ObjType";
            this.ObjType.Name = "ObjType";
            this.ObjType.ReadOnly = true;
            // 
            // KEY
            // 
            this.KEY.DataPropertyName = "KEY";
            this.KEY.HeaderText = "KEY";
            this.KEY.Name = "KEY";
            this.KEY.ReadOnly = true;
            // 
            // s2
            // 
            this.s2.DataPropertyName = "s2";
            this.s2.HeaderText = "s2";
            this.s2.Name = "s2";
            this.s2.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btbBack,
            this.txtRefresh,
            this.toolStripSeparator1,
            this.btnUpload,
            this.btnDelete,
            this.btnCopy,
            this.btn_Cut,
            this.txtCutPath,
            this.btnCreateFolder,
            this.txtFolderName,
            this.btnDownload,
            this.ddSelectBucket,
            this.toolStripSeparator2,
            this.lbSelectedBucket,
            this.btnDownload1,
            this.btn_ClearMuPartsInfo,
            this.btnOpenText});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1042, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btbBack
            // 
            this.btbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btbBack.Image = ((System.Drawing.Image)(resources.GetObject("btbBack.Image")));
            this.btbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btbBack.Name = "btbBack";
            this.btbBack.Size = new System.Drawing.Size(52, 22);
            this.btbBack.Text = "向上(&B)";
            this.btbBack.Click += new System.EventHandler(this.btbBack_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtRefresh.Image = ((System.Drawing.Image)(resources.GetObject("txtRefresh.Image")));
            this.txtRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(52, 22);
            this.txtRefresh.Text = "刷新(&R)";
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(53, 22);
            this.btnUpload.Text = "上传(&U)";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 22);
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(51, 22);
            this.btnCopy.Text = "复制(&P)";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btn_Cut
            // 
            this.btn_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Cut.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cut.Image")));
            this.btn_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cut.Name = "btn_Cut";
            this.btn_Cut.Size = new System.Drawing.Size(52, 22);
            this.btn_Cut.Text = "剪切(&X)";
            this.btn_Cut.Click += new System.EventHandler(this.btn_Cut_Click);
            // 
            // txtCutPath
            // 
            this.txtCutPath.Name = "txtCutPath";
            this.txtCutPath.Size = new System.Drawing.Size(100, 25);
            this.txtCutPath.Text = "20160122001/uploadFiles/";
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateFolder.Image")));
            this.btnCreateFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(88, 22);
            this.btnCreateFolder.Text = "新建文件夹(&C)";
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(100, 25);
            this.txtFolderName.Visible = false;
            this.txtFolderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolderName_KeyPress);
            // 
            // btnDownload
            // 
            this.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(53, 22);
            this.btnDownload.Text = "下载(&D)";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ddSelectBucket
            // 
            this.ddSelectBucket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddSelectBucket.Image = ((System.Drawing.Image)(resources.GetObject("ddSelectBucket.Image")));
            this.ddSelectBucket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddSelectBucket.Name = "ddSelectBucket";
            this.ddSelectBucket.Size = new System.Drawing.Size(84, 22);
            this.ddSelectBucket.Text = "选择bucket";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbSelectedBucket
            // 
            this.lbSelectedBucket.Name = "lbSelectedBucket";
            this.lbSelectedBucket.Size = new System.Drawing.Size(96, 22);
            this.lbSelectedBucket.Text = "toolStripLabel1";
            // 
            // btnDownload1
            // 
            this.btnDownload1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDownload1.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload1.Image")));
            this.btnDownload1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload1.Name = "btnDownload1";
            this.btnDownload1.Size = new System.Drawing.Size(36, 22);
            this.btnDownload1.Text = "下载";
            this.btnDownload1.Click += new System.EventHandler(this.btnDownload1_Click);
            // 
            // btn_ClearMuPartsInfo
            // 
            this.btn_ClearMuPartsInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ClearMuPartsInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearMuPartsInfo.Image")));
            this.btn_ClearMuPartsInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ClearMuPartsInfo.Name = "btn_ClearMuPartsInfo";
            this.btn_ClearMuPartsInfo.Size = new System.Drawing.Size(120, 22);
            this.btn_ClearMuPartsInfo.Text = "清空所有分片上传块";
            this.btn_ClearMuPartsInfo.Click += new System.EventHandler(this.btn_ClearMuPartsInfo_Click);
            // 
            // btnOpenText
            // 
            this.btnOpenText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenText.Image")));
            this.btnOpenText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenText.Name = "btnOpenText";
            this.btnOpenText.Size = new System.Drawing.Size(78, 22);
            this.btnOpenText.Text = "打开文本(&O)";
            this.btnOpenText.Click += new System.EventHandler(this.btnOpenText_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前路径：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbPath,
            this.pbProcess,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1048, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbPath
            // 
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(131, 17);
            this.lbPath.Text = "toolStripStatusLabel2";
            // 
            // pbProcess
            // 
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // BosTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "BosTestForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Bos工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BosTestForm_FormClosing);
            this.Load += new System.EventHandler(this.BosTestForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnCreateFolder;
        private System.Windows.Forms.ToolStripButton btnDownload;
        private System.Windows.Forms.ToolStripButton btbBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton ddSelectBucket;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbSelectedBucket;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.ToolStripStatusLabel lbPath;
        private System.Windows.Forms.ToolStripButton btnOpenText;
        private System.Windows.Forms.ToolStripProgressBar pbProcess;
        private System.Windows.Forms.ToolStripTextBox txtFolderName;
        private System.Windows.Forms.ToolStripButton btn_ClearMuPartsInfo;
        private System.Windows.Forms.ToolStripButton btnDownload1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripButton btn_Cut;
        private System.Windows.Forms.ToolStripTextBox txtCutPath;
        private System.Windows.Forms.DataGridViewLinkColumn ObjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjType;
        private System.Windows.Forms.DataGridViewTextBoxColumn KEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton txtRefresh;
    }
}