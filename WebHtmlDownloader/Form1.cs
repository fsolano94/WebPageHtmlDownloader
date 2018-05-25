using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebHtmlDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetContentButton_Click(object sender, EventArgs e)
        {
            using (var webClient = new System.Net.WebClient())
            {
                ContentTextBox.Text = webClient.DownloadString(urlTextBox.Text);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var binaryWriter = new BinaryWriter(File.Create(saveFileDialog.FileName)))
                    {
                        binaryWriter.Write(ContentTextBox.Text);
                    }
                }
            }
        }

        private void ContentTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

