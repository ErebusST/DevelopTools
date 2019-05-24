namespace CreateProject
{
    partial class FormatSqlForm
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnPinJie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbState1 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSql = new System.Windows.Forms.RichTextBox();
            this.raMyBatis = new System.Windows.Forms.RadioButton();
            this.raHibernate = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.btnConvert);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.btnRestore);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(200, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(687, 40);
            this.panel9.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Controls.Add(this.btnPaste);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.btnCopy);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.button1);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(519, 40);
            this.panel12.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.raMyBatis);
            this.panel16.Controls.Add(this.raHibernate);
            this.panel16.Controls.Add(this.btnPinJie);
            this.panel16.Controls.Add(this.panel2);
            this.panel16.Controls.Add(this.lbState1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(240, 40);
            this.panel16.TabIndex = 9;
            // 
            // btnPinJie
            // 
            this.btnPinJie.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPinJie.Location = new System.Drawing.Point(147, 0);
            this.btnPinJie.Name = "btnPinJie";
            this.btnPinJie.Size = new System.Drawing.Size(75, 40);
            this.btnPinJie.TabIndex = 9;
            this.btnPinJie.Text = "拼接(&J)";
            this.btnPinJie.UseVisualStyleBackColor = true;
            this.btnPinJie.Click += new System.EventHandler(this.btnPinJie_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 40);
            this.panel2.TabIndex = 8;
            // 
            // lbState1
            // 
            this.lbState1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbState1.ForeColor = System.Drawing.Color.Red;
            this.lbState1.Location = new System.Drawing.Point(0, 0);
            this.lbState1.Name = "lbState1";
            this.lbState1.Size = new System.Drawing.Size(240, 40);
            this.lbState1.TabIndex = 0;
            this.lbState1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPaste
            // 
            this.btnPaste.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPaste.Location = new System.Drawing.Point(240, 0);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 40);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "粘贴(&P)";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(315, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(18, 40);
            this.panel15.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopy.Location = new System.Drawing.Point(333, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 40);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "复制(&C)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(408, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(18, 40);
            this.panel14.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(426, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "清空(&U)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(501, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(18, 40);
            this.panel13.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConvert.Location = new System.Drawing.Point(519, 0);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 40);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "封装(&D)";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(594, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(18, 40);
            this.panel11.TabIndex = 2;
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestore.Location = new System.Drawing.Point(612, 0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 40);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "解封(&R)";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 40);
            this.panel8.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lbState);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 40);
            this.panel10.TabIndex = 7;
            // 
            // lbState
            // 
            this.lbState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbState.ForeColor = System.Drawing.Color.Red;
            this.lbState.Location = new System.Drawing.Point(0, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(200, 40);
            this.lbState.TabIndex = 1;
            this.lbState.Text = "label1";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSql);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSql
            // 
            this.txtSql.AllowDrop = true;
            this.txtSql.CausesValidation = false;
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSql.Location = new System.Drawing.Point(3, 17);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(881, 464);
            this.txtSql.TabIndex = 3;
            this.txtSql.Text = "";
            this.txtSql.TextChanged += new System.EventHandler(this.txtSql_TextChanged);
            this.txtSql.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSql_KeyUp);
            // 
            // raMyBatis
            // 
            this.raMyBatis.AutoSize = true;
            this.raMyBatis.Location = new System.Drawing.Point(16, 21);
            this.raMyBatis.Name = "raMyBatis";
            this.raMyBatis.Size = new System.Drawing.Size(65, 16);
            this.raMyBatis.TabIndex = 2;
            this.raMyBatis.TabStop = true;
            this.raMyBatis.Text = "MyBatis";
            this.raMyBatis.UseVisualStyleBackColor = true;
            // 
            // raHibernate
            // 
            this.raHibernate.AutoSize = true;
            this.raHibernate.Checked = true;
            this.raHibernate.Location = new System.Drawing.Point(16, 3);
            this.raHibernate.Name = "raHibernate";
            this.raHibernate.Size = new System.Drawing.Size(77, 16);
            this.raHibernate.TabIndex = 10;
            this.raHibernate.TabStop = true;
            this.raHibernate.Text = "Hibernate";
            this.raHibernate.UseVisualStyleBackColor = true;
            this.raHibernate.CheckedChanged += new System.EventHandler(this.raHibernate_CheckedChanged);
            // 
            // FormatSqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormatSqlForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sql封装/解封";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormatSqlForm_FormClosing);
            this.Load += new System.EventHandler(this.FormatSqllForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtSql;
        private System.Windows.Forms.Label lbState1;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Button btnPinJie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton raMyBatis;
        private System.Windows.Forms.RadioButton raHibernate;
    }
}