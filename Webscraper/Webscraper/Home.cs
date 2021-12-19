using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webscraper
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnIndeed_Click(object sender, EventArgs e)
        {
            webScraper scraper = new webScraper();
            scraper.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYT_Click(object sender, EventArgs e)
        {
            this.Hide();
            yt yt = new yt();
            yt.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop shop = new Shop();
            shop.Show();

        }
    }
}
