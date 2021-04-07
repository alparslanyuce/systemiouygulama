namespace SystemIoWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnpersonelgetir = new System.Windows.Forms.Button();
            this.btnpersonelkaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfirma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPersonel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.Location = new System.Drawing.Point(6, 19);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(143, 277);
            this.lstPersonel.TabIndex = 0;
            this.lstPersonel.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstPersonel.DoubleClick += new System.EventHandler(this.lstPersonel_DoubleClick);
            // 
            // btnpersonelgetir
            // 
            this.btnpersonelgetir.Location = new System.Drawing.Point(18, 325);
            this.btnpersonelgetir.Name = "btnpersonelgetir";
            this.btnpersonelgetir.Size = new System.Drawing.Size(149, 34);
            this.btnpersonelgetir.TabIndex = 1;
            this.btnpersonelgetir.Text = "Personel Getir";
            this.btnpersonelgetir.UseVisualStyleBackColor = true;
            this.btnpersonelgetir.Click += new System.EventHandler(this.btnpersonelgetir_Click);
            // 
            // btnpersonelkaydet
            // 
            this.btnpersonelkaydet.Location = new System.Drawing.Point(18, 365);
            this.btnpersonelkaydet.Name = "btnpersonelkaydet";
            this.btnpersonelkaydet.Size = new System.Drawing.Size(149, 35);
            this.btnpersonelkaydet.TabIndex = 2;
            this.btnpersonelkaydet.Text = "Personel Kaydet";
            this.btnpersonelkaydet.UseVisualStyleBackColor = true;
            this.btnpersonelkaydet.Click += new System.EventHandler(this.btnpersonelkaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtulke);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtfirma);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtsoyisim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtisim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(192, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 296);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Detay";
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(84, 191);
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(100, 20);
            this.txtulke.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ülke";
            // 
            // txtfirma
            // 
            this.txtfirma.Location = new System.Drawing.Point(84, 165);
            this.txtfirma.Name = "txtfirma";
            this.txtfirma.Size = new System.Drawing.Size(100, 20);
            this.txtfirma.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "firmaadi";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(84, 139);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "emailadres";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(84, 113);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "soyisim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(84, 87);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpersonelkaydet);
            this.Controls.Add(this.btnpersonelgetir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SystemIoUygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnpersonelgetir;
        private System.Windows.Forms.Button btnpersonelkaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
    }
}

