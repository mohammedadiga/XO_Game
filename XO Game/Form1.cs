using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class frmmain : Form
    {

        /*
         *  mersin üniversitesi bilgisayar programcılığı
         *  Project Name : XO Oyunu
         *  User: Mohamad Younes
         *  GitHub: https://github.com/mohammedadiga
         */

        public frmmain()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        // Düğme GitHub

        private void GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mohammedadiga/XO_Game");
        }

        // Düğme 1 Oyuncu

        private void btn1player_Click(object sender, EventArgs e)
        {
            Frm_1player frm = new Frm_1player();
            frm.Show();
            this.Hide();
        }

        // Düğme 2 Oyuncu

        private void btn2player_Click(object sender, EventArgs e)
        {
            Frm_2player frm = new Frm_2player();
            frm.Show();
            this.Hide();
        }

        // Düğme Çıkış

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
