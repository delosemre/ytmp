using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.IO;
using System.Windows.Forms;
using VideoLibrary;

namespace ytmp
{
    public partial class ytmp : Form
    {
        public ytmp()
        {
            InitializeComponent();
        }

        public void mp3_Click(object sender, EventArgs e)
        {
            durum.Text = "İndirme İşlemi Başladı...";
            var dosyayol = Application.StartupPath;
            var source = @dosyayol;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(yturl.Text);
            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());
            durum.Text = "MP3 indiriliyor...";

            MediaFile inputFile = new MediaFile { Filename = source + vid.FullName };
            MediaFile outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };
            
            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                engine.Convert(inputFile, outputFile);
            }

            FileInfo info = new FileInfo(source + vid.FullName);

            info.MoveTo(vid.Title + ".mp3");
            File.Delete(source+vid.FullName+".mp3");
            
            durum.Text = "İşlem bitti!";
            MessageBox.Show(vid.Title + " Şuraya yüklenmiştir: " + dosyayol );
            
        }

        public void mp4_Click(object sender, EventArgs e)
        {
            durum.Text = "İndirme İşlemi Başladı...";
            var dosyayol = Application.StartupPath;
            var source = dosyayol;
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(yturl.Text);
            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());
            durum.Text = "MP4 işlemi uzun sürebilir. Tahmini 2 dk";
            var inputFile = new MediaFile { Filename = source + vid.FullName };
            var outputFile = new MediaFile { Filename = $"{vid.Title}.mp4" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
                engine.Convert(inputFile, outputFile);
            }
            File.Delete(source + vid.FullName);
            
            durum.Text = "İşlem bitti!";
            MessageBox.Show(vid.Title + " Şuraya yüklenmiştir: " + dosyayol);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://emreylmz.com");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/delosemre");

        }
    }
}
