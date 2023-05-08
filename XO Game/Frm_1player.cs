using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XO_Game
{
    public partial class Frm_1player : Form
    {

        /*
         *  mersin üniversitesi bilgisayar programcılığı
         *  Project Name : XO Oyunu
         *  User: Mohamad Younes
         *  GitHub: https://github.com/mohammedadiga
         */


        public Frm_1player()
        {
            InitializeComponent();
        }

        // değişkenler

        List<Guna2Button> buttons;
        Random rand = new Random();
        int player1 = 0;
        int player2 = 0;
        void loadbuttons()
        {
            buttons = new List<Guna2Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }
        void wineffect(Guna2Button b1, Guna2Button b2, Guna2Button b3)
        {
            b1.ForeColor = Color.FromArgb(254, 255, 134);
            b2.ForeColor = Color.FromArgb(254, 255, 134);
            b3.ForeColor = Color.FromArgb(254, 255, 134);
            if (b1.Text == "X")
            {
                player1++;
                lbl1.Text = player1.ToString();
            }
            else
            {
                player2++;
                lbl2.Text = player2.ToString();
            }
        }
        bool win = false;
        void getthewinner()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                wineffect(btn1, btn2, btn3);
                win = true;
                loadbuttons();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                wineffect(btn4, btn5, btn6);
                win = true;
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                wineffect(btn7, btn8, btn9);
                win = true;
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                wineffect(btn1, btn4, btn7);
                win = true;
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                wineffect(btn2, btn5, btn8);
                win = true;
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                wineffect(btn3, btn6, btn9);
                win = true;
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                wineffect(btn1, btn5, btn9);
                win = true;
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                wineffect(btn3, btn5, btn7);
                win = true;
            }
        }

        private void Frm_1player_Load(object sender, EventArgs e)
        {
            foreach (Control c in PanelOfButtons.Controls)
            {
                if (c is Guna2Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
            loadbuttons();
        }

        public void btn_click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                btn.Text = "X";
                btn.ForeColor = Color.FromArgb(25, 167, 206);
                buttons.Remove(btn);
                move.Start();
            }
        }

        private void move_Tick(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && win == false)
            {
                int index = rand.Next(buttons.Count);
                if (buttons[index].Text == "")
                {
                    buttons[index].ForeColor = Color.FromArgb(231, 97, 97);
                    buttons[index].Text = "O";
                    buttons.RemoveAt(index);
                    getthewinner();
                    move.Stop();
                }
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        // Düğme GitHub

        private void GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mohammedadiga/XO_Game");
        }

        // Düğme Ana Sayfa

        private void btnbefore_Click(object sender, EventArgs e)
        {
            frmmain frm = new frmmain();
            frm.Show();
            this.Hide();
        }

        // Düğme Tekrar Oyna

        private void btnplayeragain_Click(object sender, EventArgs e)
        {
            loadbuttons();
            win = false;
            foreach (Control c in PanelOfButtons.Controls)
            {
                if (c is Guna2Button)
                {
                    c.Text = "";
                }
            }
        }

        // Düğme Kapat

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelOfButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
