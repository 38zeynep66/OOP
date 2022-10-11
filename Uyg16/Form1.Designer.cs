
namespace Uyg16
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatD = new System.Windows.Forms.TextBox();
            this.txtTürkçeD = new System.Windows.Forms.TextBox();
            this.txtTürkçeY = new System.Windows.Forms.TextBox();
            this.txtMatY = new System.Windows.Forms.TextBox();
            this.txtMatS = new System.Windows.Forms.TextBox();
            this.txtTürkçeS = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTürkçeS);
            this.groupBox1.Controls.Add(this.txtMatS);
            this.groupBox1.Controls.Add(this.txtMatY);
            this.groupBox1.Controls.Add(this.txtTürkçeY);
            this.groupBox1.Controls.Add(this.txtTürkçeD);
            this.groupBox1.Controls.Add(this.txtMatD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Location = new System.Drawing.Point(52, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(170, 100);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(79, 22);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matematik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doğru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yanlış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Toplam";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMatD
            // 
            this.txtMatD.Location = new System.Drawing.Point(118, 40);
            this.txtMatD.Name = "txtMatD";
            this.txtMatD.Size = new System.Drawing.Size(32, 20);
            this.txtMatD.TabIndex = 6;
            // 
            // txtTürkçeD
            // 
            this.txtTürkçeD.Location = new System.Drawing.Point(118, 74);
            this.txtTürkçeD.Name = "txtTürkçeD";
            this.txtTürkçeD.Size = new System.Drawing.Size(32, 20);
            this.txtTürkçeD.TabIndex = 7;
            // 
            // txtTürkçeY
            // 
            this.txtTürkçeY.Location = new System.Drawing.Point(170, 74);
            this.txtTürkçeY.Name = "txtTürkçeY";
            this.txtTürkçeY.Size = new System.Drawing.Size(32, 20);
            this.txtTürkçeY.TabIndex = 8;
            // 
            // txtMatY
            // 
            this.txtMatY.Location = new System.Drawing.Point(170, 40);
            this.txtMatY.Name = "txtMatY";
            this.txtMatY.Size = new System.Drawing.Size(32, 20);
            this.txtMatY.TabIndex = 9;
            // 
            // txtMatS
            // 
            this.txtMatS.Enabled = false;
            this.txtMatS.Location = new System.Drawing.Point(217, 40);
            this.txtMatS.Name = "txtMatS";
            this.txtMatS.Size = new System.Drawing.Size(32, 20);
            this.txtMatS.TabIndex = 10;
            // 
            // txtTürkçeS
            // 
            this.txtTürkçeS.Enabled = false;
            this.txtTürkçeS.Location = new System.Drawing.Point(217, 74);
            this.txtTürkçeS.Name = "txtTürkçeS";
            this.txtTürkçeS.Size = new System.Drawing.Size(32, 20);
            this.txtTürkçeS.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTürkçeS;
        private System.Windows.Forms.TextBox txtMatS;
        private System.Windows.Forms.TextBox txtMatY;
        private System.Windows.Forms.TextBox txtTürkçeY;
        private System.Windows.Forms.TextBox txtTürkçeD;
        private System.Windows.Forms.TextBox txtMatD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

