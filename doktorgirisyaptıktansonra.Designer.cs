
namespace hastane_randevu_otomasyonu
{
    partial class doktorgirisyaptıktansonra
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Location = new System.Drawing.Point(112, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Muayene olan hasta bilgilerini girmek için tıklayınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta Tahlil Sonuçları Girmek için tıklayınız";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Location = new System.Drawing.Point(112, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Git";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(239, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Çıkış yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(41, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // doktorgirisyaptıktansonra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(331, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doktorgirisyaptıktansonra";
            this.Text = "doktorgirisyaptıktansonra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}