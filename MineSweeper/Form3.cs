using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form3 : Form
    {
        public static int rows=0;
        public static int cols=0;
        public static int nMines=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
             rows = int.Parse(row.Text);
             cols = int.Parse(col.Text);
             nMines = int.Parse(numOfMines.Text);

            if (rows * cols < 18)
                MessageBox.Show("Field is too small!! ");
            else if (nMines > rows * cols / 2)
                MessageBox.Show("Too many mines! At-most half of the ");
            else
            {
                this.Hide();
                // Form f2 = new Form2();
                int size = Math.Min(30, 1000 / Math.Max(rows, cols));
                Form2 f2 = new Form2("Custom", rows, cols, size, nMines);
                 f2.Owner = this;
                f2.Show();
               // this.Hide();
             //  this.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void row_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Column_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close this game?", "Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
