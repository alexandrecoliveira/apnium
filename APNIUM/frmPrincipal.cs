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
using System.Threading;

namespace APNIUM
{
    public partial class frmPrincipal : Form
    {

        private static IWebDriver driver;

        public frmPrincipal()
        {
            InitializeComponent();            
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
        private void addDateFilter(String dataI, String dataF)
        {
            var dataInicio = driver.FindElement(By.Name("ddmmaa1"));
            var dataFim = driver.FindElement(By.Name("ddmmaa2"));
            var filtrar = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/form/div[1]/input"));

            dataInicio.SendKeys(dataI);
            dataFim.SendKeys(dataF);
            filtrar.Click();            
        }

        private void recoverJobs()
        {
            //Thread.Sleep(10);
            var vagas = driver.FindElements(By.XPath("/html/body/div[4]/div[2]/div/section/div[2]/div"));

            foreach (var vaga in vagas)
            {
                //Console.WriteLine("\tVaga: " + vaga.Text + "\n\n");
                txtResult.AppendText("\t\tVaga: " + vaga.Text + "\n\n");                    
            }
        }

        private void nextPage()
        {
            var nPaginas = driver.FindElement(By.ClassName("n-paginas"));
            int nroPaginas = int.Parse(nPaginas.Text.Substring(nPaginas.Text.Length - 3));
            Console.WriteLine(nroPaginas + "\t\t" + (nroPaginas - 1));

            //var campoProxPagina = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/section/form/div/div[2]/table/tbody/tr/td[4]/input"));
            //var botaoProxPagina = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/section/form/div/div[2]/table/tbody/tr/td[5]/input"));

            int i = 1;
            while (i < nroPaginas)
            {
                var botaoProxPagina = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/section/form/div/div[2]/table/tbody/tr/td[5]/input"));
                //var campoProxPagina = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/section/form/div/div[2]/table/tbody/tr/td[4]/input"));
                //campoProxPagina.Clear();
                //campoProxPagina.SendKeys(i.ToString());
                botaoProxPagina.Click();
                i++;
                Thread.Sleep(10000);
            }
        }                

        private void btnScrap_Click(object sender, EventArgs e)
        {
            startWeb("https://www.apinfo.com/apinfo/inc/list4.cfm");
                        
            frmDataInicio.MaxSelectionCount = 1;
            frmDataFim.MaxSelectionCount = 1;
            
            var dtInicio = frmDataInicio.SelectionRange.Start.ToString("dd/MM/yy");
            var dtFim = frmDataFim.SelectionRange.Start.ToString("dd/MM/yy");

            addDateFilter(dtInicio, dtFim);
            recoverJobs();
        }
    }
}
