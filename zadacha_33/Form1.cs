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
// Количество и сумма чисел в текстовом файле.
namespace zadacha_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxRead.ReadOnly = true;
        }
        static public int CountNumbers(List<int> list)
        {
            int sum = 0;
            foreach (var e in list)
            {
                sum += e;
            }
            return sum;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string[] arrNumWr = textBoxWriteNum.Text.Split();
            StreamWriter streamWriter = new StreamWriter("FILE_33.txt");
            foreach (var temp in arrNumWr)
            {
                streamWriter.WriteLine(temp);
            }
            streamWriter.Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("FILE_33.txt");
            string tempString;
            List<int> listNum = new List<int>();
            while ((tempString = streamReader.ReadLine()) != null)
            {
                listNum.Add(int.Parse(tempString));
            }
            streamReader.Close();
            textBoxRead.Text = "Количество чисел в файле: " + listNum.Count.ToString() + "\n" + "Сумма чисел: " + CountNumbers(listNum).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            File.WriteAllText("FILE_33.txt", string.Empty);
            
        }
    }
}
