using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
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
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("headless");
            //driver = new ChromeDriver(chromeOptions);
            try 
	        {	        
		        driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
	        }
	        catch (Exception e)
	        {
                Console.WriteLine(e);   
                throw e;
	        }                                                               
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
                var cidade = vaga.FindElement(By.ClassName("info-data"));

                if (cidade.Text.Substring(0, cidade.Text.IndexOf("-")).ToString().Equals("São Paulo ") ||
                    cidade.Text.Substring(0, cidade.Text.IndexOf("-")).ToString().Equals("Barueri "))
                    txtResult.AppendText("\t\tVaga: " + vaga.Text + "\n\n");
                //txtResult.AppendText(cidade.Text.Substring(0, cidade.Text.IndexOf("-")) + "\n\n");                                                   
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
            
            try
            {
                var nPaginas = driver.FindElement(By.ClassName("n-paginas")); //Encontra o valor do nro de páginas no html
                int nroPaginas = int.Parse(nPaginas.Text.Substring(nPaginas.Text.IndexOf("de ") + 3));

                int i = 1;  //Representa a primeira página
                while (i < nroPaginas)
                {
                    var botaoProxPagina = driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/section/form/div/div[2]/table/tbody/tr/td[5]/input"));

                    recoverJobs();
                    //Thread.Sleep(5000);
                    botaoProxPagina.Click();
                    i++;
                }
                driver.Close();

            }
            catch (Exception ex)
            {
                txtResult.AppendText("*** ERRO: A BUSCA NÃO RETORNOU VALORES *** \n\n" + ex);
                driver.Close();
            }

        }

    }
}
