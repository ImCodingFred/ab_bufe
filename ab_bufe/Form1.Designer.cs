namespace ab_bufe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV = new DataGridView();
            sorszam = new DataGridViewTextBoxColumn();
            vnev = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            termek = new DataGridViewTextBoxColumn();
            menny = new DataGridViewTextBoxColumn();
            bruttoe = new DataGridViewTextBoxColumn();
            fizar = new DataGridViewTextBoxColumn();
            tb_keres = new TextBox();
            label1 = new Label();
            tb_sorszam = new TextBox();
            label2 = new Label();
            tb_vnev = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_termek = new TextBox();
            label5 = new Label();
            tb_egysegar = new TextBox();
            label7 = new Label();
            tb_mennyiseg = new TextBox();
            label8 = new Label();
            label6 = new Label();
            l_fiz = new Label();
            btn_ment = new Button();
            dtp = new DateTimePicker();
            groupBox1 = new GroupBox();
            rb_modosit = new RadioButton();
            rb_uj = new RadioButton();
            panel = new Panel();
            btn_elvetes = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            groupBox1.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { sorszam, vnev, datum, termek, menny, bruttoe, fizar });
            DGV.Location = new Point(15, 37);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(870, 543);
            DGV.TabIndex = 0;
            DGV.TabStop = false;
            DGV.CellClick += DGV_CellClick;
            // 
            // sorszam
            // 
            sorszam.HeaderText = "Sorszám";
            sorszam.Name = "sorszam";
            sorszam.ReadOnly = true;
            // 
            // vnev
            // 
            vnev.HeaderText = "Vevő neve";
            vnev.Name = "vnev";
            vnev.ReadOnly = true;
            // 
            // datum
            // 
            datum.HeaderText = "Dátum";
            datum.Name = "datum";
            datum.ReadOnly = true;
            // 
            // termek
            // 
            termek.HeaderText = "Termék";
            termek.Name = "termek";
            termek.ReadOnly = true;
            // 
            // menny
            // 
            menny.HeaderText = "Mennyiség";
            menny.Name = "menny";
            menny.ReadOnly = true;
            // 
            // bruttoe
            // 
            bruttoe.HeaderText = "Brutto egységár";
            bruttoe.Name = "bruttoe";
            bruttoe.ReadOnly = true;
            // 
            // fizar
            // 
            fizar.HeaderText = "Fizetendő ár";
            fizar.Name = "fizar";
            fizar.ReadOnly = true;
            // 
            // tb_keres
            // 
            tb_keres.Location = new Point(175, 8);
            tb_keres.Name = "tb_keres";
            tb_keres.Size = new Size(118, 23);
            tb_keres.TabIndex = 10;
            tb_keres.TextChanged += tb_keres_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Keresés";
            // 
            // tb_sorszam
            // 
            tb_sorszam.Location = new Point(55, 28);
            tb_sorszam.Name = "tb_sorszam";
            tb_sorszam.Size = new Size(118, 23);
            tb_sorszam.TabIndex = 2;
            tb_sorszam.TextChanged += tb_sorszam_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "sorszám";
            // 
            // tb_vnev
            // 
            tb_vnev.Location = new Point(72, 66);
            tb_vnev.Name = "tb_vnev";
            tb_vnev.Size = new Size(118, 23);
            tb_vnev.TabIndex = 3;
            tb_vnev.TextChanged += tb_vnev_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "vevő neve:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Dátum";
            // 
            // tb_termek
            // 
            tb_termek.Location = new Point(55, 147);
            tb_termek.Name = "tb_termek";
            tb_termek.Size = new Size(118, 23);
            tb_termek.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 150);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Termék";
            // 
            // tb_egysegar
            // 
            tb_egysegar.Location = new Point(99, 235);
            tb_egysegar.Name = "tb_egysegar";
            tb_egysegar.Size = new Size(118, 23);
            tb_egysegar.TabIndex = 7;
            tb_egysegar.TextChanged += tb_egysegar_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 238);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 2;
            label7.Text = "Brutto egységár";
            // 
            // tb_mennyiseg
            // 
            tb_mennyiseg.Location = new Point(74, 190);
            tb_mennyiseg.Name = "tb_mennyiseg";
            tb_mennyiseg.Size = new Size(118, 23);
            tb_mennyiseg.TabIndex = 6;
            tb_mennyiseg.TextChanged += tb_mennyiseg_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 193);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 2;
            label8.Text = "Mennyiség";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(3, 293);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 2;
            label6.Text = "Fizetendő összeg:";
            // 
            // l_fiz
            // 
            l_fiz.AutoSize = true;
            l_fiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            l_fiz.ForeColor = Color.Red;
            l_fiz.Location = new Point(108, 293);
            l_fiz.Name = "l_fiz";
            l_fiz.Size = new Size(28, 15);
            l_fiz.TabIndex = 2;
            l_fiz.Text = "0 Ft";
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(3, 331);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(105, 75);
            btn_ment.TabIndex = 8;
            btn_ment.Text = "mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // dtp
            // 
            dtp.CustomFormat = "yyyy-MM-dd";
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(55, 106);
            dtp.Name = "dtp";
            dtp.Size = new Size(118, 23);
            dtp.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_modosit);
            groupBox1.Controls.Add(rb_uj);
            groupBox1.Location = new Point(915, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "művelet";
            // 
            // rb_modosit
            // 
            rb_modosit.AutoSize = true;
            rb_modosit.Location = new Point(24, 51);
            rb_modosit.Name = "rb_modosit";
            rb_modosit.Size = new Size(81, 19);
            rb_modosit.TabIndex = 1;
            rb_modosit.TabStop = true;
            rb_modosit.Text = "módosítás";
            rb_modosit.UseVisualStyleBackColor = true;
            rb_modosit.CheckedChanged += rb_modosit_CheckedChanged;
            // 
            // rb_uj
            // 
            rb_uj.AutoSize = true;
            rb_uj.Location = new Point(24, 26);
            rb_uj.Name = "rb_uj";
            rb_uj.Size = new Size(82, 19);
            rb_uj.TabIndex = 0;
            rb_uj.TabStop = true;
            rb_uj.Text = "új felvétel";
            rb_uj.UseVisualStyleBackColor = true;
            rb_uj.CheckedChanged += rb_uj_CheckedChanged;
            // 
            // panel
            // 
            panel.Controls.Add(label4);
            panel.Controls.Add(tb_sorszam);
            panel.Controls.Add(dtp);
            panel.Controls.Add(tb_vnev);
            panel.Controls.Add(btn_elvetes);
            panel.Controls.Add(btn_ment);
            panel.Controls.Add(tb_termek);
            panel.Controls.Add(l_fiz);
            panel.Controls.Add(tb_mennyiseg);
            panel.Controls.Add(label6);
            panel.Controls.Add(tb_egysegar);
            panel.Controls.Add(label7);
            panel.Controls.Add(label2);
            panel.Controls.Add(label8);
            panel.Controls.Add(label3);
            panel.Controls.Add(label5);
            panel.Location = new Point(891, 143);
            panel.Name = "panel";
            panel.Size = new Size(244, 437);
            panel.TabIndex = 6;
            // 
            // btn_elvetes
            // 
            btn_elvetes.Location = new Point(119, 331);
            btn_elvetes.Name = "btn_elvetes";
            btn_elvetes.Size = new Size(105, 75);
            btn_elvetes.TabIndex = 9;
            btn_elvetes.Text = "elvetés";
            btn_elvetes.UseVisualStyleBackColor = true;
            btn_elvetes.Click += btn_elvetes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 592);
            Controls.Add(panel);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(tb_keres);
            Controls.Add(DGV);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "Form1";
            Text = "Katica büfé";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private DataGridViewTextBoxColumn sorszam;
        private DataGridViewTextBoxColumn vnev;
        private DataGridViewTextBoxColumn datum;
        private DataGridViewTextBoxColumn termek;
        private DataGridViewTextBoxColumn menny;
        private DataGridViewTextBoxColumn bruttoe;
        private DataGridViewTextBoxColumn fizar;
        private TextBox tb_keres;
        private Label label1;
        private TextBox tb_sorszam;
        private Label label2;
        private TextBox tb_vnev;
        private Label label3;
        private Label label4;
        private TextBox tb_termek;
        private Label label5;
        private TextBox tb_egysegar;
        private Label label7;
        private TextBox tb_mennyiseg;
        private Label label8;
        private Label label6;
        private Label l_fiz;
        private Button btn_ment;
        private DateTimePicker dtp;
        private GroupBox groupBox1;
        private RadioButton rb_modosit;
        private RadioButton rb_uj;
        private Panel panel;
        private Button btn_elvetes;
    }
}
