namespace QuanLyKyTucXa
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
            this.btnSV = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnDaiLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSV
            // 
            this.btnSV.Location = new System.Drawing.Point(56, 74);
            this.btnSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(100, 64);
            this.btnSV.TabIndex = 0;
            this.btnSV.Text = "Quản lý sinh viên";
            this.btnSV.UseVisualStyleBackColor = true;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // btnHD
            // 
            this.btnHD.Location = new System.Drawing.Point(286, 74);
            this.btnHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(100, 64);
            this.btnHD.TabIndex = 1;
            this.btnHD.Text = "Quản lý hợp đồng";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Location = new System.Drawing.Point(56, 184);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(100, 64);
            this.btnThongBao.TabIndex = 2;
            this.btnThongBao.Text = "Quản lý thông báo";
            this.btnThongBao.UseVisualStyleBackColor = true;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnDaiLy
            // 
            this.btnDaiLy.Location = new System.Drawing.Point(286, 184);
            this.btnDaiLy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDaiLy.Name = "btnDaiLy";
            this.btnDaiLy.Size = new System.Drawing.Size(100, 64);
            this.btnDaiLy.TabIndex = 3;
            this.btnDaiLy.Text = "Quản lý đại lý";
            this.btnDaiLy.UseVisualStyleBackColor = true;
            this.btnDaiLy.Click += new System.EventHandler(this.btnDaiLy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 280);
            this.Controls.Add(this.btnDaiLy);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnSV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnDaiLy;
    }
}

