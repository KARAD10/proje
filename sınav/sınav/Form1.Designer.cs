namespace sınav
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnTalimat = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBasla.BackColor = System.Drawing.Color.Maroon;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(418, 117);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(106, 53);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnTalimat
            // 
            this.btnTalimat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTalimat.BackColor = System.Drawing.Color.Maroon;
            this.btnTalimat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTalimat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalimat.Location = new System.Drawing.Point(418, 198);
            this.btnTalimat.Name = "btnTalimat";
            this.btnTalimat.Size = new System.Drawing.Size(106, 53);
            this.btnTalimat.TabIndex = 1;
            this.btnTalimat.Text = "Talimatlar";
            this.btnTalimat.UseVisualStyleBackColor = false;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCıkıs.BackColor = System.Drawing.Color.Maroon;
            this.btnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCıkıs.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(418, 279);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(106, 53);
            this.btnCıkıs.TabIndex = 2;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sınav.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnTalimat);
            this.Controls.Add(this.btnBasla);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnTalimat;
        private System.Windows.Forms.Button btnCıkıs;
    }
}

