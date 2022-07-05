
namespace örnekkk
{
    partial class GarsonGirisi
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
            this.btn_siparisler = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_masalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_siparisler
            // 
            this.btn_siparisler.BackColor = System.Drawing.Color.White;
            this.btn_siparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparisler.Location = new System.Drawing.Point(400, 186);
            this.btn_siparisler.Name = "btn_siparisler";
            this.btn_siparisler.Size = new System.Drawing.Size(141, 104);
            this.btn_siparisler.TabIndex = 12;
            this.btn_siparisler.Text = "Siparişler";
            this.btn_siparisler.UseVisualStyleBackColor = false;
            this.btn_siparisler.Click += new System.EventHandler(this.btn_siparisler_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.White;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(619, 186);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(141, 104);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_masalar
            // 
            this.btn_masalar.BackColor = System.Drawing.Color.White;
            this.btn_masalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_masalar.Location = new System.Drawing.Point(184, 186);
            this.btn_masalar.Name = "btn_masalar";
            this.btn_masalar.Size = new System.Drawing.Size(141, 104);
            this.btn_masalar.TabIndex = 8;
            this.btn_masalar.Text = "Masalar";
            this.btn_masalar.UseVisualStyleBackColor = false;
            this.btn_masalar.Click += new System.EventHandler(this.btn_masalar_Click);
            // 
            // GarsonGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(989, 548);
            this.Controls.Add(this.btn_siparisler);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_masalar);
            this.Name = "GarsonGirisi";
            this.Text = "GarsonFormu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_siparisler;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_masalar;
    }
}