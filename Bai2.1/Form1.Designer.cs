namespace Bai2._1
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
            label1 = new Label();
            label2 = new Label();
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnChia = new Button();
            btnNhan = new Button();
            label3 = new Label();
            txtKetQua = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 76);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "SoA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 155);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "SoB";
            // 
            // txtSoA
            // 
            txtSoA.Location = new Point(212, 69);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(239, 27);
            txtSoA.TabIndex = 2;
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(212, 148);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(239, 27);
            txtSoB.TabIndex = 3;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(235, 194);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(52, 29);
            btnCong.TabIndex = 4;
            btnCong.Tag = "Cong";
            btnCong.Text = "Cong";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += TinhToan_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(343, 194);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(52, 29);
            btnTru.TabIndex = 5;
            btnTru.Tag = "Tru";
            btnTru.Text = "Tru";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += TinhToan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(343, 258);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(52, 29);
            btnChia.TabIndex = 7;
            btnChia.Tag = "Chia";
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += TinhToan_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(235, 258);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(52, 29);
            btnNhan.TabIndex = 8;
            btnNhan.Tag = "Nhan";
            btnNhan.Text = "Nhan";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += TinhToan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 296);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 9;
            label3.Text = "KetQua";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(212, 293);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(239, 27);
            txtKetQua.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(227, 9);
            label4.Name = "label4";
            label4.Size = new Size(168, 41);
            label4.TabIndex = 11;
            label4.Text = "MÁY TÍNH ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 421);
            Controls.Add(label4);
            Controls.Add(txtKetQua);
            Controls.Add(label3);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TinhToan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private Button btnCong;
        private Button btnTru;
        private Button btnChia;
        private Button btnNhan;
        private Label label3;
        private TextBox txtKetQua;
        private Label label4;
    }
}
