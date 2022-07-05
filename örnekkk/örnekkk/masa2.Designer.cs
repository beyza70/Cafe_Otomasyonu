
namespace örnekkk
{
    partial class masa2
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
            this.dataGridViewMenüü = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMenü = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSepett = new System.Windows.Forms.DataGridView();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.btn_fiyath = new System.Windows.Forms.Button();
            this.btn_sipars = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.EKLE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenüü)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepett)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenüü
            // 
            this.dataGridViewMenüü.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenüü.Location = new System.Drawing.Point(25, 139);
            this.dataGridViewMenüü.Name = "dataGridViewMenüü";
            this.dataGridViewMenüü.RowHeadersWidth = 51;
            this.dataGridViewMenüü.RowTemplate.Height = 24;
            this.dataGridViewMenüü.Size = new System.Drawing.Size(459, 259);
            this.dataGridViewMenüü.TabIndex = 0;
            this.dataGridViewMenüü.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenüü_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "MENÜ SEÇİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(554, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "SEPET";
            // 
            // comboBoxMenü
            // 
            this.comboBoxMenü.FormattingEnabled = true;
            this.comboBoxMenü.Location = new System.Drawing.Point(25, 61);
            this.comboBoxMenü.Name = "comboBoxMenü";
            this.comboBoxMenü.Size = new System.Drawing.Size(212, 24);
            this.comboBoxMenü.TabIndex = 72;
            this.comboBoxMenü.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenü_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "MENÜ";
            // 
            // dataGridViewSepett
            // 
            this.dataGridViewSepett.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepett.Location = new System.Drawing.Point(548, 139);
            this.dataGridViewSepett.Name = "dataGridViewSepett";
            this.dataGridViewSepett.RowHeadersWidth = 51;
            this.dataGridViewSepett.RowTemplate.Height = 24;
            this.dataGridViewSepett.Size = new System.Drawing.Size(419, 259);
            this.dataGridViewSepett.TabIndex = 74;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(490, 228);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(43, 43);
            this.buttonEkle.TabIndex = 75;
            this.buttonEkle.Text = ">>";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(671, 465);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(100, 22);
            this.textBoxTutar.TabIndex = 77;
            // 
            // btn_fiyath
            // 
            this.btn_fiyath.Location = new System.Drawing.Point(548, 419);
            this.btn_fiyath.Name = "btn_fiyath";
            this.btn_fiyath.Size = new System.Drawing.Size(117, 32);
            this.btn_fiyath.TabIndex = 78;
            this.btn_fiyath.Text = "Fiyat Hesapla";
            this.btn_fiyath.UseVisualStyleBackColor = true;
            this.btn_fiyath.Click += new System.EventHandler(this.btn_fiyath_Click);
            // 
            // btn_sipars
            // 
            this.btn_sipars.Location = new System.Drawing.Point(548, 505);
            this.btn_sipars.Name = "btn_sipars";
            this.btn_sipars.Size = new System.Drawing.Size(104, 33);
            this.btn_sipars.TabIndex = 79;
            this.btn_sipars.Text = "Sipariş Ver";
            this.btn_sipars.UseVisualStyleBackColor = true;
            this.btn_sipars.Click += new System.EventHandler(this.btn_sipars_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(671, 505);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(104, 33);
            this.btn_cikis.TabIndex = 80;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // EKLE
            // 
            this.EKLE.AutoSize = true;
            this.EKLE.Location = new System.Drawing.Point(490, 197);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(43, 17);
            this.EKLE.TabIndex = 94;
            this.EKLE.Text = "EKLE";
            // 
            // masa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 639);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sipars);
            this.Controls.Add(this.btn_fiyath);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridViewSepett);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMenü);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMenüü);
            this.Name = "masa2";
            this.Text = "masa2";
            this.Load += new System.EventHandler(this.masa2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenüü)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepett)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenüü;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMenü;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSepett;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.Button btn_fiyath;
        private System.Windows.Forms.Button btn_sipars;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label EKLE;
    }
}