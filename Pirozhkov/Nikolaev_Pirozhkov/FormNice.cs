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
    public partial class FormNice : Form
    {
        public FormNice()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }
    }
}
