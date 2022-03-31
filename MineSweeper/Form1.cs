using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public static string userName;
   //     public static bool closeAll=false;
        public Form1()
        {
            InitializeComponent();
             System.Media.SoundPlayer player = new System.Media.SoundPlayer();       
            player.SoundLocation = "mine.wav";
            player.PlayLooping();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
          //  f.Owner = this;
            //  Form f = new Form2();
            // f.Owner = this;
            if (easy.Checked)
            {
                
                //  Form f = new Form2();
                row = col = 9;
                mines = 10;
                text = "Easy";
               // f.Owner = this;
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
               // f.Owner = this;
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
              //  f.Owner = this;
            }
            else if (custom.Checked)
            {
                /*
                 customSet = false;
                Form f1 = new Form2();
                f1.Owner = this;
                while (true)
                {
                    if (f.ShowDialog() == DialogResult.Cancel)
                        break;
                    if (customSet)// if error in custom keep askining until numbers are good and customset = true
                    {
                        text = "Custom: " + row + " by " + col + " &" + mines;
                            break;
                    }
                }*/
                
                Form f1 = new Form3();
                f1.Show();
                f1.Owner = this;
                
            }
            else
                return;
            if (row > 0 && col > 0)
            {
                int size = Math.Min(30, 1000 / Math.Max(row, col));
                f = new Form2(text, row, col, size, mines);
                f.Show(this);
                f.Owner = this;
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseAll_Click(object sender, EventArgs e)
        {
            //closeAll = true;
            foreach (Form f in this.OwnedForms)
                f.Close();
          //  closeAll = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerDisplay.Text = "" + (Double.Parse(timerDisplay.Text) + .1);

            int count = 0;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Visible == true)
                    count++;

            }
            count = count - 1;
            openGames.ForeColor = Color.LightGreen;
            openGames.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
       
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // timer1.Stop();
            if(MessageBox.Show("Are you sure, you want to close this game?","Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No){
                e.Cancel = true;
            }
          //  timer1.Start();
            /*
             DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
             if(confirm == DialogResult.Yes)
             {
                 Application.Exit();

             }
             else if (confirm == DialogResult.No)
             {
                 e.Cancel = true;
             }
             */
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
                f.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            row = col = 9;
            mines = 10;
            text = "Easy";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show(this);
            f.Owner = this;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            row = col = 16;
            mines = 40;
            text = "Medium";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show(this);
            f.Owner = this;
            // f.Owner = this;

        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            row = 30;
            col = 16;
            mines = 99;
            text = "Expert";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            f.Show(this);
            f.Owner = this;
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            userName = userN.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
