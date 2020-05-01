using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APNIUM
{
    public partial class Form1 : Form
    {

        private static IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
            startWeb("https://www.apinfo.com/apinfo/inc/list4.cfm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Inicia o browser e navega para a página desejada
        private void startWeb(String url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }

        //Adiciona o filtro de data
        private void addDateFilter()
        {
            var dataInicio = driver.FindElement(By.Name("ddmmaa1"));
            var dataFim = driver.FindElement(By.Name("ddmmaa2"));
            var filtrar = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/form/div[1]/input"));

            dataInicio.SendKeys("29/04/2020");
            dataFim.SendKeys("29/04/2020");
            filtrar.Click();            
        }

        private void recoverJobs()
        {
            //Thread.Sleep(10);

            var vagas = driver.FindElements(By.XPath("/html/body/div[4]/div[2]/div/section/div[2]/div"));

            foreach (var vaga in vagas)
            {
                Console.WriteLine("\tVaga: " + vaga.Text + "\n\n");
            }
        }
    }
}
