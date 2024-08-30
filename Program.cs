using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "119999999", modelo: "Modelo 1", imei: "15254", memoria: 166);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");



Console.WriteLine("\n");
Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "119999888", modelo: "Modelo 1", imei: "46548", memoria: 166);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

