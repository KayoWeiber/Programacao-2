using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_04_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
            //dateTimePicker1.Value = DateTime.UtcNow;
            dateTimePicker1.Value = DateTime.Now;
            DateTime teste = dateTimePicker1.Value;
            teste = teste.AddDays(7);
            TimeSpan diferença = DateTime.Now - teste;
            MessageBox.Show(diferença.ToString());
            DateTime data = new DateTime(2025, 8, 20, 10, 30, 45);
            dateTimePicker1.Value = data;
            MessageBox.Show(data.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
