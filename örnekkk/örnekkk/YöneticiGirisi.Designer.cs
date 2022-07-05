
namespace örnekkk
{
    partial class YöneticiGirisi
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
            this.siparisler_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.personeller_btn = new System.Windows.Forms.Button();
            this.kasa_btn = new System.Windows.Forms.Button();
            this.masalar_btn = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siparisler_btn
            // 
            this.siparisler_btn.BackColor = System.Drawing.Color.White;
            this.siparisler_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisler_btn.Location = new System.Drawing.Point(381, 119);
            this.siparisler_btn.Name = "siparisler_btn";
            this.siparisler_btn.Size = new System.Drawing.Size(141, 104);
            this.siparisler_btn.TabIndex = 12;
            this.siparisler_btn.Text = "Siparişler";
            this.siparisler_btn.UseVisualStyleBackColor = false;
            this.siparisler_btn.Click += new System.EventHandler(this.siparisler_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.White;
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Location = new System.Drawing.Point(586, 297);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(141, 104);
            this.cikis_btn.TabIndex = 11;
            this.cikis_btn.Text = "Çıkış";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_Click);
            // 
            // personeller_btn
            // 
            this.personeller_btn.BackColor = System.Drawing.Color.White;
            this.personeller_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personeller_btn.Location = new System.Drawing.Point(175, 297);
            this.personeller_btn.Name = "personeller_btn";
            this.personeller_btn.Size = new System.Drawing.Size(141, 104);
            this.personeller_btn.TabIndex = 10;
            this.personeller_btn.Text = "Personeller";
            this.personeller_btn.UseVisualStyleBackColor = false;
            this.personeller_btn.Click += new System.EventHandler(this.personeller_Click);
            // 
            // kasa_btn
            // 
            this.kasa_btn.BackColor = System.Drawing.Color.White;
            this.kasa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasa_btn.Location = new System.Drawing.Point(381, 297);
            this.kasa_btn.Name = "kasa_btn";
            this.kasa_btn.Size = new System.Drawing.Size(141, 104);
            this.kasa_btn.TabIndex = 9;
            this.kasa_btn.Text = "Kasa";
            this.kasa_btn.UseVisualStyleBackColor = false;
            this.kasa_btn.Click += new System.EventHandler(this.kasa_Click);
            // 
            // masalar_btn
            // 
            this.masalar_btn.BackColor = System.Drawing.Color.White;
            this.masalar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masalar_btn.Location = new System.Drawing.Point(175, 119);
            this.masalar_btn.Name = "masalar_btn";
            this.masalar_btn.Size = new System.Drawing.Size(141, 104);
            this.masalar_btn.TabIndex = 8;
            this.masalar_btn.Text = "Masalar";
            this.masalar_btn.UseVisualStyleBackColor = false;
            this.masalar_btn.Click += new System.EventHandler(this.masalar_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.White;
            this.menu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_btn.Location = new System.Drawing.Point(586, 119);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(141, 104);
            this.menu_btn.TabIndex = 7;
            this.menu_btn.Text = "Menü";
            this.menu_btn.UseVisualStyleBackColor = false;
            this.menu_btn.Click += new System.EventHandler(this.menü_Click);
            // 
            // YöneticiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(928, 543);
            this.Controls.Add(this.siparisler_btn);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.personeller_btn);
            this.Controls.Add(this.masalar_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.kasa_btn);
            this.Name = "YöneticiGirisi";
            this.Text = "YöneticiGirisi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siparisler_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button personeller_btn;
        private System.Windows.Forms.Button kasa_btn;
        private System.Windows.Forms.Button masalar_btn;
        private System.Windows.Forms.Button menu_btn;
    }
}