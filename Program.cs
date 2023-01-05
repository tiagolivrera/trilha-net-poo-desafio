using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "83912345678", modelo: "Lumia", imei: "0000000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "83909871234", modelo: "12", imei: "9999999", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");