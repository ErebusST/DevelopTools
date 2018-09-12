namespace DataBaseApp
{
    partial class CreateFieldForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.cboCodeDataType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.raCheckNotEmpty = new System.Windows.Forms.RadioButton();
            this.raCheckNotNull = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            this.raCheckRange = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字段名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "代码数据类型";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(109, 20);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(237, 21);
            this.txtFieldName.TabIndex = 3;
            // 
            // cboCodeDataType
            // 
            this.cboCodeDataType.FormattingEnabled = true;
            this.cboCodeDataType.Location = new System.Drawing.Point(108, 49);
            this.cboCodeDataType.Name = "cboCodeDataType";
            this.cboCodeDataType.Size = new System.Drawing.Size(237, 20);
            this.cboCodeDataType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "验证类型";
            // 
            // raCheckNotEmpty
            // 
            this.raCheckNotEmpty.AutoSize = true;
            this.raCheckNotEmpty.Checked = true;
            this.raCheckNotEmpty.Location = new System.Drawing.Point(108, 74);
            this.raCheckNotEmpty.Name = "raCheckNotEmpty";
            this.raCheckNotEmpty.Size = new System.Drawing.Size(71, 16);
            this.raCheckNotEmpty.TabIndex = 8;
            this.raCheckNotEmpty.TabStop = true;
            this.raCheckNotEmpty.Text = "验证非空";
            this.raCheckNotEmpty.UseVisualStyleBackColor = true;
            // 
            // raCheckNotNull
            // 
            this.raCheckNotNull.AutoSize = true;
            this.raCheckNotNull.Location = new System.Drawing.Point(185, 74);
            this.raCheckNotNull.Name = "raCheckNotNull";
            this.raCheckNotNull.Size = new System.Drawing.Size(83, 16);
            this.raCheckNotNull.TabIndex = 9;
            this.raCheckNotNull.Text = "验证非Null";
            this.raCheckNotNull.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(108, 275);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确定(&Y)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCannel.Location = new System.Drawing.Point(229, 275);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(75, 23);
            this.btnCannel.TabIndex = 11;
            this.btnCannel.Text = "取消(&C)";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // raCheckRange
            // 
            this.raCheckRange.AutoSize = true;
            this.raCheckRange.Location = new System.Drawing.Point(274, 74);
            this.raCheckRange.Name = "raCheckRange";
            this.raCheckRange.Size = new System.Drawing.Size(71, 16);
            this.raCheckRange.TabIndex = 12;
            this.raCheckRange.Text = "范围验证";
            this.raCheckRange.UseVisualStyleBackColor = true;
            this.raCheckRange.CheckedChanged += new System.EventHandler(this.raCheckRange_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "验证类型";
            // 
            // txtRange
            // 
            this.txtRange.Enabled = false;
            this.txtRange.Location = new System.Drawing.Point(109, 100);
            this.txtRange.Multiline = true;
            this.txtRange.Name = "txtRange";
            this.txtRange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRange.Size = new System.Drawing.Size(236, 160);
            this.txtRange.TabIndex = 14;
            // 
            // CreateFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCannel;
            this.ClientSize = new System.Drawing.Size(367, 329);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.raCheckRange);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.raCheckNotNull);
            this.Controls.Add(this.raCheckNotEmpty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCodeDataType);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateFieldForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加验证字段";
            this.Load += new System.EventHandler(this.CreateFieldForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.ComboBox cboCodeDataType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton raCheckNotEmpty;
        private System.Windows.Forms.RadioButton raCheckNotNull;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCannel;
        private System.Windows.Forms.RadioButton raCheckRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRange;
    }
}