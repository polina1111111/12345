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
        int N;
        int[] m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void кнопочка_Click(object sender, EventArgs e)
        {
            N = (int)numericUpDown1.Value;
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = N;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
