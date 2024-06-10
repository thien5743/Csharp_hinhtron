namespace Csharp_hinhtron
{
    partial class Form1
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
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.btnthoát = new System.Windows.Forms.Button();
            this.lblkq = new System.Windows.Forms.Label();
            this.btndientich = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lbntinh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.ckbdientich = new System.Windows.Forms.CheckBox();
            this.ckbchuvi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(269, 119);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 0;
            this.txtbankinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(170, 119);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(50, 13);
            this.lblbankinh.TabIndex = 3;
            this.lblbankinh.Text = "bán kính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Location = new System.Drawing.Point(565, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(77, 36);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(67, 17);
            this.rdbdientich.TabIndex = 0;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tính";
            this.rdbdientich.UseVisualStyleBackColor = true;
            this.rdbdientich.CheckedChanged += new System.EventHandler(this.rdbdientich_CheckedChanged);
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(77, 83);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(54, 17);
            this.rdbchuvi.TabIndex = 1;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // btnthoát
            // 
            this.btnthoát.BackColor = System.Drawing.Color.Red;
            this.btnthoát.Location = new System.Drawing.Point(1135, 369);
            this.btnthoát.Name = "btnthoát";
            this.btnthoát.Size = new System.Drawing.Size(49, 52);
            this.btnthoát.TabIndex = 6;
            this.btnthoát.Text = "thoát";
            this.btnthoát.UseVisualStyleBackColor = false;
            this.btnthoát.Click += new System.EventHandler(this.btnthoát_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(173, 245);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 8;
            this.lblkq.Text = "kết quả";
            // 
            // btndientich
            // 
            this.btndientich.BackColor = System.Drawing.Color.Lime;
            this.btndientich.Location = new System.Drawing.Point(235, 335);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(96, 52);
            this.btndientich.TabIndex = 9;
            this.btndientich.Text = "Diện tích";
            this.btndientich.UseVisualStyleBackColor = false;
            this.btndientich.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(351, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Chu vi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(269, 245);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 7;
            // 
            // lbntinh
            // 
            this.lbntinh.BackColor = System.Drawing.Color.Lime;
            this.lbntinh.Location = new System.Drawing.Point(623, 160);
            this.lbntinh.Name = "lbntinh";
            this.lbntinh.Size = new System.Drawing.Size(96, 40);
            this.lbntinh.TabIndex = 11;
            this.lbntinh.Text = "TÍnh";
            this.lbntinh.UseVisualStyleBackColor = false;
            this.lbntinh.Click += new System.EventHandler(this.lbntinh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbchuvi);
            this.groupBox2.Controls.Add(this.ckbdientich);
            this.groupBox2.Location = new System.Drawing.Point(950, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 130);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btntinh2
            // 
            this.btntinh2.BackColor = System.Drawing.Color.Lime;
            this.btntinh2.Location = new System.Drawing.Point(1029, 160);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(96, 40);
            this.btntinh2.TabIndex = 13;
            this.btntinh2.Text = "TÍnh";
            this.btntinh2.UseVisualStyleBackColor = false;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // ckbdientich
            // 
            this.ckbdientich.AutoSize = true;
            this.ckbdientich.Location = new System.Drawing.Point(49, 36);
            this.ckbdientich.Name = "ckbdientich";
            this.ckbdientich.Size = new System.Drawing.Size(68, 17);
            this.ckbdientich.TabIndex = 0;
            this.ckbdientich.Text = "diện tích";
            this.ckbdientich.UseVisualStyleBackColor = true;
            // 
            // ckbchuvi
            // 
            this.ckbchuvi.AutoSize = true;
            this.ckbchuvi.Location = new System.Drawing.Point(49, 83);
            this.ckbchuvi.Name = "ckbchuvi";
            this.ckbchuvi.Size = new System.Drawing.Size(55, 17);
            this.ckbchuvi.TabIndex = 1;
            this.ckbchuvi.Text = "chu vi";
            this.ckbchuvi.UseVisualStyleBackColor = true;
            this.ckbchuvi.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbntinh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btnthoát);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.txtbankinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.Button btnthoát;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button lbntinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntinh2;
        private System.Windows.Forms.CheckBox ckbchuvi;
        private System.Windows.Forms.CheckBox ckbdientich;
    }
}

