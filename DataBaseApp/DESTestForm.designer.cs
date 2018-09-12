namespace CreateProject
{
    partial class DESTestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtJMStr = new System.Windows.Forms.TextBox();
            this.txtJieMStr = new System.Windows.Forms.TextBox();
            this.btnCtreateKey = new System.Windows.Forms.Button();
            this.btnCreateIV = new System.Windows.Forms.Button();
            this.btnJiaMi = new System.Windows.Forms.Button();
            this.btnJieMi = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "待加密";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "加密后";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "解密";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(72, 20);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(462, 21);
            this.txtKey.TabIndex = 5;
            this.txtKey.Text = "AD67EA2F3BE6E5ADD368DFE03120B5DF";
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(72, 56);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(462, 21);
            this.txtIV.TabIndex = 6;
            this.txtIV.Text = "AS3F1AE4";
            this.txtIV.TextChanged += new System.EventHandler(this.txtIV_TextChanged);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(72, 92);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(462, 21);
            this.txtStr.TabIndex = 7;
            this.txtStr.Text = "oproirasf3q232r3qeq34!@";
            // 
            // txtJMStr
            // 
            this.txtJMStr.Location = new System.Drawing.Point(72, 128);
            this.txtJMStr.Name = "txtJMStr";
            this.txtJMStr.Size = new System.Drawing.Size(462, 21);
            this.txtJMStr.TabIndex = 8;
            // 
            // txtJieMStr
            // 
            this.txtJieMStr.Location = new System.Drawing.Point(72, 164);
            this.txtJieMStr.Name = "txtJieMStr";
            this.txtJieMStr.Size = new System.Drawing.Size(462, 21);
            this.txtJieMStr.TabIndex = 10;
            // 
            // btnCtreateKey
            // 
            this.btnCtreateKey.Location = new System.Drawing.Point(25, 209);
            this.btnCtreateKey.Name = "btnCtreateKey";
            this.btnCtreateKey.Size = new System.Drawing.Size(75, 23);
            this.btnCtreateKey.TabIndex = 11;
            this.btnCtreateKey.Text = "生成KEY";
            this.btnCtreateKey.UseVisualStyleBackColor = true;
            this.btnCtreateKey.Click += new System.EventHandler(this.btnCtreateKey_Click);
            // 
            // btnCreateIV
            // 
            this.btnCreateIV.Location = new System.Drawing.Point(106, 209);
            this.btnCreateIV.Name = "btnCreateIV";
            this.btnCreateIV.Size = new System.Drawing.Size(75, 23);
            this.btnCreateIV.TabIndex = 12;
            this.btnCreateIV.Text = "生成IV";
            this.btnCreateIV.UseVisualStyleBackColor = true;
            this.btnCreateIV.Click += new System.EventHandler(this.btnCreateIV_Click);
            // 
            // btnJiaMi
            // 
            this.btnJiaMi.Location = new System.Drawing.Point(187, 209);
            this.btnJiaMi.Name = "btnJiaMi";
            this.btnJiaMi.Size = new System.Drawing.Size(75, 23);
            this.btnJiaMi.TabIndex = 13;
            this.btnJiaMi.Text = "加密";
            this.btnJiaMi.UseVisualStyleBackColor = true;
            this.btnJiaMi.Click += new System.EventHandler(this.btnJiaMi_Click);
            // 
            // btnJieMi
            // 
            this.btnJieMi.Location = new System.Drawing.Point(268, 209);
            this.btnJieMi.Name = "btnJieMi";
            this.btnJieMi.Size = new System.Drawing.Size(75, 23);
            this.btnJieMi.TabIndex = 14;
            this.btnJieMi.Text = "解密";
            this.btnJieMi.UseVisualStyleBackColor = true;
            this.btnJieMi.Click += new System.EventHandler(this.btnJieMi_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(349, 209);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 15;
            this.btnCompare.Text = "比对";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(430, 209);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(104, 23);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "复制到剪贴板";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 21);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // DESTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnJieMi);
            this.Controls.Add(this.btnJiaMi);
            this.Controls.Add(this.btnCreateIV);
            this.Controls.Add(this.btnCtreateKey);
            this.Controls.Add(this.txtJieMStr);
            this.Controls.Add(this.txtJMStr);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DESTestForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "加密/解密工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DESTestForm_FormClosing);
            this.Load += new System.EventHandler(this.DESTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtJMStr;
        private System.Windows.Forms.TextBox txtJieMStr;
        private System.Windows.Forms.Button btnCtreateKey;
        private System.Windows.Forms.Button btnCreateIV;
        private System.Windows.Forms.Button btnJiaMi;
        private System.Windows.Forms.Button btnJieMi;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox textBox1;
    }
}