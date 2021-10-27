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
    public partial class dlina2 : FormNice
    {
        List<MarathonObjects>
               mo = new List<MarathonObjects>();
        public dlina2()
        {
            InitializeComponent();

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox1",
                Name = "Слизняка",
                Length = 0.01,
                Speed = 0.01,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.slug }
            });

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox2",
                Name = "Болида",
                Length = 3.5,
                Speed = 345,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.f1_car }
            });

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox6",
                Name = "Ишака",
                Length = 1.6,
                Speed = 24,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.horse }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox7",
                Name = "Ленивца",
                Length = 0.4,
                Speed = 4,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.sloth }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox8",
                Name = "Капибары",
                Length = 1.3,
                Speed = 35,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.capybara }
            });

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox9",
                Name = "Ягуара",
                Length = 1.8,
                Speed = 80,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.jaguar }
            });



        }

        public class MarathonObjects
        {
            public string ObjectName;
            public string Name;
            public double Length;
            public double Speed;
            public int Type;
            public PictureBox Picture;
        }


        private void dlina2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            PictureBox CurrentPicture = sender as PictureBox;

            /*foreach (var m in mo)
            {

            }*/

            // Type - можно заменить на tabControl1.SelectedIndex

            var m = mo.Where(p => p.ObjectName == CurrentPicture.Name).Single();

          
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }

            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }

            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }





            /*if (tabControl1.SelectedIndex == 0)
            {
                label1.Text = "Длина объекта " + m.Name + " составляет " + m.Length + " м. Потребуется " + (42 * 1000 / m.Length) + " " + m.Name + " чтобы растянуть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }
            

            if (tabControl1.SelectedIndex == 1)
            {
                label1.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.00") + " минут, чтобы преодолеть на весь марафон";
                pictureBox3.Image = m.Picture.Image;
            }*/

            /*switch (((PictureBox)sender).Name)
            {
                case "pictureBox1":
                    {

                    }
                    break;
                case "pictureBox2":
                    {

                    }
                    break;
            }*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dlina2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
         

        }

        private void dlina2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
