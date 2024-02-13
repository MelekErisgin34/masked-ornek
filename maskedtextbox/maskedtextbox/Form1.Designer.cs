namespace maskedtextbox
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
            this.maskIp = new System.Windows.Forms.MaskedTextBox();
            this.maskKart = new System.Windows.Forms.MaskedTextBox();
            this.maskDtarih = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskIp
            // 
            this.maskIp.Location = new System.Drawing.Point(127, 288);
            this.maskIp.Name = "maskIp";
            this.maskIp.Size = new System.Drawing.Size(100, 20);
            this.maskIp.TabIndex = 19;
            // 
            // maskKart
            // 
            this.maskKart.Location = new System.Drawing.Point(127, 245);
            this.maskKart.Name = "maskKart";
            this.maskKart.Size = new System.Drawing.Size(100, 20);
            this.maskKart.TabIndex = 18;
            // 
            // maskDtarih
            // 
            this.maskDtarih.Location = new System.Drawing.Point(127, 207);
            this.maskDtarih.Name = "maskDtarih";
            this.maskDtarih.Size = new System.Drawing.Size(100, 20);
            this.maskDtarih.TabIndex = 17;
            // 
            // maskTelefon
            // 
            this.maskTelefon.Location = new System.Drawing.Point(127, 174);
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(100, 20);
            this.maskTelefon.TabIndex = 16;
            // 
            // maskTC
            // 
            this.maskTC.Location = new System.Drawing.Point(127, 143);
            this.maskTC.Name = "maskTC";
            this.maskTC.Size = new System.Drawing.Size(100, 20);
            this.maskTC.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "IP Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kart Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dogum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "T.C No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.maskIp);
            this.Controls.Add(this.maskKart);
            this.Controls.Add(this.maskDtarih);
            this.Controls.Add(this.maskTelefon);
            this.Controls.Add(this.maskTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskIp;
        private System.Windows.Forms.MaskedTextBox maskKart;
        private System.Windows.Forms.MaskedTextBox maskDtarih;
        private System.Windows.Forms.MaskedTextBox maskTelefon;
        private System.Windows.Forms.MaskedTextBox maskTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

