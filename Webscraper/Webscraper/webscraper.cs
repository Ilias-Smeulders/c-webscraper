using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webscraper
{
    public partial class webScraper : Form
    {
        public webScraper()
        {
            InitializeComponent();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSearch.Text != "")
                {
                    dgvJobs.Rows.Clear();
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://be.indeed.com/");
                    var element = driver.FindElement(By.Id("text-input-what"));
                    element.SendKeys(txtSearch.Text);
                    element.Submit();
                    if(txtWaar.Text != "")
                    {
                        var where = driver.FindElement(By.Id("text-input-where"));
                        where.SendKeys(txtWaar.Text);
                    }

                    driver.FindElement(By.ClassName("yosegi-FilterPill-dropdownPillContainer")).Click();
                    driver.FindElement(By.PartialLinkText("Afgelopen 3 dagen")).Click();
                    Thread.Sleep(3000);
                    driver.FindElement(By.ClassName("popover-x-button-close")).Click();

                    var jobs = driver.FindElements(By.ClassName("job_seen_beacon"));
                    foreach (var job in jobs)
                    {
                        string jobTitel = job.FindElement(By.ClassName("jobTitle")).Text;

                        if (jobTitel.StartsWith("nieuw"))
                            jobTitel = jobTitel.Remove(0, 5);

                        string jobBedrijf = job.FindElement(By.ClassName("companyName")).Text;
                        string jobLocatie = job.FindElement(By.ClassName("companyLocation")).Text;
                        string jobLink = driver.FindElement(By.ClassName("sponsoredJob")).GetAttribute("href").ToString();
                        string[] row = {jobTitel, jobBedrijf, jobLocatie, jobLink};
                        dgvJobs.Rows.Add(row);
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

        private void btnCsv_Click(object sender, EventArgs e)
        {
            CsvWriter writer = new CsvWriter();
            writer.writeCSV(dgvJobs, txtSearch.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
