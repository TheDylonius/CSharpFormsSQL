using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSharpFormsSQL
{
    public partial class FileDownloader : Form
    {
        WebClient client = new WebClient();
        SaveFileDialog fileSaver = new SaveFileDialog();

        public FileDownloader()
        {
            InitializeComponent();
        }

        private void downloadFreeze_Click(object sender, EventArgs e)
        {
            // DownloadFile freezes the interface while it downloads the file.
            if(fileSaver.ShowDialog() == DialogResult.OK)
            {
                client.DownloadFile("https://pixabay.com/en/videos/download/video-5194_source.mp4", fileSaver.FileName);
            }
        }

        private void downloadNoFreeze_Click(object sender, EventArgs e)
        {
            // DownloadFile freezes the interface while it downloads the file.
            if (fileSaver.ShowDialog() == DialogResult.OK)
            {
                client.DownloadFileAsync(new Uri("https://pixabay.com/en/videos/download/video-5194_source.mp4"), fileSaver.FileName);
            }
        }

        private void openWinExplore_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select," + fileSaver.FileName);
        }
    }
}