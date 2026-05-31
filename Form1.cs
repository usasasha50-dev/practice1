using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                double x = Convert.ToDouble(textBox1.Text);
                double y = Math.Sqrt(Math.Abs(x - 1)) + Math.Sin(x);
                textBox2.Text = y.ToString("F4");
                textBox3.Text = "Успішно обчислено";
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка введення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "Помилка введення даних";
            }
        }
    }
}
