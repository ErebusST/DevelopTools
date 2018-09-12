namespace DataBaseApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mmMenuStrip = new System.Windows.Forms.MenuStrip();
            this.btnBuiderCheckCode = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateBean = new System.Windows.Forms.ToolStripMenuItem();
            this.miSqlFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuilderCheckCode = new System.Windows.Forms.ToolStripMenuItem();
            this.miBuildQuartzConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.miDesTools = new System.Windows.Forms.ToolStripMenuItem();
            this.miBosTools = new System.Windows.Forms.ToolStripMenuItem();
            this.生成前端和后端代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版权所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbWorkType = new System.Windows.Forms.ToolStripStatusLabel();
            this.mmMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmMenuStrip
            // 
            this.mmMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuiderCheckCode,
            this.miSetting,
            this.关于ToolStripMenuItem,
            this.toolStripTextBox1});
            this.mmMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mmMenuStrip.Name = "mmMenuStrip";
            this.mmMenuStrip.Size = new System.Drawing.Size(1267, 27);
            this.mmMenuStrip.TabIndex = 0;
            this.mmMenuStrip.Text = "menuStrip1";
            // 
            // btnBuiderCheckCode
            // 
            this.btnBuiderCheckCode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataBase,
            this.miCreateBean,
            this.miSqlFormat,
            this.btnBuilderCheckCode,
            this.miBuildQuartzConfig,
            this.miDesTools,
            this.miBosTools,
            this.生成前端和后端代码ToolStripMenuItem});
            this.btnBuiderCheckCode.Name = "btnBuiderCheckCode";
            this.btnBuiderCheckCode.Size = new System.Drawing.Size(68, 23);
            this.btnBuiderCheckCode.Text = "工具集合";
            // 
            // miDataBase
            // 
            this.miDataBase.Name = "miDataBase";
            this.miDataBase.Size = new System.Drawing.Size(204, 22);
            this.miDataBase.Text = "生成Insert Update工具";
            this.miDataBase.Click += new System.EventHandler(this.miDataBase_Click);
            // 
            // miCreateBean
            // 
            this.miCreateBean.Name = "miCreateBean";
            this.miCreateBean.Size = new System.Drawing.Size(204, 22);
            this.miCreateBean.Text = "生成实体工具";
            this.miCreateBean.Click += new System.EventHandler(this.miCreateBean_Click);
            // 
            // miSqlFormat
            // 
            this.miSqlFormat.Name = "miSqlFormat";
            this.miSqlFormat.Size = new System.Drawing.Size(204, 22);
            this.miSqlFormat.Text = "Sql格式化工具";
            this.miSqlFormat.Click += new System.EventHandler(this.miSqlFormat_Click);
            // 
            // btnBuilderCheckCode
            // 
            this.btnBuilderCheckCode.Name = "btnBuilderCheckCode";
            this.btnBuilderCheckCode.Size = new System.Drawing.Size(204, 22);
            this.btnBuilderCheckCode.Text = "构建验证代码";
            this.btnBuilderCheckCode.Click += new System.EventHandler(this.btnBuilderCheckCode_Click);
            // 
            // miBuildQuartzConfig
            // 
            this.miBuildQuartzConfig.Name = "miBuildQuartzConfig";
            this.miBuildQuartzConfig.Size = new System.Drawing.Size(204, 22);
            this.miBuildQuartzConfig.Text = "生成Quartz配置";
            this.miBuildQuartzConfig.Click += new System.EventHandler(this.miBuildQuartzConfig_Click);
            // 
            // miDesTools
            // 
            this.miDesTools.Name = "miDesTools";
            this.miDesTools.Size = new System.Drawing.Size(204, 22);
            this.miDesTools.Text = "加密/解密";
            this.miDesTools.Click += new System.EventHandler(this.miDesTools_Click);
            // 
            // miBosTools
            // 
            this.miBosTools.Name = "miBosTools";
            this.miBosTools.Size = new System.Drawing.Size(204, 22);
            this.miBosTools.Text = "Bos工具";
            this.miBosTools.Click += new System.EventHandler(this.miBosTools_Click);
            // 
            // 生成前端和后端代码ToolStripMenuItem
            // 
            this.生成前端和后端代码ToolStripMenuItem.Name = "生成前端和后端代码ToolStripMenuItem";
            this.生成前端和后端代码ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.生成前端和后端代码ToolStripMenuItem.Text = "生成前端和后端代码";
            this.生成前端和后端代码ToolStripMenuItem.Click += new System.EventHandler(this.生成前端和后端代码ToolStripMenuItem_Click);
            // 
            // miSetting
            // 
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(44, 23);
            this.miSetting.Text = "设置";
            this.miSetting.Visible = false;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版权所有ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 版权所有ToolStripMenuItem
            // 
            this.版权所有ToolStripMenuItem.Name = "版权所有ToolStripMenuItem";
            this.版权所有ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.版权所有ToolStripMenuItem.Text = "版权所有";
            this.版权所有ToolStripMenuItem.Click += new System.EventHandler(this.版权所有ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(10, 23);
            this.toolStripTextBox1.Text = "|";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbWorkType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1267, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 21);
            this.toolStripStatusLabel1.Text = "工作类型";
            // 
            // lbWorkType
            // 
            this.lbWorkType.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbWorkType.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.lbWorkType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbWorkType.Image = ((System.Drawing.Image)(resources.GetObject("lbWorkType.Image")));
            this.lbWorkType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbWorkType.Name = "lbWorkType";
            this.lbWorkType.Size = new System.Drawing.Size(170, 21);
            this.lbWorkType.Text = "toolStripDropDownButton1";
            this.lbWorkType.ToolTipText = "点击更改工作类型";
            this.lbWorkType.Click += new System.EventHandler(this.lbWorkType_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DataBaseApp.Properties.Resources.sw1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1267, 703);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mmMenuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mmMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顺为互联开发工具集合";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mmMenuStrip.ResumeLayout(false);
            this.mmMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnBuiderCheckCode;
        private System.Windows.Forms.ToolStripMenuItem miDataBase;
        private System.Windows.Forms.ToolStripMenuItem miSqlFormat;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版权所有ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.ToolStripMenuItem miDesTools;
        private System.Windows.Forms.ToolStripMenuItem miBosTools;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbWorkType;
        private System.Windows.Forms.ToolStripMenuItem miCreateBean;
        private System.Windows.Forms.ToolStripMenuItem btnBuilderCheckCode;
        private System.Windows.Forms.ToolStripMenuItem miBuildQuartzConfig;
        private System.Windows.Forms.ToolStripMenuItem 生成前端和后端代码ToolStripMenuItem;
    }
}