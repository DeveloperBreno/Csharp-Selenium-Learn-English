using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
class EntryPoint
{

    // Feito por Breno Gonçalves
    // Github: DeveloperBreno
    // Esse é apenas um programa teste para mostrar um pouco sobre automação web, apenas para estudo
    // exemplos do livro "Basic Grammar in use second edition by Raymond Murphy"


    static IWebDriver driver;
    static IWebElement id;
    static IWebElement tecla;

    static void metodo()
    {
        // espera um minuto
        Thread.Sleep(1000);

        // escrever o valor(texto da textarea) no console
        tecla = driver.FindElement(By.Name("text"));
        Console.WriteLine(tecla.GetAttribute("value"));

        // espera um minuto
        Thread.Sleep(1000);

        // click no botao para falar em EN
        id = driver.FindElement(By.Id("gt-src-listen"));
        id.SendKeys(Keys.Enter);

        // espera
        Thread.Sleep(5000);

        // click no botao para falar em PT
        id = driver.FindElement(By.Id("gt-res-listen"));
        id.SendKeys(Keys.Enter);

        // escreva no console
        Console.WriteLine("Feito por Breno Gonçalves");
        Console.WriteLine("github.com/DeveloperBreno");
        Console.WriteLine("OK (Enter)");

        // leia espera o "enter" do usuario
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

        // tela anônimo
        options.AddArguments("--incognito");

        // remove informacao de (teste de automacao)
        options.AddArguments("--disable-infobars");

        // abrir o Chrome com as opcoes
        driver = new ChromeDriver(options);

        // limpa tela console
        Console.Clear();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/please%20be%20quiet.%20i%20am%20working");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/i%20work%20every%20day%20from%209%20o'clock%20to%205");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/I%20have%20a%20bike%20but%20I%20don't%20have%20a%20car");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/did%20you%20find%20the%20book%20you%20wanted");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/the%20people%20we%20met%20were%20very%20nice");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/the%20movie%20we%20saw%20was%20very%20good");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/I%20looked%20at%20myself%20in%20the%20mirror");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/we%20have%20a%20good%20vacation.%20We%20enjoyed%20ourselves");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/we%20have%20a%20good%20vacation.%20We%20enjoyed%20ourselves");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#pt/en/exemplos%20do%20livro%20%22Gram%C3%A1tica%20B%C3%A1sica%20em%20uso%20segunda%20edi%C3%A7%C3%A3o%20de%20Raymond%20Murphy%22");
        metodo();

        // ir para link
        driver.Navigate().GoToUrl("https://translate.google.com.br/?hl=pt-BR#en/pt/you%20finished");
        metodo();

        // espera 
        Thread.Sleep(3000);

        // sair do chrome
        driver.Quit();

        // escreva
        Console.WriteLine("Feito por Breno Gonçalves");
        Console.WriteLine("Github: DeveloperBreno");
        Console.WriteLine("You finished!");
    }
}