using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        private int player;
        private int x = 12, y=12;
        private Button[,] buttons = new Button[3,3];
          
        public Form1()
        {

            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            player = 1;
            label1.Text = "Yurish xod: o'yinchi 1";
            for(int i = 0; i < buttons.Length/3; i++)
            {
                for(int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                }
            }
            SetButtons();
        
        }
        private void SetButtons()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 203 * i, 12 + 203 * j);
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                    buttons[i,j].BackColor = Color.LimeGreen;
                    this.Controls.Add(buttons[i, j]);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    label1.Text = "Yurish xod: o'yinchi 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "0");
                    player = 1;
                    label1.Text = "Yurish xod: o'yinchi 1";
                    break;
            }
            //  MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkwin();
        }
        private void checkwin()
        {
            if (buttons[0,0].Text=="X" && buttons[0,1].Text== "X" && buttons[0,2].Text=="X" || buttons[0,0].Text == "0" && buttons[0,1].Text == "0" && buttons[0,2].Text == "0") {
                MessageBox.Show("O'yin tugadi! ");
            }
            if (buttons[1,0].Text == "X" && buttons[1,1].Text == "X" && buttons[1,2].Text == "X" || buttons[1,0].Text == "0" && buttons[1,1].Text == "0" && buttons[1,2].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
            if (buttons[2, 0].Text == "X" && buttons[2, 1].Text == "X" && buttons[2, 2].Text == "X" || buttons[2, 0].Text == "0" && buttons[2, 1].Text == "0" && buttons[2, 2].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
            ////////////////
            if (buttons[0, 0].Text == "X" && buttons[1, 0].Text == "X" && buttons[2, 0].Text == "X" || buttons[0, 0].Text == "0" && buttons[1, 0].Text == "0" && buttons[2, 0].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
            if (buttons[0, 1].Text == "X" && buttons[1, 1].Text == "X" && buttons[2, 1].Text == "X" || buttons[0, 1].Text == "0" && buttons[1, 1].Text == "0" && buttons[2, 1].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
            if (buttons[0, 2].Text == "X" && buttons[1, 2].Text == "X" && buttons[2, 2].Text == "X" || buttons[0, 2].Text == "0" && buttons[1, 2].Text == "0" && buttons[2, 2].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
            ///////////////////////
            if (buttons[0, 2].Text == "X" && buttons[1, 1].Text == "X" && buttons[2, 0].Text == "X" || buttons[0, 2].Text == "0" && buttons[1, 1].Text == "0" && buttons[2, 0].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
            if (buttons[0, 0].Text == "X" && buttons[1, 1].Text == "X" && buttons[2, 2].Text == "X" || buttons[0, 0].Text == "0" && buttons[1, 1].Text == "0" && buttons[2, 2].Text == "0")
            {
                MessageBox.Show("O'yin tugadi! ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<3; i++)
            {
                 for(int j = 0; j<3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i,j].Enabled = true;
                    label1.Text = "Yurish xod: o'yinchi 1";
                }
            }
        }
    }
}
