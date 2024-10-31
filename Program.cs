using DesafioPOO.Models;
public class Program
{

    public static void Main(string[] args)
    {
        // Instanciando um objeto do tipo Nokia
        Smartphone nokia = new Nokia("12345", "Nokia 3310", "1111111111", 64);
        Console.WriteLine("Telefone Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        // Instanciando um objeto do tipo iPhone
        Smartphone iphone = new Iphone("67890", "iPhone X", "2222222222", 128);
        Console.WriteLine("Telefone iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}