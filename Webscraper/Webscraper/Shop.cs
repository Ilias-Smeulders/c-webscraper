using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webscraper
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    dgvBol.Rows.Clear();
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.bol.com/be/nl/");

                    //Cookies accepteren
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//*[@id=\"modalWindow\"]/div[2]/div[2]/wsp-consent-modal/div[2]/button[1]")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath("/html/body/wsp-modal-window/div[2]/button")).Click();
                    //find searchbar and search!
                    var element = driver.FindElement(By.XPath("//*[@id=\"searchfor\"]"));
                    element.Click();
                    element.SendKeys(txtSearch.Text);
                    element.Submit();
                    //waiting for bol to load
                    Thread.Sleep(500);
                    //getting all articles
                    var artikelen = driver.FindElements(By.CssSelector("li.product-item--row.js_item_root"));
                    foreach (var art in artikelen)
                    {
                        //getting data from list
                        string titel = art.FindElement(By.CssSelector("a.product-title")).Text;
                        string prijs = art.FindElement(By.CssSelector("div.price-block__highlight>meta")).GetAttribute("content").ToString();
                        string sterren = art.FindElement(By.CssSelector("div.star-rating")).GetAttribute("Title").ToString()[18].ToString();
                        string url = art.FindElement(By.CssSelector("a.product-title")).GetAttribute("href").ToString();
                       
                        //putting data in DGV
                        string[] row = { titel, prijs, sterren, url };
                        dgvBol.Rows.Add(row);
                        
                    }
                    driver.Quit();
                }
                else
                {
                    MessageBox.Show("Uw zoekopdracht was leeg!", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Er ging iets mis!", "Error");
                throw;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (dgvBol != null)
            {
                if (rbSterren.Checked)
                    dgvBol.Sort(dgvBol.Columns["Sterren"], ListSortDirection.Ascending);
                if (rbPrijs.Checked)
                    dgvBol.Sort(dgvBol.Columns["Prijs"], ListSortDirection.Ascending);
                else
                    dgvBol.Sort(dgvBol.Columns["Artikel"], ListSortDirection.Descending);
            }
            else
                MessageBox.Show("Zoek eerst iets op", "Error");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            CsvWriter writer = new CsvWriter();
            writer.writeCSV(dgvBol, txtSearch.Text);
        }
    }
}
