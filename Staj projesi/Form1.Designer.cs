namespace Staj_projesi
{
    partial class ana_sayfa
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
            this.b_urunler = new System.Windows.Forms.Button();
            this.b_kisiler = new System.Windows.Forms.Button();
            this.b_form = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_urunler
            // 
            this.b_urunler.BackColor = System.Drawing.Color.SandyBrown;
            this.b_urunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_urunler.Location = new System.Drawing.Point(12, 12);
            this.b_urunler.Name = "b_urunler";
            this.b_urunler.Size = new System.Drawing.Size(305, 142);
            this.b_urunler.TabIndex = 0;
            this.b_urunler.Text = "ÜRÜNLER";
            this.b_urunler.UseVisualStyleBackColor = false;
            this.b_urunler.Click += new System.EventHandler(this.b_urunler_Click);
            // 
            // b_kisiler
            // 
            this.b_kisiler.BackColor = System.Drawing.Color.SandyBrown;
            this.b_kisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_kisiler.Location = new System.Drawing.Point(333, 12);
            this.b_kisiler.Name = "b_kisiler";
            this.b_kisiler.Size = new System.Drawing.Size(305, 142);
            this.b_kisiler.TabIndex = 0;
            this.b_kisiler.Text = "PERSONELLER";
            this.b_kisiler.UseVisualStyleBackColor = false;
            this.b_kisiler.Click += new System.EventHandler(this.b_kisiler_Click);
            // 
            // b_form
            // 
            this.b_form.BackColor = System.Drawing.Color.SandyBrown;
            this.b_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_form.Location = new System.Drawing.Point(653, 12);
            this.b_form.Name = "b_form";
            this.b_form.Size = new System.Drawing.Size(305, 142);
            this.b_form.TabIndex = 0;
            this.b_form.Text = "SORGU EKRANI";
            this.b_form.UseVisualStyleBackColor = false;
            this.b_form.Click += new System.EventHandler(this.b_form_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(695, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programmed by Kuvarti(Ahmet Eryılmaz)";
            // 
            // ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_form);
            this.Controls.Add(this.b_kisiler);
            this.Controls.Add(this.b_urunler);
            this.Name = "ana_sayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.ana_sayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_urunler;
        private System.Windows.Forms.Button b_kisiler;
        private System.Windows.Forms.Button b_form;
        private System.Windows.Forms.Label label1;
    }
}

