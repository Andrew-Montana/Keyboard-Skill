using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Skill
{
    public partial class Form1 : Form
    {        
        Random rand = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)rand.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Игра окончена");
                timer1.Stop();
            }
            if (difficultyProgressBar.Value == 700)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ты победил!");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                timer1.Interval -= 10;
                if (timer1.Interval > 250)
                timer1.Interval -= 7;
                if (timer1.Interval > 100)
                timer1.Interval -= 2;

                difficultyProgressBar.Value = 800 - timer1.Interval;

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            label_Total.Text = "Всего: "+stats.Total;
            label_Good.Text = "Удачно: " +stats.Good;
            label_Bad.Text = "Неудачно: "+stats.Bad;
            label_Accuracy.Text = "Точность: "+stats.Accuracy+"%";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
