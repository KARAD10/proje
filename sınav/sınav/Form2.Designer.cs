namespace sınav
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullanicitxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yastxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baslabtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(238, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kullanicitxtbox
            // 
            this.kullanicitxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullanicitxtbox.Location = new System.Drawing.Point(403, 159);
            this.kullanicitxtbox.Name = "kullanicitxtbox";
            this.kullanicitxtbox.Size = new System.Drawing.Size(157, 22);
            this.kullanicitxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // yastxtbox
            // 
            this.yastxtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yastxtbox.Location = new System.Drawing.Point(403, 214);
            this.yastxtbox.Name = "yastxtbox";
            this.yastxtbox.Size = new System.Drawing.Size(157, 22);
            this.yastxtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yaşınız:";
            // 
            // baslabtn
            // 
            this.baslabtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baslabtn.BackColor = System.Drawing.Color.Firebrick;
            this.baslabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslabtn.Location = new System.Drawing.Point(438, 265);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.Size = new System.Drawing.Size(122, 49);
            this.baslabtn.TabIndex = 5;
            this.baslabtn.Text = "Başla";
            this.baslabtn.UseVisualStyleBackColor = false;
            // 
            // geribtn
            // 
            this.geribtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.geribtn.BackColor = System.Drawing.Color.Firebrick;
            this.geribtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geribtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geribtn.Image = global::sınav.Properties.Resources.goback__1_;
            this.geribtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geribtn.Location = new System.Drawing.Point(256, 265);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(122, 49);
            this.geribtn.TabIndex = 6;
            this.geribtn.Text = "Geri";
            this.geribtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geribtn.UseVisualStyleBackColor = false;
            this.geribtn.Click += new System.EventHandler(this.geribtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sınav.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.baslabtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yastxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanicitxtbox);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kullanicitxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yastxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button baslabtn;
        private System.Windows.Forms.Button geribtn;
    }
}