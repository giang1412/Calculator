namespace Calculator
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
            this.lb_SoA = new System.Windows.Forms.Label();
            this.lb_SoB = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_SoA
            // 
            this.lb_SoA.AutoSize = true;
            this.lb_SoA.Location = new System.Drawing.Point(80, 55);
            this.lb_SoA.Name = "lb_SoA";
            this.lb_SoA.Size = new System.Drawing.Size(72, 32);
            this.lb_SoA.TabIndex = 0;
            this.lb_SoA.Text = "Số a: ";
            this.lb_SoA.Click += new System.EventHandler(this.lb_SoA_Click);
            // 
            // lb_SoB
            // 
            this.lb_SoB.AutoSize = true;
            this.lb_SoB.Location = new System.Drawing.Point(80, 117);
            this.lb_SoB.Name = "lb_SoB";
            this.lb_SoB.Size = new System.Drawing.Size(74, 32);
            this.lb_SoB.TabIndex = 0;
            this.lb_SoB.Text = "Số b: ";
            this.lb_SoB.Click += new System.EventHandler(this.lb_SoB_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(191, 55);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(444, 39);
            this.txtSoA.TabIndex = 1;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(191, 110);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(444, 39);
            this.txtSoB.TabIndex = 1;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(448, 244);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(150, 46);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng ";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(80, 179);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(112, 32);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = "Kết Quả: ";
            this.lbKetQua.Click += new System.EventHandler(this.lb_SoB_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(191, 172);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(444, 39);
            this.txtKetQua.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lb_SoB);
            this.Controls.Add(this.lb_SoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_SoA;
        private Label lb_SoB;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private Button btnCong;
        private Label lbKetQua;
        private TextBox txtKetQua;
    }
}