using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Instanciando Nokia");
Smartphone nokia = new Nokia(numero: "1234567",modelo: "Nokia2030",imei: "123wer123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");


Console.WriteLine("\n");

Console.WriteLine("Instanciando Iphone");
Smartphone iphone = new Iphone(numero: "1234567",modelo: "Iphone 1",imei: "123wer123", memoria: 164);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Google Maps");