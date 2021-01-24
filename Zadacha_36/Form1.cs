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

namespace Zadacha_36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double Precent(int a, int b)
        {
            return (b*100)/a;
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            int positiveNumCount = 0;
            int temprnd;
            int n = int.Parse(textBoxCount.Text);
            Random rnd = new Random();
            StreamWriter sw = new StreamWriter("FILE_36.txt");
            for (int i = 0; i < n; i++)
            {
                temprnd = rnd.Next(-100, 100);
                sw.WriteLine(temprnd);
                if (temprnd > 0)
                    positiveNumCount++;
            }
            sw.Close();
            listBoxGetNum.Items.Add(positiveNumCount);
            listBoxGetNum.Items.Add("Всего сгенерируемых чисел: " + n + "Процент положительных чисел: " + Precent(n,positiveNumCount));
        }
    }
}
