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

namespace Алфовит
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "что вы хотите рашифровать ";
            openFileDialog1.Filter = "Все фаилы | *.*|Текстовые фаилы | *.txt";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int num = 0;
                string patc = openFileDialog1.FileName;
                string text = File.ReadAllText(patc);
                File.WriteAllText(patc, text);
                string[] line = text.Split(' ');
                Array.Sort(line);
                for (int i = 0; i < line.Length; i++)
                {
                    listBox1.Items.Add(line[i]);
                }
               
            }
        }
    }
}
