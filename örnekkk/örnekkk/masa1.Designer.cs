
namespace örnekkk
{
    partial class masa1
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
            this.btncikiss = new System.Windows.Forms.Button();
            this.btn_siparısver = new System.Windows.Forms.Button();
            this.btnfiyathesapla = new System.Windows.Forms.Button();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridViewSepet = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMenü = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMenü = new System.Windows.Forms.DataGridView();
            this.EKLE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenü)).BeginInit();
            this.SuspendLayout();
            // 
            // btncikiss
            // 
            this.btncikiss.Location = new System.Drawing.Point(658, 500);
            this.btncikiss.Name = "btncikiss";
            this.btncikiss.Size = new System.Drawing.Size(104, 33);
            this.btncikiss.TabIndex = 92;
            this.btncikiss.Text = "Çıkış";
            this.btncikiss.UseVisualStyleBackColor = true;
            this.btncikiss.Click += new System.EventHandler(this.btncikiss_Click);
            // 
            // btn_siparısver
            // 
            this.btn_siparısver.Location = new System.Drawing.Point(535, 500);
            this.btn_siparısver.Name = "btn_siparısver";
            this.btn_siparısver.Size = new System.Drawing.Size(104, 33);
            this.btn_siparısver.TabIndex = 91;
            this.btn_siparısver.Text = "Sipariş Ver";
            this.btn_siparısver.UseVisualStyleBackColor = true;
            this.btn_siparısver.Click += new System.EventHandler(this.btn_siparısver_Click_1);
            // 
            // btnfiyathesapla
            // 
            this.btnfiyathesapla.Location = new System.Drawing.Point(535, 414);
            this.btnfiyathesapla.Name = "btnfiyathesapla";
            this.btnfiyathesapla.Size = new System.Drawing.Size(117, 32);
            this.btnfiyathesapla.TabIndex = 90;
            this.btnfiyathesapla.Text = "Fiyat Hesapla";
            this.btnfiyathesapla.UseVisualStyleBackColor = true;
            this.btnfiyathesapla.Click += new System.EventHandler(this.btnfiyathesapla_Click);
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(658, 460);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(100, 22);
            this.textBoxTutar.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(477, 223);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(43, 43);
            this.buttonEkle.TabIndex = 87;
            this.buttonEkle.Text = ">>";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click_1);
            // 
            // dataGridViewSepet
            // 
            this.dataGridViewSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepet.Location = new System.Drawing.Point(535, 134);
            this.dataGridViewSepet.Name = "dataGridViewSepet";
            this.dataGridViewSepet.RowHeadersWidth = 51;
            this.dataGridViewSepet.RowTemplate.Height = 24;
            this.dataGridViewSepet.Size = new System.Drawing.Size(419, 259);
            this.dataGridViewSepet.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "MENÜ";
            // 
            // comboBoxMenü
            // 
            this.comboBoxMenü.FormattingEnabled = true;
            this.comboBoxMenü.Location = new System.Drawing.Point(12, 56);
            this.comboBoxMenü.Name = "comboBoxMenü";
            this.comboBoxMenü.Size = new System.Drawing.Size(212, 24);
            this.comboBoxMenü.TabIndex = 84;
            this.comboBoxMenü.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenü_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "MENÜ SEÇİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(541, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "SEPET";
            // 
            // dataGridViewMenü
            // 
            this.dataGridViewMenü.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenü.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewMenü.Name = "dataGridViewMenü";
            this.dataGridViewMenü.RowHeadersWidth = 51;
            this.dataGridViewMenü.RowTemplate.Height = 24;
            this.dataGridViewMenü.Size = new System.Drawing.Size(459, 259);
            this.dataGridViewMenü.TabIndex = 81;
            // 
            // EKLE
            // 
            this.EKLE.AutoSize = true;
            this.EKLE.Location = new System.Drawing.Point(477, 188);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(43, 17);
            this.EKLE.TabIndex = 93;
            this.EKLE.Text = "EKLE";
            // 
            // masa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 622);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.btncikiss);
            this.Controls.Add(this.btn_siparısver);
            this.Controls.Add(this.btnfiyathesapla);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridViewSepet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMenü);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMenü);
            this.Name = "masa1";
            this.Text = "masa1";
            this.Load += new System.EventHandler(this.masa1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenü)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncikiss;
        private System.Windows.Forms.Button btn_siparısver;
        private System.Windows.Forms.Button btnfiyathesapla;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.DataGridView dataGridViewSepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMenü;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMenü;
        private System.Windows.Forms.Label EKLE;
    }
}