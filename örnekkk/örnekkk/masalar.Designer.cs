
namespace örnekkk
{
    partial class masalar
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
            this.masa2_btn = new System.Windows.Forms.Button();
            this.masa1_btn = new System.Windows.Forms.Button();
            this.masa3_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masa2_btn
            // 
            this.masa2_btn.BackColor = System.Drawing.Color.White;
            this.masa2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masa2_btn.Location = new System.Drawing.Point(357, 171);
            this.masa2_btn.Name = "masa2_btn";
            this.masa2_btn.Size = new System.Drawing.Size(141, 104);
            this.masa2_btn.TabIndex = 18;
            this.masa2_btn.Text = "Masa 2";
            this.masa2_btn.UseVisualStyleBackColor = false;
            this.masa2_btn.Click += new System.EventHandler(this.masa2_Click);
            // 
            // masa1_btn
            // 
            this.masa1_btn.BackColor = System.Drawing.Color.White;
            this.masa1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masa1_btn.Location = new System.Drawing.Point(141, 171);
            this.masa1_btn.Name = "masa1_btn";
            this.masa1_btn.Size = new System.Drawing.Size(141, 104);
            this.masa1_btn.TabIndex = 14;
            this.masa1_btn.Text = "Masa 1";
            this.masa1_btn.UseVisualStyleBackColor = false;
            this.masa1_btn.Click += new System.EventHandler(this.masa1_Click);
            // 
            // masa3_btn
            // 
            this.masa3_btn.BackColor = System.Drawing.Color.White;
            this.masa3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masa3_btn.Location = new System.Drawing.Point(552, 171);
            this.masa3_btn.Name = "masa3_btn";
            this.masa3_btn.Size = new System.Drawing.Size(141, 104);
            this.masa3_btn.TabIndex = 13;
            this.masa3_btn.Text = "Masa 3";
            this.masa3_btn.UseVisualStyleBackColor = false;
            this.masa3_btn.Click += new System.EventHandler(this.masa3_Click);
            // 
            // masalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           
            this.ClientSize = new System.Drawing.Size(908, 533);
            this.Controls.Add(this.masa2_btn);
            this.Controls.Add(this.masa1_btn);
            this.Controls.Add(this.masa3_btn);
            this.Name = "masalar";
            this.Text = "masalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button masa2_btn;
        private System.Windows.Forms.Button masa1_btn;
        private System.Windows.Forms.Button masa3_btn;
    }
}