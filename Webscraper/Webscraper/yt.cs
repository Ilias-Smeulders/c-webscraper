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
    public partial class yt : Form
    {
        public yt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            CsvWriter writer = new CsvWriter();
            writer.writeCSV(dgvYT, txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    dgvYT.Rows.Clear();
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://www.youtube.com/");
                    
                    //Cookies accepteren
                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div[5]/div[2]/ytd-button-renderer[2]/a")).Click();

                    //searchbar vinden en zoektext intypen
                    var element = driver.FindElement(By.CssSelector("input#search"));
                    element.Click();
                    element.SendKeys(txtSearch.Text);
                    element.Submit();
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[1]/div[2]/ytd-search-sub-menu-renderer/div[1]/div/ytd-toggle-button-renderer/a/tp-yt-paper-button/yt-icon")).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[1]/div[2]/ytd-search-sub-menu-renderer/div[1]/iron-collapse/div/ytd-search-filter-group-renderer[5]/ytd-search-filter-renderer[2]/a/div/yt-formatted-string")).Click();
                    Thread.Sleep(500);
                    var vids = driver.FindElements(By.Id("dismissible"));
                    int i = 0;
                    foreach (var vid in vids)
                    { 
                        string titel = vid.FindElement(By.Id("video-title")).Text;

                        //if (jobTitel.StartsWith("nieuw"))
                            //jobTitel = jobTitel.Remove(0, 5);

                        string uploader = vid.FindElement(By.CssSelector("div[id=\"channel-info\"]")).Text;
                        string views = vid.FindElement(By.CssSelector("div[id=\"metadata-line\"]>span")).Text;
                        string link = vid.FindElement(By.CssSelector("a#video-title")).GetAttribute("href").ToString();
                        string[] row = { titel, uploader, views, link };
                        dgvYT.Rows.Add(row);
                        i++;
                        if (i == 5)
                            break;

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
    }
}
