namespace DataBaseApp
{
    partial class BuilderCheckCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuilderCheckCodeForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtEntityName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddField = new System.Windows.Forms.ToolStripButton();
            this.btnAddRangeCheck = new System.Windows.Forms.ToolStripButton();
            this.btnAddPageNumber = new System.Windows.Forms.ToolStripButton();
            this.btnAddPageSize = new System.Windows.Forms.ToolStripButton();
            this.btnAddSearchContent = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteField = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SqlType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckEmpty = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CheckNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CheckRange = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbState = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnCreate,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtEntityName,
            this.toolStripSeparator2,
            this.btnAddField,
            this.btnAddRangeCheck,
            this.btnAddPageNumber,
            this.btnAddPageSize,
            this.btnAddSearchContent,
            this.btnDeleteField});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(63, 22);
            this.btnStart.Text = "初始化(&S)";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(52, 22);
            this.btnCreate.Text = "生成(&C)";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "实体名称";
            // 
            // txtEntityName
            // 
            this.txtEntityName.BackColor = System.Drawing.Color.White;
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(100, 25);
            this.txtEntityName.Text = "findEntity";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddField
            // 
            this.btnAddField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddField.Image = ((System.Drawing.Image)(resources.GetObject("btnAddField.Image")));
            this.btnAddField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(74, 22);
            this.btnAddField.Text = "添加字段(&F)";
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnAddRangeCheck
            // 
            this.btnAddRangeCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddRangeCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRangeCheck.Image")));
            this.btnAddRangeCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRangeCheck.Name = "btnAddRangeCheck";
            this.btnAddRangeCheck.Size = new System.Drawing.Size(100, 22);
            this.btnAddRangeCheck.Text = "添加范围验证(&R)";
            this.btnAddRangeCheck.Click += new System.EventHandler(this.btnAddRangeCheck_Click);
            // 
            // btnAddPageNumber
            // 
            this.btnAddPageNumber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPageNumber.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPageNumber.Image")));
            this.btnAddPageNumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPageNumber.Name = "btnAddPageNumber";
            this.btnAddPageNumber.Size = new System.Drawing.Size(131, 22);
            this.btnAddPageNumber.Text = "添加PageNumber(&N)";
            this.btnAddPageNumber.Click += new System.EventHandler(this.btnAddPageNumber_Click);
            // 
            // btnAddPageSize
            // 
            this.btnAddPageSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPageSize.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPageSize.Image")));
            this.btnAddPageSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPageSize.Name = "btnAddPageSize";
            this.btnAddPageSize.Size = new System.Drawing.Size(103, 22);
            this.btnAddPageSize.Text = "添加PageSize(&Z)";
            this.btnAddPageSize.Click += new System.EventHandler(this.btnAddPageSize_Click);
            // 
            // btnAddSearchContent
            // 
            this.btnAddSearchContent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddSearchContent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSearchContent.Image")));
            this.btnAddSearchContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSearchContent.Name = "btnAddSearchContent";
            this.btnAddSearchContent.Size = new System.Drawing.Size(146, 22);
            this.btnAddSearchContent.Text = "添加SearchContent（&O)";
            this.btnAddSearchContent.Click += new System.EventHandler(this.btnAddSearchContent_Click);
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteField.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteField.Image")));
            this.btnDeleteField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(77, 22);
            this.btnDeleteField.Text = "删除字段(&D)";
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(974, 480);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgMain
            // 
            this.dgMain.AllowUserToAddRows = false;
            this.dgMain.AllowUserToDeleteRows = false;
            this.dgMain.AllowUserToResizeColumns = false;
            this.dgMain.AllowUserToResizeRows = false;
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.Field,
            this.SqlType,
            this.CodeDataType,
            this.CheckEmpty,
            this.CheckNull,
            this.CheckRange});
            this.dgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMain.Location = new System.Drawing.Point(0, 0);
            this.dgMain.MultiSelect = false;
            this.dgMain.Name = "dgMain";
            this.dgMain.ReadOnly = true;
            this.dgMain.RowHeadersVisible = false;
            this.dgMain.RowTemplate.Height = 23;
            this.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMain.Size = new System.Drawing.Size(460, 480);
            this.dgMain.TabIndex = 0;
            this.dgMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMain_CellContentClick);
            this.dgMain.DoubleClick += new System.EventHandler(this.dgMain_DoubleClick);
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            this.NO.HeaderText = "序号";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 40;
            // 
            // Field
            // 
            this.Field.DataPropertyName = "Field";
            this.Field.HeaderText = "字段";
            this.Field.Name = "Field";
            this.Field.ReadOnly = true;
            // 
            // SqlType
            // 
            this.SqlType.DataPropertyName = "SqlDataType";
            this.SqlType.HeaderText = "SqlDataType";
            this.SqlType.Name = "SqlType";
            this.SqlType.ReadOnly = true;
            this.SqlType.Visible = false;
            this.SqlType.Width = 90;
            // 
            // CodeDataType
            // 
            this.CodeDataType.DataPropertyName = "CodeDataType";
            this.CodeDataType.HeaderText = "代码类型";
            this.CodeDataType.Name = "CodeDataType";
            this.CodeDataType.ReadOnly = true;
            this.CodeDataType.Width = 110;
            // 
            // CheckEmpty
            // 
            this.CheckEmpty.DataPropertyName = "CheckEmpty";
            this.CheckEmpty.HeaderText = "验证非空";
            this.CheckEmpty.Name = "CheckEmpty";
            this.CheckEmpty.ReadOnly = true;
            this.CheckEmpty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckEmpty.Width = 60;
            // 
            // CheckNull
            // 
            this.CheckNull.DataPropertyName = "CheckNull";
            this.CheckNull.HeaderText = "验证非Null";
            this.CheckNull.Name = "CheckNull";
            this.CheckNull.ReadOnly = true;
            this.CheckNull.Width = 80;
            // 
            // CheckRange
            // 
            this.CheckRange.DataPropertyName = "CheckRange";
            this.CheckRange.HeaderText = "验证范围";
            this.CheckRange.Name = "CheckRange";
            this.CheckRange.ReadOnly = true;
            this.CheckRange.Width = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 427);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 427);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "验证代码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(496, 395);
            this.txtResult.TabIndex = 0;
            this.txtResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtResult_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtJson);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "调用Json";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtJson
            // 
            this.txtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJson.Location = new System.Drawing.Point(3, 3);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtJson.Size = new System.Drawing.Size(496, 395);
            this.txtJson.TabIndex = 0;
            this.txtJson.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJson_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbState);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.ForeColor = System.Drawing.Color.Red;
            this.lbState.Location = new System.Drawing.Point(18, 18);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(41, 12);
            this.lbState.TabIndex = 1;
            this.lbState.Text = "label1";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(345, 13);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(137, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "复制验证代码(&C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // BuilderCheckCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 505);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuilderCheckCodeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "构建验证代码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuilderCheckCodeForm_FormClosed);
            this.Load += new System.EventHandler(this.BuilderCheckCodeForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtEntityName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddField;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnAddPageNumber;
        private System.Windows.Forms.ToolStripButton btnAddPageSize;
        private System.Windows.Forms.ToolStripButton btnAddSearchContent;
        private System.Windows.Forms.ToolStripButton btnDeleteField;
        private System.Windows.Forms.ToolStripButton btnAddRangeCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn SqlType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeDataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckEmpty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckRange;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtJson;
    }
}