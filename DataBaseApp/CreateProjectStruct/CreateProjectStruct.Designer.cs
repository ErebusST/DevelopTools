namespace DataBaseApp
{
    partial class CreateProjectStruct
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.chkApi = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtWebPath = new System.Windows.Forms.TextBox();
            this.txtApiPath = new System.Windows.Forms.TextBox();
            this.保存路径 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "构建模板路径";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(110, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(416, 25);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(535, 15);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(12, 54);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(89, 19);
            this.chkWeb.TabIndex = 3;
            this.chkWeb.Text = "构建前端";
            this.chkWeb.UseVisualStyleBackColor = true;
            // 
            // chkApi
            // 
            this.chkApi.AutoSize = true;
            this.chkApi.Location = new System.Drawing.Point(359, 57);
            this.chkApi.Name = "chkApi";
            this.chkApi.Size = new System.Drawing.Size(89, 19);
            this.chkApi.TabIndex = 4;
            this.chkApi.Text = "构建后端";
            this.chkApi.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(620, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始构建";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 131);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(674, 298);
            this.textBox2.TabIndex = 6;
            // 
            // txtWebPath
            // 
            this.txtWebPath.Location = new System.Drawing.Point(112, 54);
            this.txtWebPath.Name = "txtWebPath";
            this.txtWebPath.Size = new System.Drawing.Size(236, 25);
            this.txtWebPath.TabIndex = 7;
            // 
            // txtApiPath
            // 
            this.txtApiPath.Location = new System.Drawing.Point(459, 54);
            this.txtApiPath.Name = "txtApiPath";
            this.txtApiPath.Size = new System.Drawing.Size(236, 25);
            this.txtApiPath.TabIndex = 8;
            // 
            // 保存路径
            // 
            this.保存路径.AutoSize = true;
            this.保存路径.Location = new System.Drawing.Point(34, 92);
            this.保存路径.Name = "保存路径";
            this.保存路径.Size = new System.Drawing.Size(67, 15);
            this.保存路径.TabIndex = 9;
            this.保存路径.Text = "保存路径";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(111, 90);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(414, 25);
            this.txtSavePath.TabIndex = 10;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(620, 88);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPath.TabIndex = 11;
            this.btnOpenPath.Text = "打开路径";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.Location = new System.Drawing.Point(535, 88);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSavePath.TabIndex = 12;
            this.btnSelectSavePath.Text = "选择路径";
            this.btnSelectSavePath.UseVisualStyleBackColor = true;
            // 
            // CreateProjectStruct
            // 
            this.ClientSize = new System.Drawing.Size(724, 445);
            this.Controls.Add(this.btnSelectSavePath);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.保存路径);
            this.Controls.Add(this.txtApiPath);
            this.Controls.Add(this.txtWebPath);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkApi);
            this.Controls.Add(this.chkWeb);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProjectStruct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateProjectStruct_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.CheckBox chkApi;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtWebPath;
        private System.Windows.Forms.TextBox txtApiPath;
        private System.Windows.Forms.Label 保存路径;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.Button btnSelectSavePath;
    }
}
