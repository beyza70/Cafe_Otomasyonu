
namespace örnekkk
{
    partial class siparisler
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
            this.dataGridViewsiparisler = new System.Windows.Forms.DataGridView();
            this.comboBoxsiparisler = new System.Windows.Forms.ComboBox();
            this.SilmeButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewsiparisler
            // 
            this.dataGridViewsiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsiparisler.Location = new System.Drawing.Point(207, 79);
            this.dataGridViewsiparisler.Name = "dataGridViewsiparisler";
            this.dataGridViewsiparisler.RowHeadersWidth = 51;
            this.dataGridViewsiparisler.RowTemplate.Height = 24;
            this.dataGridViewsiparisler.Size = new System.Drawing.Size(642, 334);
            this.dataGridViewsiparisler.TabIndex = 0;
            this.dataGridViewsiparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsiparisler_CellContentClick);
            // 
            // comboBoxsiparisler
            // 
            this.comboBoxsiparisler.FormattingEnabled = true;
            this.comboBoxsiparisler.Location = new System.Drawing.Point(27, 79);
            this.comboBoxsiparisler.Name = "comboBoxsiparisler";
            this.comboBoxsiparisler.Size = new System.Drawing.Size(151, 24);
            this.comboBoxsiparisler.TabIndex = 1;
            this.comboBoxsiparisler.SelectedIndexChanged += new System.EventHandler(this.comboBoxsiparisler_SelectedIndexChanged);
            // 
            // SilmeButonu
            // 
            this.SilmeButonu.Location = new System.Drawing.Point(207, 440);
            this.SilmeButonu.Name = "SilmeButonu";
            this.SilmeButonu.Size = new System.Drawing.Size(150, 30);
            this.SilmeButonu.TabIndex = 2;
            this.SilmeButonu.Text = "Seçili Satırı Sil";
            this.SilmeButonu.UseVisualStyleBackColor = true;
            this.SilmeButonu.Click += new System.EventHandler(this.SilmeButonu_Click);
            // 
            // siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 554);
            this.Controls.Add(this.SilmeButonu);
            this.Controls.Add(this.comboBoxsiparisler);
            this.Controls.Add(this.dataGridViewsiparisler);
            this.Name = "siparisler";
            this.Text = "siparisler";
            this.Load += new System.EventHandler(this.siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsiparisler;
        private System.Windows.Forms.ComboBox comboBoxsiparisler;
        private System.Windows.Forms.Button SilmeButonu;
    }
}