using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713107.Properties;

namespace WP_2020_01_HW02_3A713107
{
    public partial class frmGame : Form
    {
        List<Image> list;
        Poker p = null;
        List<int> Poker;


        public frmGame()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int index = 3;//模擬隨機產生 一個值;
            btnDraw.Image = list[index];
        }

        int a = 0;
        private void btnGO_Click(object sender, EventArgs e)
        {
            if (a < 30)
            {
                btnDraw.Image = list[Poker[a]];
                a = a + 1;
            }
        }

        private void frmGame_Load_1(object sender, EventArgs e)
        {
            p = new Poker();
            Poker = p.GetPoker(30);
            list = new List<Image>();

            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._007);
            list.Add(Resources._004);
            list.Add(Resources._006);
            list.Add(Resources._009);
            list.Add(Resources._012);
            list.Add(Resources._013);
            list.Add(Resources._014);
            list.Add(Resources._016);
            list.Add(Resources._017);
            list.Add(Resources._018);
            list.Add(Resources._019);
            list.Add(Resources._020);
            list.Add(Resources._021);
            list.Add(Resources._025);
            list.Add(Resources._026);
            list.Add(Resources._028);
            list.Add(Resources._029);
            list.Add(Resources._031);
            list.Add(Resources._032);
            list.Add(Resources._033);
            list.Add(Resources._034);
            list.Add(Resources._035);
            list.Add(Resources._036);
            list.Add(Resources._037);
            list.Add(Resources._038);
            list.Add(Resources._040);
            list.Add(Resources._042);
            list.Add(Resources._044);
            list.Add(Resources._048);
            list.Add(Resources._050);
        }
    }
}
