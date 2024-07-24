namespace CSharp_TinhChuViDienTich
{
    partial class HinhChuNhat
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDai = new TextBox();
            txtRong = new TextBox();
            label4 = new Label();
            lblKQ = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            btnDienTich = new Button();
            btnChuVi = new Button();
            groupBox1 = new GroupBox();
            rdoCV = new RadioButton();
            rdoDT = new RadioButton();
            tinhmoi = new Button();
            button2 = new Button();
            nmr1 = new NumericUpDown();
            trackBar1 = new TrackBar();
            nmr2 = new NumericUpDown();
            trackBar2 = new TrackBar();
            ckbDT = new CheckBox();
            groupBox2 = new GroupBox();
            ckbCV = new CheckBox();
            tinmoi2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(789, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F);
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 1;
            label2.Text = "Chiều dài";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F);
            label3.Location = new Point(22, 142);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 2;
            label3.Text = "Chiều rộng";
            // 
            // txtDai
            // 
            txtDai.Location = new Point(186, 79);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(219, 40);
            txtDai.TabIndex = 3;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(186, 139);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(219, 40);
            txtRong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(22, 202);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 2;
            label4.Text = "Kết quả";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Tahoma", 20F);
            lblKQ.Location = new Point(186, 202);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(22, 267);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(144, 56);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(625, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(22, 344);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(168, 56);
            btnDienTich.TabIndex = 6;
            btnDienTich.Text = "DIỆN TÍCH";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(237, 344);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(168, 56);
            btnChuVi.TabIndex = 6;
            btnChuVi.Text = "CHU VI";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoCV);
            groupBox1.Controls.Add(rdoDT);
            groupBox1.Location = new Point(548, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 157);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn Chức năng ";
            // 
            // rdoCV
            // 
            rdoCV.AutoSize = true;
            rdoCV.Location = new Point(6, 118);
            rdoCV.Name = "rdoCV";
            rdoCV.Size = new Size(109, 37);
            rdoCV.TabIndex = 0;
            rdoCV.TabStop = true;
            rdoCV.Text = "Chu Vi";
            rdoCV.UseVisualStyleBackColor = true;
            // 
            // rdoDT
            // 
            rdoDT.AutoSize = true;
            rdoDT.Location = new Point(6, 61);
            rdoDT.Name = "rdoDT";
            rdoDT.Size = new Size(143, 37);
            rdoDT.TabIndex = 0;
            rdoDT.TabStop = true;
            rdoDT.Text = "Diện Tích";
            rdoDT.UseVisualStyleBackColor = true;
            rdoDT.CheckedChanged += rdoDT_CheckedChanged;
            // 
            // tinhmoi
            // 
            tinhmoi.Location = new Point(440, 346);
            tinhmoi.Name = "tinhmoi";
            tinhmoi.Size = new Size(144, 56);
            tinhmoi.TabIndex = 5;
            tinhmoi.Text = "Tính Mới";
            tinhmoi.UseVisualStyleBackColor = true;
            tinhmoi.Click += btnTinh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1043, 427);
            button2.Name = "button2";
            button2.Size = new Size(168, 56);
            button2.TabIndex = 5;
            button2.Text = "Tính Mới";
            button2.UseVisualStyleBackColor = true;
            // 
            // nmr1
            // 
            nmr1.Location = new Point(440, 82);
            nmr1.Name = "nmr1";
            nmr1.Size = new Size(80, 40);
            nmr1.TabIndex = 8;
            nmr1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(548, 82);
            trackBar1.Maximum = 9999999;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(245, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // nmr2
            // 
            nmr2.Location = new Point(440, 135);
            nmr2.Name = "nmr2";
            nmr2.Size = new Size(80, 40);
            nmr2.TabIndex = 8;
            nmr2.ValueChanged += numercUpDown1_ValueChanged_1;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(548, 139);
            trackBar2.Maximum = 9999999;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(245, 45);
            trackBar2.TabIndex = 9;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // ckbDT
            // 
            ckbDT.AutoSize = true;
            ckbDT.Location = new Point(6, 49);
            ckbDT.Name = "ckbDT";
            ckbDT.Size = new Size(144, 37);
            ckbDT.TabIndex = 11;
            ckbDT.Text = "Diện Tích";
            ckbDT.UseVisualStyleBackColor = true;
            ckbDT.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckbCV);
            groupBox2.Controls.Add(ckbDT);
            groupBox2.Location = new Point(824, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 157);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng ";
            // 
            // ckbCV
            // 
            ckbCV.AutoSize = true;
            ckbCV.Location = new Point(6, 101);
            ckbCV.Name = "ckbCV";
            ckbCV.Size = new Size(110, 37);
            ckbCV.TabIndex = 11;
            ckbCV.Text = "Chu Vi";
            ckbCV.UseVisualStyleBackColor = true;
            // 
            // tinmoi2
            // 
            tinmoi2.Location = new Point(830, 348);
            tinmoi2.Name = "tinmoi2";
            tinmoi2.Size = new Size(196, 56);
            tinmoi2.TabIndex = 5;
            tinmoi2.Text = "Tính Mới 2";
            tinmoi2.UseVisualStyleBackColor = true;
            tinmoi2.Click += tinhmoi2_Click;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 415);
            Controls.Add(groupBox2);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(nmr2);
            Controls.Add(nmr1);
            Controls.Add(groupBox1);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(button2);
            Controls.Add(tinmoi2);
            Controls.Add(tinhmoi);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(lblKQ);
            Controls.Add(txtRong);
            Controls.Add(txtDai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HinhChuNhat";
            Text = "HÌNH CHỮ NHẬT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDai;
        private TextBox txtRong;
        private Label label4;
        private Label lblKQ;
        private Button btnTinh;
        private Button btnThoat;
        private Button btnDienTich;
        private Button btnChuVi;
        private GroupBox groupBox1;
        private RadioButton rdoCV;
        private RadioButton rdoDT;
        private Button tinhmoi;
        private Button button2;
        private NumericUpDown nmr1;
        private TrackBar trackBar1;
        private NumericUpDown nmr2;
        private TrackBar trackBar2;
        private CheckBox ckbDT;
        private GroupBox groupBox2;
        private CheckBox ckbCV;
        private Button tinmoi2;
    }
}
