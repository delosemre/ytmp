
namespace ytmp
{
    partial class ytmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ytmp));
            this.yturl = new System.Windows.Forms.TextBox();
            this.mp3 = new System.Windows.Forms.Button();
            this.mp4 = new System.Windows.Forms.Button();
            this.durum = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yturl
            // 
            this.yturl.Location = new System.Drawing.Point(42, 52);
            this.yturl.Name = "yturl";
            this.yturl.Size = new System.Drawing.Size(446, 22);
            this.yturl.TabIndex = 0;
            // 
            // mp3
            // 
            this.mp3.Location = new System.Drawing.Point(110, 107);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(75, 23);
            this.mp3.TabIndex = 1;
            this.mp3.Text = "MP3 İndir";
            this.mp3.UseVisualStyleBackColor = true;
            this.mp3.Click += new System.EventHandler(this.mp3_Click);
            // 
            // mp4
            // 
            this.mp4.Location = new System.Drawing.Point(336, 107);
            this.mp4.Name = "mp4";
            this.mp4.Size = new System.Drawing.Size(75, 23);
            this.mp4.TabIndex = 2;
            this.mp4.Text = "MP4 İndir";
            this.mp4.UseVisualStyleBackColor = true;
            this.mp4.Click += new System.EventHandler(this.mp4_Click);
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Location = new System.Drawing.Point(39, 205);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(0, 17);
            this.durum.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(469, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "WebSite";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(411, 267);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(52, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GitHub";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Youtube Linkini Giriniz!";
            // 
            // ytmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(553, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.mp4);
            this.Controls.Add(this.mp3);
            this.Controls.Add(this.yturl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ytmp";
            this.Text = "Youtube MP3 MP4 İndirici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yturl;
        private System.Windows.Forms.Button mp3;
        private System.Windows.Forms.Button mp4;
        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
    }
}

