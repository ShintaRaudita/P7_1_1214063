namespace P7_1_1214063
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.tbTA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerem = new System.Windows.Forms.RadioButton();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btPilihMatkul = new System.Windows.Forms.Button();
            this.gbKuri = new System.Windows.Forms.GroupBox();
            this.rbKuri2014 = new System.Windows.Forms.RadioButton();
            this.rbKuri2010 = new System.Windows.Forms.RadioButton();
            this.rbKuri2006 = new System.Windows.Forms.RadioButton();
            this.gbMatkul = new System.Windows.Forms.GroupBox();
            this.cbPasok = new System.Windows.Forms.CheckBox();
            this.cbSO = new System.Windows.Forms.CheckBox();
            this.cbJarKom = new System.Windows.Forms.CheckBox();
            this.cbPengLog = new System.Windows.Forms.CheckBox();
            this.cbPemrog7 = new System.Windows.Forms.CheckBox();
            this.cbPemrog6 = new System.Windows.Forms.CheckBox();
            this.cbPemrog5 = new System.Windows.Forms.CheckBox();
            this.cbPemrog4 = new System.Windows.Forms.CheckBox();
            this.cbPemrog3 = new System.Windows.Forms.CheckBox();
            this.cbPemrog2 = new System.Windows.Forms.CheckBox();
            this.cbPemrog1 = new System.Windows.Forms.CheckBox();
            this.cbMTK = new System.Windows.Forms.CheckBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.epTA = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbKuri.SuspendLayout();
            this.gbMatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "tahun akaademik";
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(111, 64);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(144, 20);
            this.tbNIM.TabIndex = 5;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(111, 108);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(144, 20);
            this.tbNama.TabIndex = 6;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(113, 191);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(142, 80);
            this.tbAlamat.TabIndex = 7;
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(446, 160);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(155, 20);
            this.tbSemester.TabIndex = 8;
            this.tbSemester.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // tbTA
            // 
            this.tbTA.Location = new System.Drawing.Point(446, 115);
            this.tbTA.Name = "tbTA";
            this.tbTA.Size = new System.Drawing.Size(155, 20);
            this.tbTA.TabIndex = 9;
            this.tbTA.TextChanged += new System.EventHandler(this.tbTA_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jenis Kelamin";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(113, 158);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(68, 17);
            this.rbLaki.TabIndex = 11;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerem
            // 
            this.rbPerem.AutoSize = true;
            this.rbPerem.Location = new System.Drawing.Point(187, 158);
            this.rbPerem.Name = "rbPerem";
            this.rbPerem.Size = new System.Drawing.Size(79, 17);
            this.rbPerem.TabIndex = 12;
            this.rbPerem.TabStop = true;
            this.rbPerem.Text = "Perempuan";
            this.rbPerem.UseVisualStyleBackColor = true;
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Akutansi",
            "Manajemen Informasi"});
            this.cbProdi.Location = new System.Drawing.Point(446, 67);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(155, 21);
            this.cbProdi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "PILIHAN MATA KULIAH MAHASISWAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prodi";
            // 
            // btPilihMatkul
            // 
            this.btPilihMatkul.Location = new System.Drawing.Point(397, 233);
            this.btPilihMatkul.Name = "btPilihMatkul";
            this.btPilihMatkul.Size = new System.Drawing.Size(111, 38);
            this.btPilihMatkul.TabIndex = 16;
            this.btPilihMatkul.Text = "Pilih Matkul";
            this.btPilihMatkul.UseVisualStyleBackColor = true;
            this.btPilihMatkul.Click += new System.EventHandler(this.btPilihMatkul_Click);
            // 
            // gbKuri
            // 
            this.gbKuri.Controls.Add(this.rbKuri2014);
            this.gbKuri.Controls.Add(this.rbKuri2010);
            this.gbKuri.Controls.Add(this.rbKuri2006);
            this.gbKuri.Location = new System.Drawing.Point(39, 323);
            this.gbKuri.Name = "gbKuri";
            this.gbKuri.Size = new System.Drawing.Size(174, 100);
            this.gbKuri.TabIndex = 17;
            this.gbKuri.TabStop = false;
            this.gbKuri.Text = "Kurikulum Pilihan";
            // 
            // rbKuri2014
            // 
            this.rbKuri2014.AutoSize = true;
            this.rbKuri2014.Location = new System.Drawing.Point(6, 65);
            this.rbKuri2014.Name = "rbKuri2014";
            this.rbKuri2014.Size = new System.Drawing.Size(98, 17);
            this.rbKuri2014.TabIndex = 2;
            this.rbKuri2014.TabStop = true;
            this.rbKuri2014.Text = "Kurikulum 2014";
            this.rbKuri2014.UseVisualStyleBackColor = true;
            this.rbKuri2014.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbKuri2010
            // 
            this.rbKuri2010.AutoSize = true;
            this.rbKuri2010.Location = new System.Drawing.Point(6, 42);
            this.rbKuri2010.Name = "rbKuri2010";
            this.rbKuri2010.Size = new System.Drawing.Size(98, 17);
            this.rbKuri2010.TabIndex = 1;
            this.rbKuri2010.TabStop = true;
            this.rbKuri2010.Text = "Kurikulum 2010";
            this.rbKuri2010.UseVisualStyleBackColor = true;
            this.rbKuri2010.CheckedChanged += new System.EventHandler(this.rbKuri2010_CheckedChanged);
            // 
            // rbKuri2006
            // 
            this.rbKuri2006.AutoSize = true;
            this.rbKuri2006.Location = new System.Drawing.Point(6, 19);
            this.rbKuri2006.Name = "rbKuri2006";
            this.rbKuri2006.Size = new System.Drawing.Size(98, 17);
            this.rbKuri2006.TabIndex = 0;
            this.rbKuri2006.TabStop = true;
            this.rbKuri2006.Text = "Kurikulum 2006";
            this.rbKuri2006.UseVisualStyleBackColor = true;
            this.rbKuri2006.CheckedChanged += new System.EventHandler(this.rbKuri2006_CheckedChanged);
            // 
            // gbMatkul
            // 
            this.gbMatkul.Controls.Add(this.cbPasok);
            this.gbMatkul.Controls.Add(this.cbSO);
            this.gbMatkul.Controls.Add(this.cbJarKom);
            this.gbMatkul.Controls.Add(this.cbPengLog);
            this.gbMatkul.Controls.Add(this.cbPemrog7);
            this.gbMatkul.Controls.Add(this.cbPemrog6);
            this.gbMatkul.Controls.Add(this.cbPemrog5);
            this.gbMatkul.Controls.Add(this.cbPemrog4);
            this.gbMatkul.Controls.Add(this.cbPemrog3);
            this.gbMatkul.Controls.Add(this.cbPemrog2);
            this.gbMatkul.Controls.Add(this.cbPemrog1);
            this.gbMatkul.Controls.Add(this.cbMTK);
            this.gbMatkul.Location = new System.Drawing.Point(303, 323);
            this.gbMatkul.Name = "gbMatkul";
            this.gbMatkul.Size = new System.Drawing.Size(426, 123);
            this.gbMatkul.TabIndex = 18;
            this.gbMatkul.TabStop = false;
            this.gbMatkul.Text = "Mata Kuliah Pilihan";
            // 
            // cbPasok
            // 
            this.cbPasok.AutoSize = true;
            this.cbPasok.Location = new System.Drawing.Point(260, 89);
            this.cbPasok.Name = "cbPasok";
            this.cbPasok.Size = new System.Drawing.Size(148, 17);
            this.cbPasok.TabIndex = 11;
            this.cbPasok.Text = "Manajemen Rantai Pasok";
            this.cbPasok.UseVisualStyleBackColor = true;
            // 
            // cbSO
            // 
            this.cbSO.AutoSize = true;
            this.cbSO.Location = new System.Drawing.Point(260, 66);
            this.cbSO.Name = "cbSO";
            this.cbSO.Size = new System.Drawing.Size(96, 17);
            this.cbSO.TabIndex = 10;
            this.cbSO.Text = "Ssitem Operasi";
            this.cbSO.UseVisualStyleBackColor = true;
            // 
            // cbJarKom
            // 
            this.cbJarKom.AutoSize = true;
            this.cbJarKom.Location = new System.Drawing.Point(260, 43);
            this.cbJarKom.Name = "cbJarKom";
            this.cbJarKom.Size = new System.Drawing.Size(120, 17);
            this.cbJarKom.TabIndex = 9;
            this.cbJarKom.Text = "Jaringan LKomputer";
            this.cbJarKom.UseVisualStyleBackColor = true;
            // 
            // cbPengLog
            // 
            this.cbPengLog.AutoSize = true;
            this.cbPengLog.Location = new System.Drawing.Point(260, 20);
            this.cbPengLog.Name = "cbPengLog";
            this.cbPengLog.Size = new System.Drawing.Size(114, 17);
            this.cbPengLog.TabIndex = 8;
            this.cbPengLog.Text = "Pengantar Logistik";
            this.cbPengLog.UseVisualStyleBackColor = true;
            // 
            // cbPemrog7
            // 
            this.cbPemrog7.AutoSize = true;
            this.cbPemrog7.Location = new System.Drawing.Point(143, 89);
            this.cbPemrog7.Name = "cbPemrog7";
            this.cbPemrog7.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog7.TabIndex = 7;
            this.cbPemrog7.Text = "Pemrograman 7";
            this.cbPemrog7.UseVisualStyleBackColor = true;
            this.cbPemrog7.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // cbPemrog6
            // 
            this.cbPemrog6.AutoSize = true;
            this.cbPemrog6.Location = new System.Drawing.Point(143, 66);
            this.cbPemrog6.Name = "cbPemrog6";
            this.cbPemrog6.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog6.TabIndex = 6;
            this.cbPemrog6.Text = "Pemrograman 6";
            this.cbPemrog6.UseVisualStyleBackColor = true;
            // 
            // cbPemrog5
            // 
            this.cbPemrog5.AutoSize = true;
            this.cbPemrog5.Location = new System.Drawing.Point(143, 43);
            this.cbPemrog5.Name = "cbPemrog5";
            this.cbPemrog5.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog5.TabIndex = 5;
            this.cbPemrog5.Text = "Pemrograman 5";
            this.cbPemrog5.UseVisualStyleBackColor = true;
            // 
            // cbPemrog4
            // 
            this.cbPemrog4.AutoSize = true;
            this.cbPemrog4.Location = new System.Drawing.Point(143, 20);
            this.cbPemrog4.Name = "cbPemrog4";
            this.cbPemrog4.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog4.TabIndex = 4;
            this.cbPemrog4.Text = "Pemrograman 4";
            this.cbPemrog4.UseVisualStyleBackColor = true;
            // 
            // cbPemrog3
            // 
            this.cbPemrog3.AutoSize = true;
            this.cbPemrog3.Location = new System.Drawing.Point(6, 89);
            this.cbPemrog3.Name = "cbPemrog3";
            this.cbPemrog3.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog3.TabIndex = 3;
            this.cbPemrog3.Text = "Pemrograman 3";
            this.cbPemrog3.UseVisualStyleBackColor = true;
            // 
            // cbPemrog2
            // 
            this.cbPemrog2.AutoSize = true;
            this.cbPemrog2.Location = new System.Drawing.Point(6, 66);
            this.cbPemrog2.Name = "cbPemrog2";
            this.cbPemrog2.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog2.TabIndex = 2;
            this.cbPemrog2.Text = "Pemrograman 2";
            this.cbPemrog2.UseVisualStyleBackColor = true;
            // 
            // cbPemrog1
            // 
            this.cbPemrog1.AutoSize = true;
            this.cbPemrog1.Location = new System.Drawing.Point(6, 43);
            this.cbPemrog1.Name = "cbPemrog1";
            this.cbPemrog1.Size = new System.Drawing.Size(100, 17);
            this.cbPemrog1.TabIndex = 1;
            this.cbPemrog1.Text = "Pemrograman 1";
            this.cbPemrog1.UseVisualStyleBackColor = true;
            // 
            // cbMTK
            // 
            this.cbMTK.AutoSize = true;
            this.cbMTK.Location = new System.Drawing.Point(6, 20);
            this.cbMTK.Name = "cbMTK";
            this.cbMTK.Size = new System.Drawing.Size(81, 17);
            this.cbMTK.TabIndex = 0;
            this.cbMTK.Text = "Matematika";
            this.cbMTK.UseVisualStyleBackColor = true;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(249, 481);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(106, 34);
            this.btSimpan.TabIndex = 19;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(455, 481);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(106, 34);
            this.btBatal.TabIndex = 20;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // epTA
            // 
            this.epTA.ContainerControl = this;
            this.epTA.Icon = ((System.Drawing.Icon)(resources.GetObject("epTA.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 538);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.gbMatkul);
            this.Controls.Add(this.gbKuri);
            this.Controls.Add(this.btPilihMatkul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.rbPerem);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTA);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNIM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pilihan Matkul";
            this.gbKuri.ResumeLayout(false);
            this.gbKuri.PerformLayout();
            this.gbMatkul.ResumeLayout(false);
            this.gbMatkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.TextBox tbTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerem;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btPilihMatkul;
        private System.Windows.Forms.GroupBox gbKuri;
        private System.Windows.Forms.RadioButton rbKuri2014;
        private System.Windows.Forms.RadioButton rbKuri2010;
        private System.Windows.Forms.RadioButton rbKuri2006;
        private System.Windows.Forms.GroupBox gbMatkul;
        private System.Windows.Forms.CheckBox cbPasok;
        private System.Windows.Forms.CheckBox cbSO;
        private System.Windows.Forms.CheckBox cbJarKom;
        private System.Windows.Forms.CheckBox cbPengLog;
        private System.Windows.Forms.CheckBox cbPemrog7;
        private System.Windows.Forms.CheckBox cbPemrog6;
        private System.Windows.Forms.CheckBox cbPemrog5;
        private System.Windows.Forms.CheckBox cbPemrog4;
        private System.Windows.Forms.CheckBox cbPemrog3;
        private System.Windows.Forms.CheckBox cbPemrog2;
        private System.Windows.Forms.CheckBox cbPemrog1;
        private System.Windows.Forms.CheckBox cbMTK;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.ErrorProvider epTA;
    }
}

