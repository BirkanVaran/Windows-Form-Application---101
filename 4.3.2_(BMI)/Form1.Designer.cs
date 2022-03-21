
namespace _4._3._2__BMI_
{
    partial class FormVKI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAgirlik = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblCinsiyetSecimi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAgirlik
            // 
            this.lblAgirlik.AutoSize = true;
            this.lblAgirlik.Location = new System.Drawing.Point(28, 40);
            this.lblAgirlik.Name = "lblAgirlik";
            this.lblAgirlik.Size = new System.Drawing.Size(85, 20);
            this.lblAgirlik.TabIndex = 0;
            this.lblAgirlik.Text = "Ağırlık (kg):";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(28, 76);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(64, 20);
            this.lblBoy.TabIndex = 1;
            this.lblBoy.Text = "Boy (m):";
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(119, 37);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(125, 27);
            this.txtAgirlik.TabIndex = 2;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(119, 73);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(125, 27);
            this.txtBoy.TabIndex = 3;
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(145, 114);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(68, 24);
            this.radioButtonKadin.TabIndex = 4;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(219, 114);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(65, 24);
            this.radioButtonErkek.TabIndex = 5;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(250, 37);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(125, 63);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblCinsiyetSecimi
            // 
            this.lblCinsiyetSecimi.AutoSize = true;
            this.lblCinsiyetSecimi.Location = new System.Drawing.Point(28, 116);
            this.lblCinsiyetSecimi.Name = "lblCinsiyetSecimi";
            this.lblCinsiyetSecimi.Size = new System.Drawing.Size(111, 20);
            this.lblCinsiyetSecimi.TabIndex = 7;
            this.lblCinsiyetSecimi.Text = "Cinsiyet Seçimi:";
            // 
            // FormVKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 161);
            this.Controls.Add(this.lblCinsiyetSecimi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.radioButtonKadin);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblAgirlik);
            this.Name = "FormVKI";
            this.Text = "Vücut Kitle Enedeksi Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgirlik;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblCinsiyetSecimi;
    }
}

