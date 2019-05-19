namespace OtelOtomasyonApp.UI.WinForm
{
    partial class frm_MusteriOtelBilgileri
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
            this.btn_musteriBilgiGonder = new System.Windows.Forms.Button();
            this.txt_musteriPuan = new System.Windows.Forms.TextBox();
            this.txt_musteriYorum = new System.Windows.Forms.TextBox();
            this.txt_musteriEposta = new System.Windows.Forms.TextBox();
            this.txt_musteriSoyad = new System.Windows.Forms.TextBox();
            this.txt_müsteriAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_musteriOtelSecim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_musteriBilgiGonder
            // 
            this.btn_musteriBilgiGonder.Location = new System.Drawing.Point(333, 121);
            this.btn_musteriBilgiGonder.Name = "btn_musteriBilgiGonder";
            this.btn_musteriBilgiGonder.Size = new System.Drawing.Size(143, 49);
            this.btn_musteriBilgiGonder.TabIndex = 25;
            this.btn_musteriBilgiGonder.Text = "Gönder";
            this.btn_musteriBilgiGonder.UseVisualStyleBackColor = true;
            this.btn_musteriBilgiGonder.Click += new System.EventHandler(this.btn_musteriBilgiGonder_Click);
            // 
            // txt_musteriPuan
            // 
            this.txt_musteriPuan.Location = new System.Drawing.Point(147, 272);
            this.txt_musteriPuan.Name = "txt_musteriPuan";
            this.txt_musteriPuan.Size = new System.Drawing.Size(25, 20);
            this.txt_musteriPuan.TabIndex = 24;
            // 
            // txt_musteriYorum
            // 
            this.txt_musteriYorum.Location = new System.Drawing.Point(147, 178);
            this.txt_musteriYorum.Multiline = true;
            this.txt_musteriYorum.Name = "txt_musteriYorum";
            this.txt_musteriYorum.Size = new System.Drawing.Size(167, 85);
            this.txt_musteriYorum.TabIndex = 23;
            // 
            // txt_musteriEposta
            // 
            this.txt_musteriEposta.Location = new System.Drawing.Point(147, 104);
            this.txt_musteriEposta.Name = "txt_musteriEposta";
            this.txt_musteriEposta.Size = new System.Drawing.Size(167, 20);
            this.txt_musteriEposta.TabIndex = 22;
            // 
            // txt_musteriSoyad
            // 
            this.txt_musteriSoyad.Location = new System.Drawing.Point(147, 69);
            this.txt_musteriSoyad.Name = "txt_musteriSoyad";
            this.txt_musteriSoyad.Size = new System.Drawing.Size(120, 20);
            this.txt_musteriSoyad.TabIndex = 21;
            // 
            // txt_müsteriAd
            // 
            this.txt_müsteriAd.Location = new System.Drawing.Point(147, 33);
            this.txt_müsteriAd.Name = "txt_müsteriAd";
            this.txt_müsteriAd.Size = new System.Drawing.Size(120, 20);
            this.txt_müsteriAd.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Otel Puanınız:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Otel Yorumunuz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Soyadınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "E-Posta Adresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Otel Seçiniz:";
            // 
            // cmb_musteriOtelSecim
            // 
            this.cmb_musteriOtelSecim.FormattingEnabled = true;
            this.cmb_musteriOtelSecim.Location = new System.Drawing.Point(147, 140);
            this.cmb_musteriOtelSecim.Name = "cmb_musteriOtelSecim";
            this.cmb_musteriOtelSecim.Size = new System.Drawing.Size(120, 21);
            this.cmb_musteriOtelSecim.TabIndex = 13;
            // 
            // frm_MusteriOtelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.btn_musteriBilgiGonder);
            this.Controls.Add(this.txt_musteriPuan);
            this.Controls.Add(this.txt_musteriYorum);
            this.Controls.Add(this.txt_musteriEposta);
            this.Controls.Add(this.txt_musteriSoyad);
            this.Controls.Add(this.txt_müsteriAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_musteriOtelSecim);
            this.Name = "frm_MusteriOtelBilgileri";
            this.Text = "frm_MusteriOtelBilgileri";
            this.Load += new System.EventHandler(this.frm_MusteriOtelBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_musteriBilgiGonder;
        private System.Windows.Forms.TextBox txt_musteriPuan;
        private System.Windows.Forms.TextBox txt_musteriYorum;
        private System.Windows.Forms.TextBox txt_musteriEposta;
        private System.Windows.Forms.TextBox txt_musteriSoyad;
        private System.Windows.Forms.TextBox txt_müsteriAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_musteriOtelSecim;
    }
}