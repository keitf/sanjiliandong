namespace sanjiliandong
{
    partial class Form1
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
            this.lbsheng = new System.Windows.Forms.ListBox();
            this.lbshi = new System.Windows.Forms.ListBox();
            this.lbxian = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbsheng
            // 
            this.lbsheng.FormattingEnabled = true;
            this.lbsheng.ItemHeight = 12;
            this.lbsheng.Location = new System.Drawing.Point(6, 58);
            this.lbsheng.Name = "lbsheng";
            this.lbsheng.Size = new System.Drawing.Size(120, 64);
            this.lbsheng.TabIndex = 0;
            this.lbsheng.SelectedIndexChanged += new System.EventHandler(this.lbsheng_SelectedIndexChanged);
            // 
            // lbshi
            // 
            this.lbshi.FormattingEnabled = true;
            this.lbshi.ItemHeight = 12;
            this.lbshi.Location = new System.Drawing.Point(132, 58);
            this.lbshi.Name = "lbshi";
            this.lbshi.Size = new System.Drawing.Size(120, 64);
            this.lbshi.TabIndex = 1;
            this.lbshi.SelectedIndexChanged += new System.EventHandler(this.lbshi_SelectedIndexChanged);
            // 
            // lbxian
            // 
            this.lbxian.FormattingEnabled = true;
            this.lbxian.ItemHeight = 12;
            this.lbxian.Location = new System.Drawing.Point(258, 58);
            this.lbxian.Name = "lbxian";
            this.lbxian.Size = new System.Drawing.Size(120, 64);
            this.lbxian.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbsheng);
            this.groupBox1.Controls.Add(this.lbxian);
            this.groupBox1.Controls.Add(this.lbshi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产地";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "县";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "市";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "省";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtb);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产地";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(303, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(8, 36);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(244, 21);
            this.txtb.TabIndex = 1;
            this.txtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbsheng;
        private System.Windows.Forms.ListBox lbshi;
        private System.Windows.Forms.ListBox lbxian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btnAdd;
    }
}

