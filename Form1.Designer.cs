namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChuyenKhoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSinhKhoa = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTuDong = new System.Windows.Forms.RadioButton();
            this.rdbThucong = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuuFileMaHoa = new System.Windows.Forms.Button();
            this.btnChuyenSangBanMa = new System.Windows.Forms.Button();
            this.txtBanMaMaHoa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMoFileMaHoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnLuuFileGiaiMa = new System.Windows.Forms.Button();
            this.txtBanRoGiaiMa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKhoaBiMat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnMoFileGiaiMa = new System.Windows.Forms.Button();
            this.txtBanMaGiaiMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnResetMaHoa = new System.Windows.Forms.Button();
            this.btnResetGiaiMa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnChuyenKhoa);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSinhKhoa);
            this.panel1.Controls.Add(this.txtKhoa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(66, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 428);
            this.panel1.TabIndex = 1;
            // 
            // btnChuyenKhoa
            // 
            this.btnChuyenKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChuyenKhoa.Location = new System.Drawing.Point(28, 323);
            this.btnChuyenKhoa.Name = "btnChuyenKhoa";
            this.btnChuyenKhoa.Size = new System.Drawing.Size(108, 42);
            this.btnChuyenKhoa.TabIndex = 5;
            this.btnChuyenKhoa.Text = "Chuyển khóa";
            this.btnChuyenKhoa.UseVisualStyleBackColor = false;
            this.btnChuyenKhoa.Click += new System.EventHandler(this.btnChuyenKhoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(159, 323);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSinhKhoa
            // 
            this.btnSinhKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSinhKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSinhKhoa.Location = new System.Drawing.Point(54, 269);
            this.btnSinhKhoa.Name = "btnSinhKhoa";
            this.btnSinhKhoa.Size = new System.Drawing.Size(180, 48);
            this.btnSinhKhoa.TabIndex = 3;
            this.btnSinhKhoa.Text = "Tạo khóa ngẫu nhiên";
            this.btnSinhKhoa.UseVisualStyleBackColor = false;
            this.btnSinhKhoa.Click += new System.EventHandler(this.btnSinhKhoa_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtKhoa.Location = new System.Drawing.Point(10, 127);
            this.txtKhoa.Multiline = true;
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(272, 111);
            this.txtKhoa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khóa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTuDong);
            this.groupBox1.Controls.Add(this.rdbThucong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Khóa:";
            // 
            // rdbTuDong
            // 
            this.rdbTuDong.AutoSize = true;
            this.rdbTuDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbTuDong.Location = new System.Drawing.Point(165, 34);
            this.rdbTuDong.Name = "rdbTuDong";
            this.rdbTuDong.Size = new System.Drawing.Size(73, 19);
            this.rdbTuDong.TabIndex = 1;
            this.rdbTuDong.TabStop = true;
            this.rdbTuDong.Text = "Tự động";
            this.rdbTuDong.UseVisualStyleBackColor = true;
            this.rdbTuDong.CheckedChanged += new System.EventHandler(this.rdbThucong_CheckedChanged);
            // 
            // rdbThucong
            // 
            this.rdbThucong.AutoSize = true;
            this.rdbThucong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbThucong.Location = new System.Drawing.Point(7, 34);
            this.rdbThucong.Name = "rdbThucong";
            this.rdbThucong.Size = new System.Drawing.Size(79, 19);
            this.rdbThucong.TabIndex = 0;
            this.rdbThucong.Text = "Thủ công";
            this.rdbThucong.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnResetMaHoa);
            this.panel2.Controls.Add(this.btnLuuFileMaHoa);
            this.panel2.Controls.Add(this.btnChuyenSangBanMa);
            this.panel2.Controls.Add(this.txtBanMaMaHoa);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnMoFileMaHoa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBanRo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(459, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 428);
            this.panel2.TabIndex = 2;
            // 
            // btnLuuFileMaHoa
            // 
            this.btnLuuFileMaHoa.BackColor = System.Drawing.Color.Purple;
            this.btnLuuFileMaHoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuFileMaHoa.Location = new System.Drawing.Point(174, 355);
            this.btnLuuFileMaHoa.Name = "btnLuuFileMaHoa";
            this.btnLuuFileMaHoa.Size = new System.Drawing.Size(99, 40);
            this.btnLuuFileMaHoa.TabIndex = 9;
            this.btnLuuFileMaHoa.Text = "Lưu file";
            this.btnLuuFileMaHoa.UseVisualStyleBackColor = false;
            this.btnLuuFileMaHoa.Click += new System.EventHandler(this.btnLuuFileMaHoa_Click);
            // 
            // btnChuyenSangBanMa
            // 
            this.btnChuyenSangBanMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChuyenSangBanMa.Location = new System.Drawing.Point(3, 355);
            this.btnChuyenSangBanMa.Name = "btnChuyenSangBanMa";
            this.btnChuyenSangBanMa.Size = new System.Drawing.Size(164, 40);
            this.btnChuyenSangBanMa.TabIndex = 8;
            this.btnChuyenSangBanMa.Text = "Chuyển sang bản mã";
            this.btnChuyenSangBanMa.UseVisualStyleBackColor = false;
            this.btnChuyenSangBanMa.Click += new System.EventHandler(this.btnChuyenSangBanMa_Click);
            // 
            // txtBanMaMaHoa
            // 
            this.txtBanMaMaHoa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBanMaMaHoa.Location = new System.Drawing.Point(3, 241);
            this.txtBanMaMaHoa.Multiline = true;
            this.txtBanMaMaHoa.Name = "txtBanMaMaHoa";
            this.txtBanMaMaHoa.Size = new System.Drawing.Size(263, 103);
            this.txtBanMaMaHoa.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(158, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mã hóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnMoFileMaHoa
            // 
            this.btnMoFileMaHoa.BackColor = System.Drawing.Color.Purple;
            this.btnMoFileMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMoFileMaHoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoFileMaHoa.Location = new System.Drawing.Point(7, 129);
            this.btnMoFileMaHoa.Name = "btnMoFileMaHoa";
            this.btnMoFileMaHoa.Size = new System.Drawing.Size(108, 45);
            this.btnMoFileMaHoa.TabIndex = 5;
            this.btnMoFileMaHoa.Text = "Tải file";
            this.btnMoFileMaHoa.UseVisualStyleBackColor = false;
            this.btnMoFileMaHoa.Click += new System.EventHandler(this.btnMoFileMaHoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bản mã( Dạng Hex):";
            // 
            // txtBanRo
            // 
            this.txtBanRo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBanRo.Location = new System.Drawing.Point(7, 33);
            this.txtBanRo.Multiline = true;
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(263, 90);
            this.txtBanRo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bản rõ: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnResetGiaiMa);
            this.panel3.Controls.Add(this.btnKiemTra);
            this.panel3.Controls.Add(this.btnLuuFileGiaiMa);
            this.panel3.Controls.Add(this.txtBanRoGiaiMa);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtKhoaBiMat);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnGiaiMa);
            this.panel3.Controls.Add(this.btnMoFileGiaiMa);
            this.panel3.Controls.Add(this.txtBanMaGiaiMa);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(821, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 428);
            this.panel3.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKiemTra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKiemTra.Location = new System.Drawing.Point(7, 358);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(108, 37);
            this.btnKiemTra.TabIndex = 12;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnLuuFileGiaiMa
            // 
            this.btnLuuFileGiaiMa.BackColor = System.Drawing.Color.Purple;
            this.btnLuuFileGiaiMa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuFileGiaiMa.Location = new System.Drawing.Point(159, 358);
            this.btnLuuFileGiaiMa.Name = "btnLuuFileGiaiMa";
            this.btnLuuFileGiaiMa.Size = new System.Drawing.Size(108, 37);
            this.btnLuuFileGiaiMa.TabIndex = 10;
            this.btnLuuFileGiaiMa.Text = "Lưu file";
            this.btnLuuFileGiaiMa.UseVisualStyleBackColor = false;
            this.btnLuuFileGiaiMa.Click += new System.EventHandler(this.btnLuuFileGiaiMa_Click);
            // 
            // txtBanRoGiaiMa
            // 
            this.txtBanRoGiaiMa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBanRoGiaiMa.Location = new System.Drawing.Point(3, 297);
            this.txtBanRoGiaiMa.Multiline = true;
            this.txtBanRoGiaiMa.Name = "txtBanRoGiaiMa";
            this.txtBanRoGiaiMa.Size = new System.Drawing.Size(263, 55);
            this.txtBanRoGiaiMa.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(0, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bản rõ(Sau khi giải mã) :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtKhoaBiMat
            // 
            this.txtKhoaBiMat.Location = new System.Drawing.Point(3, 241);
            this.txtKhoaBiMat.Multiline = true;
            this.txtKhoaBiMat.Name = "txtKhoaBiMat";
            this.txtKhoaBiMat.Size = new System.Drawing.Size(263, 33);
            this.txtKhoaBiMat.TabIndex = 9;
            this.txtKhoaBiMat.TextChanged += new System.EventHandler(this.txtKhoaBiMat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(0, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Khóa bí mật:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiaiMa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGiaiMa.Location = new System.Drawing.Point(162, 130);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(108, 44);
            this.btnGiaiMa.TabIndex = 7;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = false;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnMoFileGiaiMa
            // 
            this.btnMoFileGiaiMa.BackColor = System.Drawing.Color.Purple;
            this.btnMoFileGiaiMa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoFileGiaiMa.Location = new System.Drawing.Point(7, 130);
            this.btnMoFileGiaiMa.Name = "btnMoFileGiaiMa";
            this.btnMoFileGiaiMa.Size = new System.Drawing.Size(108, 44);
            this.btnMoFileGiaiMa.TabIndex = 6;
            this.btnMoFileGiaiMa.Text = "Tải file";
            this.btnMoFileGiaiMa.UseVisualStyleBackColor = false;
            this.btnMoFileGiaiMa.Click += new System.EventHandler(this.btnMoFileGiaiMa_Click);
            // 
            // txtBanMaGiaiMa
            // 
            this.txtBanMaGiaiMa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBanMaGiaiMa.Location = new System.Drawing.Point(7, 34);
            this.txtBanMaGiaiMa.Multiline = true;
            this.txtBanMaGiaiMa.Name = "txtBanMaGiaiMa";
            this.txtBanMaGiaiMa.Size = new System.Drawing.Size(263, 89);
            this.txtBanMaGiaiMa.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bản mã( Để giải mã) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(125, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "TẠO KHÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(525, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "MÃ HÓA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(898, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "GIẢI MÃ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(11, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1203, 556);
            this.panel4.TabIndex = 7;
            // 
            // btnResetMaHoa
            // 
            this.btnResetMaHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResetMaHoa.Location = new System.Drawing.Point(87, 182);
            this.btnResetMaHoa.Name = "btnResetMaHoa";
            this.btnResetMaHoa.Size = new System.Drawing.Size(108, 36);
            this.btnResetMaHoa.TabIndex = 10;
            this.btnResetMaHoa.Text = "Reset";
            this.btnResetMaHoa.UseVisualStyleBackColor = false;
            this.btnResetMaHoa.Click += new System.EventHandler(this.btnResetMaHoa_Click);
            // 
            // btnResetGiaiMa
            // 
            this.btnResetGiaiMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResetGiaiMa.Location = new System.Drawing.Point(82, 180);
            this.btnResetGiaiMa.Name = "btnResetGiaiMa";
            this.btnResetGiaiMa.Size = new System.Drawing.Size(108, 36);
            this.btnResetGiaiMa.TabIndex = 11;
            this.btnResetGiaiMa.Text = "Reset";
            this.btnResetGiaiMa.UseVisualStyleBackColor = false;
            this.btnResetGiaiMa.Click += new System.EventHandler(this.btnResetGiaiMa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 755);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "Chuẩn DES và ứng dụng trong mã hóa dữ liệu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTuDong;
        private System.Windows.Forms.RadioButton rdbThucong;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChuyenKhoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSinhKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMoFileMaHoa;
        private System.Windows.Forms.TextBox txtBanMaMaHoa;
        private System.Windows.Forms.Button btnLuuFileMaHoa;
        private System.Windows.Forms.Button btnChuyenSangBanMa;
        private System.Windows.Forms.TextBox txtKhoaBiMat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnMoFileGiaiMa;
        private System.Windows.Forms.TextBox txtBanMaGiaiMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBanRoGiaiMa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuuFileGiaiMa;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnResetMaHoa;
        private System.Windows.Forms.Button btnResetGiaiMa;
    }
}

