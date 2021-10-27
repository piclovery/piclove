using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikolaev_Pirozhkov
{
    public partial class info : FormNice
    {
        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void trackBarImage_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBarImage.Value)
            {
                case 1:
                    pictureBoxImage.Image = Properties.Resources.brazil as Image;
                    pictureBoxImage.Text = "1";
                    break;
                case 2:
                    pictureBoxImage.Image = Properties.Resources.banco_banespa as Image;
                    pictureBoxImage.Text = "2";
                    break;
                case 3:
                    pictureBoxImage.Image = Properties.Resources.ibirapuera_park_lake as Image;
                    pictureBoxImage.Text = "3";
                    break;
                case 4:
                    pictureBoxImage.Image = Properties.Resources.marathon_image as Image;
                    pictureBoxImage.Text = "4";
                    break;
                case 5:
                    pictureBoxImage.Image = Properties.Resources.teatro_municipal as Image;
                    pictureBoxImage.Text = "5";
                    break;
            }
        }

        private void trackBarImage_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
