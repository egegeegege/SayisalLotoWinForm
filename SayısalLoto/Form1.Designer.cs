namespace SayısalLoto
{
    partial class Form1
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
            this.btn_sayiolustur = new System.Windows.Forms.Button();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sayiolustur
            // 
            this.btn_sayiolustur.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_sayiolustur.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sayiolustur.ForeColor = System.Drawing.Color.White;
            this.btn_sayiolustur.Location = new System.Drawing.Point(340, 346);
            this.btn_sayiolustur.Name = "btn_sayiolustur";
            this.btn_sayiolustur.Size = new System.Drawing.Size(207, 76);
            this.btn_sayiolustur.TabIndex = 0;
            this.btn_sayiolustur.Text = "Sayıyı Bul";
            this.btn_sayiolustur.UseVisualStyleBackColor = false;
            this.btn_sayiolustur.Click += new System.EventHandler(this.btn_sayiolustur_Click);
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.BackColor = System.Drawing.Color.White;
            this.lbl_Sonuc.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sonuc.Location = new System.Drawing.Point(335, 68);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(0, 29);
            this.lbl_Sonuc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SayısalLoto.Properties.Resources._60767ba22269a20920736557;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 505);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.btn_sayiolustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sayiolustur;
        private System.Windows.Forms.Label lbl_Sonuc;
    }
}

