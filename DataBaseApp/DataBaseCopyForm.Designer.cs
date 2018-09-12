namespace DataBaseApp
{
    partial class DataBaseCopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseCopyForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbSourceState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTargetState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.lbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboDataBaseType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radSkip = new System.Windows.Forms.RadioButton();
            this.radCreate = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radClearAndAdd = new System.Windows.Forms.RadioButton();
            this.radUpdateAndAdd = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSourceDataBase = new System.Windows.Forms.ComboBox();
            this.btnConnSource = new System.Windows.Forms.Button();
            this.txtSourcePassWord = new System.Windows.Forms.TextBox();
            this.txtSourceUserName = new System.Windows.Forms.TextBox();
            this.txtSourcePort = new System.Windows.Forms.TextBox();
            this.txtSourceIP = new System.Windows.Forms.TextBox();
            this.txtSourceDataBase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTargetDataBase = new System.Windows.Forms.ComboBox();
            this.btnConnTarget = new System.Windows.Forms.Button();
            this.txtTargetPassWord = new System.Windows.Forms.TextBox();
            this.txtTargetUserName = new System.Windows.Forms.TextBox();
            this.txtTargetPort = new System.Windows.Forms.TextBox();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clbTableInfo = new System.Windows.Forms.CheckedListBox();
            this.lbSeletedInfo = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreateSchemaInTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopySourceToTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyTargetToSource = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSourceState,
            this.toolStripStatusLabel2,
            this.lbTargetState,
            this.toolStripStatusLabel4,
            this.pbMain,
            this.lbState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbSourceState
            // 
            this.lbSourceState.ForeColor = System.Drawing.Color.Red;
            this.lbSourceState.Name = "lbSourceState";
            this.lbSourceState.Size = new System.Drawing.Size(92, 17);
            this.lbSourceState.Text = "源数据库未连接";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lbTargetState
            // 
            this.lbTargetState.ForeColor = System.Drawing.Color.Red;
            this.lbTargetState.Name = "lbTargetState";
            this.lbTargetState.Size = new System.Drawing.Size(104, 17);
            this.lbTargetState.Text = "目标数据库未连接";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // pbMain
            // 
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(400, 16);
            // 
            // lbState
            // 
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(129, 17);
            this.lbState.Text = "共100个表2000条数据";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSeletedInfo);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnClearSelected);
            this.panel3.Controls.Add(this.btnSelectAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(704, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 212);
            this.panel3.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 23);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "开始拷贝(&P)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(6, 117);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(88, 23);
            this.btnClearSelected.TabIndex = 21;
            this.btnClearSelected.Text = "清空所选(&C)";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(6, 77);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(88, 23);
            this.btnSelectAll.TabIndex = 20;
            this.btnSelectAll.Text = "选择全部(&S)";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboDataBaseType,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "数据库类型";
            // 
            // cboDataBaseType
            // 
            this.cboDataBaseType.Name = "cboDataBaseType";
            this.cboDataBaseType.Size = new System.Drawing.Size(121, 25);
            this.cboDataBaseType.SelectedIndexChanged += new System.EventHandler(this.cboDataBaseType_SelectedIndexChanged);
            this.cboDataBaseType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combox_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 93);
            this.panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radSkip);
            this.groupBox3.Controls.Add(this.radCreate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(226, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "拷贝策略";
            // 
            // radSkip
            // 
            this.radSkip.AutoSize = true;
            this.radSkip.Location = new System.Drawing.Point(320, 20);
            this.radSkip.Name = "radSkip";
            this.radSkip.Size = new System.Drawing.Size(107, 16);
            this.radSkip.TabIndex = 17;
            this.radSkip.Text = "跳过不存在的表";
            this.radSkip.UseVisualStyleBackColor = true;
            // 
            // radCreate
            // 
            this.radCreate.AutoSize = true;
            this.radCreate.Checked = true;
            this.radCreate.Location = new System.Drawing.Point(67, 20);
            this.radCreate.Name = "radCreate";
            this.radCreate.Size = new System.Drawing.Size(107, 16);
            this.radCreate.TabIndex = 16;
            this.radCreate.TabStop = true;
            this.radCreate.Text = "创建不存在的表";
            this.radCreate.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 50);
            this.panel4.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSearchContent);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(226, 50);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "表名筛选";
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchContent.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchContent.Location = new System.Drawing.Point(3, 17);
            this.txtSearchContent.Multiline = true;
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(220, 30);
            this.txtSearchContent.TabIndex = 18;
            this.txtSearchContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchContent_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radAdd);
            this.groupBox4.Controls.Add(this.radClearAndAdd);
            this.groupBox4.Controls.Add(this.radUpdateAndAdd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(809, 43);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "目标库中不存在所选表时策略";
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(267, 20);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(167, 16);
            this.radAdd.TabIndex = 14;
            this.radAdd.Text = "将新数据追加到源数据库中";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // radClearAndAdd
            // 
            this.radClearAndAdd.AutoSize = true;
            this.radClearAndAdd.Checked = true;
            this.radClearAndAdd.Location = new System.Drawing.Point(12, 20);
            this.radClearAndAdd.Name = "radClearAndAdd";
            this.radClearAndAdd.Size = new System.Drawing.Size(167, 16);
            this.radClearAndAdd.TabIndex = 13;
            this.radClearAndAdd.TabStop = true;
            this.radClearAndAdd.Text = "清空源数据库并填入新数据";
            this.radClearAndAdd.UseVisualStyleBackColor = true;
            // 
            // radUpdateAndAdd
            // 
            this.radUpdateAndAdd.AutoSize = true;
            this.radUpdateAndAdd.Location = new System.Drawing.Point(520, 20);
            this.radUpdateAndAdd.Name = "radUpdateAndAdd";
            this.radUpdateAndAdd.Size = new System.Drawing.Size(203, 16);
            this.radUpdateAndAdd.TabIndex = 15;
            this.radUpdateAndAdd.Text = "交叉比对更新旧数据并填入新数据";
            this.radUpdateAndAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSourceDataBase);
            this.groupBox1.Controls.Add(this.btnConnSource);
            this.groupBox1.Controls.Add(this.txtSourcePassWord);
            this.groupBox1.Controls.Add(this.txtSourceUserName);
            this.groupBox1.Controls.Add(this.txtSourcePort);
            this.groupBox1.Controls.Add(this.txtSourceIP);
            this.groupBox1.Controls.Add(this.txtSourceDataBase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "源数据库";
            // 
            // cboSourceDataBase
            // 
            this.cboSourceDataBase.FormattingEnabled = true;
            this.cboSourceDataBase.Location = new System.Drawing.Point(60, 74);
            this.cboSourceDataBase.Name = "cboSourceDataBase";
            this.cboSourceDataBase.Size = new System.Drawing.Size(135, 20);
            this.cboSourceDataBase.TabIndex = 7;
            this.cboSourceDataBase.SelectedIndexChanged += new System.EventHandler(this.cboSourceDataBase_SelectedIndexChanged);
            this.cboSourceDataBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combox_KeyPress);
            // 
            // btnConnSource
            // 
            this.btnConnSource.Location = new System.Drawing.Point(241, 72);
            this.btnConnSource.Name = "btnConnSource";
            this.btnConnSource.Size = new System.Drawing.Size(75, 23);
            this.btnConnSource.TabIndex = 6;
            this.btnConnSource.Text = "连接(&A)";
            this.btnConnSource.UseVisualStyleBackColor = true;
            this.btnConnSource.Click += new System.EventHandler(this.btnConnSource_Click);
            // 
            // txtSourcePassWord
            // 
            this.txtSourcePassWord.Location = new System.Drawing.Point(241, 46);
            this.txtSourcePassWord.Name = "txtSourcePassWord";
            this.txtSourcePassWord.Size = new System.Drawing.Size(135, 21);
            this.txtSourcePassWord.TabIndex = 4;
            // 
            // txtSourceUserName
            // 
            this.txtSourceUserName.Location = new System.Drawing.Point(60, 46);
            this.txtSourceUserName.Name = "txtSourceUserName";
            this.txtSourceUserName.Size = new System.Drawing.Size(135, 21);
            this.txtSourceUserName.TabIndex = 3;
            // 
            // txtSourcePort
            // 
            this.txtSourcePort.Location = new System.Drawing.Point(241, 18);
            this.txtSourcePort.Name = "txtSourcePort";
            this.txtSourcePort.Size = new System.Drawing.Size(135, 21);
            this.txtSourcePort.TabIndex = 2;
            // 
            // txtSourceIP
            // 
            this.txtSourceIP.Location = new System.Drawing.Point(60, 18);
            this.txtSourceIP.Name = "txtSourceIP";
            this.txtSourceIP.Size = new System.Drawing.Size(135, 21);
            this.txtSourceIP.TabIndex = 1;
            // 
            // txtSourceDataBase
            // 
            this.txtSourceDataBase.AutoSize = true;
            this.txtSourceDataBase.Location = new System.Drawing.Point(6, 77);
            this.txtSourceDataBase.Name = "txtSourceDataBase";
            this.txtSourceDataBase.Size = new System.Drawing.Size(41, 12);
            this.txtSourceDataBase.TabIndex = 4;
            this.txtSourceDataBase.Text = "数据库";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTargetDataBase);
            this.groupBox2.Controls.Add(this.btnConnTarget);
            this.groupBox2.Controls.Add(this.txtTargetPassWord);
            this.groupBox2.Controls.Add(this.txtTargetUserName);
            this.groupBox2.Controls.Add(this.txtTargetPort);
            this.groupBox2.Controls.Add(this.txtTargetIP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(400, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目标数据库";
            // 
            // cboTargetDataBase
            // 
            this.cboTargetDataBase.FormattingEnabled = true;
            this.cboTargetDataBase.Location = new System.Drawing.Point(74, 74);
            this.cboTargetDataBase.Name = "cboTargetDataBase";
            this.cboTargetDataBase.Size = new System.Drawing.Size(135, 20);
            this.cboTargetDataBase.TabIndex = 16;
            this.cboTargetDataBase.SelectedIndexChanged += new System.EventHandler(this.cboTargetDataBase_SelectedIndexChanged);
            this.cboTargetDataBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combox_KeyPress);
            // 
            // btnConnTarget
            // 
            this.btnConnTarget.Location = new System.Drawing.Point(257, 72);
            this.btnConnTarget.Name = "btnConnTarget";
            this.btnConnTarget.Size = new System.Drawing.Size(75, 23);
            this.btnConnTarget.TabIndex = 12;
            this.btnConnTarget.Text = "连接(&B)";
            this.btnConnTarget.UseVisualStyleBackColor = true;
            this.btnConnTarget.Click += new System.EventHandler(this.btnConnTarget_Click);
            // 
            // txtTargetPassWord
            // 
            this.txtTargetPassWord.Location = new System.Drawing.Point(257, 46);
            this.txtTargetPassWord.Name = "txtTargetPassWord";
            this.txtTargetPassWord.Size = new System.Drawing.Size(135, 21);
            this.txtTargetPassWord.TabIndex = 10;
            // 
            // txtTargetUserName
            // 
            this.txtTargetUserName.Location = new System.Drawing.Point(74, 46);
            this.txtTargetUserName.Name = "txtTargetUserName";
            this.txtTargetUserName.Size = new System.Drawing.Size(135, 21);
            this.txtTargetUserName.TabIndex = 9;
            // 
            // txtTargetPort
            // 
            this.txtTargetPort.Location = new System.Drawing.Point(257, 18);
            this.txtTargetPort.Name = "txtTargetPort";
            this.txtTargetPort.Size = new System.Drawing.Size(135, 21);
            this.txtTargetPort.TabIndex = 8;
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.Location = new System.Drawing.Point(74, 18);
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(135, 21);
            this.txtTargetIP.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "数据库";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "密码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "用户名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "端口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "IP地址";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 200);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clbTableInfo);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(704, 212);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "源数据库表信息";
            // 
            // clbTableInfo
            // 
            this.clbTableInfo.CheckOnClick = true;
            this.clbTableInfo.ColumnWidth = 200;
            this.clbTableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTableInfo.FormattingEnabled = true;
            this.clbTableInfo.Location = new System.Drawing.Point(3, 17);
            this.clbTableInfo.MultiColumn = true;
            this.clbTableInfo.Name = "clbTableInfo";
            this.clbTableInfo.Size = new System.Drawing.Size(698, 192);
            this.clbTableInfo.Sorted = true;
            this.clbTableInfo.TabIndex = 19;
            this.clbTableInfo.SelectedValueChanged += new System.EventHandler(this.clbTableInfo_SelectedValueChanged);
            // 
            // lbSeletedInfo
            // 
            this.lbSeletedInfo.AutoSize = true;
            this.lbSeletedInfo.Location = new System.Drawing.Point(6, 30);
            this.lbSeletedInfo.Name = "lbSeletedInfo";
            this.lbSeletedInfo.Size = new System.Drawing.Size(41, 12);
            this.lbSeletedInfo.TabIndex = 23;
            this.lbSeletedInfo.Text = "label5";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateSchemaInTarget,
            this.btnCopySourceToTarget,
            this.btnCopyTargetToSource});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton1.Text = "数据源操作";
            // 
            // btnCreateSchemaInTarget
            // 
            this.btnCreateSchemaInTarget.Name = "btnCreateSchemaInTarget";
            this.btnCreateSchemaInTarget.Size = new System.Drawing.Size(260, 22);
            this.btnCreateSchemaInTarget.Text = "在目标库中创建新Schema";
            // 
            // btnCopySourceToTarget
            // 
            this.btnCopySourceToTarget.Name = "btnCopySourceToTarget";
            this.btnCopySourceToTarget.Size = new System.Drawing.Size(260, 22);
            this.btnCopySourceToTarget.Text = "复制源数据库配置到目标数据库(&R)";
            this.btnCopySourceToTarget.Click += new System.EventHandler(this.btnCopySourceToTarget_Click);
            // 
            // btnCopyTargetToSource
            // 
            this.btnCopyTargetToSource.Name = "btnCopyTargetToSource";
            this.btnCopyTargetToSource.Size = new System.Drawing.Size(260, 22);
            this.btnCopyTargetToSource.Text = "复制目标数据库配置到源数据库(&L)";
            this.btnCopyTargetToSource.Click += new System.EventHandler(this.btnCopyTargetToSource_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // DataBaseCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 459);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DataBaseCopyForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库数据拷贝工具";
            this.Load += new System.EventHandler(this.DataBaseCopyForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbSourceState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbTargetState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar pbMain;
        private System.Windows.Forms.ToolStripStatusLabel lbState;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radSkip;
        private System.Windows.Forms.RadioButton radCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radClearAndAdd;
        private System.Windows.Forms.RadioButton radUpdateAndAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnSource;
        private System.Windows.Forms.TextBox txtSourcePassWord;
        private System.Windows.Forms.TextBox txtSourceUserName;
        private System.Windows.Forms.TextBox txtSourcePort;
        private System.Windows.Forms.TextBox txtSourceIP;
        private System.Windows.Forms.Label txtSourceDataBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnTarget;
        private System.Windows.Forms.TextBox txtTargetPassWord;
        private System.Windows.Forms.TextBox txtTargetUserName;
        private System.Windows.Forms.TextBox txtTargetPort;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox clbTableInfo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboDataBaseType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cboSourceDataBase;
        private System.Windows.Forms.ComboBox cboTargetDataBase;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnCopySourceToTarget;
        private System.Windows.Forms.ToolStripMenuItem btnCopyTargetToSource;
        private System.Windows.Forms.ToolStripMenuItem btnCreateSchemaInTarget;
        private System.Windows.Forms.Label lbSeletedInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}