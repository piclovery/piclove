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
    public partial class FormPattern : Form
    {
        public FormPattern()
        {
            InitializeComponent();
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
            info regForm = new info();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }
    }
}
