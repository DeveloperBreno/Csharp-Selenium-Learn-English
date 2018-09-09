using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
class EntryPoint
{
    static IWebDriver driver;
    static IWebElement id;
    static IWebElement tecla;

    static void metodo()
    {
        // espera
        Thread.Sleep(1000);

        // escrever o valor(texto da textarea) no console
        tecla = driver.FindElement(By.Name("text"));
        Console.WriteLine(tecla.GetAttribute("value"));


        // click no botao para falar em pt
        id = driver.FindElement(By.Id("gt-src-listen"));
        id.SendKeys(Keys.Enter);

        // espera
        Thread.Sleep(5000);

        // click no botao para falar em en
        id = driver.FindElement(By.Id("gt-res-listen"));
        id.SendKeys(Keys.Enter);

        // escreva
        Console.WriteLine("Feito por Breno Gonçalves");
        Console.WriteLine("https://github.com/DeveloperBreno");
        Console.WriteLine("OK (Enter)");

        // leia
        Console.ReadLine();

        // limpa tela
        Console.Clear();
    }

    static void Main()
    {



        // cria a classe do Chrome
        ChromeOptions options = new ChromeOptions();

        // tela maximized
        options.AddArgument("--start-maximized");

        // anônimo
        options.AddArguments("--incognito");

        // remove informacao de (teste de automacao)
        options.AddArguments("--disable-infobars");

        // abrir o Chrome com as opcoes
        driver = new ChromeDriver(options);

        // limpa tela console
        Console.Clear();

        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/please%20be%20quiet.%20i%20am%20working");
        metodo();
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/i%20work%20every%20day%20from%209%20oclock%20to%205");
        metodo();
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/I%20have%20a%20bike%20but%20I%20don't%20have%20a%20car");
        metodo();
        
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/did%20you%20find%20the%20book%20you%20wanted");
        metodo();
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/the%20people%20we%20met%20were%20very%20nice");
        metodo();
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/the%20movie%20we%20saw%20was%20very%20good");
        metodo();

        // espera 
        Thread.Sleep(3000);

        // sair do chrome
        driver.Quit();

        // escreva
        Console.WriteLine("VOCE TERMINOU!");
    }
}