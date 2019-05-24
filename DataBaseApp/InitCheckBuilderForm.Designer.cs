namespace DataBaseApp
{
    partial class InitCheckBuilderForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.raBuilderFromSql = new System.Windows.Forms.RadioButton();
            this.raBuilderFromJavaBean = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.raBuilderFromSql);
            this.panel1.Controls.Add(this.raBuilderFromJavaBean);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(450, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出(&E)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // raBuilderFromSql
            // 
            this.raBuilderFromSql.AutoSize = true;
            this.raBuilderFromSql.Location = new System.Drawing.Point(149, 21);
            this.raBuilderFromSql.Name = "raBuilderFromSql";
            this.raBuilderFromSql.Size = new System.Drawing.Size(89, 16);
            this.raBuilderFromSql.TabIndex = 2;
            this.raBuilderFromSql.Text = "通过Sql生成";
            this.raBuilderFromSql.UseVisualStyleBackColor = true;
            // 
            // raBuilderFromJavaBean
            // 
            this.raBuilderFromJavaBean.AutoSize = true;
            this.raBuilderFromJavaBean.Checked = true;
            this.raBuilderFromJavaBean.Location = new System.Drawing.Point(24, 21);
            this.raBuilderFromJavaBean.Name = "raBuilderFromJavaBean";
            this.raBuilderFromJavaBean.Size = new System.Drawing.Size(119, 16);
            this.raBuilderFromJavaBean.TabIndex = 1;
            this.raBuilderFromJavaBean.TabStop = true;
            this.raBuilderFromJavaBean.Text = "通过JavaBean生成";
            this.raBuilderFromJavaBean.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreate.Location = new System.Drawing.Point(369, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "生成(&C)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(558, 372);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空(&Q)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // InitCheckBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 434);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitCheckBuilderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "初始化数据";
            this.Load += new System.EventHandler(this.InitCheckBuilderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton raBuilderFromSql;
        private System.Windows.Forms.RadioButton raBuilderFromJavaBean;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}