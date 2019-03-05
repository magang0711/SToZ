namespace SConvertZ
{
    partial class frmConvert
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDwgNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnEsc = new System.Windows.Forms.Button();
            this.rdSigle = new System.Windows.Forms.RadioButton();
            this.rdMultiple = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(418, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "浏览";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(136, 14);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(276, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.Tag = "文件路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择施工图文件夹:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "图框上施工图属性:";
            // 
            // txtDesign
            // 
            this.txtDesign.Location = new System.Drawing.Point(136, 41);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(95, 21);
            this.txtDesign.TabIndex = 3;
            this.txtDesign.Tag = "施工图属性";
            this.txtDesign.Text = "DESIGNSTATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图框上图号属性:";
            // 
            // txtDwgNo
            // 
            this.txtDwgNo.Location = new System.Drawing.Point(136, 84);
            this.txtDwgNo.Name = "txtDwgNo";
            this.txtDwgNo.Size = new System.Drawing.Size(95, 21);
            this.txtDwgNo.TabIndex = 3;
            this.txtDwgNo.Tag = "图号属性";
            this.txtDwgNo.Text = "DWGNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "属性值替换";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(305, 84);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(65, 21);
            this.txtOld.TabIndex = 3;
            this.txtOld.Tag = "需要替换的图号";
            this.txtOld.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "修改属性值为=>";
            // 
            // txtFinish
            // 
            this.txtFinish.Location = new System.Drawing.Point(332, 41);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(80, 21);
            this.txtFinish.TabIndex = 3;
            this.txtFinish.Tag = "竣工图";
            this.txtFinish.Text = "竣工图";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(418, 134);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "替换为=>";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(423, 84);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(65, 21);
            this.txtNew.TabIndex = 3;
            this.txtNew.Tag = "替换后的图号";
            this.txtNew.Text = "Z";
            // 
            // btnEsc
            // 
            this.btnEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsc.Location = new System.Drawing.Point(337, 134);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 0;
            this.btnEsc.Text = "取消";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // rdSigle
            // 
            this.rdSigle.AutoSize = true;
            this.rdSigle.Checked = true;
            this.rdSigle.Location = new System.Drawing.Point(13, 118);
            this.rdSigle.Name = "rdSigle";
            this.rdSigle.Size = new System.Drawing.Size(119, 16);
            this.rdSigle.TabIndex = 4;
            this.rdSigle.TabStop = true;
            this.rdSigle.Text = "一张图纸一个图框";
            this.rdSigle.UseVisualStyleBackColor = true;
            // 
            // rdMultiple
            // 
            this.rdMultiple.AutoSize = true;
            this.rdMultiple.Location = new System.Drawing.Point(136, 118);
            this.rdMultiple.Name = "rdMultiple";
            this.rdMultiple.Size = new System.Drawing.Size(119, 16);
            this.rdMultiple.TabIndex = 4;
            this.rdMultiple.Text = "一张图纸多个图框";
            this.rdMultiple.UseVisualStyleBackColor = true;
            // 
            // frmConvert
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEsc;
            this.ClientSize = new System.Drawing.Size(500, 170);
            this.Controls.Add(this.rdMultiple);
            this.Controls.Add(this.rdSigle);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.txtDwgNo);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "施工图转竣工图";
            this.Load += new System.EventHandler(this.frmConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDwgNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.RadioButton rdSigle;
        private System.Windows.Forms.RadioButton rdMultiple;
    }
}