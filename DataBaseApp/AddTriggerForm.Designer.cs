namespace DataBaseApp
{
    partial class AddTriggerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobClass = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExcuteParameter = new System.Windows.Forms.TextBox();
            this.lbExcuteParameter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTriggerType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务类名称";
            // 
            // txtJobClass
            // 
            this.txtJobClass.Location = new System.Drawing.Point(94, 21);
            this.txtJobClass.Name = "txtJobClass";
            this.txtJobClass.Size = new System.Drawing.Size(218, 21);
            this.txtJobClass.TabIndex = 1;
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(94, 106);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(218, 131);
            this.txtDiscription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "描述";
            // 
            // txtExcuteParameter
            // 
            this.txtExcuteParameter.Location = new System.Drawing.Point(94, 77);
            this.txtExcuteParameter.Name = "txtExcuteParameter";
            this.txtExcuteParameter.Size = new System.Drawing.Size(218, 21);
            this.txtExcuteParameter.TabIndex = 3;
            // 
            // lbExcuteParameter
            // 
            this.lbExcuteParameter.AutoSize = true;
            this.lbExcuteParameter.Location = new System.Drawing.Point(12, 80);
            this.lbExcuteParameter.Name = "lbExcuteParameter";
            this.lbExcuteParameter.Size = new System.Drawing.Size(77, 12);
            this.lbExcuteParameter.TabIndex = 6;
            this.lbExcuteParameter.Text = "间隔时间(分)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "触发器类型";
            // 
            // cboTriggerType
            // 
            this.cboTriggerType.FormattingEnabled = true;
            this.cboTriggerType.Location = new System.Drawing.Point(94, 51);
            this.cboTriggerType.Name = "cboTriggerType";
            this.cboTriggerType.Size = new System.Drawing.Size(218, 20);
            this.cboTriggerType.TabIndex = 2;
            this.cboTriggerType.SelectedIndexChanged += new System.EventHandler(this.cboTriggerType_SelectedIndexChanged);
            this.cboTriggerType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTriggerType_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCannel.Location = new System.Drawing.Point(221, 256);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 23);
            this.btnCannel.TabIndex = 6;
            this.btnCannel.Text = "取消(&C)";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // AddTriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCannel;
            this.ClientSize = new System.Drawing.Size(345, 296);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboTriggerType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExcuteParameter);
            this.Controls.Add(this.lbExcuteParameter);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJobClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTriggerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加任务";
            this.Load += new System.EventHandler(this.AddTriggerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobClass;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExcuteParameter;
        private System.Windows.Forms.Label lbExcuteParameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTriggerType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCannel;
    }
}