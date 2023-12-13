using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "2222222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");