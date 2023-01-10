using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia1 = new Nokia("99888-7898", "Nokia C01 Plus", "100001-01-100001-1", 32);
nokia1.Ligar();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("Trocar de número");
nokia1.Numero = "999754725";
Console.WriteLine($"Novo número: {nokia1.Numero}");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Iphone iphone1 = new Iphone ("99877-7976", "iPhone 14 Plus", "110011-11-110011-1", 128);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");
