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
    public partial class reg3 : FormNice
    {
        
        BindingList<string> list = new BindingList<string>();
        public reg3()
        {
            InitializeComponent();
            list.Add("Мужской");
            list.Add("Женский");
            comboBox1.DataSource = list;
        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            labelDate.Text = dateTimePickerBirth.Value.ToString("MMM");
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            TimeSpan diap = DateTime.Now - dateTimePickerBirth.Value;
            string sss = diap.TotalDays.ToString("0.") + "дней\n" + diap.TotalHours.ToString("0.") + "часов\n" + diap.TotalMinutes.ToString("0.") + " минут";
            MessageBox.Show(sss);
        }

        private void reg3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.ракомсаком as Image;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.pudge2 as Image;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Вы не согласились с условаиями регистрации!");
            }
            else
            {
                MessageBox.Show("Спасибо за согласие!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }
    }
}
