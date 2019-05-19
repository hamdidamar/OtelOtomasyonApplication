namespace OtelOtomasyonApp.UI.WinForm
{
    partial class frm_OtelListele
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
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ililcelistele = new System.Windows.Forms.Button();
            this.cmb_il = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_puanaGöreListele = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_yıldızaGöreListele = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ilce);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_ililcelistele);
            this.groupBox1.Controls.Add(this.cmb_il);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İl-İlçeye Göre Listele";
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(84, 62);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(121, 20);
            this.txt_ilce.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 212);
            this.listBox1.TabIndex = 8;
            // 
            // btn_ililcelistele
            // 
            this.btn_ililcelistele.Location = new System.Drawing.Point(65, 95);
            this.btn_ililcelistele.Name = "btn_ililcelistele";
            this.btn_ililcelistele.Size = new System.Drawing.Size(120, 35);
            this.btn_ililcelistele.TabIndex = 7;
            this.btn_ililcelistele.Text = "Listele";
            this.btn_ililcelistele.UseVisualStyleBackColor = true;
            // cmb_il
            // 
            this.cmb_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_il.FormattingEnabled = true;
            this.cmb_il.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmb_il.Location = new System.Drawing.Point(84, 19);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Size = new System.Drawing.Size(121, 21);
            this.cmb_il.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlçe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İl:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_puanaGöreListele);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(269, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puana Göre Listele";
            // 
            // btn_puanaGöreListele
            // 
            this.btn_puanaGöreListele.Location = new System.Drawing.Point(63, 33);
            this.btn_puanaGöreListele.Name = "btn_puanaGöreListele";
            this.btn_puanaGöreListele.Size = new System.Drawing.Size(120, 35);
            this.btn_puanaGöreListele.TabIndex = 9;
            this.btn_puanaGöreListele.Text = "Listele";
            this.btn_puanaGöreListele.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(229, 277);
            this.listBox2.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_yıldızaGöreListele);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Location = new System.Drawing.Point(527, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 361);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yıldız Sayısına Göre Listele";
            // 
            // btn_yıldızaGöreListele
            // 
            this.btn_yıldızaGöreListele.Location = new System.Drawing.Point(70, 33);
            this.btn_yıldızaGöreListele.Name = "btn_yıldızaGöreListele";
            this.btn_yıldızaGöreListele.Size = new System.Drawing.Size(120, 35);
            this.btn_yıldızaGöreListele.TabIndex = 10;
            this.btn_yıldızaGöreListele.Text = "Listele";
            this.btn_yıldızaGöreListele.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 74);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(229, 277);
            this.listBox3.TabIndex = 9;
            // 
            // frm_OtelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_OtelListele";
            this.Text = "frm_OtelListele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ililcelistele;
        private System.Windows.Forms.ComboBox cmb_il;
        private System.Windows.Forms.Button btn_puanaGöreListele;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_yıldızaGöreListele;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txt_ilce;
    }
}