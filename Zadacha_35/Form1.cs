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

namespace Zadacha_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSetNandK_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = int.Parse(textBoxN.Text);
            int k = int.Parse(textBoxK.Text);
            int temp = 0;
            int[] arr = new int[n];
            StreamWriter sw = new StreamWriter("FILE_35_1.txt");
            for (int i = 0; i < n; i++)
            {
                temp = rnd.Next(1,100);
                sw.WriteLine(temp);
                arr[i] = temp;
            }
            sw.Close();
            StreamWriter sw1 = new StreamWriter("FILE_35_2.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % k != 0)
                {
                    sw1.WriteLine(arr[i]);
                    listBoxRes.Items.Add(arr[i]);
                }
                    
            }
            sw1.Close();
        }
    }
}
