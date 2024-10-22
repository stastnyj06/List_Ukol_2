using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                Random random = new Random();
                List<int> cisla = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    cisla.Add(random.Next(-6, 26));
                }
                listBox1.Items.Clear();
                foreach (var c in cisla)
                {
                    listBox1.Items.Add(c);
                }
                List<int> reverze = new List<int>(cisla);
                reverze.Reverse();
                listBox2.Items.Clear();
                foreach (var c in reverze)
                {
                    listBox2.Items.Add(c);
                }
                int minv = cisla.Min();
                List<int> min = new List<int>();
                for (int i = 0; i < cisla.Count; i++)
                {
                    if (cisla[i] == minv)
                    {
                        min.Add(i);
                    }
                }
                listBox3.Items.Clear();
                foreach (var index in min)
                {
                    listBox3.Items.Add(index);
                }
            }
            else
            {
                MessageBox.Show("Zadejte platné číslo pro n.");
            }
        }
    }
}
