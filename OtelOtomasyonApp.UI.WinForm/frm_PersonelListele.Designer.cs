namespace OtelOtomasyonApp.UI.WinForm
{
    partial class frm_PersonelListele
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
            this.grpbbx_DepartmantGoreListele = new System.Windows.Forms.GroupBox();
            this.Lstbx_DepartmantaGoreListele = new System.Windows.Forms.ListBox();
            this.cmbbx_OtelDepartman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DepartmantListele = new System.Windows.Forms.Button();
            this.cmbbx_departmantListele = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbx_PuanListele = new System.Windows.Forms.GroupBox();
            this.lstbx_PuanaGoreListele = new System.Windows.Forms.ListBox();
            this.cmbbx_OtelPuan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PuanListele = new System.Windows.Forms.Button();
            this.grpbbx_DepartmantGoreListele.SuspendLayout();
            this.grpbx_PuanListele.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbbx_DepartmantGoreListele
            // 
            this.grpbbx_DepartmantGoreListele.Controls.Add(this.Lstbx_DepartmantaGoreListele);
            this.grpbbx_DepartmantGoreListele.Controls.Add(this.cmbbx_OtelDepartman);
            this.grpbbx_DepartmantGoreListele.Controls.Add(this.label2);
            this.grpbbx_DepartmantGoreListele.Controls.Add(this.btn_DepartmantListele);
            this.grpbbx_DepartmantGoreListele.Controls.Add(this.cmbbx_departmantListele);
            this.grpbbx_DepartmantGoreListele.Controls.Add(this.label1);
            this.grpbbx_DepartmantGoreListele.Location = new System.Drawing.Point(0, 0);
            this.grpbbx_DepartmantGoreListele.Name = "grpbbx_DepartmantGoreListele";
            this.grpbbx_DepartmantGoreListele.Size = new System.Drawing.Size(256, 319);
            this.grpbbx_DepartmantGoreListele.TabIndex = 0;
            this.grpbbx_DepartmantGoreListele.TabStop = false;
            this.grpbbx_DepartmantGoreListele.Text = "Departmanta Göre Listele";
            // 
            // Lstbx_DepartmantaGoreListele
            // 
            this.Lstbx_DepartmantaGoreListele.FormattingEnabled = true;
            this.Lstbx_DepartmantaGoreListele.Location = new System.Drawing.Point(12, 135);
            this.Lstbx_DepartmantaGoreListele.Name = "Lstbx_DepartmantaGoreListele";
            this.Lstbx_DepartmantaGoreListele.Size = new System.Drawing.Size(229, 173);
            this.Lstbx_DepartmantaGoreListele.TabIndex = 5;
            // 
            // cmbbx_OtelDepartman
            // 
            this.cmbbx_OtelDepartman.FormattingEnabled = true;
            this.cmbbx_OtelDepartman.Location = new System.Drawing.Point(108, 43);
            this.cmbbx_OtelDepartman.Name = "cmbbx_OtelDepartman";
            this.cmbbx_OtelDepartman.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_OtelDepartman.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Otel Seçiniz";
            // 
            // btn_DepartmantListele
            // 
            this.btn_DepartmantListele.Location = new System.Drawing.Point(144, 96);
            this.btn_DepartmantListele.Name = "btn_DepartmantListele";
            this.btn_DepartmantListele.Size = new System.Drawing.Size(85, 23);
            this.btn_DepartmantListele.TabIndex = 2;
            this.btn_DepartmantListele.Text = "Listele";
            this.btn_DepartmantListele.UseVisualStyleBackColor = true;
            this.btn_DepartmantListele.Click += new System.EventHandler(this.btn_DepartmantListele_Click);
            // 
            // cmbbx_departmantListele
            // 
            this.cmbbx_departmantListele.FormattingEnabled = true;
            this.cmbbx_departmantListele.Location = new System.Drawing.Point(108, 70);
            this.cmbbx_departmantListele.Name = "cmbbx_departmantListele";
            this.cmbbx_departmantListele.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_departmantListele.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seçiniz";
            // 
            // grpbx_PuanListele
            // 
            this.grpbx_PuanListele.Controls.Add(this.lstbx_PuanaGoreListele);
            this.grpbx_PuanListele.Controls.Add(this.cmbbx_OtelPuan);
            this.grpbx_PuanListele.Controls.Add(this.label3);
            this.grpbx_PuanListele.Controls.Add(this.btn_PuanListele);
            this.grpbx_PuanListele.Location = new System.Drawing.Point(282, 0);
            this.grpbx_PuanListele.Name = "grpbx_PuanListele";
            this.grpbx_PuanListele.Size = new System.Drawing.Size(256, 319);
            this.grpbx_PuanListele.TabIndex = 1;
            this.grpbx_PuanListele.TabStop = false;
            this.grpbx_PuanListele.Text = "Puana Göre Listele";
            // 
            // lstbx_PuanaGoreListele
            // 
            this.lstbx_PuanaGoreListele.FormattingEnabled = true;
            this.lstbx_PuanaGoreListele.Location = new System.Drawing.Point(12, 109);
            this.lstbx_PuanaGoreListele.Name = "lstbx_PuanaGoreListele";
            this.lstbx_PuanaGoreListele.Size = new System.Drawing.Size(229, 199);
            this.lstbx_PuanaGoreListele.TabIndex = 5;
            // 
            // cmbbx_OtelPuan
            // 
            this.cmbbx_OtelPuan.FormattingEnabled = true;
            this.cmbbx_OtelPuan.Location = new System.Drawing.Point(108, 43);
            this.cmbbx_OtelPuan.Name = "cmbbx_OtelPuan";
            this.cmbbx_OtelPuan.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_OtelPuan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Otel Seçiniz";
            // 
            // btn_PuanListele
            // 
            this.btn_PuanListele.Location = new System.Drawing.Point(144, 73);
            this.btn_PuanListele.Name = "btn_PuanListele";
            this.btn_PuanListele.Size = new System.Drawing.Size(85, 23);
            this.btn_PuanListele.TabIndex = 2;
            this.btn_PuanListele.Text = "Listele";
            this.btn_PuanListele.UseVisualStyleBackColor = true;
            this.btn_PuanListele.Click += new System.EventHandler(this.btn_PuanListele_Click);
            // 
            // frm_PersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 333);
            this.Controls.Add(this.grpbx_PuanListele);
            this.Controls.Add(this.grpbbx_DepartmantGoreListele);
            this.Name = "frm_PersonelListele";
            this.Text = "frm_PersonelListele";
            this.Load += new System.EventHandler(this.frm_PersonelListele_Load);
            this.grpbbx_DepartmantGoreListele.ResumeLayout(false);
            this.grpbbx_DepartmantGoreListele.PerformLayout();
            this.grpbx_PuanListele.ResumeLayout(false);
            this.grpbx_PuanListele.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbbx_DepartmantGoreListele;
        private System.Windows.Forms.ListBox Lstbx_DepartmantaGoreListele;
        private System.Windows.Forms.ComboBox cmbbx_OtelDepartman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DepartmantListele;
        private System.Windows.Forms.ComboBox cmbbx_departmantListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbx_PuanListele;
        private System.Windows.Forms.ListBox lstbx_PuanaGoreListele;
        private System.Windows.Forms.ComboBox cmbbx_OtelPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PuanListele;
    }
}