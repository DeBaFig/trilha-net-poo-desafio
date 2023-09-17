using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo 1", "1111", 64);
Smartphone iphone = new Iphone("987654321", "Modelo 2", "2222", 32);
Console.WriteLine("Nokia --------");

nokia.Ligar();
nokia.InstalarAplicativo("jogo");

Console.WriteLine("Iphone --------");

iphone.Ligar();
iphone.InstalarAplicativo("whatapp");
