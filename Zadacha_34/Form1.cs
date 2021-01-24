using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Длину строк в файле
namespace Zadacha_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWriter_Click(object sender, EventArgs e)
        {
            string[] tempStrArr = textBoxWriter.Text.Split('.');
            StreamWriter sw = new StreamWriter("FILE_34.txt");
            foreach (var str in tempStrArr)
            {
                sw.WriteLine(str);
            }
            sw.Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("FILE_34.txt");
            string str = null;
            List<string> listString = new List<string>();
            while ((str = sr.ReadLine()) != null)
            {
                listString.Add(str);
            }
            for (int i = 0; i < listString.Count-1; i++)
            {
                listBoxRead.Items.Add("Строка: " + listString[i] + "-" + "Длина: " + listString[i].Length);
            }
        }
    }
}
