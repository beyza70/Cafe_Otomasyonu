
namespace örnekkk
{
    partial class masa3
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
            this.btn_cikisss = new System.Windows.Forms.Button();
            this.btn_siparisvr = new System.Windows.Forms.Button();
            this.btn_fytHesapla = new System.Windows.Forms.Button();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridView_Sepet = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMenü = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Menü = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EKLE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menü)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikisss
            // 
            this.btn_cikisss.Location = new System.Drawing.Point(654, 491);
            this.btn_cikisss.Name = "btn_cikisss";
            this.btn_cikisss.Size = new System.Drawing.Size(104, 33);
            this.btn_cikisss.TabIndex = 104;
            this.btn_cikisss.Text = "Çıkış";
            this.btn_cikisss.UseVisualStyleBackColor = true;
            this.btn_cikisss.Click += new System.EventHandler(this.btn_cikisss_Click);
            // 
            // btn_siparisvr
            // 
            this.btn_siparisvr.Location = new System.Drawing.Point(531, 491);
            this.btn_siparisvr.Name = "btn_siparisvr";
            this.btn_siparisvr.Size = new System.Drawing.Size(104, 33);
            this.btn_siparisvr.TabIndex = 103;
            this.btn_siparisvr.Text = "Sipariş Ver";
            this.btn_siparisvr.UseVisualStyleBackColor = true;
            this.btn_siparisvr.Click += new System.EventHandler(this.btn_siparisvr_Click);
            // 
            // btn_fytHesapla
            // 
            this.btn_fytHesapla.Location = new System.Drawing.Point(531, 405);
            this.btn_fytHesapla.Name = "btn_fytHesapla";
            this.btn_fytHesapla.Size = new System.Drawing.Size(117, 32);
            this.btn_fytHesapla.TabIndex = 102;
            this.btn_fytHesapla.Text = "Fiyat Hesapla";
            this.btn_fytHesapla.UseVisualStyleBackColor = true;
            this.btn_fytHesapla.Click += new System.EventHandler(this.btn_fytHesapla_Click);
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(654, 451);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(100, 22);
            this.textBoxTutar.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(473, 214);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(43, 43);
            this.buttonEkle.TabIndex = 99;
            this.buttonEkle.Text = ">>";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dataGridView_Sepet
            // 
            this.dataGridView_Sepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sepet.Location = new System.Drawing.Point(531, 125);
            this.dataGridView_Sepet.Name = "dataGridView_Sepet";
            this.dataGridView_Sepet.RowHeadersWidth = 51;
            this.dataGridView_Sepet.RowTemplate.Height = 24;
            this.dataGridView_Sepet.Size = new System.Drawing.Size(419, 259);
            this.dataGridView_Sepet.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-73, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 97;
            this.label3.Text = "MENÜ";
            // 
            // comboBoxMenü
            // 
            this.comboBoxMenü.FormattingEnabled = true;
            this.comboBoxMenü.Location = new System.Drawing.Point(12, 37);
            this.comboBoxMenü.Name = "comboBoxMenü";
            this.comboBoxMenü.Size = new System.Drawing.Size(212, 24);
            this.comboBoxMenü.TabIndex = 96;
            this.comboBoxMenü.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenü_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-73, -34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 95;
            this.label2.Text = "MENÜ SEÇİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(537, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "SEPET";
            // 
            // dataGridView_Menü
            // 
            this.dataGridView_Menü.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Menü.Location = new System.Drawing.Point(8, 125);
            this.dataGridView_Menü.Name = "dataGridView_Menü";
            this.dataGridView_Menü.RowHeadersWidth = 51;
            this.dataGridView_Menü.RowTemplate.Height = 24;
            this.dataGridView_Menü.Size = new System.Drawing.Size(459, 259);
            this.dataGridView_Menü.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 107;
            this.label5.Text = "MENÜ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 105;
            this.label6.Text = "MENÜ SEÇİNİZ";
            // 
            // EKLE
            // 
            this.EKLE.AutoSize = true;
            this.EKLE.Location = new System.Drawing.Point(473, 180);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(43, 17);
            this.EKLE.TabIndex = 108;
            this.EKLE.Text = "EKLE";
            // 
            // masa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 604);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cikisss);
            this.Controls.Add(this.btn_siparisvr);
            this.Controls.Add(this.btn_fytHesapla);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridView_Sepet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMenü);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Menü);
            this.Name = "masa3";
            this.Text = "masa3";
            this.Load += new System.EventHandler(this.masa3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menü)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikisss;
        private System.Windows.Forms.Button btn_siparisvr;
        private System.Windows.Forms.Button btn_fytHesapla;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.DataGridView dataGridView_Sepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMenü;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Menü;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EKLE;
    }
}