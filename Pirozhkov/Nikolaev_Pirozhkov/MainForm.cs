using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Nikolaev_Pirozhkov
{
    public partial class MainForm : FormNice
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public MainForm()
        {
            InitializeComponent();
            player.URL = "33.mp3";
            player.settings.volume = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorize2 regForm = new Autorize2();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg2 regForm = new reg2();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Подтверждение закрытия", "Вы уверены что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.Yes
                )
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (
                    MessageBox.Show("Подтверждение закрытия", "Вы уверены что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            info regForm = new info();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dlina2 regForm = new dlina2();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }
    }
}
