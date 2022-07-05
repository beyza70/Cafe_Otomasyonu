
namespace örnekkk
{
    partial class Kasa
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
            this.comboBoxKasa = new System.Windows.Forms.ComboBox();
            this.dataGridViewKasa = new System.Windows.Forms.DataGridView();
            this.sil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKasa
            // 
            this.comboBoxKasa.FormattingEnabled = true;
            this.comboBoxKasa.Location = new System.Drawing.Point(56, 61);
            this.comboBoxKasa.Name = "comboBoxKasa";
            this.comboBoxKasa.Size = new System.Drawing.Size(161, 24);
            this.comboBoxKasa.TabIndex = 0;
            this.comboBoxKasa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKasa_SelectedIndexChanged);
            // 
            // dataGridViewKasa
            // 
            this.dataGridViewKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKasa.Location = new System.Drawing.Point(283, 61);
            this.dataGridViewKasa.Name = "dataGridViewKasa";
            this.dataGridViewKasa.RowHeadersWidth = 51;
            this.dataGridViewKasa.RowTemplate.Height = 24;
            this.dataGridViewKasa.Size = new System.Drawing.Size(544, 320);
            this.dataGridViewKasa.TabIndex = 1;
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(283, 403);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(75, 23);
            this.sil_btn.TabIndex = 2;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 543);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.dataGridViewKasa);
            this.Controls.Add(this.comboBoxKasa);
            this.Name = "Kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKasa;
        private System.Windows.Forms.DataGridView dataGridViewKasa;
        private System.Windows.Forms.Button sil_btn;
    }
}