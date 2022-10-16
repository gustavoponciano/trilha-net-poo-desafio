using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

System.Console.WriteLine("Celular iPhone");
Smartphone iphone = new Iphone();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iTunes");
