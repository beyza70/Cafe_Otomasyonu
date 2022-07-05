
namespace örnekkk
{
    partial class KasierGirisi
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
            this.cikis_btn = new System.Windows.Forms.Button();
            this.kasa_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.White;
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Location = new System.Drawing.Point(469, 185);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(141, 104);
            this.cikis_btn.TabIndex = 13;
            this.cikis_btn.Text = "Çıkış";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // kasa_btn
            // 
            this.kasa_btn.BackColor = System.Drawing.Color.White;
            this.kasa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasa_btn.Location = new System.Drawing.Point(261, 185);
            this.kasa_btn.Name = "kasa_btn";
            this.kasa_btn.Size = new System.Drawing.Size(141, 104);
            this.kasa_btn.TabIndex = 12;
            this.kasa_btn.Text = "Kasa";
            this.kasa_btn.UseVisualStyleBackColor = false;
            this.kasa_btn.Click += new System.EventHandler(this.kasa_btn_Click);
            // 
            // KasierGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.ClientSize = new System.Drawing.Size(929, 504);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.kasa_btn);
            this.Name = "KasierGirisi";
            this.Text = "KasierGirisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button kasa_btn;
    }
}